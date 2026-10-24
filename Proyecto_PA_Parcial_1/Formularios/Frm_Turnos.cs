using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using Proyecto_PA_Parcial_1.Controlador;
using Proyecto_PA_Parcial_1.Entidades;

namespace Proyecto_PA_Parcial_1.Formularios
{
    public partial class Frm_Turnos : Form
    {
        private readonly TListSucursales controladorSucursales = new TListSucursales();
        private readonly TListFilas controladorFilas = new TListFilas();
        private readonly TListTickets controladorTickets = new TListTickets();
        private Ticket ticketSeleccionado;
        private Sucursal sucursalSeleccionada;
        private Fila filaSeleccionada;

        public Frm_Turnos()
        {
            InitializeComponent();
            CargarSucursales();
            CargarTickets();
            ActualizarResumen(null);
            ActualizarDetalleTicket(null);
            button2.Enabled = false;
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
            sucursalSeleccionada = sucursal;
            comboBox2.DataSource = null;
            comboBox2.DisplayMember = "Descripcion";
            comboBox2.ValueMember = "Codigo";
            if (sucursal != null)
            {
                comboBox2.DataSource = controladorFilas.ListarPorSucursal(sucursal.Codigo).OrderBy(item => item.Descripcion).ToList();
            }
            comboBox2.SelectedIndex = comboBox2.Items.Count > 0 ? 0 : -1;
            filaSeleccionada = comboBox2.SelectedItem as Fila;
            ActualizarResumen(filaSeleccionada);
        }

        private void CargarTickets()
        {
            var filas = controladorFilas.Listar();
            var sucursales = controladorSucursales.Listar();
            var tickets = controladorTickets.Listar()
                .OrderByDescending(item => item.FechaEmision)
                .Select(item => new
                {
                    item.Id,
                    item.CodigoTicket,
                    Sucursal = sucursales.Where(sucursal => filas.Where(fila => fila.Codigo == item.CodigoFila).Select(fila => fila.CodigoSucursal).Contains(sucursal.Codigo)).Select(sucursal => sucursal.Codigo).FirstOrDefault() ?? string.Empty,
                    Servicio = filas.Where(fila => fila.Codigo == item.CodigoFila).Select(fila => fila.Descripcion).FirstOrDefault() ?? item.CodigoFila,
                    item.Cedula,
                    item.Nombres,
                    item.Email,
                    item.Telefono,
                    Emision = item.FechaEmision.ToString("dd/MM/yyyy HH:mm"),
                    item.Estado
                })
                .ToList();
            dataGridView1.DataSource = tickets;
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["Id"].Visible = false;
            }
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

        private Ticket CrearTicket()
        {
            Fila fila = comboBox2.SelectedItem as Fila;
            return new Ticket
            {
                CodigoFila = fila == null ? string.Empty : fila.Codigo,
                Programado = false,
                Cedula = textBox1.Text.Trim(),
                Nombres = textBox2.Text.Trim(),
                Email = textBox3.Text.Trim(),
                Telefono = textBox4.Text.Trim(),
                SolicitoRecordatorio = checkBox1.Checked,
                SolicitoSms = checkBox2.Checked,
                FechaEmision = DateTime.Now,
                FechaCita = DateTime.Now,
                Estado = TListTickets.Pendiente
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                Ticket ticket = CrearTicket();
                if (controladorTickets.AgregarNormal(ticket))
                {
                    ticketSeleccionado = ticket;
                    textBox5.Text = ticket.CodigoTicket;
                    richTextBox1.Text = CrearComprobante(ticket);
                    ActualizarDetalleTicket(ticket);
                    button2.Enabled = true;
                    CargarTickets();
                    ActualizarResumen(comboBox2.SelectedItem as Fila);
                    MostrarInformacion("El turno se generó correctamente.");
                }
                else
                {
                    MostrarAdvertencia("No se pudo generar el turno. Verifique que el servicio exista y que los datos sean válidos.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ticketSeleccionado == null)
            {
                MostrarAdvertencia("Genere o seleccione un ticket antes de imprimirlo.");
            }
            else
            {
                try
                {
                    printPreviewDialog1.Document = printDocument1;
                    printPreviewDialog1.ShowDialog(this);
                }
                catch (InvalidPrinterException ex)
                {
                    MostrarAdvertencia("La impresión no está disponible: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MostrarAdvertencia("No fue posible abrir la vista previa de impresión: " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarFilas();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            filaSeleccionada = comboBox2.SelectedItem as Fila;
            ActualizarResumen(filaSeleccionada);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Ticket ticket = null;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id;
                bool idValido = int.TryParse(Convert.ToString(dataGridView1.SelectedRows[0].Cells["Id"].Value), out id);
                if (idValido)
                {
                    ticket = controladorTickets.Buscar(id);
                }
            }
            if (ticket != null)
            {
                ticketSeleccionado = ticket;
                textBox5.Text = ticket.CodigoTicket;
                richTextBox1.Text = CrearComprobante(ticket);
                ActualizarDetalleTicket(ticket);
                button2.Enabled = true;
                ActualizarResumen(controladorFilas.Buscar(ticket.CodigoFila));
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (ticketSeleccionado != null)
            {
                using (Font titulo = new Font("Segoe UI", 16F, FontStyle.Bold))
                using (Font texto = new Font("Segoe UI", 11F))
                {
                    e.Graphics.DrawString(ObtenerNombreEmpresa(), titulo, Brushes.DarkBlue, 70, 60);
                    e.Graphics.DrawString(CrearComprobante(ticketSeleccionado), texto, Brushes.Black, new RectangleF(70, 115, 620, 500));
                }
            }
        }

        private string ObtenerNombreEmpresa()
        {
            string razonSocial = Frm_Empresa.ConfiguracionCompartida.RazonSocial;
            return string.IsNullOrWhiteSpace(razonSocial) ? "TurnoSmarts" : razonSocial;
        }

        private string CrearComprobante(Ticket ticket)
        {
            Fila fila = controladorFilas.Buscar(ticket.CodigoFila);
            string servicio = fila == null ? ticket.CodigoFila : fila.Descripcion;
            StringBuilder comprobante = new StringBuilder();
            comprobante.AppendLine("COMPROBANTE DE ATENCIÓN");
            comprobante.AppendLine();
            comprobante.AppendLine("Empresa: " + ObtenerNombreEmpresa());
            comprobante.AppendLine("Servicio: " + servicio);
            comprobante.AppendLine("Código: " + ticket.CodigoTicket);
            comprobante.AppendLine("Fecha y hora: " + ticket.FechaEmision.ToString("dd/MM/yyyy HH:mm"));
            comprobante.AppendLine("Estado: " + ticket.Estado);
            comprobante.AppendLine("Cliente: " + ticket.Nombres);
            return comprobante.ToString();
        }

        private void ActualizarDetalleTicket(Ticket ticket)
        {
            if (ticket == null)
            {
                labelFechaValor.Text = "-";
                labelEstadoValor.Text = "-";
            }
            else
            {
                labelFechaValor.Text = ticket.FechaEmision.ToString("dd/MM/yyyy HH:mm");
                labelEstadoValor.Text = ticket.Estado;
            }
        }

        private void ActualizarResumen(Fila fila)
        {
            if (fila == null)
            {
                labelCodigoValor.Text = "Sin servicio seleccionado";
                labelServicioValor.Text = "-";
                labelEsperaValor.Text = "-";
            }
            else
            {
                int pendientes = controladorTickets.Listar(fila.Codigo).Count(item => item.Estado == TListTickets.Pendiente);
                int minutos = pendientes * fila.TiempoEstimadoMinutos;
                labelCodigoValor.Text = "Listo para generar";
                labelServicioValor.Text = fila.Descripcion;
                labelEsperaValor.Text = pendientes + " turno(s) en espera · Aproximadamente " + minutos + " minuto(s)";
            }
        }

        private void LimpiarCampos()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            ticketSeleccionado = null;
            textBox5.Clear();
            richTextBox1.Clear();
            ActualizarDetalleTicket(null);
            button2.Enabled = false;
            dataGridView1.ClearSelection();
            comboBox1.Focus();
        }

        private void MostrarAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Generación de turnos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void MostrarInformacion(string mensaje)
        {
            MessageBox.Show(mensaje, "TurnoSmarts", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
