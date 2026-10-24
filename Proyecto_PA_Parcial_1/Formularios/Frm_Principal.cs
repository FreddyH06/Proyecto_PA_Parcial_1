
using System;
using System.Drawing;
using System.Windows.Forms;
using Proyecto_PA_Parcial_1.Entidades;

namespace Proyecto_PA_Parcial_1.Formularios
{
    public partial class Frm_Principal : Form
    {
        private readonly Usuario usuarioActual;

        public Frm_Principal() : this(null)
        {
        }
        private Frm_Pantalla pantallaExterna;
        public Frm_Principal(Usuario usuario)
        {
            usuarioActual = usuario;

            InitializeComponent();

            ConfigurarInformacionUsuario();
            AplicarPermisos();
            ConectarEventos();

            if (button1.Enabled)
            {
                CargarFormularioEnPanel(new Frm_Dashboard());
            }
        }

        private void ConfigurarInformacionUsuario()
        {
            string nombreUsuario = usuarioActual == null
                ? "Usuario no identificado"
                : usuarioActual.Nombre;

            string tipoUsuario = usuarioActual == null
                ? "Sin rol"
                : usuarioActual.TipoUsuario;

            labelUsuario.Text = nombreUsuario + " - " + tipoUsuario;
        }

        private void AplicarPermisos()
        {
            bool esAdministrador = usuarioActual != null &&
                string.Equals(
                    usuarioActual.TipoUsuario,
                    "ADMINISTRADOR",
                    StringComparison.OrdinalIgnoreCase);

            bool esTrabajador = usuarioActual != null &&
                string.Equals(
                    usuarioActual.TipoUsuario,
                    "TRABAJADOR",
                    StringComparison.OrdinalIgnoreCase);

            bool autorizado = esAdministrador || esTrabajador;

            button1.Enabled = autorizado;
            button2.Enabled = esAdministrador;
            button3.Enabled = esAdministrador;
            button4.Enabled = esAdministrador;
            button5.Enabled = esAdministrador;
            button6.Enabled = esAdministrador;
            button7.Enabled = autorizado;
            button8.Enabled = autorizado;
            button9.Enabled = autorizado;
            button10.Enabled = autorizado;
            button11.Enabled = autorizado;
            button12.Enabled = esAdministrador;
            button13.Enabled = autorizado;
            button14.Enabled = true;
        }

        private void ConectarEventos()
        {
            button1.Click -= button1_Click;
            button2.Click -= button2_Click;
            button3.Click -= button3_Click;
            button14.Click -= button14_Click;

            button1.Click += button1_Click;
            button2.Click += button2_Click;
            button3.Click += button3_Click;

            button4.Click += button4_Click;
            button5.Click += button5_Click;
            button6.Click += button6_Click;
            button7.Click += button7_Click;
            button8.Click += button8_Click;
            button9.Click += button9_Click;
            button10.Click += button10_Click;
            button11.Click += button11_Click;
            button12.Click += button12_Click;
            button13.Click += button13_Click;

            button14.Click += button14_Click;
        }

        private void CargarFormularioEnPanel(Form formulario)
        {
            if (formulario != null)
            {
                while (panelContenedor.Controls.Count > 0)
                {
                    Control anterior = panelContenedor.Controls[0];

                    panelContenedor.Controls.RemoveAt(0);

                    anterior.Dispose();
                }

                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;

                panelContenedor.Controls.Add(formulario);

                formulario.Show();
                formulario.BringToFront();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarFormularioEnPanel(new Frm_Dashboard());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargarFormularioEnPanel(new Frm_Empresa());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CargarFormularioEnPanel(new Frm_Sucursales());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CargarFormularioEnPanel(new Frm_Filas());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CargarFormularioEnPanel(new Frm_Usuarios());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CargarFormularioEnPanel(new Frm_Totems());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CargarFormularioEnPanel(new Frm_Turnos());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CargarFormularioEnPanel(new Frm_Citas());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CargarFormularioEnPanel(new Frm_Atencion());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CargarFormularioEnPanel(new Frm_Reportes());
        }


        private void button11_Click(object sender, EventArgs e)
        {
            if (pantallaExterna == null || pantallaExterna.IsDisposed)
            {
                pantallaExterna = new Frm_Pantalla();

                pantallaExterna.StartPosition = FormStartPosition.Manual;

                Screen monitor = Screen.AllScreens.Length > 1
                    ? Screen.AllScreens[1]
                    : Screen.FromControl(this);

                pantallaExterna.Location = monitor.WorkingArea.Location;

                pantallaExterna.Show();

                pantallaExterna.WindowState = FormWindowState.Maximized;
            }
            else
            {
                pantallaExterna.WindowState = FormWindowState.Maximized;
                pantallaExterna.Activate();
            }
        }


        private void button12_Click(object sender, EventArgs e)
        {
            CargarFormularioEnPanel(new Frm_Recordatorios());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            CargarFormularioEnPanel(new Frm_Perfil());
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {

        }
    }
}
