namespace Proyecto_PA_Parcial_1.Formularios
{
    partial class Frm_Pantalla
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelEncabezado;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelSubtitulo;
        private System.Windows.Forms.Label labelFechaHora;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.Label labelSucursalFiltro;
        private System.Windows.Forms.Label labelServicioFiltro;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelTurnoActual;
        private System.Windows.Forms.Label labelTurnoActualTitulo;
        private System.Windows.Forms.Label labelTurnoActual;
        private System.Windows.Forms.Label labelVentanillaTitulo;
        private System.Windows.Forms.Label labelVentanillaActual;
        private System.Windows.Forms.Label labelServicioActual;
        private System.Windows.Forms.Label labelSucursalActual;
        private System.Windows.Forms.Panel panelDerecho;
        private System.Windows.Forms.Label labelUltimosLlamados;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaTurno;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaVentanilla;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Label labelPendientesTitulo;
        private System.Windows.Forms.Label labelPendientes;
        private System.Windows.Forms.Label labelEsperaTitulo;
        private System.Windows.Forms.Label labelTiempoEstimado;
        private System.Windows.Forms.Label labelMensaje;

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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelEncabezado = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelSubtitulo = new System.Windows.Forms.Label();
            this.labelFechaHora = new System.Windows.Forms.Label();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.labelSucursalFiltro = new System.Windows.Forms.Label();
            this.labelServicioFiltro = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelTurnoActual = new System.Windows.Forms.Panel();
            this.labelTurnoActualTitulo = new System.Windows.Forms.Label();
            this.labelTurnoActual = new System.Windows.Forms.Label();
            this.labelVentanillaTitulo = new System.Windows.Forms.Label();
            this.labelVentanillaActual = new System.Windows.Forms.Label();
            this.labelServicioActual = new System.Windows.Forms.Label();
            this.labelSucursalActual = new System.Windows.Forms.Label();
            this.panelDerecho = new System.Windows.Forms.Panel();
            this.labelUltimosLlamados = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnaTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaVentanilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.labelPendientesTitulo = new System.Windows.Forms.Label();
            this.labelPendientes = new System.Windows.Forms.Label();
            this.labelEsperaTitulo = new System.Windows.Forms.Label();
            this.labelTiempoEstimado = new System.Windows.Forms.Label();
            this.labelMensaje = new System.Windows.Forms.Label();
            this.panelEncabezado.SuspendLayout();
            this.panelFiltros.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.panelTurnoActual.SuspendLayout();
            this.panelDerecho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelEncabezado
            // 
            this.panelEncabezado.BackColor = System.Drawing.Color.FromArgb(32, 59, 92);
            this.panelEncabezado.Controls.Add(this.labelFechaHora);
            this.panelEncabezado.Controls.Add(this.labelSubtitulo);
            this.panelEncabezado.Controls.Add(this.labelTitulo);
            this.panelEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEncabezado.Location = new System.Drawing.Point(0, 0);
            this.panelEncabezado.Name = "panelEncabezado";
            this.panelEncabezado.Size = new System.Drawing.Size(1200, 110);
            this.panelEncabezado.TabIndex = 0;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(28, 15);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(185, 45);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "TurnoSmarts";
            // 
            // labelSubtitulo
            // 
            this.labelSubtitulo.AutoSize = true;
            this.labelSubtitulo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelSubtitulo.ForeColor = System.Drawing.Color.FromArgb(220, 230, 240);
            this.labelSubtitulo.Location = new System.Drawing.Point(32, 67);
            this.labelSubtitulo.Name = "labelSubtitulo";
            this.labelSubtitulo.Size = new System.Drawing.Size(171, 21);
            this.labelSubtitulo.TabIndex = 1;
            this.labelSubtitulo.Text = "Pantalla de llamados";
            // 
            // labelFechaHora
            // 
            this.labelFechaHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFechaHora.AutoSize = true;
            this.labelFechaHora.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelFechaHora.ForeColor = System.Drawing.Color.White;
            this.labelFechaHora.Location = new System.Drawing.Point(875, 45);
            this.labelFechaHora.Name = "labelFechaHora";
            this.labelFechaHora.Size = new System.Drawing.Size(293, 21);
            this.labelFechaHora.TabIndex = 2;
            this.labelFechaHora.Text = "Fecha y hora";
            this.labelFechaHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelFiltros
            // 
            this.panelFiltros.BackColor = System.Drawing.Color.White;
            this.panelFiltros.Controls.Add(this.comboBox2);
            this.panelFiltros.Controls.Add(this.labelServicioFiltro);
            this.panelFiltros.Controls.Add(this.comboBox1);
            this.panelFiltros.Controls.Add(this.labelSucursalFiltro);
            this.panelFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltros.Location = new System.Drawing.Point(0, 110);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Padding = new System.Windows.Forms.Padding(24, 10, 24, 10);
            this.panelFiltros.Size = new System.Drawing.Size(1200, 58);
            this.panelFiltros.TabIndex = 1;
            // 
            // labelSucursalFiltro
            // 
            this.labelSucursalFiltro.AutoSize = true;
            this.labelSucursalFiltro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelSucursalFiltro.Location = new System.Drawing.Point(24, 19);
            this.labelSucursalFiltro.Name = "labelSucursalFiltro";
            this.labelSucursalFiltro.Size = new System.Drawing.Size(67, 19);
            this.labelSucursalFiltro.TabIndex = 0;
            this.labelSucursalFiltro.Text = "Sucursal:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(97, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 25);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelServicioFiltro
            // 
            this.labelServicioFiltro.AutoSize = true;
            this.labelServicioFiltro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelServicioFiltro.Location = new System.Drawing.Point(345, 19);
            this.labelServicioFiltro.Name = "labelServicioFiltro";
            this.labelServicioFiltro.Size = new System.Drawing.Size(62, 19);
            this.labelServicioFiltro.TabIndex = 2;
            this.labelServicioFiltro.Text = "Servicio:";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(413, 15);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(280, 25);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(238, 241, 245);
            this.panelPrincipal.Controls.Add(this.panelDerecho);
            this.panelPrincipal.Controls.Add(this.panelTurnoActual);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 168);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Padding = new System.Windows.Forms.Padding(20, 16, 20, 16);
            this.panelPrincipal.Size = new System.Drawing.Size(1200, 492);
            this.panelPrincipal.TabIndex = 2;
            // 
            // panelTurnoActual
            // 
            this.panelTurnoActual.BackColor = System.Drawing.Color.White;
            this.panelTurnoActual.Controls.Add(this.labelSucursalActual);
            this.panelTurnoActual.Controls.Add(this.labelServicioActual);
            this.panelTurnoActual.Controls.Add(this.labelVentanillaActual);
            this.panelTurnoActual.Controls.Add(this.labelVentanillaTitulo);
            this.panelTurnoActual.Controls.Add(this.labelTurnoActual);
            this.panelTurnoActual.Controls.Add(this.labelTurnoActualTitulo);
            this.panelTurnoActual.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTurnoActual.Location = new System.Drawing.Point(20, 16);
            this.panelTurnoActual.Name = "panelTurnoActual";
            this.panelTurnoActual.Padding = new System.Windows.Forms.Padding(24);
            this.panelTurnoActual.Size = new System.Drawing.Size(360, 460);
            this.panelTurnoActual.TabIndex = 0;
            // 
            // labelTurnoActualTitulo
            // 
            this.labelTurnoActualTitulo.AutoSize = true;
            this.labelTurnoActualTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelTurnoActualTitulo.ForeColor = System.Drawing.Color.FromArgb(32, 59, 92);
            this.labelTurnoActualTitulo.Location = new System.Drawing.Point(24, 28);
            this.labelTurnoActualTitulo.Name = "labelTurnoActualTitulo";
            this.labelTurnoActualTitulo.Size = new System.Drawing.Size(171, 25);
            this.labelTurnoActualTitulo.TabIndex = 0;
            this.labelTurnoActualTitulo.Text = "TURNO ACTUAL";
            // 
            // labelTurnoActual
            // 
            this.labelTurnoActual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTurnoActual.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.labelTurnoActual.ForeColor = System.Drawing.Color.FromArgb(32, 59, 92);
            this.labelTurnoActual.Location = new System.Drawing.Point(24, 75);
            this.labelTurnoActual.Name = "labelTurnoActual";
            this.labelTurnoActual.Size = new System.Drawing.Size(312, 65);
            this.labelTurnoActual.TabIndex = 1;
            this.labelTurnoActual.Text = "ESPERANDO PRÓXIMO TURNO";
            this.labelTurnoActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelVentanillaTitulo
            // 
            this.labelVentanillaTitulo.AutoSize = true;
            this.labelVentanillaTitulo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelVentanillaTitulo.Location = new System.Drawing.Point(24, 171);
            this.labelVentanillaTitulo.Name = "labelVentanillaTitulo";
            this.labelVentanillaTitulo.Size = new System.Drawing.Size(82, 20);
            this.labelVentanillaTitulo.TabIndex = 2;
            this.labelVentanillaTitulo.Text = "Ventanilla";
            // 
            // labelVentanillaActual
            // 
            this.labelVentanillaActual.BackColor = System.Drawing.Color.FromArgb(52, 168, 83);
            this.labelVentanillaActual.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.labelVentanillaActual.ForeColor = System.Drawing.Color.White;
            this.labelVentanillaActual.Location = new System.Drawing.Point(24, 198);
            this.labelVentanillaActual.Name = "labelVentanillaActual";
            this.labelVentanillaActual.Size = new System.Drawing.Size(312, 66);
            this.labelVentanillaActual.TabIndex = 3;
            this.labelVentanillaActual.Text = "-";
            this.labelVentanillaActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelServicioActual
            // 
            this.labelServicioActual.AutoEllipsis = true;
            this.labelServicioActual.AutoSize = true;
            this.labelServicioActual.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelServicioActual.Location = new System.Drawing.Point(24, 300);
            this.labelServicioActual.MaximumSize = new System.Drawing.Size(312, 0);
            this.labelServicioActual.Name = "labelServicioActual";
            this.labelServicioActual.Size = new System.Drawing.Size(85, 20);
            this.labelServicioActual.TabIndex = 4;
            this.labelServicioActual.Text = "Servicio: -";
            // 
            // labelSucursalActual
            // 
            this.labelSucursalActual.AutoEllipsis = true;
            this.labelSucursalActual.AutoSize = true;
            this.labelSucursalActual.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelSucursalActual.Location = new System.Drawing.Point(24, 337);
            this.labelSucursalActual.MaximumSize = new System.Drawing.Size(312, 0);
            this.labelSucursalActual.Name = "labelSucursalActual";
            this.labelSucursalActual.Size = new System.Drawing.Size(88, 20);
            this.labelSucursalActual.TabIndex = 5;
            this.labelSucursalActual.Text = "Sucursal: -";
            // 
            // panelDerecho
            // 
            this.panelDerecho.BackColor = System.Drawing.Color.White;
            this.panelDerecho.Controls.Add(this.dataGridView1);
            this.panelDerecho.Controls.Add(this.labelUltimosLlamados);
            this.panelDerecho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDerecho.Location = new System.Drawing.Point(380, 16);
            this.panelDerecho.Name = "panelDerecho";
            this.panelDerecho.Padding = new System.Windows.Forms.Padding(24);
            this.panelDerecho.Size = new System.Drawing.Size(800, 460);
            this.panelDerecho.TabIndex = 1;
            // 
            // labelUltimosLlamados
            // 
            this.labelUltimosLlamados.AutoSize = true;
            this.labelUltimosLlamados.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelUltimosLlamados.ForeColor = System.Drawing.Color.FromArgb(32, 59, 92);
            this.labelUltimosLlamados.Location = new System.Drawing.Point(24, 24);
            this.labelUltimosLlamados.Name = "labelUltimosLlamados";
            this.labelUltimosLlamados.Size = new System.Drawing.Size(234, 25);
            this.labelUltimosLlamados.TabIndex = 0;
            this.labelUltimosLlamados.Text = "Últimos turnos llamados";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaTurno,
            this.columnaServicio,
            this.columnaVentanilla});
            this.dataGridView1.Location = new System.Drawing.Point(24, 68);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(752, 368);
            this.dataGridView1.TabIndex = 1;
            // 
            // columnaTurno
            // 
            this.columnaTurno.HeaderText = "Turno";
            this.columnaTurno.Name = "columnaTurno";
            this.columnaTurno.ReadOnly = true;
            // 
            // columnaServicio
            // 
            this.columnaServicio.HeaderText = "Servicio";
            this.columnaServicio.Name = "columnaServicio";
            this.columnaServicio.ReadOnly = true;
            // 
            // columnaVentanilla
            // 
            this.columnaVentanilla.HeaderText = "Ventanilla";
            this.columnaVentanilla.Name = "columnaVentanilla";
            this.columnaVentanilla.ReadOnly = true;
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.Color.White;
            this.panelInferior.Controls.Add(this.labelMensaje);
            this.panelInferior.Controls.Add(this.labelTiempoEstimado);
            this.panelInferior.Controls.Add(this.labelEsperaTitulo);
            this.panelInferior.Controls.Add(this.labelPendientes);
            this.panelInferior.Controls.Add(this.labelPendientesTitulo);
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 660);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(1200, 90);
            this.panelInferior.TabIndex = 3;
            // 
            // labelPendientesTitulo
            // 
            this.labelPendientesTitulo.AutoSize = true;
            this.labelPendientesTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelPendientesTitulo.Location = new System.Drawing.Point(28, 16);
            this.labelPendientesTitulo.Name = "labelPendientesTitulo";
            this.labelPendientesTitulo.Size = new System.Drawing.Size(144, 19);
            this.labelPendientesTitulo.TabIndex = 0;
            this.labelPendientesTitulo.Text = "Turnos pendientes";
            // 
            // labelPendientes
            // 
            this.labelPendientes.AutoSize = true;
            this.labelPendientes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelPendientes.ForeColor = System.Drawing.Color.FromArgb(32, 59, 92);
            this.labelPendientes.Location = new System.Drawing.Point(31, 41);
            this.labelPendientes.Name = "labelPendientes";
            this.labelPendientes.Size = new System.Drawing.Size(29, 32);
            this.labelPendientes.TabIndex = 1;
            this.labelPendientes.Text = "0";
            // 
            // labelEsperaTitulo
            // 
            this.labelEsperaTitulo.AutoSize = true;
            this.labelEsperaTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelEsperaTitulo.Location = new System.Drawing.Point(245, 16);
            this.labelEsperaTitulo.Name = "labelEsperaTitulo";
            this.labelEsperaTitulo.Size = new System.Drawing.Size(131, 19);
            this.labelEsperaTitulo.TabIndex = 2;
            this.labelEsperaTitulo.Text = "Tiempo estimado";
            // 
            // labelTiempoEstimado
            // 
            this.labelTiempoEstimado.AutoSize = true;
            this.labelTiempoEstimado.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelTiempoEstimado.ForeColor = System.Drawing.Color.FromArgb(32, 59, 92);
            this.labelTiempoEstimado.Location = new System.Drawing.Point(248, 41);
            this.labelTiempoEstimado.Name = "labelTiempoEstimado";
            this.labelTiempoEstimado.Size = new System.Drawing.Size(25, 32);
            this.labelTiempoEstimado.TabIndex = 3;
            this.labelTiempoEstimado.Text = "-";
            // 
            // labelMensaje
            // 
            this.labelMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMensaje.AutoSize = true;
            this.labelMensaje.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.labelMensaje.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.labelMensaje.Location = new System.Drawing.Point(829, 35);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(339, 21);
            this.labelMensaje.TabIndex = 4;
            this.labelMensaje.Text = "Espere a que llamen su turno";
            // 
            // Frm_Pantalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(238, 241, 245);
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.panelFiltros);
            this.Controls.Add(this.panelEncabezado);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "Frm_Pantalla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TurnoSmarts - Pantalla de llamados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Pantalla_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Pantalla_Load);
            this.panelEncabezado.ResumeLayout(false);
            this.panelEncabezado.PerformLayout();
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            this.panelTurnoActual.ResumeLayout(false);
            this.panelTurnoActual.PerformLayout();
            this.panelDerecho.ResumeLayout(false);
            this.panelDerecho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelInferior.ResumeLayout(false);
            this.panelInferior.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
