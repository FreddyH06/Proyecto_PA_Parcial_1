using System;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;
using Proyecto_PA_Parcial_1.Controlador;
using Proyecto_PA_Parcial_1.Entidades;

namespace Proyecto_PA_Parcial_1.Formularios
{
    public partial class Frm_Citas : Form
    {
        private readonly TListSucursales controladorSucursales = new TListSucursales();
        private readonly TListFilas controladorFilas = new TListFilas();
        private readonly TListTickets controladorTickets = new TListTickets();
        private Ticket citaSeleccionada;

        public Frm_Citas()
        {
            InitializeComponent();
            CargarSucursales();
            CargarCitas();
            LimpiarCampos();
        }

        private void CargarSucursales()
        {
            comboBox1.DataSource = null;
            comboBox1.DisplayMember = "Codigo";
            comboBox1.ValueMember = "Codigo";
            comboBox1.DataSource = controladorSucursales.Listar().OrderBy(item => item.Codigo).ToList();
            comboBox1.SelectedIndex = comboBox1.Items.Count > 0 ? 0 : -1;
        }

        private void CargarFilas()
        {
            Sucursal sucursal = comboBox1.SelectedItem as Sucursal;
            comboBox2.DataSource = null;
            comboBox2.DisplayMember = "Descripcion";
            comboBox2.ValueMember = "Codigo";
            if (sucursal != null)
            {
                comboBox2.DataSource = controladorFilas.ListarPorSucursal(sucursal.Codigo).OrderBy(item => item.Descripcion).ToList();
            }
            comboBox2.SelectedIndex = comboBox2.Items.Count > 0 ? 0 : -1;
        }

        private void CargarCitas()
        {
            var filas = controladorFilas.Listar();
            var sucursales = controladorSucursales.Listar();
            var citas = controladorTickets.Listar()
                .Where(item => item.Programado)
                .OrderBy(item => item.FechaCita)
                .Select(item => new
                {
                    item.Id,
                    item.CodigoTicket,
                    Servicio = filas.Where(fila => string.Equals(fila.Codigo, item.CodigoFila, StringComparison.OrdinalIgnoreCase))
                        .Select(fila => fila.Descripcion)
                        .FirstOrDefault() ?? item.CodigoFila,
                    Sucursal = filas.Where(fila => string.Equals(fila.Codigo, item.CodigoFila, StringComparison.OrdinalIgnoreCase))
                        .Join(sucursales, fila => fila.CodigoSucursal, sucursal => sucursal.Codigo, (fila, sucursal) => sucursal.Codigo)
                        .FirstOrDefault() ?? string.Empty,
                    Fecha = item.FechaCita.ToString("dd/MM/yyyy"),
                    Hora = item.FechaCita.ToString("HH:mm"),
                    Cliente = item.Nombres,
                    item.Estado
                })
                .ToList();
            dataGridView1.DataSource = citas;
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            Empresa empresa = Frm_Empresa.ConfiguracionCompartida;
            if (comboBox1.SelectedItem == null)
            {
                MostrarAdvertencia("Seleccione una sucursal.");
                valido = false;
            }
            else if (comboBox2.SelectedItem == null)
            {
                MostrarAdvertencia("Seleccione un servicio o fila.");
                valido = false;
            }
            else if (ObtenerFechaHoraCita() <= DateTime.Now)
            {
                MostrarAdvertencia("La fecha y hora de la cita deben ser futuras.");
                valido = false;
            }
            else if (empresa.ObligarCedula && string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MostrarAdvertencia("Ingrese la cédula del cliente.");
                textBox1.Focus();
                valido = false;
            }
            else if (empresa.ObligarNombre && string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MostrarAdvertencia("Ingrese el nombre del cliente.");
                textBox2.Focus();
                valido = false;
            }
            else if (empresa.ObligarCorreo && !EsCorreoValido(textBox3.Text))
            {
                MostrarAdvertencia("Ingrese un correo electrónico válido.");
                textBox3.Focus();
                valido = false;
            }
            else if (empresa.ObligarTelefono && string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MostrarAdvertencia("Ingrese el teléfono del cliente.");
                textBox4.Focus();
                valido = false;
            }
            else if (!string.IsNullOrWhiteSpace(textBox3.Text) && !EsCorreoValido(textBox3.Text))
            {
                MostrarAdvertencia("El correo electrónico no tiene un formato válido.");
                textBox3.Focus();
                valido = false;
            }
            return valido;
        }

        private bool EsCorreoValido(string correo)
        {
            bool valido = false;
            if (!string.IsNullOrWhiteSpace(correo))
            {
                try
                {
                    MailAddress direccion = new MailAddress(correo.Trim());
                    valido = string.Equals(direccion.Address, correo.Trim(), StringComparison.OrdinalIgnoreCase);
                }
                catch (FormatException)
                {
                    valido = false;
                }
            }
            return valido;
        }

        private DateTime ObtenerFechaHoraCita()
        {
            return dateTimePicker1.Value.Date.Add(dateTimePicker2.Value.TimeOfDay);
        }

        private Ticket CrearCita()
        {
            Fila fila = comboBox2.SelectedItem as Fila;
            return new Ticket
            {
                CodigoFila = fila == null ? string.Empty : fila.Codigo,
                Programado = true,
                Cedula = textBox1.Text.Trim(),
                Nombres = textBox2.Text.Trim(),
                Email = textBox3.Text.Trim(),
                Telefono = textBox4.Text.Trim(),
                FechaEmision = DateTime.Now,
                FechaCita = ObtenerFechaHoraCita(),
                Estado = TListTickets.Pendiente
            };
        }

        private bool EstaDisponible(Ticket cita)
        {
            bool disponible = false;
            if (cita != null)
            {
                disponible = controladorTickets.DisponibleCita(cita.CodigoFila, cita.FechaCita);
            }
            return disponible;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                Ticket cita = CrearCita();
                if (!EstaDisponible(cita))
                {
                    MostrarAdvertencia("No existe disponibilidad para ese horario. Verifique el horario de la sucursal, la duración del servicio y sus ventanillas.");
                }
                else if (controladorTickets.AgregarCita(cita))
                {
                    citaSeleccionada = cita;
                    CargarCitas();
                    MostrarInformacion("La cita se reservó correctamente. Código: " + cita.CodigoTicket);
                    LimpiarCampos();
                }
                else
                {
                    MostrarAdvertencia("No se pudo reservar la cita. Verifique los datos y la disponibilidad.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == null)
            {
                MostrarAdvertencia("Seleccione un servicio o fila.");
            }
            else if (ObtenerFechaHoraCita() <= DateTime.Now)
            {
                MostrarAdvertencia("La fecha y hora deben ser futuras.");
            }
            else
            {
                Fila fila = comboBox2.SelectedItem as Fila;
                bool disponible = controladorTickets.DisponibleCita(fila.Codigo, ObtenerFechaHoraCita());
                string mensaje = disponible ? "El horario seleccionado está disponible." : "El horario seleccionado no está disponible.";
                MessageBoxIcon icono = disponible ? MessageBoxIcon.Information : MessageBoxIcon.Warning;
                MessageBox.Show(mensaje, "Disponibilidad de citas", MessageBoxButtons.OK, icono);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ticket cita = ObtenerCitaSeleccionada();
            if (cita == null)
            {
                MostrarAdvertencia("Seleccione una cita pendiente para anularla.");
            }
            else
            {
                DialogResult confirmacion = MessageBox.Show(
                    "¿Está seguro de anular la cita " + cita.CodigoTicket + "?",
                    "Confirmar anulación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    if (controladorTickets.AnularCita(cita.Id))
                    {
                        CargarCitas();
                        LimpiarCampos();
                        MostrarInformacion("La cita se anuló correctamente.");
                    }
                    else
                    {
                        MostrarAdvertencia("Solo se pueden anular citas pendientes.");
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private Ticket ObtenerCitaSeleccionada()
        {
            Ticket cita = citaSeleccionada;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id;
                if (int.TryParse(Convert.ToString(dataGridView1.SelectedRows[0].Cells["columnaId"].Value), out id))
                {
                    cita = controladorTickets.Buscar(id);
                }
            }
            return cita;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarFilas();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                int id;
                if (int.TryParse(Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["columnaId"].Value), out id))
                {
                    citaSeleccionada = controladorTickets.Buscar(id);
                    CargarCitaEnCampos(citaSeleccionada);
                }
            }
        }

        private void CargarCitaEnCampos(Ticket cita)
        {
            if (cita != null)
            {
                Fila fila = controladorFilas.Buscar(cita.CodigoFila);
                Sucursal sucursal = fila == null ? null : controladorSucursales.Buscar(fila.CodigoSucursal);
                comboBox1.SelectedValue = sucursal == null ? null : sucursal.Codigo;
                comboBox2.SelectedValue = fila == null ? null : fila.Codigo;
                dateTimePicker1.Value = cita.FechaCita;
                dateTimePicker2.Value = DateTime.Today.Add(cita.FechaCita.TimeOfDay);
                textBox1.Text = cita.Cedula;
                textBox2.Text = cita.Nombres;
                textBox3.Text = cita.Email;
                textBox4.Text = cita.Telefono;
            }
        }

        private void LimpiarCampos()
        {
            citaSeleccionada = null;
            dateTimePicker1.Value = DateTime.Today.AddDays(1);
            dateTimePicker2.Value = DateTime.Today.AddHours(8);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            dataGridView1.ClearSelection();
            comboBox1.Focus();
        }

        private void MostrarAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Reservación de citas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void MostrarInformacion(string mensaje)
        {
            MessageBox.Show(mensaje, "Reservación de citas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
