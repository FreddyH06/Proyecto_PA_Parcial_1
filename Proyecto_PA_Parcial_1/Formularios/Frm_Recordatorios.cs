using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;
using Proyecto_PA_Parcial_1.Controlador;
using Proyecto_PA_Parcial_1.Entidades;

namespace Proyecto_PA_Parcial_1.Formularios
{
    public partial class Frm_Recordatorios : Form
    {
        private readonly TListRecordatorios controladorRecordatorios = new TListRecordatorios();
        private readonly TListTickets controladorTickets = new TListTickets();
        private Recordatorio recordatorioSeleccionado;

        public Frm_Recordatorios()
        {
            InitializeComponent();
            CargarCitas();
            Listar();
            Limpiar();
        }

        private void CargarCitas()
        {
            int ticketSeleccionado = comboBox1.SelectedValue == null ? 0 : Convert.ToInt32(comboBox1.SelectedValue);
            List<Ticket> citas = controladorTickets.Listar()
                .Where(item => item.Programado)
                .OrderBy(item => item.FechaCita)
                .ThenBy(item => item.CodigoTicket)
                .ToList();
            comboBox1.DataSource = null;
            comboBox1.DisplayMember = "CodigoTicket";
            comboBox1.ValueMember = "Id";
            comboBox1.DataSource = citas;
            if (ticketSeleccionado > 0)
            {
                comboBox1.SelectedValue = ticketSeleccionado;
            }
        }

        private void Listar()
        {
            dataGridView1.Rows.Clear();
            List<Recordatorio> recordatorios = controladorRecordatorios.Listar()
                .OrderBy(item => item.FechaHoraEnvio)
                .ThenBy(item => item.Id)
                .ToList();
            foreach (Recordatorio recordatorio in recordatorios)
            {
                Ticket ticket = controladorTickets.Buscar(recordatorio.TicketId);
                dataGridView1.Rows.Add(
                    recordatorio.Id,
                    ticket == null ? recordatorio.TicketId.ToString() : ticket.CodigoTicket,
                    recordatorio.DireccionEnvio,
                    recordatorio.TipoEnvio,
                    recordatorio.FechaHoraEnvio.ToString("dd/MM/yyyy HH:mm"),
                    recordatorio.Enviado ? "ENVIADO" : "PENDIENTE",
                    recordatorio.Resultado);
            }
        }

        private void Agregar()
        {
            Ticket ticket = ObtenerTicketSeleccionado();
            if (!ValidarDatos(ticket))
            {
            }
            else
            {
                Recordatorio recordatorio = CrearRecordatorio(ticket, ObtenerNuevoId());
                if (controladorRecordatorios.Agregar(recordatorio))
                {
                    Listar();
                    Limpiar();
                    MessageBox.Show("El recordatorio se registró correctamente en memoria.", "Recordatorios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el recordatorio. Verifique que sus datos sean válidos y que el identificador no esté repetido.", "Recordatorios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Modificar()
        {
            Recordatorio seleccionado = ObtenerRecordatorioSeleccionado();
            Ticket ticket = ObtenerTicketSeleccionado();
            if (seleccionado == null)
            {
                MessageBox.Show("Seleccione un recordatorio registrado.", "Recordatorios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!ValidarDatos(ticket))
            {
            }
            else
            {
                Recordatorio recordatorio = CrearRecordatorio(ticket, seleccionado.Id);
                recordatorio.Enviado = seleccionado.Enviado;
                if (controladorRecordatorios.Modificar(recordatorio))
                {
                    Listar();
                    MessageBox.Show("El recordatorio se modificó correctamente.", "Recordatorios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el recordatorio.", "Recordatorios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Eliminar()
        {
            Recordatorio seleccionado = ObtenerRecordatorioSeleccionado();
            if (seleccionado == null)
            {
                MessageBox.Show("Seleccione un recordatorio registrado.", "Recordatorios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MessageBox.Show("¿Desea eliminar el recordatorio seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (controladorRecordatorios.Eliminar(seleccionado.Id))
                {
                    Listar();
                    Limpiar();
                    MessageBox.Show("El recordatorio se eliminó correctamente.", "Recordatorios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el recordatorio.", "Recordatorios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Limpiar()
        {
            recordatorioSeleccionado = null;
            numericUpDown1.Value = 0;
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
            comboBox2.SelectedIndex = 0;
            textBox1.Clear();
            richTextBox1.Clear();
            dateTimePicker1.Value = DateTime.Now;
            checkBox1.Checked = false;
            textBox2.Clear();
            dataGridView1.ClearSelection();
        }

        private void EnviarRecordatorio()
        {
            Recordatorio seleccionado = ObtenerRecordatorioSeleccionado();
            Ticket ticket = seleccionado == null ? null : controladorTickets.Buscar(seleccionado.TicketId);
            if (seleccionado == null)
            {
                MessageBox.Show("Seleccione un recordatorio registrado.", "Envío de recordatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (seleccionado.Enviado)
            {
                MessageBox.Show("El recordatorio seleccionado ya está marcado como enviado.", "Envío de recordatorio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ticket == null)
            {
                MessageBox.Show("La cita asociada ya no existe.", "Envío de recordatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!ticket.Programado)
            {
                MessageBox.Show("Solo se pueden enviar recordatorios de citas programadas.", "Envío de recordatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ticket.Estado == TListTickets.Anulado)
            {
                MessageBox.Show("No se pueden enviar notificaciones de citas anuladas.", "Envío de recordatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (seleccionado.FechaHoraEnvio > DateTime.Now)
            {
                MessageBox.Show("La fecha programada del recordatorio todavía no ha llegado.", "Envío de recordatorio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.Equals(seleccionado.TipoEnvio, "CORREO", StringComparison.OrdinalIgnoreCase))
            {
                IntentarCorreo(seleccionado);
            }
            else if (string.Equals(seleccionado.TipoEnvio, "SMS", StringComparison.OrdinalIgnoreCase))
            {
                seleccionado.Resultado = "Servicio SMS no configurado";
                textBox2.Text = seleccionado.Resultado;
                Listar();
                MessageBox.Show("Servicio SMS no configurado. El recordatorio permanece pendiente.", "Envío de recordatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("El medio de notificación no está configurado.", "Envío de recordatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void IntentarCorreo(Recordatorio recordatorio)
        {
            Empresa empresa = Frm_Empresa.ConfiguracionCompartida;
            bool configurado = !string.IsNullOrWhiteSpace(empresa.SmtpServidor)
                && empresa.SmtpPuerto > 0
                && !string.IsNullOrWhiteSpace(empresa.SmtpUsuario)
                && EsCorreoValido(empresa.SmtpUsuario);
            if (!configurado)
            {
                recordatorio.Resultado = "Servicio SMTP no configurado";
                textBox2.Text = recordatorio.Resultado;
                Listar();
                MessageBox.Show("Servicio SMTP no configurado. Configure el correo institucional desde Frm_Empresa; el recordatorio permanece pendiente.", "Envío de recordatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                recordatorio.Resultado = "No existe un servicio real de envío implementado";
                textBox2.Text = recordatorio.Resultado;
                Listar();
                MessageBox.Show("La configuración SMTP existe, pero la aplicación no tiene implementado un proveedor real de envío. El recordatorio permanece pendiente.", "Envío de recordatorio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private Ticket ObtenerTicketSeleccionado()
        {
            Ticket ticket = comboBox1.SelectedItem as Ticket;
            return ticket;
        }

        private Recordatorio ObtenerRecordatorioSeleccionado()
        {
            Recordatorio resultado = recordatorioSeleccionado;
            if (resultado == null && dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                resultado = controladorRecordatorios.Buscar(id);
            }
            return resultado;
        }

        private int ObtenerNuevoId()
        {
            return controladorRecordatorios.Listar().Select(item => item.Id).DefaultIfEmpty(0).Max() + 1;
        }

        private Recordatorio CrearRecordatorio(Ticket ticket, int id)
        {
            string tipoEnvio = Convert.ToString(comboBox2.SelectedItem);
            Recordatorio recordatorio = new Recordatorio(
                id,
                ticket.Id,
                tipoEnvio,
                textBox1.Text.Trim(),
                richTextBox1.Text.Trim(),
                dateTimePicker1.Value,
                checkBox1.Checked,
                textBox2.Text.Trim());
            return recordatorio;
        }

        private bool ValidarDatos(Ticket ticket)
        {
            bool valido = ticket != null;
            if (!valido)
            {
                MessageBox.Show("Seleccione una cita válida.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ticket.Estado == TListTickets.Anulado)
            {
                MessageBox.Show("No se pueden registrar recordatorios para citas anuladas.", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                valido = false;
            }
            else if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Ingrese el destinatario.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                valido = false;
            }
            else if (string.Equals(Convert.ToString(comboBox2.SelectedItem), "CORREO", StringComparison.OrdinalIgnoreCase) && !EsCorreoValido(textBox1.Text))
            {
                MessageBox.Show("Ingrese un correo electrónico válido.", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                valido = false;
            }
            else if (string.Equals(Convert.ToString(comboBox2.SelectedItem), "SMS", StringComparison.OrdinalIgnoreCase) && !EsTelefonoValido(textBox1.Text))
            {
                MessageBox.Show("Ingrese un teléfono válido para SMS.", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                valido = false;
            }
            else if (string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                MessageBox.Show("Ingrese el mensaje del recordatorio.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                valido = false;
            }
            return valido;
        }

        private bool EsCorreoValido(string correo)
        {
            bool valido = false;
            try
            {
                MailAddress direccion = new MailAddress(correo.Trim());
                valido = string.Equals(direccion.Address, correo.Trim(), StringComparison.OrdinalIgnoreCase);
            }
            catch (FormatException)
            {
                valido = false;
            }
            return valido;
        }

        private bool EsTelefonoValido(string telefono)
        {
            string valor = new string(telefono.Where(char.IsDigit).ToArray());
            return valor.Length >= 7 && valor.Length <= 15 && valor.Length == telefono.Count(char.IsDigit);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EnviarRecordatorio();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CargarCitas();
            Listar();
            MessageBox.Show("El listado se actualizó correctamente.", "Recordatorios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                recordatorioSeleccionado = controladorRecordatorios.Buscar(id);
                CargarRecordatorio(recordatorioSeleccionado);
            }
        }

        private void CargarRecordatorio(Recordatorio recordatorio)
        {
            if (recordatorio != null)
            {
                Ticket ticket = controladorTickets.Buscar(recordatorio.TicketId);
                numericUpDown1.Value = Math.Min(numericUpDown1.Maximum, recordatorio.Id);
                comboBox1.SelectedValue = recordatorio.TicketId;
                comboBox2.SelectedItem = recordatorio.TipoEnvio;
                textBox1.Text = recordatorio.DireccionEnvio;
                richTextBox1.Text = recordatorio.Contenido;
                dateTimePicker1.Value = recordatorio.FechaHoraEnvio == DateTime.MinValue ? DateTime.Now : recordatorio.FechaHoraEnvio;
                checkBox1.Checked = recordatorio.Enviado;
                textBox2.Text = recordatorio.Resultado ?? string.Empty;
            }
        }
    }
}
