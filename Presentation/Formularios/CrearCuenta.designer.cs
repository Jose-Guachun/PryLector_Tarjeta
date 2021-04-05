namespace Presentation
{
    partial class CrearCuenta
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
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtEMail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.CboEstadoCivil = new System.Windows.Forms.ComboBox();
            this.DTPFechaNac = new System.Windows.Forms.DateTimePicker();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtConPass = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.CboTipo = new System.Windows.Forms.ComboBox();
            this.tBTIPOUSUARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_Recarga_TarjetaDataSet = new Presentation.BD_Recarga_TarjetaDataSet();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.CboGenero = new System.Windows.Forms.ComboBox();
            this.TxtNacionalidad = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.CboSalida = new System.Windows.Forms.ComboBox();
            this.tBHORARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.CboEntrada = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnMinimizar = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.tB_HORARIOTableAdapter = new Presentation.BD_Recarga_TarjetaDataSetTableAdapters.TB_HORARIOTableAdapter();
            this.tB_TIPO_USUARIOTableAdapter = new Presentation.BD_Recarga_TarjetaDataSetTableAdapters.TB_TIPO_USUARIOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBTIPOUSUARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_Recarga_TarjetaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBHORARIOBindingSource)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconPictureBox1.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Snow;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Snow;
            this.iconPictureBox1.IconSize = 190;
            this.iconPictureBox1.Location = new System.Drawing.Point(665, 118);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(190, 193);
            this.iconPictureBox1.TabIndex = 31;
            this.iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(36, 204);
            this.TxtNombre.MaxLength = 100;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(250, 25);
            this.TxtNombre.TabIndex = 2;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(333, 204);
            this.TxtDireccion.MaxLength = 100;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(250, 25);
            this.TxtDireccion.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(333, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 38;
            this.label4.Text = "Estado Civil";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(36, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 21);
            this.label5.TabIndex = 40;
            this.label5.Text = "Fecha Nacimiento";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.Location = new System.Drawing.Point(36, 142);
            this.TxtCodigo.MaxLength = 10;
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(250, 25);
            this.TxtCodigo.TabIndex = 1;
            this.TxtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigo_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(36, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 21);
            this.label8.TabIndex = 46;
            this.label8.Text = "Codigo";
            // 
            // TxtEMail
            // 
            this.TxtEMail.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEMail.Location = new System.Drawing.Point(333, 142);
            this.TxtEMail.MaxLength = 70;
            this.TxtEMail.Name = "TxtEMail";
            this.TxtEMail.Size = new System.Drawing.Size(250, 25);
            this.TxtEMail.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(333, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 21);
            this.label9.TabIndex = 48;
            this.label9.Text = "E_Mail";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Crimson;
            this.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancelar.Location = new System.Drawing.Point(635, 457);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(230, 68);
            this.BtnCancelar.TabIndex = 51;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // CboEstadoCivil
            // 
            this.CboEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboEstadoCivil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboEstadoCivil.Font = new System.Drawing.Font("Ebrima", 9.75F);
            this.CboEstadoCivil.FormattingEnabled = true;
            this.CboEstadoCivil.Items.AddRange(new object[] {
            "Soltero",
            "Casado",
            "Divorsiado",
            "Viudo"});
            this.CboEstadoCivil.Location = new System.Drawing.Point(36, 400);
            this.CboEstadoCivil.Name = "CboEstadoCivil";
            this.CboEstadoCivil.Size = new System.Drawing.Size(250, 25);
            this.CboEstadoCivil.TabIndex = 6;
            // 
            // DTPFechaNac
            // 
            this.DTPFechaNac.CalendarTitleBackColor = System.Drawing.Color.DarkRed;
            this.DTPFechaNac.Font = new System.Drawing.Font("Ebrima", 9.75F);
            this.DTPFechaNac.Location = new System.Drawing.Point(36, 339);
            this.DTPFechaNac.MaxDate = new System.DateTime(2020, 12, 25, 23, 59, 0, 0);
            this.DTPFechaNac.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.DTPFechaNac.Name = "DTPFechaNac";
            this.DTPFechaNac.Size = new System.Drawing.Size(250, 25);
            this.DTPFechaNac.TabIndex = 5;
            // 
            // TxtPass
            // 
            this.TxtPass.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPass.Location = new System.Drawing.Point(333, 266);
            this.TxtPass.MaxLength = 50;
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.PasswordChar = '*';
            this.TxtPass.Size = new System.Drawing.Size(246, 25);
            this.TxtPass.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(333, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 21);
            this.label11.TabIndex = 56;
            this.label11.Text = "Contraseña";
            // 
            // TxtConPass
            // 
            this.TxtConPass.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConPass.Location = new System.Drawing.Point(333, 329);
            this.TxtConPass.MaxLength = 50;
            this.TxtConPass.Name = "TxtConPass";
            this.TxtConPass.PasswordChar = '*';
            this.TxtConPass.Size = new System.Drawing.Size(246, 25);
            this.TxtConPass.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(333, 305);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 21);
            this.label12.TabIndex = 58;
            this.label12.Text = "Confirmar Contraseña";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(333, 366);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 21);
            this.label13.TabIndex = 60;
            this.label13.Text = "Tipo Usuario";
            // 
            // CboTipo
            // 
            this.CboTipo.DataSource = this.tBTIPOUSUARIOBindingSource;
            this.CboTipo.DisplayMember = "Tipo_Usuario";
            this.CboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboTipo.Font = new System.Drawing.Font("Ebrima", 9.75F);
            this.CboTipo.FormattingEnabled = true;
            this.CboTipo.Location = new System.Drawing.Point(333, 390);
            this.CboTipo.Name = "CboTipo";
            this.CboTipo.Size = new System.Drawing.Size(246, 25);
            this.CboTipo.TabIndex = 13;
            this.CboTipo.ValueMember = "IdTipoUsu";
            // 
            // tBTIPOUSUARIOBindingSource
            // 
            this.tBTIPOUSUARIOBindingSource.DataMember = "TB_TIPO_USUARIO";
            this.tBTIPOUSUARIOBindingSource.DataSource = this.bD_Recarga_TarjetaDataSet;
            // 
            // bD_Recarga_TarjetaDataSet
            // 
            this.bD_Recarga_TarjetaDataSet.DataSetName = "BD_Recarga_TarjetaDataSet";
            this.bD_Recarga_TarjetaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TxtPhone
            // 
            this.TxtPhone.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPhone.Location = new System.Drawing.Point(36, 578);
            this.TxtPhone.MaxLength = 10;
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(250, 25);
            this.TxtPhone.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(36, 554);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 21);
            this.label7.TabIndex = 62;
            this.label7.Text = "Telefono-Celular";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Ebrima", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(321, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(258, 45);
            this.label14.TabIndex = 63;
            this.label14.Text = "CREAR CUENTA";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(40, 427);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 21);
            this.label15.TabIndex = 64;
            this.label15.Text = "Genero";
            // 
            // CboGenero
            // 
            this.CboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboGenero.Font = new System.Drawing.Font("Ebrima", 9.75F);
            this.CboGenero.FormattingEnabled = true;
            this.CboGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.CboGenero.Location = new System.Drawing.Point(36, 451);
            this.CboGenero.Name = "CboGenero";
            this.CboGenero.Size = new System.Drawing.Size(250, 25);
            this.CboGenero.TabIndex = 65;
            // 
            // TxtNacionalidad
            // 
            this.TxtNacionalidad.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNacionalidad.Location = new System.Drawing.Point(36, 512);
            this.TxtNacionalidad.MaxLength = 50;
            this.TxtNacionalidad.Name = "TxtNacionalidad";
            this.TxtNacionalidad.Size = new System.Drawing.Size(250, 25);
            this.TxtNacionalidad.TabIndex = 68;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(36, 488);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 21);
            this.label16.TabIndex = 69;
            this.label16.Text = "Nacionalidad";
            // 
            // CboSalida
            // 
            this.CboSalida.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CboSalida.DataSource = this.tBHORARIOBindingSource;
            this.CboSalida.DisplayMember = "Hora_Salida";
            this.CboSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboSalida.Enabled = false;
            this.CboSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboSalida.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboSalida.FormattingEnabled = true;
            this.CboSalida.Location = new System.Drawing.Point(464, 475);
            this.CboSalida.Name = "CboSalida";
            this.CboSalida.Size = new System.Drawing.Size(115, 29);
            this.CboSalida.TabIndex = 130;
            this.CboSalida.ValueMember = "IdHorario";
            // 
            // tBHORARIOBindingSource
            // 
            this.tBHORARIOBindingSource.DataMember = "TB_HORARIO";
            this.tBHORARIOBindingSource.DataSource = this.bD_Recarga_TarjetaDataSet;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(460, 451);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 21);
            this.label17.TabIndex = 129;
            this.label17.Text = "Salida";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(333, 452);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 21);
            this.label18.TabIndex = 128;
            this.label18.Text = "Entrada";
            // 
            // CboEntrada
            // 
            this.CboEntrada.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CboEntrada.DataSource = this.tBHORARIOBindingSource;
            this.CboEntrada.DisplayMember = "Hora_Ingreso";
            this.CboEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboEntrada.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboEntrada.FormattingEnabled = true;
            this.CboEntrada.Location = new System.Drawing.Point(333, 475);
            this.CboEntrada.Name = "CboEntrada";
            this.CboEntrada.Size = new System.Drawing.Size(115, 29);
            this.CboEntrada.TabIndex = 126;
            this.CboEntrada.ValueMember = "IdHorario";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(333, 428);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 21);
            this.label19.TabIndex = 127;
            this.label19.Text = "Horario";
            // 
            // TxtCedula
            // 
            this.TxtCedula.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCedula.Location = new System.Drawing.Point(36, 266);
            this.TxtCedula.MaxLength = 10;
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(250, 25);
            this.TxtCedula.TabIndex = 4;
            this.TxtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCedula_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(36, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 21);
            this.label6.TabIndex = 42;
            this.label6.Text = "Cedula";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(48)))), ((int)(((byte)(100)))));
            this.iconButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconSize = 40;
            this.iconButton1.Location = new System.Drawing.Point(635, 358);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(230, 67);
            this.iconButton1.TabIndex = 131;
            this.iconButton1.Text = "GUARDAR";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.BtnSalir.BackgroundImage = global::Presentation.Properties.Resources.cerrars;
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSalir.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.ForeColor = System.Drawing.Color.Transparent;
            this.BtnSalir.Location = new System.Drawing.Point(855, -2);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(29, 35);
            this.BtnSalir.TabIndex = 133;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click_1);
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
            this.BtnMinimizar.Location = new System.Drawing.Point(826, -2);
            this.BtnMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(29, 35);
            this.BtnMinimizar.TabIndex = 132;
            this.BtnMinimizar.UseVisualStyleBackColor = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click_1);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel1.Controls.Add(this.BtnSalir);
            this.Panel1.Controls.Add(this.BtnMinimizar);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(886, 33);
            this.Panel1.TabIndex = 134;
            this.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown_1);
            // 
            // tB_HORARIOTableAdapter
            // 
            this.tB_HORARIOTableAdapter.ClearBeforeFill = true;
            // 
            // tB_TIPO_USUARIOTableAdapter
            // 
            this.tB_TIPO_USUARIOTableAdapter.ClearBeforeFill = true;
            // 
            // CrearCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(886, 665);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.CboSalida);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.CboEntrada);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.TxtNacionalidad);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.CboGenero);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TxtPhone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CboTipo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TxtConPass);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DTPFechaNac);
            this.Controls.Add(this.CboEstadoCivil);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.TxtEMail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtCedula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearCuenta";
            this.Text = "CrearCuenta";
            this.Load += new System.EventHandler(this.CrearCuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBTIPOUSUARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_Recarga_TarjetaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBHORARIOBindingSource)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtEMail;
        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.ComboBox CboEstadoCivil;
        private System.Windows.Forms.DateTimePicker DTPFechaNac;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtConPass;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox CboTipo;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox CboGenero;
        private System.Windows.Forms.TextBox TxtNacionalidad;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox CboSalida;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox CboEntrada;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton iconButton1;
        internal System.Windows.Forms.Button BtnSalir;
        internal System.Windows.Forms.Button BtnMinimizar;
        internal System.Windows.Forms.Panel Panel1;
        private BD_Recarga_TarjetaDataSet bD_Recarga_TarjetaDataSet;
        private System.Windows.Forms.BindingSource tBHORARIOBindingSource;
        private BD_Recarga_TarjetaDataSetTableAdapters.TB_HORARIOTableAdapter tB_HORARIOTableAdapter;
        private System.Windows.Forms.BindingSource tBTIPOUSUARIOBindingSource;
        private BD_Recarga_TarjetaDataSetTableAdapters.TB_TIPO_USUARIOTableAdapter tB_TIPO_USUARIOTableAdapter;
    }
}