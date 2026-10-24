namespace Proyecto_PA_Parcial_1.Formularios
{
    partial class Frm_Recordatorios
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
        private System.Windows.Forms.Label labelTicket;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label labelDestinatario;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelMensaje;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDestinatario;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaResultado;
        private System.Windows.Forms.Label labelId;

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
            this.panelEncabezado = new System.Windows.Forms.Panel();
            this.labelSubtitulo = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelLista = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaDestinatario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaResultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelLista = new System.Windows.Forms.Label();
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelMensaje = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelFecha = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelDestinatario = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labelTipo = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelTicket = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelId = new System.Windows.Forms.Label();
            this.labelFormulario = new System.Windows.Forms.Label();
            this.panelEncabezado.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.panelLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.panelEncabezado.Size = new System.Drawing.Size(1165, 108);
            this.panelEncabezado.TabIndex = 0;
            // 
            // labelSubtitulo
            // 
            this.labelSubtitulo.AutoSize = true;
            this.labelSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.labelSubtitulo.Location = new System.Drawing.Point(31, 68);
            this.labelSubtitulo.Name = "labelSubtitulo";
            this.labelSubtitulo.Size = new System.Drawing.Size(538, 23);
            this.labelSubtitulo.TabIndex = 1;
            this.labelSubtitulo.Text = "Administra las notificaciones y recordatorios de citas de TurnoSmarts.";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(27, 14);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(461, 50);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Gestión de Recordatorios";
            // 
            // panelContenido
            // 
            this.panelContenido.AutoScroll = true;
            this.panelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.panelContenido.Controls.Add(this.panelLista);
            this.panelContenido.Controls.Add(this.panelFormulario);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 108);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Padding = new System.Windows.Forms.Padding(24, 22, 24, 22);
            this.panelContenido.Size = new System.Drawing.Size(1165, 684);
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
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeight = 38;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaId,
            this.columnaTicket,
            this.columnaDestinatario,
            this.columnaTipo,
            this.columnaFecha,
            this.columnaEstado,
            this.columnaResultado});
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
            // columnaId
            // 
            this.columnaId.HeaderText = "Identificador";
            this.columnaId.MinimumWidth = 6;
            this.columnaId.Name = "columnaId";
            this.columnaId.ReadOnly = true;
            // 
            // columnaTicket
            // 
            this.columnaTicket.HeaderText = "Cita o ticket";
            this.columnaTicket.MinimumWidth = 6;
            this.columnaTicket.Name = "columnaTicket";
            this.columnaTicket.ReadOnly = true;
            // 
            // columnaDestinatario
            // 
            this.columnaDestinatario.HeaderText = "Destinatario";
            this.columnaDestinatario.MinimumWidth = 6;
            this.columnaDestinatario.Name = "columnaDestinatario";
            this.columnaDestinatario.ReadOnly = true;
            // 
            // columnaTipo
            // 
            this.columnaTipo.HeaderText = "Medio";
            this.columnaTipo.MinimumWidth = 6;
            this.columnaTipo.Name = "columnaTipo";
            this.columnaTipo.ReadOnly = true;
            // 
            // columnaFecha
            // 
            this.columnaFecha.HeaderText = "Fecha programada";
            this.columnaFecha.MinimumWidth = 6;
            this.columnaFecha.Name = "columnaFecha";
            this.columnaFecha.ReadOnly = true;
            // 
            // columnaEstado
            // 
            this.columnaEstado.HeaderText = "Estado";
            this.columnaEstado.MinimumWidth = 6;
            this.columnaEstado.Name = "columnaEstado";
            this.columnaEstado.ReadOnly = true;
            // 
            // columnaResultado
            // 
            this.columnaResultado.HeaderText = "Resultado";
            this.columnaResultado.MinimumWidth = 6;
            this.columnaResultado.Name = "columnaResultado";
            this.columnaResultado.ReadOnly = true;
            // 
            // labelLista
            // 
            this.labelLista.AutoSize = true;
            this.labelLista.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.labelLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(92)))));
            this.labelLista.Location = new System.Drawing.Point(18, 16);
            this.labelLista.Name = "labelLista";
            this.labelLista.Size = new System.Drawing.Size(281, 30);
            this.labelLista.TabIndex = 0;
            this.labelLista.Text = "Recordatorios registrados";
            // 
            // panelFormulario
            // 
            this.panelFormulario.BackColor = System.Drawing.Color.White;
            this.panelFormulario.Controls.Add(this.button6);
            this.panelFormulario.Controls.Add(this.button5);
            this.panelFormulario.Controls.Add(this.button4);
            this.panelFormulario.Controls.Add(this.button3);
            this.panelFormulario.Controls.Add(this.button2);
            this.panelFormulario.Controls.Add(this.button1);
            this.panelFormulario.Controls.Add(this.textBox2);
            this.panelFormulario.Controls.Add(this.labelResultado);
            this.panelFormulario.Controls.Add(this.checkBox1);
            this.panelFormulario.Controls.Add(this.richTextBox1);
            this.panelFormulario.Controls.Add(this.labelMensaje);
            this.panelFormulario.Controls.Add(this.dateTimePicker1);
            this.panelFormulario.Controls.Add(this.labelFecha);
            this.panelFormulario.Controls.Add(this.textBox1);
            this.panelFormulario.Controls.Add(this.labelDestinatario);
            this.panelFormulario.Controls.Add(this.comboBox2);
            this.panelFormulario.Controls.Add(this.labelTipo);
            this.panelFormulario.Controls.Add(this.comboBox1);
            this.panelFormulario.Controls.Add(this.labelTicket);
            this.panelFormulario.Controls.Add(this.numericUpDown1);
            this.panelFormulario.Controls.Add(this.labelId);
            this.panelFormulario.Controls.Add(this.labelFormulario);
            this.panelFormulario.Location = new System.Drawing.Point(24, 22);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Padding = new System.Windows.Forms.Padding(22, 18, 22, 18);
            this.panelFormulario.Size = new System.Drawing.Size(360, 588);
            this.panelFormulario.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(92)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(190, 535);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(145, 36);
            this.button6.TabIndex = 21;
            this.button6.Text = "Actualizar listado";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(92)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(25, 535);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(145, 36);
            this.button5.TabIndex = 20;
            this.button5.Text = "Enviar recordatorio";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(190, 489);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 36);
            this.button4.TabIndex = 19;
            this.button4.Text = "Limpiar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(25, 489);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 36);
            this.button3.TabIndex = 18;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(88)))), ((int)(((byte)(128)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(190, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 36);
            this.button2.TabIndex = 17;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(120)))), ((int)(((byte)(85)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(25, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "Agregar recordatorio";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox2.Location = new System.Drawing.Point(25, 397);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(310, 27);
            this.textBox2.TabIndex = 15;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(73)))));
            this.labelResultado.Location = new System.Drawing.Point(22, 374);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(79, 20);
            this.labelResultado.TabIndex = 14;
            this.labelResultado.Text = "Resultado";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.checkBox1.Location = new System.Drawing.Point(190, 348);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 24);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Enviado";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.richTextBox1.Location = new System.Drawing.Point(25, 306);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(310, 58);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // labelMensaje
            // 
            this.labelMensaje.AutoSize = true;
            this.labelMensaje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(73)))));
            this.labelMensaje.Location = new System.Drawing.Point(22, 283);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(67, 20);
            this.labelMensaje.TabIndex = 11;
            this.labelMensaje.Text = "Mensaje";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(25, 247);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(310, 27);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(73)))));
            this.labelFecha.Location = new System.Drawing.Point(22, 224);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(139, 20);
            this.labelFecha.TabIndex = 9;
            this.labelFecha.Text = "Fecha programada";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox1.Location = new System.Drawing.Point(25, 193);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(310, 27);
            this.textBox1.TabIndex = 8;
            // 
            // labelDestinatario
            // 
            this.labelDestinatario.AutoSize = true;
            this.labelDestinatario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelDestinatario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(73)))));
            this.labelDestinatario.Location = new System.Drawing.Point(22, 170);
            this.labelDestinatario.Name = "labelDestinatario";
            this.labelDestinatario.Size = new System.Drawing.Size(95, 20);
            this.labelDestinatario.TabIndex = 7;
            this.labelDestinatario.Text = "Destinatario";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "CORREO",
            "SMS"});
            this.comboBox2.Location = new System.Drawing.Point(25, 139);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(310, 28);
            this.comboBox2.TabIndex = 6;
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(73)))));
            this.labelTipo.Location = new System.Drawing.Point(22, 116);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(160, 20);
            this.labelTipo.TabIndex = 5;
            this.labelTipo.Text = "Medio de notificación";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(310, 28);
            this.comboBox1.TabIndex = 4;
            // 
            // labelTicket
            // 
            this.labelTicket.AutoSize = true;
            this.labelTicket.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(73)))));
            this.labelTicket.Location = new System.Drawing.Point(22, 62);
            this.labelTicket.Name = "labelTicket";
            this.labelTicket.Size = new System.Drawing.Size(183, 20);
            this.labelTicket.TabIndex = 3;
            this.labelTicket.Text = "Cita o ticket programado";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(116, 42);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(80, 27);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Visible = false;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelId.Location = new System.Drawing.Point(25, 46);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(85, 19);
            this.labelId.TabIndex = 1;
            this.labelId.Text = "Identificador";
            this.labelId.Visible = false;
            // 
            // labelFormulario
            // 
            this.labelFormulario.AutoSize = true;
            this.labelFormulario.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.labelFormulario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(92)))));
            this.labelFormulario.Location = new System.Drawing.Point(18, 16);
            this.labelFormulario.Name = "labelFormulario";
            this.labelFormulario.Size = new System.Drawing.Size(247, 30);
            this.labelFormulario.TabIndex = 0;
            this.labelFormulario.Text = "Datos del recordatorio";
            // 
            // Frm_Recordatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1165, 792);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelEncabezado);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "Frm_Recordatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recordatorios - TurnoSmarts";
            this.panelEncabezado.ResumeLayout(false);
            this.panelEncabezado.PerformLayout();
            this.panelContenido.ResumeLayout(false);
            this.panelLista.ResumeLayout(false);
            this.panelLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
