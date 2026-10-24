namespace Proyecto_PA_Parcial_1.Formularios
{
    partial class Frm_Citas
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelEncabezado;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelSubtitulo;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Panel panelNuevaCita;
        private System.Windows.Forms.Panel panelCitas;
        private System.Windows.Forms.Label labelNuevaCita;
        private System.Windows.Forms.Label labelCitas;
        private System.Windows.Forms.Label labelSucursal;
        private System.Windows.Forms.Label labelServicio;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Label labelCedula;
        private System.Windows.Forms.Label labelNombres;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaEstado;

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
            this.panelCitas = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelCitas = new System.Windows.Forms.Label();
            this.panelNuevaCita = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.labelNombres = new System.Windows.Forms.Label();
            this.labelCedula = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelServicio = new System.Windows.Forms.Label();
            this.labelSucursal = new System.Windows.Forms.Label();
            this.labelNuevaCita = new System.Windows.Forms.Label();
            this.panelEncabezado.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.panelCitas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelNuevaCita.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEncabezado
            // 
            this.panelEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(92)))));
            this.panelEncabezado.Controls.Add(this.labelSubtitulo);
            this.panelEncabezado.Controls.Add(this.labelTitulo);
            this.panelEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEncabezado.Location = new System.Drawing.Point(0, 0);
            this.panelEncabezado.Name = "panelEncabezado";
            this.panelEncabezado.Padding = new System.Windows.Forms.Padding(28, 16, 28, 12);
            this.panelEncabezado.Size = new System.Drawing.Size(1050, 108);
            this.panelEncabezado.TabIndex = 0;
            // 
            // labelSubtitulo
            // 
            this.labelSubtitulo.AutoSize = true;
            this.labelSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.labelSubtitulo.Location = new System.Drawing.Point(31, 68);
            this.labelSubtitulo.Name = "labelSubtitulo";
            this.labelSubtitulo.Size = new System.Drawing.Size(352, 23);
            this.labelSubtitulo.TabIndex = 1;
            this.labelSubtitulo.Text = "Programa y administra citas de atención";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(27, 14);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(298, 50);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Reservación de Citas";
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.panelContenido.Controls.Add(this.panelCitas);
            this.panelContenido.Controls.Add(this.panelNuevaCita);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 108);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Padding = new System.Windows.Forms.Padding(24, 22, 24, 22);
            this.panelContenido.Size = new System.Drawing.Size(1050, 572);
            this.panelContenido.TabIndex = 1;
            // 
            // panelCitas
            // 
            this.panelCitas.BackColor = System.Drawing.Color.White;
            this.panelCitas.Controls.Add(this.dataGridView1);
            this.panelCitas.Controls.Add(this.labelCitas);
            this.panelCitas.Location = new System.Drawing.Point(424, 22);
            this.panelCitas.Name = "panelCitas";
            this.panelCitas.Padding = new System.Windows.Forms.Padding(18, 14, 18, 18);
            this.panelCitas.Size = new System.Drawing.Size(602, 550);
            this.panelCitas.TabIndex = 1;
            // 
            // dataGridView1
            // 
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
            this.columnaId,
            this.columnaCodigo,
            this.columnaServicio,
            this.columnaSucursal,
            this.columnaFecha,
            this.columnaHora,
            this.columnaCliente,
            this.columnaEstado});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.dataGridView1.Location = new System.Drawing.Point(18, 58);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 34;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(566, 474);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // columnaId
            // 
            this.columnaId.DataPropertyName = "Id";
            this.columnaId.HeaderText = "Id";
            this.columnaId.Name = "columnaId";
            this.columnaId.ReadOnly = true;
            this.columnaId.Visible = false;
            // 
            // columnaCodigo
            // 
            this.columnaCodigo.DataPropertyName = "CodigoTicket";
            this.columnaCodigo.HeaderText = "Código";
            this.columnaCodigo.Name = "columnaCodigo";
            this.columnaCodigo.ReadOnly = true;
            // 
            // columnaServicio
            // 
            this.columnaServicio.DataPropertyName = "Servicio";
            this.columnaServicio.HeaderText = "Servicio";
            this.columnaServicio.Name = "columnaServicio";
            this.columnaServicio.ReadOnly = true;
            // 
            // columnaSucursal
            // 
            this.columnaSucursal.DataPropertyName = "Sucursal";
            this.columnaSucursal.HeaderText = "Sucursal";
            this.columnaSucursal.Name = "columnaSucursal";
            this.columnaSucursal.ReadOnly = true;
            // 
            // columnaFecha
            // 
            this.columnaFecha.DataPropertyName = "Fecha";
            this.columnaFecha.HeaderText = "Fecha";
            this.columnaFecha.Name = "columnaFecha";
            this.columnaFecha.ReadOnly = true;
            // 
            // columnaHora
            // 
            this.columnaHora.DataPropertyName = "Hora";
            this.columnaHora.HeaderText = "Hora";
            this.columnaHora.Name = "columnaHora";
            this.columnaHora.ReadOnly = true;
            // 
            // columnaCliente
            // 
            this.columnaCliente.DataPropertyName = "Cliente";
            this.columnaCliente.HeaderText = "Cliente";
            this.columnaCliente.Name = "columnaCliente";
            this.columnaCliente.ReadOnly = true;
            // 
            // columnaEstado
            // 
            this.columnaEstado.DataPropertyName = "Estado";
            this.columnaEstado.HeaderText = "Estado";
            this.columnaEstado.Name = "columnaEstado";
            this.columnaEstado.ReadOnly = true;
            // 
            // labelCitas
            // 
            this.labelCitas.AutoSize = true;
            this.labelCitas.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.labelCitas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(92)))));
            this.labelCitas.Location = new System.Drawing.Point(18, 16);
            this.labelCitas.Name = "labelCitas";
            this.labelCitas.Size = new System.Drawing.Size(179, 30);
            this.labelCitas.TabIndex = 0;
            this.labelCitas.Text = "Citas registradas";
            // 
            // panelNuevaCita
            // 
            this.panelNuevaCita.BackColor = System.Drawing.Color.White;
            this.panelNuevaCita.Controls.Add(this.button4);
            this.panelNuevaCita.Controls.Add(this.button3);
            this.panelNuevaCita.Controls.Add(this.button2);
            this.panelNuevaCita.Controls.Add(this.button1);
            this.panelNuevaCita.Controls.Add(this.textBox4);
            this.panelNuevaCita.Controls.Add(this.textBox3);
            this.panelNuevaCita.Controls.Add(this.textBox2);
            this.panelNuevaCita.Controls.Add(this.textBox1);
            this.panelNuevaCita.Controls.Add(this.dateTimePicker2);
            this.panelNuevaCita.Controls.Add(this.dateTimePicker1);
            this.panelNuevaCita.Controls.Add(this.comboBox2);
            this.panelNuevaCita.Controls.Add(this.comboBox1);
            this.panelNuevaCita.Controls.Add(this.labelTelefono);
            this.panelNuevaCita.Controls.Add(this.labelCorreo);
            this.panelNuevaCita.Controls.Add(this.labelNombres);
            this.panelNuevaCita.Controls.Add(this.labelCedula);
            this.panelNuevaCita.Controls.Add(this.labelHora);
            this.panelNuevaCita.Controls.Add(this.labelFecha);
            this.panelNuevaCita.Controls.Add(this.labelServicio);
            this.panelNuevaCita.Controls.Add(this.labelSucursal);
            this.panelNuevaCita.Controls.Add(this.labelNuevaCita);
            this.panelNuevaCita.Location = new System.Drawing.Point(24, 22);
            this.panelNuevaCita.Name = "panelNuevaCita";
            this.panelNuevaCita.Padding = new System.Windows.Forms.Padding(18, 14, 18, 18);
            this.panelNuevaCita.Size = new System.Drawing.Size(376, 550);
            this.panelNuevaCita.TabIndex = 0;
            // 
            // labelNuevaCita
            // 
            this.labelNuevaCita.AutoSize = true;
            this.labelNuevaCita.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.labelNuevaCita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(92)))));
            this.labelNuevaCita.Location = new System.Drawing.Point(18, 16);
            this.labelNuevaCita.Name = "labelNuevaCita";
            this.labelNuevaCita.Size = new System.Drawing.Size(128, 30);
            this.labelNuevaCita.TabIndex = 0;
            this.labelNuevaCita.Text = "Nueva cita";
            // 
            // labelSucursal
            // 
            this.labelSucursal.AutoSize = true;
            this.labelSucursal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelSucursal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(73)))));
            this.labelSucursal.Location = new System.Drawing.Point(18, 62);
            this.labelSucursal.Name = "labelSucursal";
            this.labelSucursal.Size = new System.Drawing.Size(66, 20);
            this.labelSucursal.TabIndex = 1;
            this.labelSucursal.Text = "Sucursal";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(340, 28);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelServicio
            // 
            this.labelServicio.AutoSize = true;
            this.labelServicio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(73)))));
            this.labelServicio.Location = new System.Drawing.Point(18, 120);
            this.labelServicio.Name = "labelServicio";
            this.labelServicio.Size = new System.Drawing.Size(141, 20);
            this.labelServicio.TabIndex = 3;
            this.labelServicio.Text = "Servicio o fila";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(18, 142);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(340, 28);
            this.comboBox2.TabIndex = 4;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(73)))));
            this.labelFecha.Location = new System.Drawing.Point(18, 178);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(52, 20);
            this.labelFecha.TabIndex = 5;
            this.labelFecha.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 200);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(162, 27);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(73)))));
            this.labelHora.Location = new System.Drawing.Point(196, 178);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(43, 20);
            this.labelHora.TabIndex = 7;
            this.labelHora.Text = "Hora";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(196, 200);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(162, 27);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // labelCedula
            // 
            this.labelCedula.AutoSize = true;
            this.labelCedula.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelCedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(73)))));
            this.labelCedula.Location = new System.Drawing.Point(18, 236);
            this.labelCedula.Name = "labelCedula";
            this.labelCedula.Size = new System.Drawing.Size(59, 20);
            this.labelCedula.TabIndex = 9;
            this.labelCedula.Text = "Cédula";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox1.Location = new System.Drawing.Point(18, 258);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(340, 27);
            this.textBox1.TabIndex = 10;
            // 
            // labelNombres
            // 
            this.labelNombres.AutoSize = true;
            this.labelNombres.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelNombres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(73)))));
            this.labelNombres.Location = new System.Drawing.Point(18, 294);
            this.labelNombres.Name = "labelNombres";
            this.labelNombres.Size = new System.Drawing.Size(70, 20);
            this.labelNombres.TabIndex = 11;
            this.labelNombres.Text = "Nombres";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox2.Location = new System.Drawing.Point(18, 316);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(340, 27);
            this.textBox2.TabIndex = 12;
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(73)))));
            this.labelCorreo.Location = new System.Drawing.Point(18, 352);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(58, 20);
            this.labelCorreo.TabIndex = 13;
            this.labelCorreo.Text = "Correo";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox3.Location = new System.Drawing.Point(18, 374);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(340, 27);
            this.textBox3.TabIndex = 14;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(73)))));
            this.labelTelefono.Location = new System.Drawing.Point(18, 394);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(72, 20);
            this.labelTelefono.TabIndex = 15;
            this.labelTelefono.Text = "Teléfono";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox4.Location = new System.Drawing.Point(18, 416);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(340, 27);
            this.textBox4.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(120)))), ((int)(((byte)(85)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(18, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 36);
            this.button1.TabIndex = 17;
            this.button1.Text = "Reservar cita";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(105)))), ((int)(((byte)(170)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(196, 452);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 36);
            this.button2.TabIndex = 18;
            this.button2.Text = "Consultar disponibilidad";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(18, 496);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 36);
            this.button3.TabIndex = 19;
            this.button3.Text = "Anular cita";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(196, 496);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 36);
            this.button4.TabIndex = 20;
            this.button4.Text = "Limpiar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Frm_Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 680);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelEncabezado);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1050, 680);
            this.Name = "Frm_Citas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservación de Citas - TurnoSmarts";
            this.panelEncabezado.ResumeLayout(false);
            this.panelEncabezado.PerformLayout();
            this.panelContenido.ResumeLayout(false);
            this.panelCitas.ResumeLayout(false);
            this.panelCitas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelNuevaCita.ResumeLayout(false);
            this.panelNuevaCita.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
