using System;
using System.Drawing;
using System.Windows.Forms;
using Proyecto_PA_Parcial_1.Entidades;

namespace Proyecto_PA_Parcial_1.Formularios
{
    public partial class Frm_Principal : Form
    {
        private readonly Usuario usuarioActual;

        public Frm_Principal()
            : this(null)
        {
        }

        public Frm_Principal(Usuario usuario)
        {
            usuarioActual = usuario;
            InitializeComponent();
            ConfigurarInformacionUsuario();
            AplicarPermisos();
        }

        private void ConfigurarInformacionUsuario()
        {
            string nombreUsuario = usuarioActual == null ? "Usuario no identificado" : usuarioActual.Nombre;
            string tipoUsuario = usuarioActual == null ? "Sin rol" : usuarioActual.TipoUsuario;
            labelUsuario.Text = nombreUsuario + " - " + tipoUsuario;
        }

        private void AplicarPermisos()
        {
            bool esAdministrador = usuarioActual != null && string.Equals(usuarioActual.TipoUsuario, "ADMINISTRADOR", StringComparison.OrdinalIgnoreCase);
            bool esTrabajador = usuarioActual != null && string.Equals(usuarioActual.TipoUsuario, "TRABAJADOR", StringComparison.OrdinalIgnoreCase);
            bool usuarioAutorizado = esAdministrador || esTrabajador;
            bool dashboardDisponible = false;
            bool empresaDisponible = false;
            bool sucursalesDisponible = false;
            bool filasDisponible = false;
            bool usuariosDisponible = false;
            bool totemsDisponible = false;
            bool turnosDisponible = false;
            bool citasDisponible = false;
            bool atencionDisponible = false;
            bool reportesDisponible = false;
            bool pantallaDisponible = false;
            bool recordatoriosDisponible = false;
            bool perfilDisponible = false;

            button1.Enabled = usuarioAutorizado && dashboardDisponible;
            button2.Enabled = esAdministrador && empresaDisponible;
            button3.Enabled = esAdministrador && sucursalesDisponible;
            button4.Enabled = esAdministrador && filasDisponible;
            button5.Enabled = esAdministrador && usuariosDisponible;
            button6.Enabled = esAdministrador && totemsDisponible;
            button7.Enabled = usuarioAutorizado && turnosDisponible;
            button8.Enabled = usuarioAutorizado && citasDisponible;
            button9.Enabled = (esAdministrador || esTrabajador) && atencionDisponible;
            button10.Enabled = (esAdministrador || esTrabajador) && reportesDisponible;
            button11.Enabled = usuarioAutorizado && pantallaDisponible;
            button12.Enabled = esAdministrador && recordatoriosDisponible;
            button13.Enabled = usuarioAutorizado && perfilDisponible;
            button14.Enabled = true;
        }

        private void CargarFormularioEnPanel(Form formulario)
        {
            if (formulario != null)
            {
                panelContenedor.Controls.Clear();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(formulario);
                formulario.Show();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
