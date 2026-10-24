using System;
using System.Linq;
using System.Windows.Forms;
using Proyecto_PA_Parcial_1.Controlador;

namespace Proyecto_PA_Parcial_1.Formularios
{
    public partial class Frm_Dashboard : Form
    {
        public Frm_Dashboard()
        {
            InitializeComponent();
            ActualizarEstadisticas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActualizarEstadisticas();
        }

        private void ActualizarEstadisticas()
        {
            DateTime hoy = DateTime.Today;
            int totalSucursales = TListSucursales.Lista.Count;
            int totalServicios = TListFilas.Lista.Count;
            int ticketsEmitidosHoy = TListTickets.Lista.Count(ticket => ticket.FechaEmision.Date == hoy);
            int ticketsPendientes = TListTickets.Lista.Count(ticket => string.Equals(ticket.Estado, TListTickets.Pendiente, StringComparison.OrdinalIgnoreCase));

            label2.Text = "Sucursales\r\n" + totalSucursales;
            label3.Text = "Servicios\r\n" + totalServicios;
            label4.Text = "Tickets emitidos hoy\r\n" + ticketsEmitidosHoy;
            label5.Text = "Tickets pendientes\r\n" + ticketsPendientes;

            dataGridView1.DataSource = TListTickets.Lista
                .OrderByDescending(ticket => ticket.FechaEmision)
                .Take(10)
                .Select(ticket => new
                {
                    ticket.CodigoTicket,
                    ticket.CodigoFila,
                    ticket.Nombres,
                    ticket.FechaEmision,
                    ticket.Estado
                })
                .ToList();
        }

        private void Frm_Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
