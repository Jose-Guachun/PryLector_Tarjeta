namespace Presentation
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.BtnEditarCuenta = new FontAwesome.Sharp.IconButton();
            this.BtnCerrarSesion = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LblE_mail = new System.Windows.Forms.Label();
            this.BtnUser = new FontAwesome.Sharp.IconButton();
            this.LblTipo = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.BtnGeneral = new FontAwesome.Sharp.IconButton();
            this.BtnConsultaEmpleado = new FontAwesome.Sharp.IconButton();
            this.BtnGanacia = new FontAwesome.Sharp.IconButton();
            this.BtnCaja = new FontAwesome.Sharp.IconButton();
            this.BtnRecarga = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnHome = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.LblTitleChildForm = new System.Windows.Forms.Label();
            this.IconEstado = new FontAwesome.Sharp.IconPictureBox();
            this.BtnMaximisar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnMinimizar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PnlEscritorio = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PanelMenu.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconEstado)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.PanelMenu.Controls.Add(this.BtnEditarCuenta);
            this.PanelMenu.Controls.Add(this.BtnCerrarSesion);
            this.PanelMenu.Controls.Add(this.panel4);
            this.PanelMenu.Controls.Add(this.BtnGeneral);
            this.PanelMenu.Controls.Add(this.BtnConsultaEmpleado);
            this.PanelMenu.Controls.Add(this.BtnGanacia);
            this.PanelMenu.Controls.Add(this.BtnCaja);
            this.PanelMenu.Controls.Add(this.BtnRecarga);
            this.PanelMenu.Controls.Add(this.panel3);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(214, 800);
            this.PanelMenu.TabIndex = 34;
            this.PanelMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelMenu_MouseClick);
            // 
            // BtnEditarCuenta
            // 
            this.BtnEditarCuenta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnEditarCuenta.FlatAppearance.BorderSize = 0;
            this.BtnEditarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarCuenta.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnEditarCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditarCuenta.ForeColor = System.Drawing.Color.White;
            this.BtnEditarCuenta.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.BtnEditarCuenta.IconColor = System.Drawing.Color.White;
            this.BtnEditarCuenta.IconSize = 25;
            this.BtnEditarCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditarCuenta.Location = new System.Drawing.Point(0, 669);
            this.BtnEditarCuenta.Name = "BtnEditarCuenta";
            this.BtnEditarCuenta.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnEditarCuenta.Rotation = 0D;
            this.BtnEditarCuenta.Size = new System.Drawing.Size(214, 24);
            this.BtnEditarCuenta.TabIndex = 15;
            this.BtnEditarCuenta.Text = "Editar Cuenta";
            this.BtnEditarCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditarCuenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEditarCuenta.UseVisualStyleBackColor = true;
            this.BtnEditarCuenta.Visible = false;
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.BtnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarSesion.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.BtnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.BtnCerrarSesion.IconColor = System.Drawing.Color.White;
            this.BtnCerrarSesion.IconSize = 25;
            this.BtnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCerrarSesion.Location = new System.Drawing.Point(0, 693);
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnCerrarSesion.Rotation = 0D;
            this.BtnCerrarSesion.Size = new System.Drawing.Size(214, 24);
            this.BtnCerrarSesion.TabIndex = 14;
            this.BtnCerrarSesion.Text = "Cerrar Sesión";
            this.BtnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCerrarSesion.UseVisualStyleBackColor = true;
            this.BtnCerrarSesion.Visible = false;
            this.BtnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.LblE_mail);
            this.panel4.Controls.Add(this.BtnUser);
            this.panel4.Controls.Add(this.LblTipo);
            this.panel4.Controls.Add(this.LblNombre);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 717);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(214, 83);
            this.panel4.TabIndex = 13;
            // 
            // LblE_mail
            // 
            this.LblE_mail.AutoSize = true;
            this.LblE_mail.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblE_mail.ForeColor = System.Drawing.Color.White;
            this.LblE_mail.Location = new System.Drawing.Point(69, 46);
            this.LblE_mail.Name = "LblE_mail";
            this.LblE_mail.Size = new System.Drawing.Size(40, 15);
            this.LblE_mail.TabIndex = 4;
            this.LblE_mail.Text = "E_mail";
            // 
            // BtnUser
            // 
            this.BtnUser.FlatAppearance.BorderSize = 0;
            this.BtnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUser.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.BtnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUser.ForeColor = System.Drawing.Color.White;
            this.BtnUser.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.BtnUser.IconColor = System.Drawing.Color.White;
            this.BtnUser.IconSize = 70;
            this.BtnUser.Location = new System.Drawing.Point(3, 3);
            this.BtnUser.Name = "BtnUser";
            this.BtnUser.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnUser.Rotation = 0D;
            this.BtnUser.Size = new System.Drawing.Size(66, 78);
            this.BtnUser.TabIndex = 12;
            this.BtnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUser.UseVisualStyleBackColor = true;
            this.BtnUser.Click += new System.EventHandler(this.BtnUser_Click);
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipo.ForeColor = System.Drawing.Color.White;
            this.LblTipo.Location = new System.Drawing.Point(69, 31);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(38, 15);
            this.LblTipo.TabIndex = 3;
            this.LblTipo.Text = "Cargo";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.Color.White;
            this.LblNombre.Location = new System.Drawing.Point(69, 16);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(50, 15);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombre";
            // 
            // BtnGeneral
            // 
            this.BtnGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnGeneral.FlatAppearance.BorderSize = 0;
            this.BtnGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGeneral.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGeneral.ForeColor = System.Drawing.Color.White;
            this.BtnGeneral.IconChar = FontAwesome.Sharp.IconChar.UserClock;
            this.BtnGeneral.IconColor = System.Drawing.Color.White;
            this.BtnGeneral.IconSize = 32;
            this.BtnGeneral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGeneral.Location = new System.Drawing.Point(0, 366);
            this.BtnGeneral.Name = "BtnGeneral";
            this.BtnGeneral.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnGeneral.Rotation = 0D;
            this.BtnGeneral.Size = new System.Drawing.Size(214, 60);
            this.BtnGeneral.TabIndex = 11;
            this.BtnGeneral.Text = "Gestor General";
            this.BtnGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGeneral.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGeneral.UseVisualStyleBackColor = true;
            this.BtnGeneral.Click += new System.EventHandler(this.BtnConfig_Click);
            // 
            // BtnConsultaEmpleado
            // 
            this.BtnConsultaEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnConsultaEmpleado.FlatAppearance.BorderSize = 0;
            this.BtnConsultaEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultaEmpleado.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnConsultaEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultaEmpleado.ForeColor = System.Drawing.Color.White;
            this.BtnConsultaEmpleado.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.BtnConsultaEmpleado.IconColor = System.Drawing.Color.White;
            this.BtnConsultaEmpleado.IconSize = 32;
            this.BtnConsultaEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultaEmpleado.Location = new System.Drawing.Point(0, 306);
            this.BtnConsultaEmpleado.Name = "BtnConsultaEmpleado";
            this.BtnConsultaEmpleado.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnConsultaEmpleado.Rotation = 0D;
            this.BtnConsultaEmpleado.Size = new System.Drawing.Size(214, 60);
            this.BtnConsultaEmpleado.TabIndex = 10;
            this.BtnConsultaEmpleado.Text = "Gestionar Empleados";
            this.BtnConsultaEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultaEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConsultaEmpleado.UseVisualStyleBackColor = true;
            this.BtnConsultaEmpleado.Click += new System.EventHandler(this.BtnConsultaEmpleado_Click);
            // 
            // BtnGanacia
            // 
            this.BtnGanacia.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnGanacia.FlatAppearance.BorderSize = 0;
            this.BtnGanacia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGanacia.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnGanacia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGanacia.ForeColor = System.Drawing.Color.White;
            this.BtnGanacia.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.BtnGanacia.IconColor = System.Drawing.Color.White;
            this.BtnGanacia.IconSize = 32;
            this.BtnGanacia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGanacia.Location = new System.Drawing.Point(0, 246);
            this.BtnGanacia.Name = "BtnGanacia";
            this.BtnGanacia.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnGanacia.Rotation = 0D;
            this.BtnGanacia.Size = new System.Drawing.Size(214, 60);
            this.BtnGanacia.TabIndex = 9;
            this.BtnGanacia.Text = "Consulta Ganancia";
            this.BtnGanacia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGanacia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGanacia.UseVisualStyleBackColor = true;
            this.BtnGanacia.Click += new System.EventHandler(this.BtnCrud_Click);
            // 
            // BtnCaja
            // 
            this.BtnCaja.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCaja.FlatAppearance.BorderSize = 0;
            this.BtnCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCaja.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCaja.ForeColor = System.Drawing.Color.White;
            this.BtnCaja.IconChar = FontAwesome.Sharp.IconChar.MoneyCheck;
            this.BtnCaja.IconColor = System.Drawing.Color.White;
            this.BtnCaja.IconSize = 32;
            this.BtnCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCaja.Location = new System.Drawing.Point(0, 186);
            this.BtnCaja.Name = "BtnCaja";
            this.BtnCaja.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnCaja.Rotation = 0D;
            this.BtnCaja.Size = new System.Drawing.Size(214, 60);
            this.BtnCaja.TabIndex = 8;
            this.BtnCaja.Text = "Cuadrar Caja";
            this.BtnCaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCaja.UseVisualStyleBackColor = true;
            this.BtnCaja.Click += new System.EventHandler(this.BtnConsulta_Click);
            // 
            // BtnRecarga
            // 
            this.BtnRecarga.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRecarga.FlatAppearance.BorderSize = 0;
            this.BtnRecarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRecarga.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnRecarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRecarga.ForeColor = System.Drawing.Color.White;
            this.BtnRecarga.IconChar = FontAwesome.Sharp.IconChar.CreditCard;
            this.BtnRecarga.IconColor = System.Drawing.Color.White;
            this.BtnRecarga.IconSize = 32;
            this.BtnRecarga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRecarga.Location = new System.Drawing.Point(0, 126);
            this.BtnRecarga.Name = "BtnRecarga";
            this.BtnRecarga.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnRecarga.Rotation = 0D;
            this.BtnRecarga.Size = new System.Drawing.Size(214, 60);
            this.BtnRecarga.TabIndex = 7;
            this.BtnRecarga.Text = "Recargar Tarjeta";
            this.BtnRecarga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRecarga.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRecarga.UseVisualStyleBackColor = true;
            this.BtnRecarga.Click += new System.EventHandler(this.BtnRecarga_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnHome);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 126);
            this.panel3.TabIndex = 0;
            // 
            // BtnHome
            // 
            this.BtnHome.Location = new System.Drawing.Point(36, 22);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(111, 79);
            this.BtnHome.TabIndex = 0;
            this.BtnHome.TabStop = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lblFecha);
            this.panel2.Controls.Add(this.lblHora);
            this.panel2.Controls.Add(this.LblTitleChildForm);
            this.panel2.Controls.Add(this.IconEstado);
            this.panel2.Controls.Add(this.BtnMaximisar);
            this.panel2.Controls.Add(this.BtnSalir);
            this.panel2.Controls.Add(this.BtnMinimizar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(214, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1147, 82);
            this.panel2.TabIndex = 37;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(964, 60);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 16);
            this.lblFecha.TabIndex = 34;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(1048, 34);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(96, 25);
            this.lblHora.TabIndex = 33;
            this.lblHora.Text = "00:00:00";
            // 
            // LblTitleChildForm
            // 
            this.LblTitleChildForm.AutoSize = true;
            this.LblTitleChildForm.BackColor = System.Drawing.Color.Transparent;
            this.LblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.LblTitleChildForm.Location = new System.Drawing.Point(66, 47);
            this.LblTitleChildForm.Name = "LblTitleChildForm";
            this.LblTitleChildForm.Size = new System.Drawing.Size(54, 20);
            this.LblTitleChildForm.TabIndex = 32;
            this.LblTitleChildForm.Text = "Home";
            // 
            // IconEstado
            // 
            this.IconEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.IconEstado.ForeColor = System.Drawing.Color.LightSalmon;
            this.IconEstado.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.IconEstado.IconColor = System.Drawing.Color.LightSalmon;
            this.IconEstado.IconSize = 42;
            this.IconEstado.Location = new System.Drawing.Point(16, 34);
            this.IconEstado.Name = "IconEstado";
            this.IconEstado.Size = new System.Drawing.Size(44, 42);
            this.IconEstado.TabIndex = 31;
            this.IconEstado.TabStop = false;
            // 
            // BtnMaximisar
            // 
            this.BtnMaximisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.BtnMaximisar.BackgroundImage = global::Presentation.Properties.Resources.icon_restaurar_14x14;
            this.BtnMaximisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnMaximisar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnMaximisar.FlatAppearance.BorderSize = 0;
            this.BtnMaximisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnMaximisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnMaximisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximisar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnMaximisar.Location = new System.Drawing.Point(1086, 0);
            this.BtnMaximisar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnMaximisar.Name = "BtnMaximisar";
            this.BtnMaximisar.Size = new System.Drawing.Size(29, 29);
            this.BtnMaximisar.TabIndex = 30;
            this.BtnMaximisar.UseVisualStyleBackColor = false;
            this.BtnMaximisar.Click += new System.EventHandler(this.BtnMaximisar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSalir.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.ForeColor = System.Drawing.Color.Transparent;
            this.BtnSalir.Image = global::Presentation.Properties.Resources.cerrars;
            this.BtnSalir.Location = new System.Drawing.Point(1117, 0);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(29, 29);
            this.BtnSalir.TabIndex = 29;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.BtnMinimizar.BackgroundImage = global::Presentation.Properties.Resources.icon_minimizar_14x14;
            this.BtnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnMinimizar.FlatAppearance.BorderSize = 0;
            this.BtnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnMinimizar.Location = new System.Drawing.Point(1053, 0);
            this.BtnMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(29, 29);
            this.BtnMinimizar.TabIndex = 28;
            this.BtnMinimizar.UseVisualStyleBackColor = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(214, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 1);
            this.panel1.TabIndex = 38;
            // 
            // PnlEscritorio
            // 
            this.PnlEscritorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.PnlEscritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlEscritorio.Location = new System.Drawing.Point(214, 83);
            this.PnlEscritorio.Name = "PnlEscritorio";
            this.PnlEscritorio.Size = new System.Drawing.Size(1147, 717);
            this.PnlEscritorio.TabIndex = 39;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 800);
            this.Controls.Add(this.PnlEscritorio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.PanelMenu.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconEstado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelMenu;
        private FontAwesome.Sharp.IconButton BtnUser;
        private FontAwesome.Sharp.IconButton BtnGeneral;
        private FontAwesome.Sharp.IconButton BtnConsultaEmpleado;
        private FontAwesome.Sharp.IconButton BtnGanacia;
        private FontAwesome.Sharp.IconButton BtnCaja;
        private FontAwesome.Sharp.IconButton BtnRecarga;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox BtnHome;
        internal System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox IconEstado;
        internal System.Windows.Forms.Button BtnMaximisar;
        internal System.Windows.Forms.Button BtnSalir;
        internal System.Windows.Forms.Button BtnMinimizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PnlEscritorio;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblE_mail;
        private FontAwesome.Sharp.IconButton BtnEditarCuenta;
        private FontAwesome.Sharp.IconButton BtnCerrarSesion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
    }
}