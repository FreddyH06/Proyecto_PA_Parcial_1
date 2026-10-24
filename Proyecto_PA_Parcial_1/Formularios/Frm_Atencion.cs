using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Proyecto_PA_Parcial_1.Controlador;
using Proyecto_PA_Parcial_1.Entidades;

namespace Proyecto_PA_Parcial_1.Formularios
{
    public partial class Frm_Atencion : Form
    {
        private readonly TListSucursales controladorSucursales = new TListSucursales();
        private readonly TListFilas controladorFilas = new TListFilas();
        private readonly TListTickets controladorTickets = new TListTickets();
        private Ticket ticketSeleccionado;

        public Frm_Atencion()
        {
            InitializeComponent();
            CargarSucursales();
            ActualizarEstadoControles();
        }

        private void CargarSucursales()
        {
            string codigoSeleccionado = comboBox1.SelectedValue == null ? string.Empty : Convert.ToString(comboBox1.SelectedValue);
            comboBox1.DataSource = null;
            comboBox1.DisplayMember = "Codigo";
            comboBox1.ValueMember = "Codigo";
            comboBox1.DataSource = controladorSucursales.Listar().OrderBy(item => item.Codigo).ToList();
            if (!string.IsNullOrWhiteSpace(codigoSeleccionado))
            {
                comboBox1.SelectedValue = codigoSeleccionado;
            }
            CargarFilas();
        }

        private void CargarFilas()
        {
            string codigoSucursal = comboBox1.SelectedValue == null ? string.Empty : Convert.ToString(comboBox1.SelectedValue);
            string codigoFilaSeleccionada = comboBox2.SelectedValue == null ? string.Empty : Convert.ToString(comboBox2.SelectedValue);
            comboBox2.DataSource = null;
            comboBox2.DisplayMember = "Descripcion";
            comboBox2.ValueMember = "Codigo";
            comboBox2.DataSource = controladorFilas.ListarPorSucursal(codigoSucursal).OrderBy(item => item.Codigo).ToList();
            if (!string.IsNullOrWhiteSpace(codigoFilaSeleccionada))
            {
                comboBox2.SelectedValue = codigoFilaSeleccionada;
            }
            ticketSeleccionado = null;
            CargarListados();
        }

        private void CargarListados()
        {
            CargarPendientes();
            CargarHistorial();
            MostrarTicketSeleccionado();
            ActualizarEstadoControles();
        }

        private void CargarPendientes()
        {
            dataGridView1.Rows.Clear();
            string codigoFila = ObtenerCodigoFilaSeleccionada();
            var pendientes = controladorTickets.Listar(codigoFila)
                .Where(item => item.Estado == TListTickets.Pendiente)
                .OrderBy(item => item.Programado ? item.FechaCita : item.FechaEmision)
                .ThenBy(item => item.Numero)
                .ToList();
            foreach (Ticket ticket in pendientes)
            {
                Fila fila = controladorFilas.Buscar(ticket.CodigoFila);
                dataGridView1.Rows.Add(
                    ticket.Id,
                    ticket.CodigoTicket,
                    fila == null ? ticket.CodigoFila : fila.Descripcion,
                    ticket.FechaEmision.ToString("dd/MM/yyyy"),
                    ticket.FechaEmision.ToString("HH:mm"),
                    ticket.Estado,
                    ticket.Nombres,
                    ticket.Programado ? "Cita" : "Normal");
            }
        }

        private void CargarHistorial()
        {
            dataGridView2.Rows.Clear();
            string codigoFila = ObtenerCodigoFilaSeleccionada();
            var historial = controladorTickets.Listar(codigoFila)
                .Where(item => item.Estado != TListTickets.Pendiente)
                .OrderByDescending(item => ObtenerFechaOrden(item))
                .ThenByDescending(item => item.Id)
                .ToList();
            foreach (Ticket ticket in historial)
            {
                dataGridView2.Rows.Add(
                    ticket.Id,
                    ticket.CodigoTicket,
                    ticket.Estado,
                    ticket.Ventanilla,
                    FormatearFecha(ticket.FechaLlamado),
                    FormatearFecha(ticket.InicioAtencion),
                    FormatearFecha(ticket.FinAtencion),
                    ticket.Nombres);
            }
        }

        private DateTime ObtenerFechaOrden(Ticket ticket)
        {
            DateTime resultado = ticket.FechaLlamado;
            if (resultado == DateTime.MinValue)
            {
                resultado = ticket.FechaEmision;
            }
            return resultado;
        }

        private string ObtenerCodigoFilaSeleccionada()
        {
            string codigoFila = string.Empty;
            if (comboBox2.SelectedItem is Fila fila)
            {
                codigoFila = fila.Codigo;
            }
            return codigoFila;
        }

        private string ObtenerVentanilla()
        {
            return numericUpDown1.Value.ToString("0");
        }

        private string ObtenerUsuarioAtencion()
        {
            return Environment.UserName;
        }

        private Ticket ObtenerTicketSeleccionado()
        {
            Ticket resultado = ticketSeleccionado;
            if (resultado == null && dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                resultado = controladorTickets.Buscar(id);
            }
            if (resultado == null && dataGridView2.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);
                resultado = controladorTickets.Buscar(id);
            }
            return resultado;
        }

        private bool ValidarFiltro()
        {
            bool valido = comboBox1.SelectedItem is Sucursal && comboBox2.SelectedItem is Fila;
            if (!valido)
            {
                MessageBox.Show("Seleccione una sucursal y una fila o servicio.", "Atención de turnos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return valido;
        }

        private bool ExisteAtencionEnVentanilla()
        {
            string ventanilla = ObtenerVentanilla();
            bool existe = controladorTickets.Listar()
                .Any(item => item.Ventanilla == ventanilla
                    && (item.Estado == TListTickets.Llamado || item.Estado == TListTickets.EnAtencion));
            return existe;
        }

        private void MostrarTicketSeleccionado()
        {
            Ticket ticket = ObtenerTicketSeleccionado();
            if (ticket == null)
            {
                labelTicketActual.Text = "Sin ticket seleccionado";
                labelServicioActual.Text = "Servicio: -";
                labelEstadoActual.Text = "Estado: -";
                labelHoraLlamada.Text = "Hora de llamada: -";
                labelVentanillaActual.Text = "Ventanilla: -";
                labelTiempoEspera.Text = "Tiempo de espera: -";
            }
            else
            {
                Fila fila = controladorFilas.Buscar(ticket.CodigoFila);
                labelTicketActual.Text = ticket.CodigoTicket;
                labelServicioActual.Text = "Servicio: " + (fila == null ? ticket.CodigoFila : fila.Descripcion);
                labelEstadoActual.Text = "Estado: " + ticket.Estado;
                labelHoraLlamada.Text = "Hora de llamada: " + FormatearFecha(ticket.FechaLlamado);
                labelVentanillaActual.Text = "Ventanilla: " + (string.IsNullOrWhiteSpace(ticket.Ventanilla) ? "-" : ticket.Ventanilla);
                labelTiempoEspera.Text = "Tiempo de espera: " + CalcularTiempoEspera(ticket);
            }
        }

        private string CalcularTiempoEspera(Ticket ticket)
        {
            string resultado = "-";
            if (ticket.FechaLlamado != DateTime.MinValue && ticket.FechaEmision != DateTime.MinValue)
            {
                TimeSpan espera = ticket.FechaLlamado - ticket.FechaEmision;
                resultado = espera.TotalMinutes < 1 ? "Menos de 1 min" : Math.Max(0, (int)espera.TotalMinutes) + " min";
            }
            return resultado;
        }

        private string FormatearFecha(DateTime fecha)
        {
            string resultado = "-";
            if (fecha != DateTime.MinValue)
            {
                resultado = fecha.ToString("dd/MM/yyyy HH:mm");
            }
            return resultado;
        }

        private void ActualizarEstadoControles()
        {
            Ticket ticket = ObtenerTicketSeleccionado();
            bool hayFiltro = comboBox1.SelectedItem is Sucursal && comboBox2.SelectedItem is Fila;
            bool puedeLlamar = hayFiltro && !ExisteAtencionEnVentanilla();
            button2.Enabled = puedeLlamar;
            button3.Enabled = ticket != null && ticket.Estado == TListTickets.Llamado;
            button4.Enabled = ticket != null && ticket.Estado == TListTickets.EnAtencion;
            button5.Enabled = ticket != null && (ticket.Estado == TListTickets.Llamado || ticket.Estado == TListTickets.EnAtencion);
            button6.Enabled = ticket != null && (ticket.Estado == TListTickets.Omitido || ticket.Estado == TListTickets.Atendido);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarSucursales();
            CargarListados();
            MessageBox.Show("El listado se actualizó correctamente.", "Atención de turnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidarFiltro())
            {
                if (ExisteAtencionEnVentanilla())
                {
                    MessageBox.Show("La ventanilla seleccionada ya tiene un turno llamado o en atención.", "Atención de turnos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Ticket ticket = controladorTickets.LlamarSiguiente(ObtenerCodigoFilaSeleccionada(), ObtenerUsuarioAtencion(), ObtenerVentanilla());
                    if (ticket == null)
                    {
                        MessageBox.Show("No existen turnos pendientes disponibles para llamar.", "Atención de turnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        ticketSeleccionado = ticket;
                        CargarListados();
                        MessageBox.Show("Se llamó el turno " + ticket.CodigoTicket + ".", "Atención de turnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ticket ticket = ObtenerTicketSeleccionado();
            if (ticket == null)
            {
                MessageBox.Show("Seleccione un turno llamado.", "Atención de turnos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (controladorTickets.IniciarAtencion(ticket.Id, ObtenerUsuarioAtencion(), ObtenerVentanilla()))
            {
                CargarListados();
                MessageBox.Show("La atención del turno " + ticket.CodigoTicket + " ha iniciado.", "Atención de turnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El turno debe estar en estado LLAMADO para iniciar la atención.", "Atención de turnos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ticket ticket = ObtenerTicketSeleccionado();
            if (ticket == null)
            {
                MessageBox.Show("Seleccione un turno en atención.", "Atención de turnos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MessageBox.Show("¿Desea finalizar la atención del turno " + ticket.CodigoTicket + "?", "Confirmar finalización", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (controladorTickets.FinalizarAtencion(ticket.Id))
                {
                    CargarListados();
                    MessageBox.Show("La atención se finalizó correctamente.", "Atención de turnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Solo se pueden finalizar turnos en atención.", "Atención de turnos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ticket ticket = ObtenerTicketSeleccionado();
            if (ticket == null)
            {
                MessageBox.Show("Seleccione un turno llamado o en atención.", "Atención de turnos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MessageBox.Show("¿Desea omitir el turno " + ticket.CodigoTicket + "?", "Confirmar omisión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (controladorTickets.Omitir(ticket.Id))
                {
                    CargarListados();
                    MessageBox.Show("El turno se omitió correctamente.", "Atención de turnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El turno seleccionado no puede omitirse en su estado actual.", "Atención de turnos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Ticket ticket = ObtenerTicketSeleccionado();
            if (ticket == null)
            {
                MessageBox.Show("Seleccione un turno omitido o atendido.", "Atención de turnos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MessageBox.Show("¿Desea reabrir el turno " + ticket.CodigoTicket + "?", "Confirmar reapertura", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (controladorTickets.Reabrir(ticket.Id))
                {
                    ticketSeleccionado = ticket;
                    CargarListados();
                    MessageBox.Show("El turno volvió a la cola de pendientes.", "Atención de turnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Solo se pueden reabrir turnos omitidos o atendidos.", "Atención de turnos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarFilas();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ticketSeleccionado = null;
            CargarListados();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                ticketSeleccionado = controladorTickets.Buscar(id);
                dataGridView2.ClearSelection();
                MostrarTicketSeleccionado();
                ActualizarEstadoControles();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView2.Rows.Count)
            {
                int id = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value);
                ticketSeleccionado = controladorTickets.Buscar(id);
                dataGridView1.ClearSelection();
                MostrarTicketSeleccionado();
                ActualizarEstadoControles();
            }
        }
    }
}
