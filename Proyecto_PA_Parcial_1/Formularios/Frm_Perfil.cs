using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Proyecto_PA_Parcial_1.Controlador;
using Proyecto_PA_Parcial_1.Entidades;

namespace Proyecto_PA_Parcial_1.Formularios
{
    public partial class Frm_Perfil : Form
    {
        private readonly TListUsuarios controlador = new TListUsuarios();
        private readonly Usuario usuarioSesion;
        private Usuario usuarioActual;

        public Frm_Perfil()
            : this(null)
        {
        }

        public Frm_Perfil(Usuario usuario)
        {
            usuarioSesion = usuario;
            InitializeComponent();
            CargarPerfil();
        }

        private void CargarPerfil()
        {
            usuarioActual = null;
            if (usuarioSesion != null && !string.IsNullOrWhiteSpace(usuarioSesion.Username))
            {
                usuarioActual = controlador.Buscar(usuarioSesion.Username);
            }
            if (usuarioActual == null)
            {
                LimpiarDatosPerfil();
                MessageBox.Show("No existe una sesión de usuario disponible para cargar el perfil. Abra el perfil desde una sesión iniciada.", "Mi perfil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MostrarDatosPerfil();
            }
        }

        private void MostrarDatosPerfil()
        {
            textBox1.Text = usuarioActual.Username;
            textBox2.Text = usuarioActual.Nombre;
            textBox3.Text = usuarioActual.Apellidos;
            textBox4.Text = usuarioActual.Telefono;
            labelRolValor.Text = usuarioActual.TipoUsuario;
            labelSucursalValor.Text = ValorNoDisponible(usuarioActual.CodigoSucursal);
            labelVentanillaValor.Text = ValorNoDisponible(usuarioActual.Ventanilla);
            labelEstadoValor.Text = usuarioActual.Activo ? "Activo" : "Inactivo";
            labelEstadoValor.ForeColor = usuarioActual.Activo ? System.Drawing.Color.FromArgb(31, 120, 85) : System.Drawing.Color.DarkRed;
        }

        private void LimpiarDatosPerfil()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            labelRolValor.Text = "No disponible";
            labelSucursalValor.Text = "No disponible";
            labelVentanillaValor.Text = "No disponible";
            labelEstadoValor.Text = "No disponible";
            labelEstadoValor.ForeColor = System.Drawing.Color.FromArgb(55, 64, 73);
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private string ValorNoDisponible(string valor)
        {
            return string.IsNullOrWhiteSpace(valor) ? "No aplica" : valor;
        }

        private bool ValidarDatosPersonales()
        {
            bool valido = true;
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MostrarAdvertencia("Ingrese el nombre.");
                textBox2.Focus();
                valido = false;
            }
            else if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MostrarAdvertencia("Ingrese los apellidos.");
                textBox3.Focus();
                valido = false;
            }
            else if (string.IsNullOrWhiteSpace(textBox4.Text) || !EsTelefonoValido(textBox4.Text.Trim()))
            {
                MostrarAdvertencia("Ingrese un teléfono válido.");
                textBox4.Focus();
                valido = false;
            }
            return valido;
        }

        private bool EsTelefonoValido(string telefono)
        {
            bool tieneDigitos = false;
            bool valido = true;
            foreach (char caracter in telefono)
            {
                if (char.IsDigit(caracter))
                {
                    tieneDigitos = true;
                }
                else if (caracter != ' ' && caracter != '-' && caracter != '(' && caracter != ')' && caracter != '+')
                {
                    valido = false;
                }
            }
            return valido && tieneDigitos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool guardado = false;
            if (usuarioActual == null)
            {
                MostrarAdvertencia("No hay una sesión válida para modificar el perfil.");
            }
            else if (ValidarDatosPersonales())
            {
                Usuario cambios = new Usuario(
                    usuarioActual.Username,
                    textBox2.Text.Trim(),
                    textBox3.Text.Trim(),
                    textBox4.Text.Trim(),
                    usuarioActual.ClaveHash,
                    usuarioActual.TipoUsuario,
                    usuarioActual.CodigoSucursal,
                    usuarioActual.Ventanilla,
                    usuarioActual.Activo);
                guardado = controlador.Modificar(cambios);
                if (guardado)
                {
                    usuarioActual = controlador.Buscar(usuarioActual.Username);
                    MostrarDatosPerfil();
                    MostrarInformacion("Los datos personales se actualizaron correctamente.");
                }
                else
                {
                    MostrarAdvertencia("No se pudieron guardar los datos personales. Verifique la información e inténtelo nuevamente.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargarPerfil();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool cambioRealizado = false;
            if (usuarioActual == null)
            {
                MostrarAdvertencia("No hay una sesión válida para cambiar la contraseña.");
            }
            else if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MostrarAdvertencia("Ingrese la contraseña actual.");
                textBox5.Focus();
            }
            else if (!string.Equals(usuarioActual.ClaveHash, CalcularHash(textBox5.Text), StringComparison.OrdinalIgnoreCase))
            {
                MostrarAdvertencia("La contraseña actual es incorrecta.");
                textBox5.Focus();
            }
            else if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MostrarAdvertencia("Ingrese una nueva contraseña.");
                textBox6.Focus();
            }
            else if (string.IsNullOrWhiteSpace(textBox7.Text))
            {
                MostrarAdvertencia("Confirme la nueva contraseña.");
                textBox7.Focus();
            }
            else if (!string.Equals(textBox6.Text, textBox7.Text, StringComparison.Ordinal))
            {
                MostrarAdvertencia("La nueva contraseña y su confirmación no coinciden.");
                textBox7.Focus();
            }
            else
            {
                Usuario cambios = new Usuario(
                    usuarioActual.Username,
                    usuarioActual.Nombre,
                    usuarioActual.Apellidos,
                    usuarioActual.Telefono,
                    CalcularHash(textBox6.Text),
                    usuarioActual.TipoUsuario,
                    usuarioActual.CodigoSucursal,
                    usuarioActual.Ventanilla,
                    usuarioActual.Activo);
                cambioRealizado = controlador.Modificar(cambios);
                if (cambioRealizado)
                {
                    usuarioActual = controlador.Buscar(usuarioActual.Username);
                    LimpiarContraseñas();
                    MostrarInformacion("La contraseña se cambió correctamente.");
                }
                else
                {
                    MostrarAdvertencia("No se pudo cambiar la contraseña. Verifique que la cuenta siga disponible.");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LimpiarContraseñas();
        }

        private void LimpiarContraseñas()
        {
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
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

        private void MostrarAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Mi perfil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void MostrarInformacion(string mensaje)
        {
            MessageBox.Show(mensaje, "Mi perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
