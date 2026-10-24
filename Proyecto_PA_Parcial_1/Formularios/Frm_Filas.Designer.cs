namespace Proyecto_PA_Parcial_1.Formularios
{
    partial class Frm_Filas
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelEncabezado;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelSubtitulo;
        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.Panel panelLista;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelSucursal;
        private System.Windows.Forms.Label labelServicio;
        private System.Windows.Forms.Label labelTiempo;
        private System.Windows.Forms.Label labelCosto;
        private System.Windows.Forms.Label labelVentanillas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label labelLista;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaTiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaVentanillas;

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
            this.columnaServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaTiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaVentanillas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelLista = new System.Windows.Forms.Label();
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelVentanillas = new System.Windows.Forms.Label();
            this.labelCosto = new System.Windows.Forms.Label();
            this.labelTiempo = new System.Windows.Forms.Label();
            this.labelServicio = new System.Windows.Forms.Label();
            this.labelSucursal = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.panelEncabezado.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.panelLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEncabezado
            // 
            this.panelEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(55)))), ((int)(((byte)(86)))));
            this.panelEncabezado.Controls.Add(this.labelSubtitulo);
            this.panelEncabezado.Controls.Add(this.labelTitulo);
            this.panelEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEncabezado.Location = new System.Drawing.Point(0, 0);
            this.panelEncabezado.Name = "panelEncabezado";
            this.panelEncabezado.Padding = new System.Windows.Forms.Padding(28, 16, 28, 12);
            this.panelEncabezado.Size = new System.Drawing.Size(1120, 108);
            this.panelEncabezado.TabIndex = 0;
            // 
            // labelSubtitulo
            // 
            this.labelSubtitulo.AutoSize = true;
            this.labelSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.labelSubtitulo.Location = new System.Drawing.Point(31, 68);
            this.labelSubtitulo.Name = "labelSubtitulo";
            this.labelSubtitulo.Size = new System.Drawing.Size(430, 23);
            this.labelSubtitulo.TabIndex = 1;
            this.labelSubtitulo.Text = "Registra y administra las filas de atención de TurnoSmarts.";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(27, 14);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(119, 50);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Filas";
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.panelContenido.Controls.Add(this.panelLista);
            this.panelContenido.Controls.Add(this.panelFormulario);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 108);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Padding = new System.Windows.Forms.Padding(24, 22, 24, 22);
            this.panelContenido.Size = new System.Drawing.Size(1120, 632);
            this.panelContenido.TabIndex = 1;
            // 
            // panelLista
            // 
            this.panelLista.BackColor = System.Drawing.Color.White;
            this.panelLista.Controls.Add(this.dataGridView1);
            this.panelLista.Controls.Add(this.labelLista);
            this.panelLista.Location = new System.Drawing.Point(404, 22);
            this.panelLista.Name = "panelLista";
            this.panelLista.Padding = new System.Windows.Forms.Padding(18, 14, 18, 18);
            this.panelLista.Size = new System.Drawing.Size(692, 588);
            this.panelLista.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeight = 38;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaCodigo,
            this.columnaSucursal,
            this.columnaServicio,
            this.columnaTiempo,
            this.columnaCosto,
            this.columnaVentanillas});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.dataGridView1.Location = new System.Drawing.Point(18, 58);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 34;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(656, 512);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // columnaCodigo
            // 
            this.columnaCodigo.HeaderText = "Código";
            this.columnaCodigo.Name = "columnaCodigo";
            this.columnaCodigo.ReadOnly = true;
            this.columnaCodigo.Width = 78;
            // 
            // columnaSucursal
            // 
            this.columnaSucursal.HeaderText = "Sucursal";
            this.columnaSucursal.Name = "columnaSucursal";
            this.columnaSucursal.ReadOnly = true;
            this.columnaSucursal.Width = 82;
            // 
            // columnaServicio
            // 
            this.columnaServicio.HeaderText = "Servicio";
            this.columnaServicio.Name = "columnaServicio";
            this.columnaServicio.ReadOnly = true;
            this.columnaServicio.Width = 172;
            // 
            // columnaTiempo
            // 
            this.columnaTiempo.HeaderText = "Tiempo";
            this.columnaTiempo.Name = "columnaTiempo";
            this.columnaTiempo.ReadOnly = true;
            this.columnaTiempo.Width = 85;
            // 
            // columnaCosto
            // 
            this.columnaCosto.HeaderText = "Costo";
            this.columnaCosto.Name = "columnaCosto";
            this.columnaCosto.ReadOnly = true;
            this.columnaCosto.Width = 95;
            // 
            // columnaVentanillas
            // 
            this.columnaVentanillas.HeaderText = "Ventanillas";
            this.columnaVentanillas.Name = "columnaVentanillas";
            this.columnaVentanillas.ReadOnly = true;
            this.columnaVentanillas.Width = 110;
            // 
            // labelLista
            // 
            this.labelLista.AutoSize = true;
            this.labelLista.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.labelLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(55)))), ((int)(((byte)(86)))));
            this.labelLista.Location = new System.Drawing.Point(18, 16);
            this.labelLista.Name = "labelLista";
            this.labelLista.Size = new System.Drawing.Size(139, 30);
            this.labelLista.TabIndex = 0;
            this.labelLista.Text = "Lista de filas";
            // 
            // panelFormulario
            // 
            this.panelFormulario.BackColor = System.Drawing.Color.White;
            this.panelFormulario.Controls.Add(this.button4);
            this.panelFormulario.Controls.Add(this.button3);
            this.panelFormulario.Controls.Add(this.button2);
            this.panelFormulario.Controls.Add(this.button1);
            this.panelFormulario.Controls.Add(this.numericUpDown3);
            this.panelFormulario.Controls.Add(this.numericUpDown2);
            this.panelFormulario.Controls.Add(this.numericUpDown1);
            this.panelFormulario.Controls.Add(this.textBox2);
            this.panelFormulario.Controls.Add(this.comboBox1);
            this.panelFormulario.Controls.Add(this.textBox1);
            this.panelFormulario.Controls.Add(this.labelVentanillas);
            this.panelFormulario.Controls.Add(this.labelCosto);
            this.panelFormulario.Controls.Add(this.labelTiempo);
            this.panelFormulario.Controls.Add(this.labelServicio);
            this.panelFormulario.Controls.Add(this.labelSucursal);
            this.panelFormulario.Controls.Add(this.labelCodigo);
            this.panelFormulario.Location = new System.Drawing.Point(24, 22);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Padding = new System.Windows.Forms.Padding(22, 18, 22, 18);
            this.panelFormulario.Size = new System.Drawing.Size(360, 588);
            this.panelFormulario.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(190, 496);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 42);
            this.button4.TabIndex = 15;
            this.button4.Text = "Limpiar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(25, 496);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 42);
            this.button3.TabIndex = 14;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(88)))), ((int)(((byte)(128)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(190, 442);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 42);
            this.button2.TabIndex = 13;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(120)))), ((int)(((byte)(85)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(25, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 42);
            this.button1.TabIndex = 12;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numericUpDown3.Location = new System.Drawing.Point(25, 387);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(310, 30);
            this.numericUpDown3.TabIndex = 11;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numericUpDown2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(310, 30);
            this.numericUpDown2.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(310, 30);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox2.Location = new System.Drawing.Point(25, 205);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(310, 30);
            this.textBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 145);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(310, 31);
            this.comboBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox1.Location = new System.Drawing.Point(25, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(310, 30);
            this.textBox1.TabIndex = 1;
            // 
            // labelVentanillas
            // 
            this.labelVentanillas.AutoSize = true;
            this.labelVentanillas.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.labelVentanillas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(73)))));
            this.labelVentanillas.Location = new System.Drawing.Point(22, 361);
            this.labelVentanillas.Name = "labelVentanillas";
            this.labelVentanillas.Size = new System.Drawing.Size(98, 21);
            this.labelVentanillas.TabIndex = 10;
            this.labelVentanillas.Text = "Ventanillas";
            // 
            // labelCosto
            // 
            this.labelCosto.AutoSize = true;
            this.labelCosto.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.labelCosto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(73)))));
            this.labelCosto.Location = new System.Drawing.Point(22, 301);
            this.labelCosto.Name = "labelCosto";
            this.labelCosto.Size = new System.Drawing.Size(53, 21);
            this.labelCosto.TabIndex = 8;
            this.labelCosto.Text = "Costo";
            // 
            // labelTiempo
            // 
            this.labelTiempo.AutoSize = true;
            this.labelTiempo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.labelTiempo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(73)))));
            this.labelTiempo.Location = new System.Drawing.Point(22, 241);
            this.labelTiempo.Name = "labelTiempo";
            this.labelTiempo.Size = new System.Drawing.Size(173, 21);
            this.labelTiempo.TabIndex = 6;
            this.labelTiempo.Text = "Tiempo estimado (min)";
            // 
            // labelServicio
            // 
            this.labelServicio.AutoSize = true;
            this.labelServicio.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.labelServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(73)))));
            this.labelServicio.Location = new System.Drawing.Point(22, 181);
            this.labelServicio.Name = "labelServicio";
            this.labelServicio.Size = new System.Drawing.Size(76, 21);
            this.labelServicio.TabIndex = 4;
            this.labelServicio.Text = "Servicio";
            // 
            // labelSucursal
            // 
            this.labelSucursal.AutoSize = true;
            this.labelSucursal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.labelSucursal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(73)))));
            this.labelSucursal.Location = new System.Drawing.Point(22, 121);
            this.labelSucursal.Name = "labelSucursal";
            this.labelSucursal.Size = new System.Drawing.Size(73, 21);
            this.labelSucursal.TabIndex = 2;
            this.labelSucursal.Text = "Sucursal";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.labelCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(73)))));
            this.labelCodigo.Location = new System.Drawing.Point(22, 61);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(60, 21);
            this.labelCodigo.TabIndex = 0;
            this.labelCodigo.Text = "Código";
            // 
            // Frm_Filas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1120, 740);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelEncabezado);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "Frm_Filas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filas - TurnoSmarts";
            this.panelEncabezado.ResumeLayout(false);
            this.panelEncabezado.PerformLayout();
            this.panelContenido.ResumeLayout(false);
            this.panelLista.ResumeLayout(false);
            this.panelLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
