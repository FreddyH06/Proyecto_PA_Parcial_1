using System;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Proyecto_PA_Parcial_1.Controlador;
using Proyecto_PA_Parcial_1.Entidades;

namespace Proyecto_PA_Parcial_1.Formularios
{
    public partial class Frm_Usuarios : Form
    {
        private readonly TListUsuarios controlador = new TListUsuarios();
        private Usuario usuarioSeleccionado;

        public Frm_Usuarios()
        {
            InitializeComponent();
            CargarSucursales();
            CargarUsuarios();
            LimpiarCampos();
        }

        private void CargarUsuarios()
        {
            dataGridView1.Rows.Clear();
            foreach (Usuario usuario in controlador.Listar())
            {
                dataGridView1.Rows.Add(
                    usuario.Username,
                    usuario.Nombre,
                    usuario.Apellidos,
                    usuario.Telefono,
                    usuario.TipoUsuario,
                    usuario.CodigoSucursal,
                    usuario.Ventanilla,
                    usuario.Activo ? "Activo" : "Inactivo");
            }
        }

        private void CargarSucursales()
        {
            comboBoxSucursal.Items.Clear();
            foreach (Sucursal sucursal in TListSucursales.Lista)
            {
                comboBoxSucursal.Items.Add(sucursal.Codigo);
            }
        }

        private bool ValidarCampos(bool esNuevo)
        {
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text))
            {
                MostrarAdvertencia("Ingrese el usuario.");
                textBoxUsername.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
            {
                MostrarAdvertencia("Ingrese el nombre.");
                textBoxNombre.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxApellidos.Text))
            {
                MostrarAdvertencia("Ingrese los apellidos.");
                textBoxApellidos.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxTelefono.Text) || !EsTelefonoValido(textBoxTelefono.Text.Trim()))
            {
                MostrarAdvertencia("Ingrese un teléfono válido.");
                textBoxTelefono.Focus();
                return false;
            }
            if (comboBoxTipoUsuario.SelectedIndex < 0)
            {
                MostrarAdvertencia("Seleccione el rol del usuario.");
                comboBoxTipoUsuario.Focus();
                return false;
            }
            if (esNuevo && string.IsNullOrEmpty(textBoxClave.Text))
            {
                MostrarAdvertencia("Ingrese la contraseña.");
                textBoxClave.Focus();
                return false;
            }
            if (!string.IsNullOrEmpty(textBoxClave.Text) && !string.Equals(textBoxClave.Text, textBoxConfirmarClave.Text, StringComparison.Ordinal))
            {
                MostrarAdvertencia("La contraseña y su confirmación no coinciden.");
                textBoxConfirmarClave.Focus();
                return false;
            }
            if (string.Equals(Convert.ToString(comboBoxTipoUsuario.SelectedItem), "TRABAJADOR", StringComparison.OrdinalIgnoreCase))
            {
                if (comboBoxSucursal.SelectedIndex < 0)
                {
                    MostrarAdvertencia("Seleccione la sucursal del trabajador.");
                    comboBoxSucursal.Focus();
                    return false;
                }
                if (string.IsNullOrWhiteSpace(textBoxVentanilla.Text))
                {
                    MostrarAdvertencia("Ingrese la ventanilla del trabajador.");
                    textBoxVentanilla.Focus();
                    return false;
                }
            }
            return true;
        }

        private bool EsTelefonoValido(string telefono)
        {
            bool tieneDigitos = false;
            foreach (char caracter in telefono)
            {
                if (char.IsDigit(caracter))
                {
                    tieneDigitos = true;
                }
                else if (caracter != ' ' && caracter != '-' && caracter != '(' && caracter != ')' && caracter != '+')
                {
                    return false;
                }
            }
            return tieneDigitos;
        }

        private Usuario ObtenerUsuarioDesdeCampos()
        {
            string claveHash = usuarioSeleccionado == null || !string.IsNullOrEmpty(textBoxClave.Text)
                ? CalcularHash(textBoxClave.Text)
                : usuarioSeleccionado.ClaveHash;
            return new Usuario(
                textBoxUsername.Text.Trim(),
                textBoxNombre.Text.Trim(),
                textBoxApellidos.Text.Trim(),
                textBoxTelefono.Text.Trim(),
                claveHash,
                Convert.ToString(comboBoxTipoUsuario.SelectedItem),
                Convert.ToString(comboBoxSucursal.SelectedItem),
                textBoxVentanilla.Text.Trim(),
                checkBoxActivo.Checked);
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos(true))
            {
                return;
            }
            if (!controlador.Agregar(ObtenerUsuarioDesdeCampos()))
            {
                MostrarAdvertencia("Ya existe un usuario con ese nombre o los datos no son válidos.");
                textBoxUsername.Focus();
                return;
            }
            CargarUsuarios();
            LimpiarCampos();
            MostrarInformacion("El usuario se agregó correctamente.");
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos(false))
            {
                return;
            }
            if (usuarioSeleccionado == null)
            {
                MostrarAdvertencia("Seleccione un usuario de la lista para modificarlo.");
                return;
            }
            if (!string.Equals(textBoxUsername.Text.Trim(), usuarioSeleccionado.Username, StringComparison.OrdinalIgnoreCase))
            {
                MostrarAdvertencia("El usuario seleccionado no puede cambiar de nombre.");
                textBoxUsername.Text = usuarioSeleccionado.Username;
                textBoxUsername.Focus();
                return;
            }
            if (!controlador.Modificar(ObtenerUsuarioDesdeCampos()))
            {
                MostrarAdvertencia("No se pudo modificar el usuario porque los datos no son válidos.");
                return;
            }
            CargarUsuarios();
            LimpiarCampos();
            MostrarInformacion("El usuario se modificó correctamente.");
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (usuarioSeleccionado == null && string.IsNullOrWhiteSpace(textBoxUsername.Text))
            {
                MostrarAdvertencia("Seleccione un usuario para eliminarlo.");
                return;
            }
            string username = usuarioSeleccionado == null ? textBoxUsername.Text.Trim() : usuarioSeleccionado.Username;
            if (MessageBox.Show("¿Está seguro de eliminar el usuario " + username + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            if (!controlador.Eliminar(username))
            {
                MostrarAdvertencia("No se pudo eliminar el usuario. Verifique que exista.");
                return;
            }
            CargarUsuarios();
            LimpiarCampos();
            MostrarInformacion("El usuario se eliminó correctamente.");
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView1.Rows.Count)
            {
                return;
            }
            string username = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            usuarioSeleccionado = controlador.Buscar(username);
            if (usuarioSeleccionado == null)
            {
                return;
            }
            textBoxUsername.Text = usuarioSeleccionado.Username;
            textBoxNombre.Text = usuarioSeleccionado.Nombre;
            textBoxApellidos.Text = usuarioSeleccionado.Apellidos;
            textBoxTelefono.Text = usuarioSeleccionado.Telefono;
            comboBoxTipoUsuario.SelectedItem = usuarioSeleccionado.TipoUsuario;
            comboBoxSucursal.SelectedItem = usuarioSeleccionado.CodigoSucursal;
            textBoxVentanilla.Text = usuarioSeleccionado.Ventanilla;
            checkBoxActivo.Checked = usuarioSeleccionado.Activo;
            textBoxClave.Clear();
            textBoxConfirmarClave.Clear();
        }

        private void comboBoxTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool esTrabajador = string.Equals(Convert.ToString(comboBoxTipoUsuario.SelectedItem), "TRABAJADOR", StringComparison.OrdinalIgnoreCase);
            comboBoxSucursal.Enabled = esTrabajador;
            textBoxVentanilla.Enabled = esTrabajador;
            if (!esTrabajador)
            {
                comboBoxSucursal.SelectedIndex = -1;
                textBoxVentanilla.Clear();
            }
        }

        private void LimpiarCampos()
        {
            usuarioSeleccionado = null;
            textBoxUsername.Clear();
            textBoxNombre.Clear();
            textBoxApellidos.Clear();
            textBoxTelefono.Clear();
            textBoxClave.Clear();
            textBoxConfirmarClave.Clear();
            comboBoxTipoUsuario.SelectedIndex = 0;
            comboBoxSucursal.SelectedIndex = -1;
            textBoxVentanilla.Clear();
            checkBoxActivo.Checked = true;
            dataGridView1.ClearSelection();
            textBoxUsername.Focus();
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
            MessageBox.Show(mensaje, "Datos de usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void MostrarInformacion(string mensaje)
        {
            MessageBox.Show(mensaje, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
