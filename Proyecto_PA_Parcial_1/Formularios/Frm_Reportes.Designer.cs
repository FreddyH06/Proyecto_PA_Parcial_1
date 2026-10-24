namespace Proyecto_PA_Parcial_1.Formularios
{
    partial class Frm_Reportes
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelEncabezado;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelSubtitulo;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.Panel panelIndicadores;
        private System.Windows.Forms.Panel panelDetalle;
        private System.Windows.Forms.Label labelFiltros;
        private System.Windows.Forms.Label labelSucursal;
        private System.Windows.Forms.Label labelServicio;
        private System.Windows.Forms.Label labelFechaInicial;
        private System.Windows.Forms.Label labelFechaFinal;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Panel panelAtendidos;
        private System.Windows.Forms.Panel panelPendientes;
        private System.Windows.Forms.Panel panelOmitidos;
        private System.Windows.Forms.Panel panelAnulados;
        private System.Windows.Forms.Panel panelPromedio;
        private System.Windows.Forms.Label labelTotalTitulo;
        private System.Windows.Forms.Label labelAtendidosTitulo;
        private System.Windows.Forms.Label labelPendientesTitulo;
        private System.Windows.Forms.Label labelOmitidosTitulo;
        private System.Windows.Forms.Label labelAnuladosTitulo;
        private System.Windows.Forms.Label labelPromedioTitulo;
        private System.Windows.Forms.Label labelTotalValor;
        private System.Windows.Forms.Label labelAtendidosValor;
        private System.Windows.Forms.Label labelPendientesValor;
        private System.Windows.Forms.Label labelOmitidosValor;
        private System.Windows.Forms.Label labelAnuladosValor;
        private System.Windows.Forms.Label labelPromedioValor;
        private System.Windows.Forms.Label labelDetalle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaEspera;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaTipo;

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
            this.panelDetalle = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnaCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaEspera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelDetalle = new System.Windows.Forms.Label();
            this.panelIndicadores = new System.Windows.Forms.Panel();
            this.panelPromedio = new System.Windows.Forms.Panel();
            this.labelPromedioValor = new System.Windows.Forms.Label();
            this.labelPromedioTitulo = new System.Windows.Forms.Label();
            this.panelAnulados = new System.Windows.Forms.Panel();
            this.labelAnuladosValor = new System.Windows.Forms.Label();
            this.labelAnuladosTitulo = new System.Windows.Forms.Label();
            this.panelOmitidos = new System.Windows.Forms.Panel();
            this.labelOmitidosValor = new System.Windows.Forms.Label();
            this.labelOmitidosTitulo = new System.Windows.Forms.Label();
            this.panelPendientes = new System.Windows.Forms.Panel();
            this.labelPendientesValor = new System.Windows.Forms.Label();
            this.labelPendientesTitulo = new System.Windows.Forms.Label();
            this.panelAtendidos = new System.Windows.Forms.Panel();
            this.labelAtendidosValor = new System.Windows.Forms.Label();
            this.labelAtendidosTitulo = new System.Windows.Forms.Label();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.labelTotalValor = new System.Windows.Forms.Label();
            this.labelTotalTitulo = new System.Windows.Forms.Label();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelFechaFinal = new System.Windows.Forms.Label();
            this.labelFechaInicial = new System.Windows.Forms.Label();
            this.labelServicio = new System.Windows.Forms.Label();
            this.labelSucursal = new System.Windows.Forms.Label();
            this.labelFiltros = new System.Windows.Forms.Label();
            this.panelEncabezado.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.panelDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelIndicadores.SuspendLayout();
            this.panelPromedio.SuspendLayout();
            this.panelAnulados.SuspendLayout();
            this.panelOmitidos.SuspendLayout();
            this.panelPendientes.SuspendLayout();
            this.panelAtendidos.SuspendLayout();
            this.panelTotal.SuspendLayout();
            this.panelFiltros.SuspendLayout();
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
            this.panelEncabezado.Size = new System.Drawing.Size(1186, 108);
            this.panelEncabezado.TabIndex = 0;
            // 
            // labelSubtitulo
            // 
            this.labelSubtitulo.AutoSize = true;
            this.labelSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.labelSubtitulo.Location = new System.Drawing.Point(31, 67);
            this.labelSubtitulo.Name = "labelSubtitulo";
            this.labelSubtitulo.Size = new System.Drawing.Size(494, 23);
            this.labelSubtitulo.TabIndex = 1;
            this.labelSubtitulo.Text = "Consulta los resultados y movimientos del sistema TurnoSmarts";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(27, 13);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(416, 50);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Reportes y Estadísticas";
            // 
            // panelContenido
            // 
            this.panelContenido.AutoScroll = true;
            this.panelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.panelContenido.Controls.Add(this.panelDetalle);
            this.panelContenido.Controls.Add(this.panelIndicadores);
            this.panelContenido.Controls.Add(this.panelFiltros);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 108);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Padding = new System.Windows.Forms.Padding(22, 18, 22, 18);
            this.panelContenido.Size = new System.Drawing.Size(1186, 592);
            this.panelContenido.TabIndex = 1;
            // 
            // panelDetalle
            // 
            this.panelDetalle.BackColor = System.Drawing.Color.White;
            this.panelDetalle.Controls.Add(this.dataGridView1);
            this.panelDetalle.Controls.Add(this.labelDetalle);
            this.panelDetalle.Location = new System.Drawing.Point(22, 306);
            this.panelDetalle.Name = "panelDetalle";
            this.panelDetalle.Padding = new System.Windows.Forms.Padding(16, 12, 16, 16);
            this.panelDetalle.Size = new System.Drawing.Size(1038, 390);
            this.panelDetalle.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeight = 36;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaCodigo,
            this.columnaSucursal,
            this.columnaServicio,
            this.columnaFecha,
            this.columnaEstado,
            this.columnaEspera,
            this.columnaTipo});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.dataGridView1.Location = new System.Drawing.Point(16, 53);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 32;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1006, 321);
            this.dataGridView1.TabIndex = 1;
            // 
            // columnaCodigo
            // 
            this.columnaCodigo.HeaderText = "Código de turno";
            this.columnaCodigo.MinimumWidth = 6;
            this.columnaCodigo.Name = "columnaCodigo";
            this.columnaCodigo.ReadOnly = true;
            // 
            // columnaSucursal
            // 
            this.columnaSucursal.HeaderText = "Sucursal";
            this.columnaSucursal.MinimumWidth = 6;
            this.columnaSucursal.Name = "columnaSucursal";
            this.columnaSucursal.ReadOnly = true;
            // 
            // columnaServicio
            // 
            this.columnaServicio.HeaderText = "Servicio o fila";
            this.columnaServicio.MinimumWidth = 6;
            this.columnaServicio.Name = "columnaServicio";
            this.columnaServicio.ReadOnly = true;
            // 
            // columnaFecha
            // 
            this.columnaFecha.HeaderText = "Fecha y hora";
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
            // columnaEspera
            // 
            this.columnaEspera.HeaderText = "Tiempo de espera";
            this.columnaEspera.MinimumWidth = 6;
            this.columnaEspera.Name = "columnaEspera";
            this.columnaEspera.ReadOnly = true;
            // 
            // columnaTipo
            // 
            this.columnaTipo.HeaderText = "Tipo";
            this.columnaTipo.MinimumWidth = 6;
            this.columnaTipo.Name = "columnaTipo";
            this.columnaTipo.ReadOnly = true;
            // 
            // labelDetalle
            // 
            this.labelDetalle.AutoSize = true;
            this.labelDetalle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.labelDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(92)))));
            this.labelDetalle.Location = new System.Drawing.Point(16, 13);
            this.labelDetalle.Name = "labelDetalle";
            this.labelDetalle.Size = new System.Drawing.Size(191, 30);
            this.labelDetalle.TabIndex = 0;
            this.labelDetalle.Text = "Detalle de turnos";
            // 
            // panelIndicadores
            // 
            this.panelIndicadores.BackColor = System.Drawing.Color.Transparent;
            this.panelIndicadores.Controls.Add(this.panelPromedio);
            this.panelIndicadores.Controls.Add(this.panelAnulados);
            this.panelIndicadores.Controls.Add(this.panelOmitidos);
            this.panelIndicadores.Controls.Add(this.panelPendientes);
            this.panelIndicadores.Controls.Add(this.panelAtendidos);
            this.panelIndicadores.Controls.Add(this.panelTotal);
            this.panelIndicadores.Location = new System.Drawing.Point(22, 174);
            this.panelIndicadores.Name = "panelIndicadores";
            this.panelIndicadores.Size = new System.Drawing.Size(1038, 116);
            this.panelIndicadores.TabIndex = 1;
            // 
            // panelPromedio
            // 
            this.panelPromedio.BackColor = System.Drawing.Color.White;
            this.panelPromedio.Controls.Add(this.labelPromedioValor);
            this.panelPromedio.Controls.Add(this.labelPromedioTitulo);
            this.panelPromedio.Location = new System.Drawing.Point(875, 0);
            this.panelPromedio.Name = "panelPromedio";
            this.panelPromedio.Size = new System.Drawing.Size(208, 116);
            this.panelPromedio.TabIndex = 5;
            // 
            // labelPromedioValor
            // 
            this.labelPromedioValor.AutoSize = true;
            this.labelPromedioValor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelPromedioValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(92)))));
            this.labelPromedioValor.Location = new System.Drawing.Point(14, 52);
            this.labelPromedioValor.Name = "labelPromedioValor";
            this.labelPromedioValor.Size = new System.Drawing.Size(153, 29);
            this.labelPromedioValor.TabIndex = 1;
            this.labelPromedioValor.Text = "No disponible";
            // 
            // labelPromedioTitulo
            // 
            this.labelPromedioTitulo.AutoSize = true;
            this.labelPromedioTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelPromedioTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(88)))), ((int)(((byte)(96)))));
            this.labelPromedioTitulo.Location = new System.Drawing.Point(14, 15);
            this.labelPromedioTitulo.Name = "labelPromedioTitulo";
            this.labelPromedioTitulo.Size = new System.Drawing.Size(148, 20);
            this.labelPromedioTitulo.TabIndex = 0;
            this.labelPromedioTitulo.Text = "Promedio de espera";
            // 
            // panelAnulados
            // 
            this.panelAnulados.BackColor = System.Drawing.Color.White;
            this.panelAnulados.Controls.Add(this.labelAnuladosValor);
            this.panelAnulados.Controls.Add(this.labelAnuladosTitulo);
            this.panelAnulados.Location = new System.Drawing.Point(700, 0);
            this.panelAnulados.Name = "panelAnulados";
            this.panelAnulados.Size = new System.Drawing.Size(160, 116);
            this.panelAnulados.TabIndex = 4;
            // 
            // labelAnuladosValor
            // 
            this.labelAnuladosValor.AutoSize = true;
            this.labelAnuladosValor.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.labelAnuladosValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.labelAnuladosValor.Location = new System.Drawing.Point(14, 46);
            this.labelAnuladosValor.Name = "labelAnuladosValor";
            this.labelAnuladosValor.Size = new System.Drawing.Size(46, 54);
            this.labelAnuladosValor.TabIndex = 1;
            this.labelAnuladosValor.Text = "0";
            // 
            // labelAnuladosTitulo
            // 
            this.labelAnuladosTitulo.AutoSize = true;
            this.labelAnuladosTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelAnuladosTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(88)))), ((int)(((byte)(96)))));
            this.labelAnuladosTitulo.Location = new System.Drawing.Point(14, 15);
            this.labelAnuladosTitulo.Name = "labelAnuladosTitulo";
            this.labelAnuladosTitulo.Size = new System.Drawing.Size(124, 20);
            this.labelAnuladosTitulo.TabIndex = 0;
            this.labelAnuladosTitulo.Text = "Turnos anulados";
            // 
            // panelOmitidos
            // 
            this.panelOmitidos.BackColor = System.Drawing.Color.White;
            this.panelOmitidos.Controls.Add(this.labelOmitidosValor);
            this.panelOmitidos.Controls.Add(this.labelOmitidosTitulo);
            this.panelOmitidos.Location = new System.Drawing.Point(525, 0);
            this.panelOmitidos.Name = "panelOmitidos";
            this.panelOmitidos.Size = new System.Drawing.Size(160, 116);
            this.panelOmitidos.TabIndex = 3;
            // 
            // labelOmitidosValor
            // 
            this.labelOmitidosValor.AutoSize = true;
            this.labelOmitidosValor.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.labelOmitidosValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.labelOmitidosValor.Location = new System.Drawing.Point(14, 46);
            this.labelOmitidosValor.Name = "labelOmitidosValor";
            this.labelOmitidosValor.Size = new System.Drawing.Size(46, 54);
            this.labelOmitidosValor.TabIndex = 1;
            this.labelOmitidosValor.Text = "0";
            // 
            // labelOmitidosTitulo
            // 
            this.labelOmitidosTitulo.AutoSize = true;
            this.labelOmitidosTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelOmitidosTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(88)))), ((int)(((byte)(96)))));
            this.labelOmitidosTitulo.Location = new System.Drawing.Point(14, 15);
            this.labelOmitidosTitulo.Name = "labelOmitidosTitulo";
            this.labelOmitidosTitulo.Size = new System.Drawing.Size(123, 20);
            this.labelOmitidosTitulo.TabIndex = 0;
            this.labelOmitidosTitulo.Text = "Turnos omitidos";
            // 
            // panelPendientes
            // 
            this.panelPendientes.BackColor = System.Drawing.Color.White;
            this.panelPendientes.Controls.Add(this.labelPendientesValor);
            this.panelPendientes.Controls.Add(this.labelPendientesTitulo);
            this.panelPendientes.Location = new System.Drawing.Point(350, 0);
            this.panelPendientes.Name = "panelPendientes";
            this.panelPendientes.Size = new System.Drawing.Size(160, 116);
            this.panelPendientes.TabIndex = 2;
            // 
            // labelPendientesValor
            // 
            this.labelPendientesValor.AutoSize = true;
            this.labelPendientesValor.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.labelPendientesValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(142)))), ((int)(((byte)(31)))));
            this.labelPendientesValor.Location = new System.Drawing.Point(14, 46);
            this.labelPendientesValor.Name = "labelPendientesValor";
            this.labelPendientesValor.Size = new System.Drawing.Size(46, 54);
            this.labelPendientesValor.TabIndex = 1;
            this.labelPendientesValor.Text = "0";
            // 
            // labelPendientesTitulo
            // 
            this.labelPendientesTitulo.AutoSize = true;
            this.labelPendientesTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelPendientesTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(88)))), ((int)(((byte)(96)))));
            this.labelPendientesTitulo.Location = new System.Drawing.Point(14, 15);
            this.labelPendientesTitulo.Name = "labelPendientesTitulo";
            this.labelPendientesTitulo.Size = new System.Drawing.Size(138, 20);
            this.labelPendientesTitulo.TabIndex = 0;
            this.labelPendientesTitulo.Text = "Turnos pendientes";
            // 
            // panelAtendidos
            // 
            this.panelAtendidos.BackColor = System.Drawing.Color.White;
            this.panelAtendidos.Controls.Add(this.labelAtendidosValor);
            this.panelAtendidos.Controls.Add(this.labelAtendidosTitulo);
            this.panelAtendidos.Location = new System.Drawing.Point(175, 0);
            this.panelAtendidos.Name = "panelAtendidos";
            this.panelAtendidos.Size = new System.Drawing.Size(160, 116);
            this.panelAtendidos.TabIndex = 1;
            // 
            // labelAtendidosValor
            // 
            this.labelAtendidosValor.AutoSize = true;
            this.labelAtendidosValor.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.labelAtendidosValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(120)))), ((int)(((byte)(85)))));
            this.labelAtendidosValor.Location = new System.Drawing.Point(14, 46);
            this.labelAtendidosValor.Name = "labelAtendidosValor";
            this.labelAtendidosValor.Size = new System.Drawing.Size(46, 54);
            this.labelAtendidosValor.TabIndex = 1;
            this.labelAtendidosValor.Text = "0";
            // 
            // labelAtendidosTitulo
            // 
            this.labelAtendidosTitulo.AutoSize = true;
            this.labelAtendidosTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelAtendidosTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(88)))), ((int)(((byte)(96)))));
            this.labelAtendidosTitulo.Location = new System.Drawing.Point(14, 15);
            this.labelAtendidosTitulo.Name = "labelAtendidosTitulo";
            this.labelAtendidosTitulo.Size = new System.Drawing.Size(130, 20);
            this.labelAtendidosTitulo.TabIndex = 0;
            this.labelAtendidosTitulo.Text = "Turnos atendidos";
            // 
            // panelTotal
            // 
            this.panelTotal.BackColor = System.Drawing.Color.White;
            this.panelTotal.Controls.Add(this.labelTotalValor);
            this.panelTotal.Controls.Add(this.labelTotalTitulo);
            this.panelTotal.Location = new System.Drawing.Point(0, 0);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(160, 116);
            this.panelTotal.TabIndex = 0;
            // 
            // labelTotalValor
            // 
            this.labelTotalValor.AutoSize = true;
            this.labelTotalValor.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.labelTotalValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(92)))));
            this.labelTotalValor.Location = new System.Drawing.Point(14, 46);
            this.labelTotalValor.Name = "labelTotalValor";
            this.labelTotalValor.Size = new System.Drawing.Size(46, 54);
            this.labelTotalValor.TabIndex = 1;
            this.labelTotalValor.Text = "0";
            // 
            // labelTotalTitulo
            // 
            this.labelTotalTitulo.AutoSize = true;
            this.labelTotalTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelTotalTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(88)))), ((int)(((byte)(96)))));
            this.labelTotalTitulo.Location = new System.Drawing.Point(14, 15);
            this.labelTotalTitulo.Name = "labelTotalTitulo";
            this.labelTotalTitulo.Size = new System.Drawing.Size(115, 20);
            this.labelTotalTitulo.TabIndex = 0;
            this.labelTotalTitulo.Text = "Total de turnos";
            // 
            // panelFiltros
            // 
            this.panelFiltros.BackColor = System.Drawing.Color.White;
            this.panelFiltros.Controls.Add(this.button3);
            this.panelFiltros.Controls.Add(this.button2);
            this.panelFiltros.Controls.Add(this.button1);
            this.panelFiltros.Controls.Add(this.comboBox3);
            this.panelFiltros.Controls.Add(this.dateTimePicker2);
            this.panelFiltros.Controls.Add(this.dateTimePicker1);
            this.panelFiltros.Controls.Add(this.comboBox2);
            this.panelFiltros.Controls.Add(this.comboBox1);
            this.panelFiltros.Controls.Add(this.labelEstado);
            this.panelFiltros.Controls.Add(this.labelFechaFinal);
            this.panelFiltros.Controls.Add(this.labelFechaInicial);
            this.panelFiltros.Controls.Add(this.labelServicio);
            this.panelFiltros.Controls.Add(this.labelSucursal);
            this.panelFiltros.Controls.Add(this.labelFiltros);
            this.panelFiltros.Location = new System.Drawing.Point(22, 18);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.panelFiltros.Size = new System.Drawing.Size(1038, 140);
            this.panelFiltros.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(852, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 25);
            this.button3.TabIndex = 13;
            this.button3.Text = "Limpiar filtros";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(120)))), ((int)(((byte)(85)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(940, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 33);
            this.button2.TabIndex = 12;
            this.button2.Text = "Exportar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(88)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(852, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(708, 75);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(130, 29);
            this.comboBox3.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(550, 75);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(142, 29);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(392, 75);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(142, 29);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(204, 75);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(170, 29);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.comboBox2_Format);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 29);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.comboBox1_Format);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelEstado.Location = new System.Drawing.Point(708, 51);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(56, 20);
            this.labelEstado.TabIndex = 5;
            this.labelEstado.Text = "Estado";
            // 
            // labelFechaFinal
            // 
            this.labelFechaFinal.AutoSize = true;
            this.labelFechaFinal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelFechaFinal.Location = new System.Drawing.Point(550, 51);
            this.labelFechaFinal.Name = "labelFechaFinal";
            this.labelFechaFinal.Size = new System.Drawing.Size(84, 20);
            this.labelFechaFinal.TabIndex = 4;
            this.labelFechaFinal.Text = "Fecha final";
            // 
            // labelFechaInicial
            // 
            this.labelFechaInicial.AutoSize = true;
            this.labelFechaInicial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelFechaInicial.Location = new System.Drawing.Point(392, 51);
            this.labelFechaInicial.Name = "labelFechaInicial";
            this.labelFechaInicial.Size = new System.Drawing.Size(93, 20);
            this.labelFechaInicial.TabIndex = 3;
            this.labelFechaInicial.Text = "Fecha inicial";
            // 
            // labelServicio
            // 
            this.labelServicio.AutoSize = true;
            this.labelServicio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelServicio.Location = new System.Drawing.Point(204, 51);
            this.labelServicio.Name = "labelServicio";
            this.labelServicio.Size = new System.Drawing.Size(103, 20);
            this.labelServicio.TabIndex = 2;
            this.labelServicio.Text = "Servicio o fila";
            // 
            // labelSucursal
            // 
            this.labelSucursal.AutoSize = true;
            this.labelSucursal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelSucursal.Location = new System.Drawing.Point(16, 51);
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
            this.labelFiltros.Location = new System.Drawing.Point(16, 12);
            this.labelFiltros.Name = "labelFiltros";
            this.labelFiltros.Size = new System.Drawing.Size(77, 30);
            this.labelFiltros.TabIndex = 0;
            this.labelFiltros.Text = "Filtros";
            // 
            // Frm_Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1186, 700);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelEncabezado);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "Frm_Reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes y Estadísticas - TurnoSmarts";
            this.panelEncabezado.ResumeLayout(false);
            this.panelEncabezado.PerformLayout();
            this.panelContenido.ResumeLayout(false);
            this.panelDetalle.ResumeLayout(false);
            this.panelDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelIndicadores.ResumeLayout(false);
            this.panelPromedio.ResumeLayout(false);
            this.panelPromedio.PerformLayout();
            this.panelAnulados.ResumeLayout(false);
            this.panelAnulados.PerformLayout();
            this.panelOmitidos.ResumeLayout(false);
            this.panelOmitidos.PerformLayout();
            this.panelPendientes.ResumeLayout(false);
            this.panelPendientes.PerformLayout();
            this.panelAtendidos.ResumeLayout(false);
            this.panelAtendidos.PerformLayout();
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
