using System;
using System.Linq;
using System.Windows.Forms;
using Proyecto_PA_Parcial_1.Controlador;
using Proyecto_PA_Parcial_1.Entidades;

namespace Proyecto_PA_Parcial_1.Formularios
{
    public partial class Frm_Filas : Form
    {
        private readonly TListFilas controlador = new TListFilas();
        private readonly TListSucursales controladorSucursales = new TListSucursales();
        private Fila filaSeleccionada;

        public Frm_Filas()
        {
            InitializeComponent();
            CargarSucursales();
            CargarFilas();
            LimpiarCampos();
        }

        private void CargarSucursales()
        {
            comboBox1.DataSource = null;
            comboBox1.DisplayMember = "Codigo";
            comboBox1.ValueMember = "Codigo";
            comboBox1.DataSource = controladorSucursales.Listar().OrderBy(item => item.Codigo).ToList();
            comboBox1.SelectedIndex = -1;
        }

        private void CargarFilas()
        {
            dataGridView1.Rows.Clear();
            var filas = controlador.Listar().OrderBy(item => item.Codigo).ToList();
            foreach (Fila fila in filas)
            {
                dataGridView1.Rows.Add(
                    fila.Codigo,
                    fila.CodigoSucursal,
                    fila.Descripcion,
                    fila.TiempoEstimadoMinutos,
                    fila.CostoEstimado.ToString("0.00"),
                    fila.CantidadVentanillas);
            }
        }

        private bool ValidarCampos()
        {
            bool valido = true;
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MostrarAdvertencia("Ingrese el código de la fila.");
                textBox1.Focus();
                valido = false;
            }
            if (valido && comboBox1.SelectedIndex < 0)
            {
                MostrarAdvertencia("Seleccione una sucursal.");
                comboBox1.Focus();
                valido = false;
            }
            if (valido && string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MostrarAdvertencia("Ingrese el servicio de la fila.");
                textBox2.Focus();
                valido = false;
            }
            if (valido && numericUpDown1.Value <= 0)
            {
                MostrarAdvertencia("El tiempo estimado debe ser mayor que cero.");
                numericUpDown1.Focus();
                valido = false;
            }
            if (valido && numericUpDown2.Value < 0)
            {
                MostrarAdvertencia("El costo estimado no puede ser negativo.");
                numericUpDown2.Focus();
                valido = false;
            }
            if (valido && numericUpDown3.Value <= 0)
            {
                MostrarAdvertencia("La cantidad de ventanillas debe ser mayor que cero.");
                numericUpDown3.Focus();
                valido = false;
            }
            return valido;
        }

        private Fila ObtenerFilaDesdeCampos()
        {
            string codigoSucursal = comboBox1.SelectedValue == null ? string.Empty : comboBox1.SelectedValue.ToString();
            return new Fila(
                textBox1.Text.Trim(),
                codigoSucursal,
                textBox2.Text.Trim(),
                decimal.ToInt32(numericUpDown1.Value),
                numericUpDown2.Value,
                decimal.ToInt32(numericUpDown3.Value));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool procesar = ValidarCampos();
            if (procesar)
            {
                Fila fila = ObtenerFilaDesdeCampos();
                procesar = controlador.Agregar(fila);
                if (procesar)
                {
                    CargarFilas();
                    LimpiarCampos();
                    MostrarInformacion("La fila se agregó correctamente.");
                }
                else
                {
                    MostrarAdvertencia("Ya existe una fila con ese código o los datos no son válidos.");
                    textBox1.Focus();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool procesar = ValidarCampos();
            if (procesar && filaSeleccionada == null)
            {
                MostrarAdvertencia("Seleccione una fila de la lista para modificarla.");
                procesar = false;
            }
            if (procesar)
            {
                Fila fila = ObtenerFilaDesdeCampos();
                if (!string.Equals(fila.Codigo, filaSeleccionada.Codigo, StringComparison.OrdinalIgnoreCase))
                {
                    MostrarAdvertencia("El código de la fila seleccionada no puede modificarse.");
                    textBox1.Text = filaSeleccionada.Codigo;
                    textBox1.Focus();
                    procesar = false;
                }
                if (procesar)
                {
                    procesar = controlador.Modificar(fila);
                    if (procesar)
                    {
                        CargarFilas();
                        LimpiarCampos();
                        MostrarInformacion("La fila se modificó correctamente.");
                    }
                    else
                    {
                        MostrarAdvertencia("No se pudo modificar la fila porque los datos no son válidos.");
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool procesar = filaSeleccionada != null || !string.IsNullOrWhiteSpace(textBox1.Text);
            if (!procesar)
            {
                MostrarAdvertencia("Seleccione una fila para eliminarla.");
            }
            if (procesar)
            {
                string codigo = filaSeleccionada == null ? textBox1.Text.Trim() : filaSeleccionada.Codigo;
                DialogResult confirmacion = MessageBox.Show(
                    "¿Está seguro de eliminar la fila con código " + codigo + "?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                procesar = confirmacion == DialogResult.Yes;
                if (procesar)
                {
                    procesar = controlador.Eliminar(codigo);
                    if (procesar)
                    {
                        CargarFilas();
                        LimpiarCampos();
                        MostrarInformacion("La fila se eliminó correctamente.");
                    }
                    else
                    {
                        MostrarAdvertencia("No se pudo eliminar la fila. Verifique que exista y que no tenga tickets o tótems asociados.");
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool filaValida = e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count;
            if (filaValida)
            {
                string codigo = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                filaSeleccionada = controlador.Buscar(codigo);
                if (filaSeleccionada != null)
                {
                    textBox1.Text = filaSeleccionada.Codigo;
                    comboBox1.SelectedValue = filaSeleccionada.CodigoSucursal;
                    textBox2.Text = filaSeleccionada.Descripcion;
                    numericUpDown1.Value = filaSeleccionada.TiempoEstimadoMinutos;
                    numericUpDown2.Value = filaSeleccionada.CostoEstimado;
                    numericUpDown3.Value = filaSeleccionada.CantidadVentanillas;
                }
            }
        }

        private void LimpiarCampos()
        {
            filaSeleccionada = null;
            textBox1.Clear();
            comboBox1.SelectedIndex = -1;
            textBox2.Clear();
            numericUpDown1.Value = 1;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 1;
            dataGridView1.ClearSelection();
            textBox1.Focus();
        }

        private void MostrarAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Datos de fila", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void MostrarInformacion(string mensaje)
        {
            MessageBox.Show(mensaje, "Filas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
