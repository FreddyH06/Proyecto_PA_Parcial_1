using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Proyecto_PA_Parcial_1.Controlador;
using Proyecto_PA_Parcial_1.Entidades;

namespace Proyecto_PA_Parcial_1.Formularios
{
    public partial class Frm_Pantalla : Form
    {
        private readonly TListSucursales controladorSucursales = new TListSucursales();
        private readonly TListFilas controladorFilas = new TListFilas();
        private readonly TListTickets controladorTickets = new TListTickets();

        public Frm_Pantalla()
        {
            InitializeComponent();
            CargarSucursales();
            ActualizarPantalla();
            timer1.Start();
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
            comboBox2.SelectedIndex = -1;
            if (!string.IsNullOrWhiteSpace(codigoFilaSeleccionada))
            {
                comboBox2.SelectedValue = codigoFilaSeleccionada;
            }
        }

        private void MostrarTurnoActual()
        {
            List<Ticket> tickets = ObtenerTicketsVisibles();
            Ticket turnoActual = tickets
                .Where(item => item.FechaLlamado != DateTime.MinValue
                    && (item.Estado == TListTickets.Llamado || item.Estado == TListTickets.EnAtencion))
                .OrderByDescending(item => item.FechaLlamado)
                .ThenByDescending(item => item.Id)
                .FirstOrDefault();
            if (turnoActual == null)
            {
                labelTurnoActual.Text = "ESPERANDO PRÓXIMO TURNO";
                labelVentanillaActual.Text = "-";
                labelServicioActual.Text = "Servicio: -";
                labelSucursalActual.Text = "Sucursal: -";
            }
            else
            {
                Fila fila = controladorFilas.Buscar(turnoActual.CodigoFila);
                Sucursal sucursal = fila == null ? null : controladorSucursales.Buscar(fila.CodigoSucursal);
                labelTurnoActual.Text = turnoActual.CodigoTicket;
                labelVentanillaActual.Text = string.IsNullOrWhiteSpace(turnoActual.Ventanilla) ? "-" : turnoActual.Ventanilla;
                labelServicioActual.Text = "Servicio: " + (fila == null ? turnoActual.CodigoFila : fila.Descripcion);
                labelSucursalActual.Text = "Sucursal: " + (sucursal == null ? (fila == null ? "-" : fila.CodigoSucursal) : sucursal.Codigo);
            }
        }

        private void MostrarUltimosLlamados()
        {
            dataGridView1.Rows.Clear();
            List<Ticket> ultimosLlamados = ObtenerTicketsVisibles()
                .Where(item => item.FechaLlamado != DateTime.MinValue)
                .OrderByDescending(item => item.FechaLlamado)
                .ThenByDescending(item => item.Id)
                .Take(10)
                .ToList();
            foreach (Ticket ticket in ultimosLlamados)
            {
                Fila fila = controladorFilas.Buscar(ticket.CodigoFila);
                dataGridView1.Rows.Add(
                    ticket.CodigoTicket,
                    fila == null ? ticket.CodigoFila : fila.Descripcion,
                    string.IsNullOrWhiteSpace(ticket.Ventanilla) ? "-" : ticket.Ventanilla);
            }
        }

        private void ActualizarPendientes()
        {
            List<Ticket> pendientes = ObtenerTicketsVisibles()
                .Where(item => item.Estado == TListTickets.Pendiente)
                .ToList();
            labelPendientes.Text = pendientes.Count.ToString("N0");
            labelTiempoEstimado.Text = CalcularTiempoEstimado(pendientes);
        }

        private string CalcularTiempoEstimado(List<Ticket> pendientes)
        {
            List<Fila> filas = pendientes
                .Select(item => controladorFilas.Buscar(item.CodigoFila))
                .Where(item => item != null && item.TiempoEstimadoMinutos > 0 && item.CantidadVentanillas > 0)
                .ToList();
            string resultado = "-";
            if (filas.Count > 0)
            {
                double minutos = filas.Sum(item => (double)item.TiempoEstimadoMinutos / item.CantidadVentanillas);
                resultado = Math.Max(1, (int)Math.Ceiling(minutos)) + " min";
            }
            return resultado;
        }

        private void ActualizarPantalla()
        {
            labelFechaHora.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy  |  HH:mm:ss");
            MostrarTurnoActual();
            MostrarUltimosLlamados();
            ActualizarPendientes();
        }

        private List<Ticket> ObtenerTicketsVisibles()
        {
            string codigoSucursal = comboBox1.SelectedValue == null ? string.Empty : Convert.ToString(comboBox1.SelectedValue);
            string codigoFila = comboBox2.SelectedValue == null ? string.Empty : Convert.ToString(comboBox2.SelectedValue);
            IEnumerable<Ticket> consulta = controladorTickets.Listar();
            if (!string.IsNullOrWhiteSpace(codigoSucursal))
            {
                List<string> codigosFilas = controladorFilas.ListarPorSucursal(codigoSucursal).Select(item => item.Codigo).ToList();
                consulta = consulta.Where(ticket => codigosFilas.Contains(ticket.CodigoFila, StringComparer.OrdinalIgnoreCase));
            }
            if (!string.IsNullOrWhiteSpace(codigoFila))
            {
                consulta = consulta.Where(ticket => string.Equals(ticket.CodigoFila, codigoFila, StringComparison.OrdinalIgnoreCase));
            }
            return consulta.ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarFilas();
            ActualizarPantalla();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarPantalla();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ActualizarPantalla();
        }

        private void Frm_Pantalla_Load(object sender, EventArgs e)
        {
            if (Screen.AllScreens.Length > 1)
            {
                StartPosition = FormStartPosition.Manual;
                Location = Screen.AllScreens[1].WorkingArea.Location;
                WindowState = FormWindowState.Maximized;
            }
        }

        private void Frm_Pantalla_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }

        private void Frm_Pantalla_Load_1(object sender, EventArgs e)
        {

        }
    }
}
