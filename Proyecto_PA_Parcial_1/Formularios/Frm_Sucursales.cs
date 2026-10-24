using System;
using System.Drawing;
using System.Windows.Forms;
using Proyecto_PA_Parcial_1.Controlador;
using Proyecto_PA_Parcial_1.Entidades;

namespace Proyecto_PA_Parcial_1.Formularios
{
    public partial class Frm_Sucursales : Form
    {
        private readonly TListSucursales controlador = new TListSucursales();
        private Sucursal sucursalSeleccionada;

        public Frm_Sucursales()
        {
            InitializeComponent();
            CargarSucursales();
            LimpiarCampos();
        }

        private void CargarSucursales()
        {
            dataGridView1.Rows.Clear();
            foreach (Sucursal sucursal in controlador.Listar())
            {
                dataGridView1.Rows.Add(
                    sucursal.Codigo,
                    sucursal.Direccion,
                    sucursal.Telefono,
                    sucursal.InicioAtencion,
                    sucursal.FinAtencion);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MostrarAdvertencia("Ingrese el código de la sucursal.");
                textBox1.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MostrarAdvertencia("Ingrese la dirección de la sucursal.");
                textBox2.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MostrarAdvertencia("Ingrese el teléfono de la sucursal.");
                textBox3.Focus();
                return false;
            }
            if (!EsTelefonoValido(textBox3.Text.Trim()))
            {
                MostrarAdvertencia("El teléfono solo puede contener números, espacios, guiones, paréntesis y el signo +.");
                textBox3.Focus();
                return false;
            }
            if (dateTimePicker1.Value.TimeOfDay >= dateTimePicker2.Value.TimeOfDay)
            {
                MostrarAdvertencia("La hora de inicio debe ser menor que la hora de fin.");
                dateTimePicker1.Focus();
                return false;
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

        private Sucursal ObtenerSucursalDesdeCampos()
        {
            return new Sucursal(
                textBox1.Text.Trim(),
                textBox2.Text.Trim(),
                textBox3.Text.Trim(),
                dateTimePicker1.Value.ToString("HH:mm"),
                dateTimePicker2.Value.ToString("HH:mm"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            Sucursal sucursal = ObtenerSucursalDesdeCampos();
            if (!controlador.Agregar(sucursal))
            {
                MostrarAdvertencia("Ya existe una sucursal con ese código o los datos no son válidos.");
                textBox1.Focus();
                return;
            }

            CargarSucursales();
            LimpiarCampos();
            MostrarInformacion("La sucursal se agregó correctamente.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            if (sucursalSeleccionada == null)
            {
                MostrarAdvertencia("Seleccione una sucursal de la lista para modificarla.");
                return;
            }

            Sucursal sucursal = ObtenerSucursalDesdeCampos();
            if (!string.Equals(sucursal.Codigo, sucursalSeleccionada.Codigo, StringComparison.OrdinalIgnoreCase))
            {
                MostrarAdvertencia("El código de la sucursal seleccionada no puede modificarse.");
                textBox1.Text = sucursalSeleccionada.Codigo;
                textBox1.Focus();
                return;
            }

            if (!controlador.Modificar(sucursal))
            {
                MostrarAdvertencia("No se pudo modificar la sucursal porque los datos no son válidos.");
                return;
            }

            CargarSucursales();
            LimpiarCampos();
            MostrarInformacion("La sucursal se modificó correctamente.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sucursalSeleccionada == null && string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MostrarAdvertencia("Seleccione una sucursal para eliminarla.");
                return;
            }

            string codigo = sucursalSeleccionada == null ? textBox1.Text.Trim() : sucursalSeleccionada.Codigo;
            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro de eliminar la sucursal con código " + codigo + "?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (confirmacion != DialogResult.Yes)
            {
                return;
            }

            if (!controlador.Eliminar(codigo))
            {
                MostrarAdvertencia("No se pudo eliminar la sucursal. Verifique que exista y que no tenga filas, usuarios o tótems asociados.");
                return;
            }

            CargarSucursales();
            LimpiarCampos();
            MostrarInformacion("La sucursal se eliminó correctamente.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView1.Rows.Count)
            {
                return;
            }

            string codigo = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            sucursalSeleccionada = controlador.Buscar(codigo);
            if (sucursalSeleccionada == null)
            {
                return;
            }

            textBox1.Text = sucursalSeleccionada.Codigo;
            textBox2.Text = sucursalSeleccionada.Direccion;
            textBox3.Text = sucursalSeleccionada.Telefono;
            dateTimePicker1.Value = ObtenerHora(sucursalSeleccionada.InicioAtencion, dateTimePicker1.Value);
            dateTimePicker2.Value = ObtenerHora(sucursalSeleccionada.FinAtencion, dateTimePicker2.Value);
        }

        private DateTime ObtenerHora(string hora, DateTime valorPredeterminado)
        {
            TimeSpan resultado;
            if (TimeSpan.TryParse(hora, out resultado))
            {
                return DateTime.Today.Add(resultado);
            }
            return valorPredeterminado;
        }

        private void LimpiarCampos()
        {
            sucursalSeleccionada = null;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            dateTimePicker1.Value = DateTime.Today.AddHours(8);
            dateTimePicker2.Value = DateTime.Today.AddHours(17);
            dataGridView1.ClearSelection();
            textBox1.Focus();
        }

        private void MostrarAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Datos de sucursal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void MostrarInformacion(string mensaje)
        {
            MessageBox.Show(mensaje, "Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
