using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Proyecto_PA_Parcial_1.Controlador;
using Proyecto_PA_Parcial_1.Entidades;

namespace Proyecto_PA_Parcial_1.Formularios
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text;
            Usuario usuario = TListUsuarios.Lista.FirstOrDefault(item => string.Equals(item.Username, username, StringComparison.OrdinalIgnoreCase));
            bool camposValidos = !string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password);
            bool credencialesValidas = usuario != null && usuario.Activo && string.Equals(usuario.ClaveHash, CalcularHash(password), StringComparison.OrdinalIgnoreCase);
            if (!camposValidos)
            {
                label4.Text = "Ingrese usuario y contraseña.";
                label4.ForeColor = System.Drawing.Color.DarkRed;
            }
            else if (usuario == null)
            {
                label4.Text = "El usuario no existe.";
                label4.ForeColor = System.Drawing.Color.DarkRed;
            }
            else if (!usuario.Activo)
            {
                label4.Text = "La cuenta está inactiva.";
                label4.ForeColor = System.Drawing.Color.DarkRed;
            }
            else if (!credencialesValidas)
            {
                label4.Text = "La contraseña es incorrecta.";
                label4.ForeColor = System.Drawing.Color.DarkRed;
            }
            else
            {
                Frm_Principal formularioPrincipal = new Frm_Principal(usuario);
                formularioPrincipal.FormClosed += formularioPrincipal_FormClosed;
                Hide();
                formularioPrincipal.Show();
            }
        }

        private void formularioPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El módulo de solicitud de turnos se habilitará cuando Frm_Turnos sea implementado.", "TurnoSmarts", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string CalcularHash(string valor)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] datos = Encoding.UTF8.GetBytes(valor);
                byte[] hash = sha256.ComputeHash(datos);
                return BitConverter.ToString(hash).Replace("-", string.Empty);
            }
        }
    }
}
