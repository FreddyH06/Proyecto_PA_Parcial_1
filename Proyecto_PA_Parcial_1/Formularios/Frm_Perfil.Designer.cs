namespace Proyecto_PA_Parcial_1.Formularios
{
    partial class Frm_Perfil
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelEncabezado;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelSubtitulo;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Panel panelPersonal;
        private System.Windows.Forms.Panel panelSeguridad;
        private System.Windows.Forms.Label labelPersonal;
        private System.Windows.Forms.Label labelSeguridad;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelRol;
        private System.Windows.Forms.Label labelSucursal;
        private System.Windows.Forms.Label labelVentanilla;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelRolValor;
        private System.Windows.Forms.Label labelSucursalValor;
        private System.Windows.Forms.Label labelVentanillaValor;
        private System.Windows.Forms.Label labelEstadoValor;
        private System.Windows.Forms.Label labelContraseñaActual;
        private System.Windows.Forms.Label labelNuevaContraseña;
        private System.Windows.Forms.Label labelConfirmarContraseña;
        private System.Windows.Forms.Label labelInformativo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;

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
            this.panelSeguridad = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelInformativo = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.labelConfirmarContraseña = new System.Windows.Forms.Label();
            this.labelNuevaContraseña = new System.Windows.Forms.Label();
            this.labelContraseñaActual = new System.Windows.Forms.Label();
            this.labelSeguridad = new System.Windows.Forms.Label();
            this.panelPersonal = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelEstadoValor = new System.Windows.Forms.Label();
            this.labelVentanillaValor = new System.Windows.Forms.Label();
            this.labelSucursalValor = new System.Windows.Forms.Label();
            this.labelRolValor = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelVentanilla = new System.Windows.Forms.Label();
            this.labelSucursal = new System.Windows.Forms.Label();
            this.labelRol = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPersonal = new System.Windows.Forms.Label();
            this.panelEncabezado.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.panelSeguridad.SuspendLayout();
            this.panelPersonal.SuspendLayout();
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
            this.panelEncabezado.Size = new System.Drawing.Size(950, 108);
            this.panelEncabezado.TabIndex = 0;
            // 
            // labelSubtitulo
            // 
            this.labelSubtitulo.AutoSize = true;
            this.labelSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.labelSubtitulo.Location = new System.Drawing.Point(31, 68);
            this.labelSubtitulo.Name = "labelSubtitulo";
            this.labelSubtitulo.Size = new System.Drawing.Size(550, 23);
            this.labelSubtitulo.TabIndex = 1;
            this.labelSubtitulo.Text = "Consulta y actualiza tu información personal y seguridad de la cuenta";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(27, 14);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(157, 50);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Mi Perfil";
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.panelContenido.Controls.Add(this.panelSeguridad);
            this.panelContenido.Controls.Add(this.panelPersonal);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 108);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Padding = new System.Windows.Forms.Padding(24, 22, 24, 22);
            this.panelContenido.Size = new System.Drawing.Size(950, 542);
            this.panelContenido.TabIndex = 1;
            // 
            // panelSeguridad
            // 
            this.panelSeguridad.BackColor = System.Drawing.Color.White;
            this.panelSeguridad.Controls.Add(this.button4);
            this.panelSeguridad.Controls.Add(this.button3);
            this.panelSeguridad.Controls.Add(this.labelInformativo);
            this.panelSeguridad.Controls.Add(this.textBox7);
            this.panelSeguridad.Controls.Add(this.textBox6);
            this.panelSeguridad.Controls.Add(this.textBox5);
            this.panelSeguridad.Controls.Add(this.labelConfirmarContraseña);
            this.panelSeguridad.Controls.Add(this.labelNuevaContraseña);
            this.panelSeguridad.Controls.Add(this.labelContraseñaActual);
            this.panelSeguridad.Controls.Add(this.labelSeguridad);
            this.panelSeguridad.Location = new System.Drawing.Point(470, 22);
            this.panelSeguridad.Name = "panelSeguridad";
            this.panelSeguridad.Padding = new System.Windows.Forms.Padding(22, 18, 22, 18);
            this.panelSeguridad.Size = new System.Drawing.Size(456, 498);
            this.panelSeguridad.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(236, 388);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(190, 42);
            this.button4.TabIndex = 10;
            this.button4.Text = "Limpiar contraseñas";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(88)))), ((int)(((byte)(128)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(22, 388);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 42);
            this.button3.TabIndex = 9;
            this.button3.Text = "Cambiar contraseña";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelInformativo
            // 
            this.labelInformativo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.labelInformativo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelInformativo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.labelInformativo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(92)))));
            this.labelInformativo.Location = new System.Drawing.Point(22, 302);
            this.labelInformativo.Name = "labelInformativo";
            this.labelInformativo.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.labelInformativo.Size = new System.Drawing.Size(404, 62);
            this.labelInformativo.TabIndex = 8;
            this.labelInformativo.Text = "Tu contraseña es personal. No la compartas\r\ncon otros usuarios.";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox7.Location = new System.Drawing.Point(22, 258);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(404, 30);
            this.textBox7.TabIndex = 7;
            this.textBox7.UseSystemPasswordChar = true;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox6.Location = new System.Drawing.Point(22, 194);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(404, 30);
            this.textBox6.TabIndex = 5;
            this.textBox6.UseSystemPasswordChar = true;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox5.Location = new System.Drawing.Point(22, 130);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(404, 30);
            this.textBox5.TabIndex = 3;
            this.textBox5.UseSystemPasswordChar = true;
            // 
            // labelConfirmarContraseña
            // 
            this.labelConfirmarContraseña.AutoSize = true;
            this.labelConfirmarContraseña.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.labelConfirmarContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(73)))));
            this.labelConfirmarContraseña.Location = new System.Drawing.Point(19, 232);
            this.labelConfirmarContraseña.Name = "labelConfirmarContraseña";
            this.labelConfirmarContraseña.Size = new System.Drawing.Size(189, 21);
            this.labelConfirmarContraseña.TabIndex = 6;
            this.labelConfirmarContraseña.Text = "Confirmar nueva contraseña";
            // 
            // labelNuevaContraseña
            // 
            this.labelNuevaContraseña.AutoSize = true;
            this.labelNuevaContraseña.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.labelNuevaContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(73)))));
            this.labelNuevaContraseña.Location = new System.Drawing.Point(19, 168);
            this.labelNuevaContraseña.Name = "labelNuevaContraseña";
            this.labelNuevaContraseña.Size = new System.Drawing.Size(158, 21);
            this.labelNuevaContraseña.TabIndex = 4;
            this.labelNuevaContraseña.Text = "Nueva contraseña";
            // 
            // labelContraseñaActual
            // 
            this.labelContraseñaActual.AutoSize = true;
            this.labelContraseñaActual.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.labelContraseñaActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(73)))));
            this.labelContraseñaActual.Location = new System.Drawing.Point(19, 104);
            this.labelContraseñaActual.Name = "labelContraseñaActual";
            this.labelContraseñaActual.Size = new System.Drawing.Size(169, 21);
            this.labelContraseñaActual.TabIndex = 2;
            this.labelContraseñaActual.Text = "Contraseña actual";
            // 
            // labelSeguridad
            // 
            this.labelSeguridad.AutoSize = true;
            this.labelSeguridad.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.labelSeguridad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(92)))));
            this.labelSeguridad.Location = new System.Drawing.Point(18, 16);
            this.labelSeguridad.Name = "labelSeguridad";
            this.labelSeguridad.Size = new System.Drawing.Size(192, 30);
            this.labelSeguridad.TabIndex = 0;
            this.labelSeguridad.Text = "Cambiar contraseña";
            // 
            // panelPersonal
            // 
            this.panelPersonal.BackColor = System.Drawing.Color.White;
            this.panelPersonal.Controls.Add(this.button2);
            this.panelPersonal.Controls.Add(this.button1);
            this.panelPersonal.Controls.Add(this.labelEstadoValor);
            this.panelPersonal.Controls.Add(this.labelVentanillaValor);
            this.panelPersonal.Controls.Add(this.labelSucursalValor);
            this.panelPersonal.Controls.Add(this.labelRolValor);
            this.panelPersonal.Controls.Add(this.textBox4);
            this.panelPersonal.Controls.Add(this.textBox3);
            this.panelPersonal.Controls.Add(this.textBox2);
            this.panelPersonal.Controls.Add(this.textBox1);
            this.panelPersonal.Controls.Add(this.labelEstado);
            this.panelPersonal.Controls.Add(this.labelVentanilla);
            this.panelPersonal.Controls.Add(this.labelSucursal);
            this.panelPersonal.Controls.Add(this.labelRol);
            this.panelPersonal.Controls.Add(this.labelTelefono);
            this.panelPersonal.Controls.Add(this.labelApellidos);
            this.panelPersonal.Controls.Add(this.labelNombre);
            this.panelPersonal.Controls.Add(this.labelUsername);
            this.panelPersonal.Controls.Add(this.labelPersonal);
            this.panelPersonal.Location = new System.Drawing.Point(24, 22);
            this.panelPersonal.Name = "panelPersonal";
            this.panelPersonal.Padding = new System.Windows.Forms.Padding(22, 18, 22, 18);
            this.panelPersonal.Size = new System.Drawing.Size(430, 498);
            this.panelPersonal.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(224, 440);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 42);
            this.button2.TabIndex = 17;
            this.button2.Text = "Restaurar datos";
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
            this.button1.Location = new System.Drawing.Point(22, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 42);
            this.button1.TabIndex = 16;
            this.button1.Text = "Guardar cambios";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelEstadoValor
            // 
            this.labelEstadoValor.AutoSize = true;
            this.labelEstadoValor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelEstadoValor.Location = new System.Drawing.Point(130, 397);
            this.labelEstadoValor.Name = "labelEstadoValor";
            this.labelEstadoValor.Size = new System.Drawing.Size(104, 23);
            this.labelEstadoValor.TabIndex = 15;
            this.labelEstadoValor.Text = "No disponible";
            // 
            // labelVentanillaValor
            // 
            this.labelVentanillaValor.AutoSize = true;
            this.labelVentanillaValor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelVentanillaValor.Location = new System.Drawing.Point(130, 361);
            this.labelVentanillaValor.Name = "labelVentanillaValor";
            this.labelVentanillaValor.Size = new System.Drawing.Size(104, 23);
            this.labelVentanillaValor.TabIndex = 13;
            this.labelVentanillaValor.Text = "No disponible";
            // 
            // labelSucursalValor
            // 
            this.labelSucursalValor.AutoSize = true;
            this.labelSucursalValor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelSucursalValor.Location = new System.Drawing.Point(130, 325);
            this.labelSucursalValor.Name = "labelSucursalValor";
            this.labelSucursalValor.Size = new System.Drawing.Size(104, 23);
            this.labelSucursalValor.TabIndex = 11;
            this.labelSucursalValor.Text = "No disponible";
            // 
            // labelRolValor
            // 
            this.labelRolValor.AutoSize = true;
            this.labelRolValor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelRolValor.Location = new System.Drawing.Point(130, 289);
            this.labelRolValor.Name = "labelRolValor";
            this.labelRolValor.Size = new System.Drawing.Size(104, 23);
            this.labelRolValor.TabIndex = 9;
            this.labelRolValor.Text = "No disponible";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox4.Location = new System.Drawing.Point(130, 241);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(274, 30);
            this.textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox3.Location = new System.Drawing.Point(130, 193);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(274, 30);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox2.Location = new System.Drawing.Point(130, 145);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(274, 30);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox1.Location = new System.Drawing.Point(130, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(274, 30);
            this.textBox1.TabIndex = 2;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.labelEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(73)))));
            this.labelEstado.Location = new System.Drawing.Point(22, 398);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(65, 21);
            this.labelEstado.TabIndex = 14;
            this.labelEstado.Text = "Estado";
            // 
            // labelVentanilla
            // 
            this.labelVentanilla.AutoSize = true;
            this.labelVentanilla.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.labelVentanilla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(73)))));
            this.labelVentanilla.Location = new System.Drawing.Point(22, 362);
            this.labelVentanilla.Name = "labelVentanilla";
            this.labelVentanilla.Size = new System.Drawing.Size(88, 21);
            this.labelVentanilla.TabIndex = 12;
            this.labelVentanilla.Text = "Ventanilla";
            // 
            // labelSucursal
            // 
            this.labelSucursal.AutoSize = true;
            this.labelSucursal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.labelSucursal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(73)))));
            this.labelSucursal.Location = new System.Drawing.Point(22, 326);
            this.labelSucursal.Name = "labelSucursal";
            this.labelSucursal.Size = new System.Drawing.Size(79, 21);
            this.labelSucursal.TabIndex = 10;
            this.labelSucursal.Text = "Sucursal";
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.labelRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(73)))));
            this.labelRol.Location = new System.Drawing.Point(22, 290);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(38, 21);
            this.labelRol.TabIndex = 8;
            this.labelRol.Text = "Rol";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.labelTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(73)))));
            this.labelTelefono.Location = new System.Drawing.Point(22, 242);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(71, 21);
            this.labelTelefono.TabIndex = 7;
            this.labelTelefono.Text = "Teléfono";
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.labelApellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(73)))));
            this.labelApellidos.Location = new System.Drawing.Point(22, 194);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(78, 21);
            this.labelApellidos.TabIndex = 5;
            this.labelApellidos.Text = "Apellidos";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.labelNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(73)))));
            this.labelNombre.Location = new System.Drawing.Point(22, 146);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(64, 21);
            this.labelNombre.TabIndex = 3;
            this.labelNombre.Text = "Nombre";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(73)))));
            this.labelUsername.Location = new System.Drawing.Point(22, 98);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(83, 21);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Username";
            // 
            // labelPersonal
            // 
            this.labelPersonal.AutoSize = true;
            this.labelPersonal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.labelPersonal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(92)))));
            this.labelPersonal.Location = new System.Drawing.Point(18, 16);
            this.labelPersonal.Name = "labelPersonal";
            this.labelPersonal.Size = new System.Drawing.Size(215, 30);
            this.labelPersonal.TabIndex = 0;
            this.labelPersonal.Text = "Información personal";
            // 
            // Frm_Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelEncabezado);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(950, 650);
            this.Name = "Frm_Perfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mi perfil - TurnoSmarts";
            this.panelEncabezado.ResumeLayout(false);
            this.panelEncabezado.PerformLayout();
            this.panelContenido.ResumeLayout(false);
            this.panelSeguridad.ResumeLayout(false);
            this.panelSeguridad.PerformLayout();
            this.panelPersonal.ResumeLayout(false);
            this.panelPersonal.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
