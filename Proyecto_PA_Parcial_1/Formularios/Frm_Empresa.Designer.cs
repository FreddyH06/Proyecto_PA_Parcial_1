namespace Proyecto_PA_Parcial_1.Formularios
{
    partial class Frm_Empresa
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelEncabezado;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelSubtitulo;
        private System.Windows.Forms.Label labelPermisos;
        private System.Windows.Forms.GroupBox groupBoxEmpresa;
        private System.Windows.Forms.Label labelRuc;
        private System.Windows.Forms.Label labelRazonSocial;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.TextBox textBoxRuc;
        private System.Windows.Forms.TextBox textBoxRazonSocial;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.GroupBox groupBoxCamposObligatorios;
        private System.Windows.Forms.Label labelCamposObligatorios;
        private System.Windows.Forms.CheckBox checkBoxCedula;
        private System.Windows.Forms.CheckBox checkBoxNombre;
        private System.Windows.Forms.CheckBox checkBoxCorreo;
        private System.Windows.Forms.CheckBox checkBoxTelefono;
        private System.Windows.Forms.GroupBox groupBoxCorreo;
        private System.Windows.Forms.Label labelSmtpServidor;
        private System.Windows.Forms.Label labelSmtpPuerto;
        private System.Windows.Forms.Label labelSmtpUsuario;
        private System.Windows.Forms.Label labelSmtpSsl;
        private System.Windows.Forms.Label labelAppId;
        private System.Windows.Forms.Label labelTenantId;
        private System.Windows.Forms.Label labelAyudaCorreo;
        private System.Windows.Forms.TextBox textBoxSmtpServidor;
        private System.Windows.Forms.NumericUpDown numericUpDownSmtpPuerto;
        private System.Windows.Forms.TextBox textBoxSmtpUsuario;
        private System.Windows.Forms.CheckBox checkBoxSmtpSsl;
        private System.Windows.Forms.TextBox textBoxAppId;
        private System.Windows.Forms.TextBox textBoxTenantId;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonComprobar;

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
            this.labelPermisos = new System.Windows.Forms.Label();
            this.labelSubtitulo = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.buttonComprobar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.groupBoxCorreo = new System.Windows.Forms.GroupBox();
            this.labelAyudaCorreo = new System.Windows.Forms.Label();
            this.textBoxTenantId = new System.Windows.Forms.TextBox();
            this.textBoxAppId = new System.Windows.Forms.TextBox();
            this.checkBoxSmtpSsl = new System.Windows.Forms.CheckBox();
            this.textBoxSmtpUsuario = new System.Windows.Forms.TextBox();
            this.numericUpDownSmtpPuerto = new System.Windows.Forms.NumericUpDown();
            this.textBoxSmtpServidor = new System.Windows.Forms.TextBox();
            this.labelTenantId = new System.Windows.Forms.Label();
            this.labelAppId = new System.Windows.Forms.Label();
            this.labelSmtpSsl = new System.Windows.Forms.Label();
            this.labelSmtpUsuario = new System.Windows.Forms.Label();
            this.labelSmtpPuerto = new System.Windows.Forms.Label();
            this.labelSmtpServidor = new System.Windows.Forms.Label();
            this.groupBoxCamposObligatorios = new System.Windows.Forms.GroupBox();
            this.checkBoxTelefono = new System.Windows.Forms.CheckBox();
            this.checkBoxCorreo = new System.Windows.Forms.CheckBox();
            this.checkBoxNombre = new System.Windows.Forms.CheckBox();
            this.checkBoxCedula = new System.Windows.Forms.CheckBox();
            this.labelCamposObligatorios = new System.Windows.Forms.Label();
            this.groupBoxEmpresa = new System.Windows.Forms.GroupBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.textBoxRazonSocial = new System.Windows.Forms.TextBox();
            this.textBoxRuc = new System.Windows.Forms.TextBox();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.labelRazonSocial = new System.Windows.Forms.Label();
            this.labelRuc = new System.Windows.Forms.Label();
            this.panelEncabezado.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.groupBoxCorreo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSmtpPuerto)).BeginInit();
            this.groupBoxCamposObligatorios.SuspendLayout();
            this.groupBoxEmpresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEncabezado
            // 
            this.panelEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(55)))), ((int)(((byte)(86)))));
            this.panelEncabezado.Controls.Add(this.labelPermisos);
            this.panelEncabezado.Controls.Add(this.labelSubtitulo);
            this.panelEncabezado.Controls.Add(this.labelTitulo);
            this.panelEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEncabezado.Location = new System.Drawing.Point(0, 0);
            this.panelEncabezado.Name = "panelEncabezado";
            this.panelEncabezado.Padding = new System.Windows.Forms.Padding(28, 18, 28, 14);
            this.panelEncabezado.Size = new System.Drawing.Size(1040, 112);
            this.panelEncabezado.TabIndex = 0;
            // 
            // labelPermisos
            // 
            this.labelPermisos.AutoSize = true;
            this.labelPermisos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPermisos.ForeColor = System.Drawing.Color.White;
            this.labelPermisos.Location = new System.Drawing.Point(665, 70);
            this.labelPermisos.Name = "labelPermisos";
            this.labelPermisos.Size = new System.Drawing.Size(324, 20);
            this.labelPermisos.TabIndex = 2;
            this.labelPermisos.Text = "Configuración disponible para administradores.";
            // 
            // labelSubtitulo
            // 
            this.labelSubtitulo.AutoSize = true;
            this.labelSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.labelSubtitulo.Location = new System.Drawing.Point(31, 68);
            this.labelSubtitulo.Name = "labelSubtitulo";
            this.labelSubtitulo.Size = new System.Drawing.Size(404, 23);
            this.labelSubtitulo.TabIndex = 1;
            this.labelSubtitulo.Text = "Administra la identidad y los canales institucionales.";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(27, 17);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(480, 50);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Configuración de Empresa";
            // 
            // panelContenido
            // 
            this.panelContenido.AutoScroll = true;
            this.panelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.panelContenido.Controls.Add(this.buttonComprobar);
            this.panelContenido.Controls.Add(this.buttonGuardar);
            this.panelContenido.Controls.Add(this.groupBoxCorreo);
            this.panelContenido.Controls.Add(this.groupBoxCamposObligatorios);
            this.panelContenido.Controls.Add(this.groupBoxEmpresa);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 112);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Padding = new System.Windows.Forms.Padding(28, 24, 28, 24);
            this.panelContenido.Size = new System.Drawing.Size(1040, 628);
            this.panelContenido.TabIndex = 1;
            // 
            // buttonComprobar
            // 
            this.buttonComprobar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(88)))), ((int)(((byte)(128)))));
            this.buttonComprobar.FlatAppearance.BorderSize = 0;
            this.buttonComprobar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComprobar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonComprobar.ForeColor = System.Drawing.Color.White;
            this.buttonComprobar.Location = new System.Drawing.Point(507, 568);
            this.buttonComprobar.Name = "buttonComprobar";
            this.buttonComprobar.Size = new System.Drawing.Size(190, 42);
            this.buttonComprobar.TabIndex = 4;
            this.buttonComprobar.Text = "Comprobar configuración";
            this.buttonComprobar.UseVisualStyleBackColor = false;
            this.buttonComprobar.Click += new System.EventHandler(this.buttonComprobar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(120)))), ((int)(((byte)(85)))));
            this.buttonGuardar.FlatAppearance.BorderSize = 0;
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonGuardar.ForeColor = System.Drawing.Color.White;
            this.buttonGuardar.Location = new System.Drawing.Point(718, 568);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(190, 42);
            this.buttonGuardar.TabIndex = 3;
            this.buttonGuardar.Text = "Guardar configuración";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // groupBoxCorreo
            // 
            this.groupBoxCorreo.BackColor = System.Drawing.Color.White;
            this.groupBoxCorreo.Controls.Add(this.labelAyudaCorreo);
            this.groupBoxCorreo.Controls.Add(this.textBoxTenantId);
            this.groupBoxCorreo.Controls.Add(this.textBoxAppId);
            this.groupBoxCorreo.Controls.Add(this.checkBoxSmtpSsl);
            this.groupBoxCorreo.Controls.Add(this.textBoxSmtpUsuario);
            this.groupBoxCorreo.Controls.Add(this.numericUpDownSmtpPuerto);
            this.groupBoxCorreo.Controls.Add(this.textBoxSmtpServidor);
            this.groupBoxCorreo.Controls.Add(this.labelTenantId);
            this.groupBoxCorreo.Controls.Add(this.labelAppId);
            this.groupBoxCorreo.Controls.Add(this.labelSmtpSsl);
            this.groupBoxCorreo.Controls.Add(this.labelSmtpUsuario);
            this.groupBoxCorreo.Controls.Add(this.labelSmtpPuerto);
            this.groupBoxCorreo.Controls.Add(this.labelSmtpServidor);
            this.groupBoxCorreo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxCorreo.Location = new System.Drawing.Point(28, 323);
            this.groupBoxCorreo.Name = "groupBoxCorreo";
            this.groupBoxCorreo.Size = new System.Drawing.Size(984, 220);
            this.groupBoxCorreo.TabIndex = 2;
            this.groupBoxCorreo.TabStop = false;
            this.groupBoxCorreo.Text = "Configuración de correo institucional";
            // 
            // labelAyudaCorreo
            // 
            this.labelAyudaCorreo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.labelAyudaCorreo.ForeColor = System.Drawing.Color.DimGray;
            this.labelAyudaCorreo.Location = new System.Drawing.Point(24, 163);
            this.labelAyudaCorreo.Name = "labelAyudaCorreo";
            this.labelAyudaCorreo.Size = new System.Drawing.Size(924, 42);
            this.labelAyudaCorreo.TabIndex = 12;
            this.labelAyudaCorreo.Text = "Estos datos se conservarán únicamente en memoria. No incluya contraseñas ni token" +
    "s aquí. El envío real para confirmaciones y recordatorios se implementará median" +
    "te un servicio autorizado.";
            // 
            // textBoxTenantId
            // 
            this.textBoxTenantId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxTenantId.Location = new System.Drawing.Point(667, 121);
            this.textBoxTenantId.Name = "textBoxTenantId";
            this.textBoxTenantId.Size = new System.Drawing.Size(294, 30);
            this.textBoxTenantId.TabIndex = 11;
            // 
            // textBoxAppId
            // 
            this.textBoxAppId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxAppId.Location = new System.Drawing.Point(184, 121);
            this.textBoxAppId.Name = "textBoxAppId";
            this.textBoxAppId.Size = new System.Drawing.Size(280, 30);
            this.textBoxAppId.TabIndex = 9;
            // 
            // checkBoxSmtpSsl
            // 
            this.checkBoxSmtpSsl.AutoSize = true;
            this.checkBoxSmtpSsl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBoxSmtpSsl.Location = new System.Drawing.Point(603, 79);
            this.checkBoxSmtpSsl.Name = "checkBoxSmtpSsl";
            this.checkBoxSmtpSsl.Size = new System.Drawing.Size(190, 24);
            this.checkBoxSmtpSsl.TabIndex = 7;
            this.checkBoxSmtpSsl.Text = "Usar SSL/TLS disponible";
            this.checkBoxSmtpSsl.UseVisualStyleBackColor = true;
            // 
            // textBoxSmtpUsuario
            // 
            this.textBoxSmtpUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxSmtpUsuario.Location = new System.Drawing.Point(165, 77);
            this.textBoxSmtpUsuario.Name = "textBoxSmtpUsuario";
            this.textBoxSmtpUsuario.Size = new System.Drawing.Size(280, 30);
            this.textBoxSmtpUsuario.TabIndex = 5;
            // 
            // numericUpDownSmtpPuerto
            // 
            this.numericUpDownSmtpPuerto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numericUpDownSmtpPuerto.Location = new System.Drawing.Point(603, 33);
            this.numericUpDownSmtpPuerto.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownSmtpPuerto.Name = "numericUpDownSmtpPuerto";
            this.numericUpDownSmtpPuerto.Size = new System.Drawing.Size(125, 30);
            this.numericUpDownSmtpPuerto.TabIndex = 3;
            // 
            // textBoxSmtpServidor
            // 
            this.textBoxSmtpServidor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxSmtpServidor.Location = new System.Drawing.Point(165, 33);
            this.textBoxSmtpServidor.Name = "textBoxSmtpServidor";
            this.textBoxSmtpServidor.Size = new System.Drawing.Size(280, 30);
            this.textBoxSmtpServidor.TabIndex = 1;
            // 
            // labelTenantId
            // 
            this.labelTenantId.AutoSize = true;
            this.labelTenantId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelTenantId.Location = new System.Drawing.Point(492, 125);
            this.labelTenantId.Name = "labelTenantId";
            this.labelTenantId.Size = new System.Drawing.Size(170, 20);
            this.labelTenantId.TabIndex = 10;
            this.labelTenantId.Text = "Microsoft 365 Tenant ID:";
            // 
            // labelAppId
            // 
            this.labelAppId.AutoSize = true;
            this.labelAppId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelAppId.Location = new System.Drawing.Point(24, 125);
            this.labelAppId.Name = "labelAppId";
            this.labelAppId.Size = new System.Drawing.Size(154, 20);
            this.labelAppId.TabIndex = 8;
            this.labelAppId.Text = "Microsoft 365 App ID:";
            // 
            // labelSmtpSsl
            // 
            this.labelSmtpSsl.AutoSize = true;
            this.labelSmtpSsl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelSmtpSsl.Location = new System.Drawing.Point(492, 81);
            this.labelSmtpSsl.Name = "labelSmtpSsl";
            this.labelSmtpSsl.Size = new System.Drawing.Size(80, 20);
            this.labelSmtpSsl.TabIndex = 6;
            this.labelSmtpSsl.Text = "Seguridad:";
            // 
            // labelSmtpUsuario
            // 
            this.labelSmtpUsuario.AutoSize = true;
            this.labelSmtpUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelSmtpUsuario.Location = new System.Drawing.Point(24, 81);
            this.labelSmtpUsuario.Name = "labelSmtpUsuario";
            this.labelSmtpUsuario.Size = new System.Drawing.Size(103, 20);
            this.labelSmtpUsuario.TabIndex = 4;
            this.labelSmtpUsuario.Text = "Usuario SMTP:";
            // 
            // labelSmtpPuerto
            // 
            this.labelSmtpPuerto.AutoSize = true;
            this.labelSmtpPuerto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelSmtpPuerto.Location = new System.Drawing.Point(492, 37);
            this.labelSmtpPuerto.Name = "labelSmtpPuerto";
            this.labelSmtpPuerto.Size = new System.Drawing.Size(55, 20);
            this.labelSmtpPuerto.TabIndex = 2;
            this.labelSmtpPuerto.Text = "Puerto:";
            // 
            // labelSmtpServidor
            // 
            this.labelSmtpServidor.AutoSize = true;
            this.labelSmtpServidor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelSmtpServidor.Location = new System.Drawing.Point(24, 37);
            this.labelSmtpServidor.Name = "labelSmtpServidor";
            this.labelSmtpServidor.Size = new System.Drawing.Size(108, 20);
            this.labelSmtpServidor.TabIndex = 0;
            this.labelSmtpServidor.Text = "Servidor SMTP:";
            // 
            // groupBoxCamposObligatorios
            // 
            this.groupBoxCamposObligatorios.BackColor = System.Drawing.Color.White;
            this.groupBoxCamposObligatorios.Controls.Add(this.checkBoxTelefono);
            this.groupBoxCamposObligatorios.Controls.Add(this.checkBoxCorreo);
            this.groupBoxCamposObligatorios.Controls.Add(this.checkBoxNombre);
            this.groupBoxCamposObligatorios.Controls.Add(this.checkBoxCedula);
            this.groupBoxCamposObligatorios.Controls.Add(this.labelCamposObligatorios);
            this.groupBoxCamposObligatorios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxCamposObligatorios.Location = new System.Drawing.Point(28, 183);
            this.groupBoxCamposObligatorios.Name = "groupBoxCamposObligatorios";
            this.groupBoxCamposObligatorios.Size = new System.Drawing.Size(984, 122);
            this.groupBoxCamposObligatorios.TabIndex = 1;
            this.groupBoxCamposObligatorios.TabStop = false;
            this.groupBoxCamposObligatorios.Text = "Datos obligatorios para turnos y citas";
            // 
            // checkBoxTelefono
            // 
            this.checkBoxTelefono.AutoSize = true;
            this.checkBoxTelefono.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBoxTelefono.Location = new System.Drawing.Point(615, 65);
            this.checkBoxTelefono.Name = "checkBoxTelefono";
            this.checkBoxTelefono.Size = new System.Drawing.Size(89, 24);
            this.checkBoxTelefono.TabIndex = 4;
            this.checkBoxTelefono.Text = "Teléfono";
            this.checkBoxTelefono.UseVisualStyleBackColor = true;
            // 
            // checkBoxCorreo
            // 
            this.checkBoxCorreo.AutoSize = true;
            this.checkBoxCorreo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBoxCorreo.Location = new System.Drawing.Point(420, 65);
            this.checkBoxCorreo.Name = "checkBoxCorreo";
            this.checkBoxCorreo.Size = new System.Drawing.Size(76, 24);
            this.checkBoxCorreo.TabIndex = 3;
            this.checkBoxCorreo.Text = "Correo";
            this.checkBoxCorreo.UseVisualStyleBackColor = true;
            // 
            // checkBoxNombre
            // 
            this.checkBoxNombre.AutoSize = true;
            this.checkBoxNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBoxNombre.Location = new System.Drawing.Point(220, 65);
            this.checkBoxNombre.Name = "checkBoxNombre";
            this.checkBoxNombre.Size = new System.Drawing.Size(86, 24);
            this.checkBoxNombre.TabIndex = 2;
            this.checkBoxNombre.Text = "Nombre";
            this.checkBoxNombre.UseVisualStyleBackColor = true;
            // 
            // checkBoxCedula
            // 
            this.checkBoxCedula.AutoSize = true;
            this.checkBoxCedula.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBoxCedula.Location = new System.Drawing.Point(27, 65);
            this.checkBoxCedula.Name = "checkBoxCedula";
            this.checkBoxCedula.Size = new System.Drawing.Size(77, 24);
            this.checkBoxCedula.TabIndex = 1;
            this.checkBoxCedula.Text = "Cédula";
            this.checkBoxCedula.UseVisualStyleBackColor = true;
            // 
            // labelCamposObligatorios
            // 
            this.labelCamposObligatorios.AutoSize = true;
            this.labelCamposObligatorios.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelCamposObligatorios.ForeColor = System.Drawing.Color.DimGray;
            this.labelCamposObligatorios.Location = new System.Drawing.Point(24, 29);
            this.labelCamposObligatorios.Name = "labelCamposObligatorios";
            this.labelCamposObligatorios.Size = new System.Drawing.Size(508, 20);
            this.labelCamposObligatorios.TabIndex = 0;
            this.labelCamposObligatorios.Text = "Seleccione los datos que deberán solicitarse al registrar un turno o una cita.";
            // 
            // groupBoxEmpresa
            // 
            this.groupBoxEmpresa.BackColor = System.Drawing.Color.White;
            this.groupBoxEmpresa.Controls.Add(this.textBoxCorreo);
            this.groupBoxEmpresa.Controls.Add(this.textBoxRazonSocial);
            this.groupBoxEmpresa.Controls.Add(this.textBoxRuc);
            this.groupBoxEmpresa.Controls.Add(this.labelCorreo);
            this.groupBoxEmpresa.Controls.Add(this.labelRazonSocial);
            this.groupBoxEmpresa.Controls.Add(this.labelRuc);
            this.groupBoxEmpresa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxEmpresa.Location = new System.Drawing.Point(28, 24);
            this.groupBoxEmpresa.Name = "groupBoxEmpresa";
            this.groupBoxEmpresa.Size = new System.Drawing.Size(984, 145);
            this.groupBoxEmpresa.TabIndex = 0;
            this.groupBoxEmpresa.TabStop = false;
            this.groupBoxEmpresa.Text = "Datos institucionales";
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxCorreo.Location = new System.Drawing.Point(165, 87);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(783, 30);
            this.textBoxCorreo.TabIndex = 5;
            this.textBoxCorreo.Text = "fherrera3@utmachala.edu.ec";
            // 
            // textBoxRazonSocial
            // 
            this.textBoxRazonSocial.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxRazonSocial.Location = new System.Drawing.Point(603, 35);
            this.textBoxRazonSocial.Name = "textBoxRazonSocial";
            this.textBoxRazonSocial.Size = new System.Drawing.Size(345, 30);
            this.textBoxRazonSocial.TabIndex = 3;
            // 
            // textBoxRuc
            // 
            this.textBoxRuc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxRuc.Location = new System.Drawing.Point(165, 35);
            this.textBoxRuc.Name = "textBoxRuc";
            this.textBoxRuc.Size = new System.Drawing.Size(280, 30);
            this.textBoxRuc.TabIndex = 1;
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelCorreo.Location = new System.Drawing.Point(24, 91);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(141, 20);
            this.labelCorreo.TabIndex = 4;
            this.labelCorreo.Text = "Correo institucional:";
            // 
            // labelRazonSocial
            // 
            this.labelRazonSocial.AutoSize = true;
            this.labelRazonSocial.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelRazonSocial.Location = new System.Drawing.Point(492, 39);
            this.labelRazonSocial.Name = "labelRazonSocial";
            this.labelRazonSocial.Size = new System.Drawing.Size(95, 20);
            this.labelRazonSocial.TabIndex = 2;
            this.labelRazonSocial.Text = "Razón social:";
            // 
            // labelRuc
            // 
            this.labelRuc.AutoSize = true;
            this.labelRuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelRuc.Location = new System.Drawing.Point(24, 39);
            this.labelRuc.Name = "labelRuc";
            this.labelRuc.Size = new System.Drawing.Size(40, 20);
            this.labelRuc.TabIndex = 0;
            this.labelRuc.Text = "RUC:";
            // 
            // Frm_Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1040, 740);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelEncabezado);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(900, 650);
            this.Name = "Frm_Empresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración de Empresa - TurnoSmarts";
            this.panelEncabezado.ResumeLayout(false);
            this.panelEncabezado.PerformLayout();
            this.panelContenido.ResumeLayout(false);
            this.groupBoxCorreo.ResumeLayout(false);
            this.groupBoxCorreo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSmtpPuerto)).EndInit();
            this.groupBoxCamposObligatorios.ResumeLayout(false);
            this.groupBoxCamposObligatorios.PerformLayout();
            this.groupBoxEmpresa.ResumeLayout(false);
            this.groupBoxEmpresa.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
