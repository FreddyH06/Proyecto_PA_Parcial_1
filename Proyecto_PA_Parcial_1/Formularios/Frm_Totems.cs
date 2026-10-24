using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Proyecto_PA_Parcial_1.Controlador;
using Proyecto_PA_Parcial_1.Entidades;

namespace Proyecto_PA_Parcial_1.Formularios
{
    public partial class Frm_Totems : Form
    {
        private readonly TListTotems controlador = new TListTotems();
        private Totem totemSeleccionado;

        public Frm_Totems()
        {
            InitializeComponent();
            CargarSucursales();
            Listar();
            LimpiarCampos();
        }

        private void CargarSucursales()
        {
            comboBox1.Items.Clear();
            foreach (Sucursal sucursal in TListSucursales.Lista.OrderBy(item => item.Codigo))
            {
                comboBox1.Items.Add(sucursal.Codigo);
            }
        }

        private void Listar()
        {
            dataGridView1.Rows.Clear();
            List<Sucursal> sucursales = TListSucursales.Lista.ToList();
            var totems = controlador.Listar()
                .Join(
                    sucursales,
                    totem => totem.CodigoSucursal,
                    sucursal => sucursal.Codigo,
                    (totem, sucursal) => new
                    {
                        Totem = totem,
                        Sucursal = sucursal.Codigo
                    })
                .ToList();

            foreach (var registro in totems)
            {
                string filas = registro.Totem.CodigosFila == null
                    ? string.Empty
                    : string.Join(", ", registro.Totem.CodigosFila);
                dataGridView1.Rows.Add(
                    registro.Totem.Codigo,
                    registro.Sucursal,
                    registro.Totem.Ubicacion,
                    filas);
            }
        }

        private bool ValidarCampos(bool esNuevo)
        {
            bool valido = true;
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MostrarAdvertencia("Ingrese el código del tótem.");
                textBox1.Focus();
                valido = false;
            }
            else if (esNuevo && controlador.Buscar(textBox1.Text.Trim()) != null)
            {
                MostrarAdvertencia("Ya existe un tótem con ese código.");
                textBox1.Focus();
                valido = false;
            }

            if (comboBox1.SelectedIndex < 0 || TListSucursales.Lista.All(item => !string.Equals(item.Codigo, Convert.ToString(comboBox1.SelectedItem), StringComparison.OrdinalIgnoreCase)))
            {
                MostrarAdvertencia("Seleccione una sucursal válida.");
                comboBox1.Focus();
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MostrarAdvertencia("Ingrese la ubicación del tótem.");
                textBox2.Focus();
                valido = false;
            }
            if (!CodigosFilaValidos())
            {
                MostrarAdvertencia("Los códigos de fila deben estar separados por comas, sin valores repetidos ni espacios vacíos.");
                textBox3.Focus();
                valido = false;
            }
            return valido;
        }

        private bool CodigosFilaValidos()
        {
            bool valido = true;
            string contenido = textBox3.Text.Trim();
            if (!string.IsNullOrWhiteSpace(contenido))
            {
                string[] codigos = contenido.Split(',');
                List<string> valores = codigos.Select(item => item.Trim()).ToList();
                valido = valores.All(item => !string.IsNullOrWhiteSpace(item))
                    && valores.Distinct(StringComparer.OrdinalIgnoreCase).Count() == valores.Count;
            }
            return valido;
        }

        private Totem ObtenerTotemDesdeCampos()
        {
            List<string> codigosFila = textBox3.Text
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(item => item.Trim())
                .Where(item => !string.IsNullOrWhiteSpace(item))
                .ToList();
            return new Totem(
                textBox1.Text.Trim(),
                Convert.ToString(comboBox1.SelectedItem),
                textBox2.Text.Trim(),
                codigosFila);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool valido = ValidarCampos(true);
            if (valido)
            {
                Totem totem = ObtenerTotemDesdeCampos();
                bool agregado = controlador.Agregar(totem);
                if (agregado)
                {
                    Listar();
                    LimpiarCampos();
                    MostrarInformacion("El tótem se agregó correctamente.");
                }
                else
                {
                    MostrarAdvertencia("No se pudo agregar el tótem. Verifique la sucursal y los códigos de fila.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool valido = ValidarCampos(false);
            if (totemSeleccionado == null)
            {
                MostrarAdvertencia("Seleccione un tótem de la lista para modificarlo.");
                valido = false;
            }
            if (valido)
            {
                Totem totem = ObtenerTotemDesdeCampos();
                if (!string.Equals(totem.Codigo, totemSeleccionado.Codigo, StringComparison.OrdinalIgnoreCase))
                {
                    MostrarAdvertencia("El código del tótem seleccionado no puede modificarse.");
                    textBox1.Text = totemSeleccionado.Codigo;
                }
                else if (controlador.Modificar(totem))
                {
                    Listar();
                    LimpiarCampos();
                    MostrarInformacion("El tótem se modificó correctamente.");
                }
                else
                {
                    MostrarAdvertencia("No se pudo modificar el tótem. Verifique la sucursal y los códigos de fila.");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool haySeleccion = totemSeleccionado != null || !string.IsNullOrWhiteSpace(textBox1.Text);
            if (!haySeleccion)
            {
                MostrarAdvertencia("Seleccione un tótem para eliminarlo.");
            }
            else
            {
                string codigo = totemSeleccionado == null ? textBox1.Text.Trim() : totemSeleccionado.Codigo;
                DialogResult confirmacion = MessageBox.Show(
                    "¿Está seguro de eliminar el tótem con código " + codigo + "?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    if (controlador.Eliminar(codigo))
                    {
                        Listar();
                        LimpiarCampos();
                        MostrarInformacion("El tótem se eliminó correctamente.");
                    }
                    else
                    {
                        MostrarAdvertencia("No se pudo eliminar el tótem. Verifique que exista.");
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
                totemSeleccionado = controlador.Buscar(codigo);
                if (totemSeleccionado != null)
                {
                    textBox1.Text = totemSeleccionado.Codigo;
                    comboBox1.SelectedItem = totemSeleccionado.CodigoSucursal;
                    textBox2.Text = totemSeleccionado.Ubicacion;
                    textBox3.Text = totemSeleccionado.CodigosFila == null
                        ? string.Empty
                        : string.Join(", ", totemSeleccionado.CodigosFila);
                }
            }
        }

        private void LimpiarCampos()
        {
            totemSeleccionado = null;
            textBox1.Clear();
            comboBox1.SelectedIndex = -1;
            textBox2.Clear();
            textBox3.Clear();
            dataGridView1.ClearSelection();
            textBox1.Focus();
        }

        private void MostrarAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Datos del tótem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void MostrarInformacion(string mensaje)
        {
            MessageBox.Show(mensaje, "Tótems", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
