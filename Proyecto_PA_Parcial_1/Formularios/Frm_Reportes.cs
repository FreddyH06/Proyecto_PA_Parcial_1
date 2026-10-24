using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Proyecto_PA_Parcial_1.Controlador;
using Proyecto_PA_Parcial_1.Entidades;

namespace Proyecto_PA_Parcial_1.Formularios
{
    public partial class Frm_Reportes : Form
    {
        private readonly TListSucursales controladorSucursales = new TListSucursales();
        private readonly TListFilas controladorFilas = new TListFilas();
        private readonly TListTickets controladorTickets = new TListTickets();
        private List<Ticket> ticketsFiltrados = new List<Ticket>();

        public Frm_Reportes()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            CargarSucursales();
            CargarEstados();
            ConsultarYActualizar();
        }

        private void CargarSucursales()
        {
            object seleccion = comboBox1.SelectedItem;
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Todos");
            foreach (Sucursal sucursal in controladorSucursales.Listar().OrderBy(item => item.Codigo))
            {
                comboBox1.Items.Add(sucursal);
            }
            comboBox1.SelectedIndex = 0;
            if (seleccion is Sucursal sucursalSeleccionada)
            {
                int indice = comboBox1.Items.Cast<object>().ToList().FindIndex(item => item is Sucursal && string.Equals(((Sucursal)item).Codigo, sucursalSeleccionada.Codigo, StringComparison.OrdinalIgnoreCase));
                if (indice >= 0)
                {
                    comboBox1.SelectedIndex = indice;
                }
            }
            CargarServicios();
        }

        private void CargarServicios()
        {
            object seleccion = comboBox2.SelectedItem;
            string codigoSucursal = ObtenerCodigoSucursalSeleccionada();
            comboBox2.Items.Clear();
            comboBox2.Items.Add("Todos");
            IEnumerable<Fila> filas = controladorFilas.Listar();
            if (!string.IsNullOrWhiteSpace(codigoSucursal))
            {
                filas = filas.Where(item => string.Equals(item.CodigoSucursal, codigoSucursal, StringComparison.OrdinalIgnoreCase));
            }
            foreach (Fila fila in filas.OrderBy(item => item.Descripcion).ThenBy(item => item.Codigo))
            {
                comboBox2.Items.Add(fila);
            }
            comboBox2.SelectedIndex = 0;
            if (seleccion is Fila filaSeleccionada)
            {
                int indice = comboBox2.Items.Cast<object>().ToList().FindIndex(item => item is Fila && string.Equals(((Fila)item).Codigo, filaSeleccionada.Codigo, StringComparison.OrdinalIgnoreCase));
                if (indice >= 0)
                {
                    comboBox2.SelectedIndex = indice;
                }
            }
        }

        private void CargarEstados()
        {
            comboBox3.Items.Clear();
            comboBox3.Items.Add("Todos");
            comboBox3.Items.Add(TListTickets.Pendiente);
            comboBox3.Items.Add(TListTickets.Llamado);
            comboBox3.Items.Add(TListTickets.EnAtencion);
            comboBox3.Items.Add(TListTickets.Atendido);
            comboBox3.Items.Add(TListTickets.Omitido);
            comboBox3.Items.Add(TListTickets.Anulado);
            comboBox3.SelectedIndex = 0;
        }

        private string ObtenerCodigoSucursalSeleccionada()
        {
            string resultado = string.Empty;
            if (comboBox1.SelectedItem is Sucursal sucursal)
            {
                resultado = sucursal.Codigo;
            }
            return resultado;
        }

        private string ObtenerCodigoFilaSeleccionada()
        {
            string resultado = string.Empty;
            if (comboBox2.SelectedItem is Fila fila)
            {
                resultado = fila.Codigo;
            }
            return resultado;
        }

        private string ObtenerEstadoSeleccionado()
        {
            string resultado = string.Empty;
            if (comboBox3.SelectedItem != null && !string.Equals(Convert.ToString(comboBox3.SelectedItem), "Todos", StringComparison.OrdinalIgnoreCase))
            {
                resultado = Convert.ToString(comboBox3.SelectedItem);
            }
            return resultado;
        }

        private List<Ticket> ConsultarReportes()
        {
            DateTime fechaInicial = dateTimePicker1.Value.Date;
            DateTime fechaFinal = dateTimePicker2.Value.Date.AddDays(1);
            string codigoSucursal = ObtenerCodigoSucursalSeleccionada();
            string codigoFila = ObtenerCodigoFilaSeleccionada();
            string estado = ObtenerEstadoSeleccionado();

            IEnumerable<Ticket> consulta = controladorTickets.Listar()
                .Where(item => item.FechaEmision >= fechaInicial && item.FechaEmision < fechaFinal);
            if (!string.IsNullOrWhiteSpace(codigoSucursal))
            {
                consulta = consulta.Where(item => controladorFilas.Buscar(item.CodigoFila) != null && string.Equals(controladorFilas.Buscar(item.CodigoFila).CodigoSucursal, codigoSucursal, StringComparison.OrdinalIgnoreCase));
            }
            if (!string.IsNullOrWhiteSpace(codigoFila))
            {
                consulta = consulta.Where(item => string.Equals(item.CodigoFila, codigoFila, StringComparison.OrdinalIgnoreCase));
            }
            if (!string.IsNullOrWhiteSpace(estado))
            {
                consulta = consulta.Where(item => string.Equals(item.Estado, estado, StringComparison.OrdinalIgnoreCase));
            }
            return consulta.OrderByDescending(item => item.FechaEmision).ThenByDescending(item => item.Id).ToList();
        }

        private void ConsultarYActualizar()
        {
            if (dateTimePicker1.Value.Date > dateTimePicker2.Value.Date)
            {
                ticketsFiltrados = new List<Ticket>();
                dataGridView1.Rows.Clear();
                CalcularEstadisticas();
            }
            else
            {
                ticketsFiltrados = ConsultarReportes();
                MostrarTickets();
                CalcularEstadisticas();
            }
        }

        private void MostrarTickets()
        {
            dataGridView1.Rows.Clear();
            foreach (Ticket ticket in ticketsFiltrados)
            {
                Fila fila = controladorFilas.Buscar(ticket.CodigoFila);
                Sucursal sucursal = fila == null ? null : controladorSucursales.Buscar(fila.CodigoSucursal);
                dataGridView1.Rows.Add(
                    ticket.CodigoTicket,
                    sucursal == null ? "No disponible" : sucursal.Codigo,
                    fila == null ? ticket.CodigoFila : fila.Descripcion,
                    ticket.FechaEmision.ToString("dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture),
                    ticket.Estado,
                    ObtenerTiempoEspera(ticket),
                    ticket.Programado ? "Cita" : "Normal");
            }
        }

        private void CalcularEstadisticas()
        {
            labelTotalValor.Text = ticketsFiltrados.Count.ToString(CultureInfo.InvariantCulture);
            labelAtendidosValor.Text = ticketsFiltrados.Count(item => item.Estado == TListTickets.Atendido).ToString(CultureInfo.InvariantCulture);
            labelPendientesValor.Text = ticketsFiltrados.Count(item => item.Estado == TListTickets.Pendiente).ToString(CultureInfo.InvariantCulture);
            labelOmitidosValor.Text = ticketsFiltrados.Count(item => item.Estado == TListTickets.Omitido).ToString(CultureInfo.InvariantCulture);
            labelAnuladosValor.Text = ticketsFiltrados.Count(item => item.Estado == TListTickets.Anulado).ToString(CultureInfo.InvariantCulture);
            List<double> esperas = ticketsFiltrados
                .Where(item => item.FechaEmision != DateTime.MinValue && item.FechaLlamado != DateTime.MinValue && item.FechaLlamado >= item.FechaEmision)
                .Select(item => (item.FechaLlamado - item.FechaEmision).TotalMinutes)
                .ToList();
            labelPromedioValor.Text = esperas.Count == 0 ? "No disponible" : TimeSpan.FromMinutes(esperas.Average()).ToString(@"hh\:mm");
        }

        private string ObtenerTiempoEspera(Ticket ticket)
        {
            string resultado = "No disponible";
            if (ticket.FechaEmision != DateTime.MinValue && ticket.FechaLlamado != DateTime.MinValue && ticket.FechaLlamado >= ticket.FechaEmision)
            {
                resultado = (ticket.FechaLlamado - ticket.FechaEmision).ToString(@"hh\:mm");
            }
            return resultado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.Date > dateTimePicker2.Value.Date)
            {
                MessageBox.Show("La fecha inicial no puede ser posterior a la fecha final.", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePicker1.Focus();
            }
            else
            {
                ConsultarYActualizar();
                if (ticketsFiltrados.Count == 0)
                {
                    MessageBox.Show("No existen turnos para los filtros seleccionados.", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ticketsFiltrados.Count == 0)
            {
                MessageBox.Show("No hay registros filtrados para exportar.", "Exportar reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                using (SaveFileDialog dialogo = new SaveFileDialog())
                {
                    dialogo.Filter = "Archivo CSV (*.csv)|*.csv";
                    dialogo.Title = "Exportar reporte a CSV";
                    dialogo.FileName = "reporte_turnos_" + DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".csv";
                    if (dialogo.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            File.WriteAllText(dialogo.FileName, ConstruirCsv(), new UTF8Encoding(true));
                            MessageBox.Show("El reporte se exportó correctamente.", "Exportar reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (IOException)
                        {
                            MessageBox.Show("No se pudo guardar el archivo CSV seleccionado.", "Exportar reportes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (UnauthorizedAccessException)
                        {
                            MessageBox.Show("No tiene permisos para guardar el archivo en la ubicación seleccionada.", "Exportar reportes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private string ConstruirCsv()
        {
            StringBuilder contenido = new StringBuilder();
            contenido.AppendLine("Código de turno,Sucursal,Servicio o fila,Fecha y hora,Estado,Tiempo de espera,Tipo");
            foreach (Ticket ticket in ticketsFiltrados)
            {
                Fila fila = controladorFilas.Buscar(ticket.CodigoFila);
                Sucursal sucursal = fila == null ? null : controladorSucursales.Buscar(fila.CodigoSucursal);
                contenido.AppendLine(string.Join(",", new string[]
                {
                    EscaparCsv(ticket.CodigoTicket),
                    EscaparCsv(sucursal == null ? "No disponible" : sucursal.Codigo),
                    EscaparCsv(fila == null ? ticket.CodigoFila : fila.Descripcion),
                    EscaparCsv(ticket.FechaEmision.ToString("dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture)),
                    EscaparCsv(ticket.Estado),
                    EscaparCsv(ObtenerTiempoEspera(ticket)),
                    EscaparCsv(ticket.Programado ? "Cita" : "Normal")
                }));
            }
            return contenido.ToString();
        }

        private string EscaparCsv(string valor)
        {
            string texto = valor ?? string.Empty;
            return "\"" + texto.Replace("\"", "\"\"") + "\"";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            CargarServicios();
            ConsultarYActualizar();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarServicios();
        }

        private void comboBox1_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem is Sucursal sucursal)
            {
                e.Value = sucursal.Codigo;
            }
        }

        private void comboBox2_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem is Fila fila)
            {
                e.Value = fila.Descripcion;
            }
        }
    }
}
