namespace Proyecto_PA_Parcial_1.Formularios
{
    partial class Frm_Atencion
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelEncabezado;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelSubtitulo;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.Panel panelTurnoActual;
        private System.Windows.Forms.Panel panelCola;
        private System.Windows.Forms.Panel panelHistorial;
        private System.Windows.Forms.Label labelFiltros;
        private System.Windows.Forms.Label labelSucursal;
        private System.Windows.Forms.Label labelFila;
        private System.Windows.Forms.Label labelVentanilla;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelTurnoActual;
        private System.Windows.Forms.Label labelTicketActual;
        private System.Windows.Forms.Label labelServicioActual;
        private System.Windows.Forms.Label labelEstadoActual;
        private System.Windows.Forms.Label labelHoraLlamada;
        private System.Windows.Forms.Label labelVentanillaActual;
        private System.Windows.Forms.Label labelTiempoEspera;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label labelCola;
        private System.Windows.Forms.Label labelHistorial;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaPendienteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaPendienteCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaPendienteServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaPendienteFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaPendienteHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaPendienteEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaPendienteCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaPendienteTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaHistorialId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaHistorialCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaHistorialEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaHistorialVentanilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaHistorialLlamada;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaHistorialInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaHistorialFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaHistorialCliente;

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
            this.panelCola = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnaPendienteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaPendienteCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaPendienteServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaPendienteFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaPendienteHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaPendienteEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaPendienteCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaPendienteTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelCola = new System.Windows.Forms.Label();
            this.panelHistorial = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.columnaHistorialId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaHistorialCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaHistorialEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaHistorialVentanilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaHistorialLlamada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaHistorialInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaHistorialFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaHistorialCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelHistorial = new System.Windows.Forms.Label();
            this.panelTurnoActual = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelTiempoEspera = new System.Windows.Forms.Label();
            this.labelVentanillaActual = new System.Windows.Forms.Label();
            this.labelHoraLlamada = new System.Windows.Forms.Label();
            this.labelEstadoActual = new System.Windows.Forms.Label();
            this.labelServicioActual = new System.Windows.Forms.Label();
            this.labelTicketActual = new System.Windows.Forms.Label();
            this.labelTurnoActual = new System.Windows.Forms.Label();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelVentanilla = new System.Windows.Forms.Label();
            this.labelFila = new System.Windows.Forms.Label();
            this.labelSucursal = new System.Windows.Forms.Label();
            this.labelFiltros = new System.Windows.Forms.Label();
            this.panelEncabezado.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.panelCola.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panelTurnoActual.SuspendLayout();
            this.panelFiltros.SuspendLayout();
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
            this.panelEncabezado.Padding = new System.Windows.Forms.Padding(28, 14, 28, 12);
            this.panelEncabezado.Size = new System.Drawing.Size(1243, 108);
            this.panelEncabezado.TabIndex = 0;
            // 
            // labelSubtitulo
            // 
            this.labelSubtitulo.AutoSize = true;
            this.labelSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.labelSubtitulo.Location = new System.Drawing.Point(31, 67);
            this.labelSubtitulo.Name = "labelSubtitulo";
            this.labelSubtitulo.Size = new System.Drawing.Size(361, 23);
            this.labelSubtitulo.TabIndex = 1;
            this.labelSubtitulo.Text = "Gestión de atención y llamadas por ventanilla.";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(27, 13);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(357, 50);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Atención de Turnos";
            // 
            // panelContenido
            // 
            this.panelContenido.AutoScroll = true;
            this.panelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.panelContenido.Controls.Add(this.panelCola);
            this.panelContenido.Controls.Add(this.panelHistorial);
            this.panelContenido.Controls.Add(this.panelTurnoActual);
            this.panelContenido.Controls.Add(this.panelFiltros);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 108);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Padding = new System.Windows.Forms.Padding(22, 20, 22, 20);
            this.panelContenido.Size = new System.Drawing.Size(1243, 592);
            this.panelContenido.TabIndex = 1;
            // 
            // panelCola
            // 
            this.panelCola.BackColor = System.Drawing.Color.White;
            this.panelCola.Controls.Add(this.dataGridView1);
            this.panelCola.Controls.Add(this.labelCola);
            this.panelCola.Location = new System.Drawing.Point(402, 20);
            this.panelCola.Name = "panelCola";
            this.panelCola.Padding = new System.Windows.Forms.Padding(16, 12, 16, 16);
            this.panelCola.Size = new System.Drawing.Size(654, 250);
            this.panelCola.TabIndex = 2;
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
            this.dataGridView1.ColumnHeadersHeight = 34;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaPendienteId,
            this.columnaPendienteCodigo,
            this.columnaPendienteServicio,
            this.columnaPendienteFecha,
            this.columnaPendienteHora,
            this.columnaPendienteEstado,
            this.columnaPendienteCliente,
            this.columnaPendienteTipo});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.dataGridView1.Location = new System.Drawing.Point(16, 52);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(622, 182);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // columnaPendienteId
            // 
            this.columnaPendienteId.HeaderText = "Id";
            this.columnaPendienteId.MinimumWidth = 6;
            this.columnaPendienteId.Name = "columnaPendienteId";
            this.columnaPendienteId.ReadOnly = true;
            this.columnaPendienteId.Visible = false;
            // 
            // columnaPendienteCodigo
            // 
            this.columnaPendienteCodigo.HeaderText = "Código";
            this.columnaPendienteCodigo.MinimumWidth = 6;
            this.columnaPendienteCodigo.Name = "columnaPendienteCodigo";
            this.columnaPendienteCodigo.ReadOnly = true;
            // 
            // columnaPendienteServicio
            // 
            this.columnaPendienteServicio.HeaderText = "Servicio";
            this.columnaPendienteServicio.MinimumWidth = 6;
            this.columnaPendienteServicio.Name = "columnaPendienteServicio";
            this.columnaPendienteServicio.ReadOnly = true;
            // 
            // columnaPendienteFecha
            // 
            this.columnaPendienteFecha.HeaderText = "Fecha";
            this.columnaPendienteFecha.MinimumWidth = 6;
            this.columnaPendienteFecha.Name = "columnaPendienteFecha";
            this.columnaPendienteFecha.ReadOnly = true;
            // 
            // columnaPendienteHora
            // 
            this.columnaPendienteHora.HeaderText = "Hora";
            this.columnaPendienteHora.MinimumWidth = 6;
            this.columnaPendienteHora.Name = "columnaPendienteHora";
            this.columnaPendienteHora.ReadOnly = true;
            // 
            // columnaPendienteEstado
            // 
            this.columnaPendienteEstado.HeaderText = "Estado";
            this.columnaPendienteEstado.MinimumWidth = 6;
            this.columnaPendienteEstado.Name = "columnaPendienteEstado";
            this.columnaPendienteEstado.ReadOnly = true;
            // 
            // columnaPendienteCliente
            // 
            this.columnaPendienteCliente.HeaderText = "Cliente";
            this.columnaPendienteCliente.MinimumWidth = 6;
            this.columnaPendienteCliente.Name = "columnaPendienteCliente";
            this.columnaPendienteCliente.ReadOnly = true;
            // 
            // columnaPendienteTipo
            // 
            this.columnaPendienteTipo.HeaderText = "Tipo";
            this.columnaPendienteTipo.MinimumWidth = 6;
            this.columnaPendienteTipo.Name = "columnaPendienteTipo";
            this.columnaPendienteTipo.ReadOnly = true;
            // 
            // labelCola
            // 
            this.labelCola.AutoSize = true;
            this.labelCola.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.labelCola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(92)))));
            this.labelCola.Location = new System.Drawing.Point(16, 13);
            this.labelCola.Name = "labelCola";
            this.labelCola.Size = new System.Drawing.Size(203, 30);
            this.labelCola.TabIndex = 0;
            this.labelCola.Text = "Turnos pendientes";
            // 
            // panelHistorial
            // 
            this.panelHistorial.BackColor = System.Drawing.Color.White;
            this.panelHistorial.Controls.Add(this.dataGridView2);
            this.panelHistorial.Controls.Add(this.labelHistorial);
            this.panelHistorial.Location = new System.Drawing.Point(516, 289);
            this.panelHistorial.Name = "panelHistorial";
            this.panelHistorial.Padding = new System.Windows.Forms.Padding(16, 12, 16, 16);
            this.panelHistorial.Size = new System.Drawing.Size(654, 286);
            this.panelHistorial.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.ColumnHeadersHeight = 34;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaHistorialId,
            this.columnaHistorialCodigo,
            this.columnaHistorialEstado,
            this.columnaHistorialVentanilla,
            this.columnaHistorialLlamada,
            this.columnaHistorialInicio,
            this.columnaHistorialFin,
            this.columnaHistorialCliente});
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.dataGridView2.Location = new System.Drawing.Point(16, 52);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 30;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(622, 218);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // columnaHistorialId
            // 
            this.columnaHistorialId.HeaderText = "Id";
            this.columnaHistorialId.MinimumWidth = 6;
            this.columnaHistorialId.Name = "columnaHistorialId";
            this.columnaHistorialId.ReadOnly = true;
            this.columnaHistorialId.Visible = false;
            // 
            // columnaHistorialCodigo
            // 
            this.columnaHistorialCodigo.HeaderText = "Código";
            this.columnaHistorialCodigo.MinimumWidth = 6;
            this.columnaHistorialCodigo.Name = "columnaHistorialCodigo";
            this.columnaHistorialCodigo.ReadOnly = true;
            // 
            // columnaHistorialEstado
            // 
            this.columnaHistorialEstado.HeaderText = "Estado";
            this.columnaHistorialEstado.MinimumWidth = 6;
            this.columnaHistorialEstado.Name = "columnaHistorialEstado";
            this.columnaHistorialEstado.ReadOnly = true;
            // 
            // columnaHistorialVentanilla
            // 
            this.columnaHistorialVentanilla.HeaderText = "Ventanilla";
            this.columnaHistorialVentanilla.MinimumWidth = 6;
            this.columnaHistorialVentanilla.Name = "columnaHistorialVentanilla";
            this.columnaHistorialVentanilla.ReadOnly = true;
            // 
            // columnaHistorialLlamada
            // 
            this.columnaHistorialLlamada.HeaderText = "Llamada";
            this.columnaHistorialLlamada.MinimumWidth = 6;
            this.columnaHistorialLlamada.Name = "columnaHistorialLlamada";
            this.columnaHistorialLlamada.ReadOnly = true;
            // 
            // columnaHistorialInicio
            // 
            this.columnaHistorialInicio.HeaderText = "Inicio";
            this.columnaHistorialInicio.MinimumWidth = 6;
            this.columnaHistorialInicio.Name = "columnaHistorialInicio";
            this.columnaHistorialInicio.ReadOnly = true;
            // 
            // columnaHistorialFin
            // 
            this.columnaHistorialFin.HeaderText = "Fin";
            this.columnaHistorialFin.MinimumWidth = 6;
            this.columnaHistorialFin.Name = "columnaHistorialFin";
            this.columnaHistorialFin.ReadOnly = true;
            // 
            // columnaHistorialCliente
            // 
            this.columnaHistorialCliente.HeaderText = "Cliente";
            this.columnaHistorialCliente.MinimumWidth = 6;
            this.columnaHistorialCliente.Name = "columnaHistorialCliente";
            this.columnaHistorialCliente.ReadOnly = true;
            // 
            // labelHistorial
            // 
            this.labelHistorial.AutoSize = true;
            this.labelHistorial.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.labelHistorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(92)))));
            this.labelHistorial.Location = new System.Drawing.Point(16, 13);
            this.labelHistorial.Name = "labelHistorial";
            this.labelHistorial.Size = new System.Drawing.Size(228, 30);
            this.labelHistorial.TabIndex = 0;
            this.labelHistorial.Text = "Historial de atención";
            // 
            // panelTurnoActual
            // 
            this.panelTurnoActual.BackColor = System.Drawing.Color.White;
            this.panelTurnoActual.Controls.Add(this.button6);
            this.panelTurnoActual.Controls.Add(this.button5);
            this.panelTurnoActual.Controls.Add(this.button4);
            this.panelTurnoActual.Controls.Add(this.button3);
            this.panelTurnoActual.Controls.Add(this.button2);
            this.panelTurnoActual.Controls.Add(this.labelTiempoEspera);
            this.panelTurnoActual.Controls.Add(this.labelVentanillaActual);
            this.panelTurnoActual.Controls.Add(this.labelHoraLlamada);
            this.panelTurnoActual.Controls.Add(this.labelEstadoActual);
            this.panelTurnoActual.Controls.Add(this.labelServicioActual);
            this.panelTurnoActual.Controls.Add(this.labelTicketActual);
            this.panelTurnoActual.Controls.Add(this.labelTurnoActual);
            this.panelTurnoActual.Location = new System.Drawing.Point(22, 276);
            this.panelTurnoActual.Name = "panelTurnoActual";
            this.panelTurnoActual.Padding = new System.Windows.Forms.Padding(18, 14, 18, 18);
            this.panelTurnoActual.Size = new System.Drawing.Size(466, 292);
            this.panelTurnoActual.TabIndex = 2;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(192, 235);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(143, 34);
            this.button6.TabIndex = 11;
            this.button6.Text = "Reabrir turno";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(24, 235);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(143, 34);
            this.button5.TabIndex = 10;
            this.button5.Text = "Omitir turno";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(192, 193);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 34);
            this.button4.TabIndex = 9;
            this.button4.Text = "Finalizar atención";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(24, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 34);
            this.button3.TabIndex = 8;
            this.button3.Text = "Iniciar atención";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(24, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(311, 34);
            this.button2.TabIndex = 7;
            this.button2.Text = "Llamar siguiente";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelTiempoEspera
            // 
            this.labelTiempoEspera.AutoSize = true;
            this.labelTiempoEspera.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelTiempoEspera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.labelTiempoEspera.Location = new System.Drawing.Point(24, 128);
            this.labelTiempoEspera.Name = "labelTiempoEspera";
            this.labelTiempoEspera.Size = new System.Drawing.Size(142, 20);
            this.labelTiempoEspera.TabIndex = 6;
            this.labelTiempoEspera.Text = "Tiempo de espera: -";
            // 
            // labelVentanillaActual
            // 
            this.labelVentanillaActual.AutoSize = true;
            this.labelVentanillaActual.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelVentanillaActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.labelVentanillaActual.Location = new System.Drawing.Point(190, 104);
            this.labelVentanillaActual.Name = "labelVentanillaActual";
            this.labelVentanillaActual.Size = new System.Drawing.Size(87, 20);
            this.labelVentanillaActual.TabIndex = 5;
            this.labelVentanillaActual.Text = "Ventanilla: -";
            // 
            // labelHoraLlamada
            // 
            this.labelHoraLlamada.AutoSize = true;
            this.labelHoraLlamada.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelHoraLlamada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.labelHoraLlamada.Location = new System.Drawing.Point(24, 104);
            this.labelHoraLlamada.Name = "labelHoraLlamada";
            this.labelHoraLlamada.Size = new System.Drawing.Size(134, 20);
            this.labelHoraLlamada.TabIndex = 4;
            this.labelHoraLlamada.Text = "Hora de llamada: -";
            // 
            // labelEstadoActual
            // 
            this.labelEstadoActual.AutoSize = true;
            this.labelEstadoActual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelEstadoActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(92)))));
            this.labelEstadoActual.Location = new System.Drawing.Point(190, 78);
            this.labelEstadoActual.Name = "labelEstadoActual";
            this.labelEstadoActual.Size = new System.Drawing.Size(70, 20);
            this.labelEstadoActual.TabIndex = 3;
            this.labelEstadoActual.Text = "Estado: -";
            // 
            // labelServicioActual
            // 
            this.labelServicioActual.AutoEllipsis = true;
            this.labelServicioActual.AutoSize = true;
            this.labelServicioActual.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelServicioActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.labelServicioActual.Location = new System.Drawing.Point(24, 78);
            this.labelServicioActual.MaximumSize = new System.Drawing.Size(155, 20);
            this.labelServicioActual.Name = "labelServicioActual";
            this.labelServicioActual.Size = new System.Drawing.Size(74, 20);
            this.labelServicioActual.TabIndex = 2;
            this.labelServicioActual.Text = "Servicio: -";
            // 
            // labelTicketActual
            // 
            this.labelTicketActual.AutoSize = true;
            this.labelTicketActual.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.labelTicketActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(92)))));
            this.labelTicketActual.Location = new System.Drawing.Point(9, 43);
            this.labelTicketActual.Name = "labelTicketActual";
            this.labelTicketActual.Size = new System.Drawing.Size(282, 35);
            this.labelTicketActual.TabIndex = 1;
            this.labelTicketActual.Text = "Sin ticket seleccionado";
            // 
            // labelTurnoActual
            // 
            this.labelTurnoActual.AutoSize = true;
            this.labelTurnoActual.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.labelTurnoActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(92)))));
            this.labelTurnoActual.Location = new System.Drawing.Point(18, 13);
            this.labelTurnoActual.Name = "labelTurnoActual";
            this.labelTurnoActual.Size = new System.Drawing.Size(141, 30);
            this.labelTurnoActual.TabIndex = 0;
            this.labelTurnoActual.Text = "Turno actual";
            // 
            // panelFiltros
            // 
            this.panelFiltros.BackColor = System.Drawing.Color.White;
            this.panelFiltros.Controls.Add(this.button1);
            this.panelFiltros.Controls.Add(this.numericUpDown1);
            this.panelFiltros.Controls.Add(this.comboBox2);
            this.panelFiltros.Controls.Add(this.comboBox1);
            this.panelFiltros.Controls.Add(this.labelVentanilla);
            this.panelFiltros.Controls.Add(this.labelFila);
            this.panelFiltros.Controls.Add(this.labelSucursal);
            this.panelFiltros.Controls.Add(this.labelFiltros);
            this.panelFiltros.Location = new System.Drawing.Point(22, 20);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Padding = new System.Windows.Forms.Padding(18, 14, 18, 18);
            this.panelFiltros.Size = new System.Drawing.Size(356, 244);
            this.panelFiltros.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(92)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(21, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(314, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numericUpDown1.Location = new System.Drawing.Point(21, 160);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(314, 27);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(21, 108);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(314, 28);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(21, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(314, 28);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelVentanilla
            // 
            this.labelVentanilla.AutoSize = true;
            this.labelVentanilla.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelVentanilla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.labelVentanilla.Location = new System.Drawing.Point(18, 137);
            this.labelVentanilla.Name = "labelVentanilla";
            this.labelVentanilla.Size = new System.Drawing.Size(78, 20);
            this.labelVentanilla.TabIndex = 3;
            this.labelVentanilla.Text = "Ventanilla";
            // 
            // labelFila
            // 
            this.labelFila.AutoSize = true;
            this.labelFila.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelFila.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.labelFila.Location = new System.Drawing.Point(18, 85);
            this.labelFila.Name = "labelFila";
            this.labelFila.Size = new System.Drawing.Size(104, 20);
            this.labelFila.TabIndex = 2;
            this.labelFila.Text = "Fila o servicio";
            // 
            // labelSucursal
            // 
            this.labelSucursal.AutoSize = true;
            this.labelSucursal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelSucursal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.labelSucursal.Location = new System.Drawing.Point(18, 33);
            this.labelSucursal.Name = "labelSucursal";
            this.labelSucursal.Size = new System.Drawing.Size(67, 20);
            this.labelSucursal.TabIndex = 1;
            this.labelSucursal.Text = "Sucursal";
            // 
            // labelFiltros
            // 
            this.labelFiltros.AutoSize = true;
            this.labelFiltros.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.labelFiltros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(92)))));
            this.labelFiltros.Location = new System.Drawing.Point(18, 13);
            this.labelFiltros.Name = "labelFiltros";
            this.labelFiltros.Size = new System.Drawing.Size(77, 30);
            this.labelFiltros.TabIndex = 0;
            this.labelFiltros.Text = "Filtros";
            // 
            // Frm_Atencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1243, 700);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelEncabezado);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(950, 620);
            this.Name = "Frm_Atencion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atención de Turnos";
            this.panelEncabezado.ResumeLayout(false);
            this.panelEncabezado.PerformLayout();
            this.panelContenido.ResumeLayout(false);
            this.panelCola.ResumeLayout(false);
            this.panelCola.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelHistorial.ResumeLayout(false);
            this.panelHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panelTurnoActual.ResumeLayout(false);
            this.panelTurnoActual.PerformLayout();
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
