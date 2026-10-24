namespace Proyecto_PA_Parcial_1.Formularios
{
    partial class Frm_Totems
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelEncabezado;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelSubtitulo;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.Panel panelLista;
        private System.Windows.Forms.Label labelFormulario;
        private System.Windows.Forms.Label labelLista;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelSucursal;
        private System.Windows.Forms.Label labelUbicacion;
        private System.Windows.Forms.Label labelFilas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaUbicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaFilas;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelEncabezado = new System.Windows.Forms.Panel();
            this.labelSubtitulo = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelLista = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnaCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaUbicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaFilas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelLista = new System.Windows.Forms.Label();
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelFilas = new System.Windows.Forms.Label();
            this.labelUbicacion = new System.Windows.Forms.Label();
            this.labelSucursal = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelFormulario = new System.Windows.Forms.Label();
            this.panelEncabezado.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.panelLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelFormulario.SuspendLayout();
            this.SuspendLayout();
            // panelEncabezado
            this.panelEncabezado.BackColor = System.Drawing.Color.FromArgb(32, 59, 92);
            this.panelEncabezado.Controls.Add(this.labelSubtitulo);
            this.panelEncabezado.Controls.Add(this.labelTitulo);
            this.panelEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEncabezado.Location = new System.Drawing.Point(0, 0);
            this.panelEncabezado.Name = "panelEncabezado";
            this.panelEncabezado.Padding = new System.Windows.Forms.Padding(28, 16, 28, 12);
            this.panelEncabezado.Size = new System.Drawing.Size(950, 108);
            this.panelEncabezado.TabIndex = 0;
            // labelSubtitulo
            this.labelSubtitulo.AutoSize = true;
            this.labelSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelSubtitulo.ForeColor = System.Drawing.Color.FromArgb(218, 229, 242);
            this.labelSubtitulo.Location = new System.Drawing.Point(31, 68);
            this.labelSubtitulo.Name = "labelSubtitulo";
            this.labelSubtitulo.Size = new System.Drawing.Size(524, 23);
            this.labelSubtitulo.TabIndex = 1;
            this.labelSubtitulo.Text = "Gestiona los dispositivos de autoservicio de TurnoSmarts";
            // labelTitulo
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(27, 14);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(397, 50);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Administración de Tótems";
            // panelContenido
            this.panelContenido.BackColor = System.Drawing.Color.FromArgb(238, 241, 245);
            this.panelContenido.Controls.Add(this.panelLista);
            this.panelContenido.Controls.Add(this.panelFormulario);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 108);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Padding = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.panelContenido.Size = new System.Drawing.Size(950, 542);
            this.panelContenido.TabIndex = 1;
            // panelLista
            this.panelLista.BackColor = System.Drawing.Color.White;
            this.panelLista.Controls.Add(this.dataGridView1);
            this.panelLista.Controls.Add(this.labelLista);
            this.panelLista.Location = new System.Drawing.Point(370, 18);
            this.panelLista.Name = "panelLista";
            this.panelLista.Padding = new System.Windows.Forms.Padding(16, 14, 16, 16);
            this.panelLista.Size = new System.Drawing.Size(560, 506);
            this.panelLista.TabIndex = 1;
            // dataGridView1
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeight = 38;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaCodigo,
            this.columnaSucursal,
            this.columnaUbicacion,
            this.columnaFilas});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(226, 230, 235);
            this.dataGridView1.Location = new System.Drawing.Point(16, 58);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 34;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(528, 432);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // columnaCodigo
            this.columnaCodigo.HeaderText = "Código";
            this.columnaCodigo.Name = "columnaCodigo";
            this.columnaCodigo.ReadOnly = true;
            // columnaSucursal
            this.columnaSucursal.HeaderText = "Sucursal";
            this.columnaSucursal.Name = "columnaSucursal";
            this.columnaSucursal.ReadOnly = true;
            // columnaUbicacion
            this.columnaUbicacion.HeaderText = "Ubicación";
            this.columnaUbicacion.Name = "columnaUbicacion";
            this.columnaUbicacion.ReadOnly = true;
            // columnaFilas
            this.columnaFilas.HeaderText = "Códigos de fila";
            this.columnaFilas.Name = "columnaFilas";
            this.columnaFilas.ReadOnly = true;
            // labelLista
            this.labelLista.AutoSize = true;
            this.labelLista.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.labelLista.ForeColor = System.Drawing.Color.FromArgb(32, 59, 92);
            this.labelLista.Location = new System.Drawing.Point(16, 16);
            this.labelLista.Name = "labelLista";
            this.labelLista.Size = new System.Drawing.Size(178, 30);
            this.labelLista.TabIndex = 0;
            this.labelLista.Text = "Tótems registrados";
            // panelFormulario
            this.panelFormulario.BackColor = System.Drawing.Color.White;
            this.panelFormulario.Controls.Add(this.button4);
            this.panelFormulario.Controls.Add(this.button3);
            this.panelFormulario.Controls.Add(this.button2);
            this.panelFormulario.Controls.Add(this.button1);
            this.panelFormulario.Controls.Add(this.textBox3);
            this.panelFormulario.Controls.Add(this.textBox2);
            this.panelFormulario.Controls.Add(this.comboBox1);
            this.panelFormulario.Controls.Add(this.textBox1);
            this.panelFormulario.Controls.Add(this.labelFilas);
            this.panelFormulario.Controls.Add(this.labelUbicacion);
            this.panelFormulario.Controls.Add(this.labelSucursal);
            this.panelFormulario.Controls.Add(this.labelCodigo);
            this.panelFormulario.Controls.Add(this.labelFormulario);
            this.panelFormulario.Location = new System.Drawing.Point(20, 18);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Padding = new System.Windows.Forms.Padding(20, 16, 20, 16);
            this.panelFormulario.Size = new System.Drawing.Size(330, 506);
            this.panelFormulario.TabIndex = 0;
            // labelFormulario
            this.labelFormulario.AutoSize = true;
            this.labelFormulario.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.labelFormulario.ForeColor = System.Drawing.Color.FromArgb(32, 59, 92);
            this.labelFormulario.Location = new System.Drawing.Point(20, 16);
            this.labelFormulario.Name = "labelFormulario";
            this.labelFormulario.Size = new System.Drawing.Size(164, 30);
            this.labelFormulario.TabIndex = 0;
            this.labelFormulario.Text = "Datos del tótem";
            // labelCodigo
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.labelCodigo.ForeColor = System.Drawing.Color.FromArgb(55, 64, 73);
            this.labelCodigo.Location = new System.Drawing.Point(20, 62);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(60, 21);
            this.labelCodigo.TabIndex = 1;
            this.labelCodigo.Text = "Código";
            // labelSucursal
            this.labelSucursal.AutoSize = true;
            this.labelSucursal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.labelSucursal.ForeColor = System.Drawing.Color.FromArgb(55, 64, 73);
            this.labelSucursal.Location = new System.Drawing.Point(20, 128);
            this.labelSucursal.Name = "labelSucursal";
            this.labelSucursal.Size = new System.Drawing.Size(75, 21);
            this.labelSucursal.TabIndex = 3;
            this.labelSucursal.Text = "Sucursal";
            // labelUbicacion
            this.labelUbicacion.AutoSize = true;
            this.labelUbicacion.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.labelUbicacion.ForeColor = System.Drawing.Color.FromArgb(55, 64, 73);
            this.labelUbicacion.Location = new System.Drawing.Point(20, 194);
            this.labelUbicacion.Name = "labelUbicacion";
            this.labelUbicacion.Size = new System.Drawing.Size(82, 21);
            this.labelUbicacion.TabIndex = 5;
            this.labelUbicacion.Text = "Ubicación";
            // labelFilas
            this.labelFilas.AutoSize = true;
            this.labelFilas.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.labelFilas.ForeColor = System.Drawing.Color.FromArgb(55, 64, 73);
            this.labelFilas.Location = new System.Drawing.Point(20, 260);
            this.labelFilas.Name = "labelFilas";
            this.labelFilas.Size = new System.Drawing.Size(169, 21);
            this.labelFilas.TabIndex = 7;
            this.labelFilas.Text = "Códigos de fila (opcional)";
            // textBox1
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox1.Location = new System.Drawing.Point(20, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 30);
            this.textBox1.TabIndex = 2;
            // comboBox1
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(20, 152);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(290, 31);
            this.comboBox1.TabIndex = 4;
            // textBox2
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox2.Location = new System.Drawing.Point(20, 218);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(290, 30);
            this.textBox2.TabIndex = 6;
            // textBox3
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox3.Location = new System.Drawing.Point(20, 284);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(290, 58);
            this.textBox3.TabIndex = 8;
            // button1
            this.button1.BackColor = System.Drawing.Color.FromArgb(31, 120, 85);
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(20, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // button2
            this.button2.BackColor = System.Drawing.Color.FromArgb(52, 88, 128);
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(170, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 42);
            this.button2.TabIndex = 10;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // button3
            this.button3.BackColor = System.Drawing.Color.FromArgb(194, 63, 63);
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(20, 424);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 42);
            this.button3.TabIndex = 11;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // button4
            this.button4.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(170, 424);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 42);
            this.button4.TabIndex = 12;
            this.button4.Text = "Limpiar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // Frm_Totems
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(238, 241, 245);
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelEncabezado);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(950, 650);
            this.Name = "Frm_Totems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de Tótems - TurnoSmarts";
            this.panelEncabezado.ResumeLayout(false);
            this.panelEncabezado.PerformLayout();
            this.panelContenido.ResumeLayout(false);
            this.panelLista.ResumeLayout(false);
            this.panelLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
