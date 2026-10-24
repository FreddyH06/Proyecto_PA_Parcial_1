using System;
using System.Net.Mail;
using System.Windows.Forms;
using Proyecto_PA_Parcial_1.Entidades;

namespace Proyecto_PA_Parcial_1.Formularios
{
    public partial class Frm_Empresa : Form
    {
        private static readonly Empresa configuracionCompartida = new Empresa
        {
            Correo = "fherrera3@utmachala.edu.ec"
        };
        private readonly bool esAdministrador;

        public Frm_Empresa()
            : this(false)
        {
        }

        public Frm_Empresa(Usuario usuario)
            : this(usuario != null && string.Equals(usuario.TipoUsuario, "ADMINISTRADOR", StringComparison.OrdinalIgnoreCase))
        {
        }

        public Frm_Empresa(bool esAdministrador)
        {
            this.esAdministrador = esAdministrador;
            InitializeComponent();
            CargarConfiguracion();
        }

        public static Empresa ConfiguracionCompartida
        {
            get { return configuracionCompartida; }
        }

        private void CargarConfiguracion()
        {
            textBoxRuc.Text = configuracionCompartida.Ruc ?? string.Empty;
            textBoxRazonSocial.Text = configuracionCompartida.RazonSocial ?? string.Empty;
            textBoxCorreo.Text = configuracionCompartida.Correo ?? "fherrera3@utmachala.edu.ec";
            checkBoxCedula.Checked = configuracionCompartida.ObligarCedula;
            checkBoxNombre.Checked = configuracionCompartida.ObligarNombre;
            checkBoxCorreo.Checked = configuracionCompartida.ObligarCorreo;
            checkBoxTelefono.Checked = configuracionCompartida.ObligarTelefono;
            textBoxSmtpServidor.Text = configuracionCompartida.SmtpServidor ?? string.Empty;
            numericUpDownSmtpPuerto.Value = Math.Max(numericUpDownSmtpPuerto.Minimum, Math.Min(numericUpDownSmtpPuerto.Maximum, configuracionCompartida.SmtpPuerto));
            textBoxSmtpUsuario.Text = configuracionCompartida.SmtpUsuario ?? string.Empty;
            checkBoxSmtpSsl.Checked = configuracionCompartida.SmtpSsl;
            textBoxAppId.Text = configuracionCompartida.Correo365AppId ?? string.Empty;
            textBoxTenantId.Text = configuracionCompartida.Correo365Tenant ?? string.Empty;
            AplicarPermisos();
        }

        private void AplicarPermisos()
        {
            groupBoxEmpresa.Enabled = esAdministrador;
            groupBoxCamposObligatorios.Enabled = esAdministrador;
            groupBoxCorreo.Enabled = esAdministrador;
            buttonGuardar.Enabled = esAdministrador;
            buttonComprobar.Enabled = esAdministrador;
            labelPermisos.Text = esAdministrador ? "Configuración disponible para administradores." : "Solo los usuarios administradores pueden modificar estos parámetros.";
            labelPermisos.ForeColor = esAdministrador ? System.Drawing.Color.DarkGreen : System.Drawing.Color.DarkRed;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (!esAdministrador)
            {
                MessageBox.Show("Solo los usuarios administradores pueden guardar la configuración.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!ValidarDatosBasicos())
            {
            }
            else if (!ValidarConfiguracionCorreo())
            {
            }
            else
            {
                GuardarConfiguracion();
                MessageBox.Show("La configuración se guardó en memoria para esta ejecución.", "TurnoSmarts", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonComprobar_Click(object sender, EventArgs e)
        {
            if (!esAdministrador)
            {
                MessageBox.Show("Solo los usuarios administradores pueden comprobar la configuración.", "Acceso restringido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!ValidarDatosBasicos())
            {
            }
            else if (!ValidarConfiguracionCorreo())
            {
            }
            else
            {
                MessageBox.Show("Los datos configurados tienen un formato válido. No se envió ningún correo porque el servicio real de envío todavía no está implementado.", "Comprobación de configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ValidarDatosBasicos()
        {
            bool datosValidos = true;
            if (string.IsNullOrWhiteSpace(textBoxRuc.Text))
            {
                MessageBox.Show("Ingrese el RUC de la empresa.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                datosValidos = false;
            }
            else if (string.IsNullOrWhiteSpace(textBoxRazonSocial.Text))
            {
                MessageBox.Show("Ingrese la razón social de la empresa.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                datosValidos = false;
            }
            else if (!EsCorreoValido(textBoxCorreo.Text))
            {
                MessageBox.Show("Ingrese un correo institucional válido.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                datosValidos = false;
            }
            return datosValidos;
        }

        private bool ValidarConfiguracionCorreo()
        {
            bool configuracionValida = true;
            bool tieneSmtp = !string.IsNullOrWhiteSpace(textBoxSmtpServidor.Text) || !string.IsNullOrWhiteSpace(textBoxSmtpUsuario.Text) || numericUpDownSmtpPuerto.Value > 0;
            bool tieneMicrosoft365 = !string.IsNullOrWhiteSpace(textBoxAppId.Text) || !string.IsNullOrWhiteSpace(textBoxTenantId.Text);
            if (tieneSmtp && (string.IsNullOrWhiteSpace(textBoxSmtpServidor.Text) || string.IsNullOrWhiteSpace(textBoxSmtpUsuario.Text) || numericUpDownSmtpPuerto.Value <= 0))
            {
                MessageBox.Show("Para usar SMTP indique servidor, puerto y usuario. La contraseña debe ser proporcionada mediante un mecanismo seguro cuando se implemente el envío real.", "Configuración incompleta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                configuracionValida = false;
            }
            else if (tieneMicrosoft365 && (string.IsNullOrWhiteSpace(textBoxAppId.Text) || string.IsNullOrWhiteSpace(textBoxTenantId.Text)))
            {
                MessageBox.Show("Para Microsoft 365 indique conjuntamente App ID y Tenant ID.", "Configuración incompleta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                configuracionValida = false;
            }
            return configuracionValida;
        }

        private void GuardarConfiguracion()
        {
            configuracionCompartida.Ruc = textBoxRuc.Text.Trim();
            configuracionCompartida.RazonSocial = textBoxRazonSocial.Text.Trim();
            configuracionCompartida.Correo = textBoxCorreo.Text.Trim();
            configuracionCompartida.ObligarCedula = checkBoxCedula.Checked;
            configuracionCompartida.ObligarNombre = checkBoxNombre.Checked;
            configuracionCompartida.ObligarCorreo = checkBoxCorreo.Checked;
            configuracionCompartida.ObligarTelefono = checkBoxTelefono.Checked;
            configuracionCompartida.SmtpServidor = textBoxSmtpServidor.Text.Trim();
            configuracionCompartida.SmtpPuerto = Convert.ToInt32(numericUpDownSmtpPuerto.Value);
            configuracionCompartida.SmtpUsuario = textBoxSmtpUsuario.Text.Trim();
            configuracionCompartida.SmtpSsl = checkBoxSmtpSsl.Checked;
            configuracionCompartida.Correo365AppId = textBoxAppId.Text.Trim();
            configuracionCompartida.Correo365Tenant = textBoxTenantId.Text.Trim();
        }

        private bool EsCorreoValido(string correo)
        {
            try
            {
                MailAddress direccion = new MailAddress(correo.Trim());
                return string.Equals(direccion.Address, correo.Trim(), StringComparison.OrdinalIgnoreCase);
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
