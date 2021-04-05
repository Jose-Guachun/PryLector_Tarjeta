namespace Presentation
{
    partial class Empleado
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PnlContenedor = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.TxtConfPass = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.CboSalida = new System.Windows.Forms.ComboBox();
            this.tBHORARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_Recarga_TarjetaDataSet = new Presentation.BD_Recarga_TarjetaDataSet();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CboEntrada = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnGuardar = new FontAwesome.Sharp.IconButton();
            this.CboTipo = new System.Windows.Forms.ComboBox();
            this.tBTIPOUSUARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtEMail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNacionalidad = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.CboGenero = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.DTPFechaNac = new System.Windows.Forms.DateTimePicker();
            this.CboEstadoCivil = new System.Windows.Forms.ComboBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnNuevo = new FontAwesome.Sharp.IconButton();
            this.BtnEditar = new FontAwesome.Sharp.IconButton();
            this.BtnEliminar = new FontAwesome.Sharp.IconButton();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new FontAwesome.Sharp.IconButton();
            this.tB_HORARIOTableAdapter = new Presentation.BD_Recarga_TarjetaDataSetTableAdapters.TB_HORARIOTableAdapter();
            this.tB_TIPO_USUARIOTableAdapter = new Presentation.BD_Recarga_TarjetaDataSetTableAdapters.TB_TIPO_USUARIOTableAdapter();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBHORARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_Recarga_TarjetaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBTIPOUSUARIOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(824, 513);
            this.dataGridView1.TabIndex = 0;
            // 
            // PnlContenedor
            // 
            this.PnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.PnlContenedor.Controls.Add(this.label18);
            this.PnlContenedor.Controls.Add(this.TxtConfPass);
            this.PnlContenedor.Controls.Add(this.label17);
            this.PnlContenedor.Controls.Add(this.label6);
            this.PnlContenedor.Controls.Add(this.TxtCedula);
            this.PnlContenedor.Controls.Add(this.CboSalida);
            this.PnlContenedor.Controls.Add(this.label12);
            this.PnlContenedor.Controls.Add(this.label3);
            this.PnlContenedor.Controls.Add(this.CboEntrada);
            this.PnlContenedor.Controls.Add(this.label10);
            this.PnlContenedor.Controls.Add(this.BtnGuardar);
            this.PnlContenedor.Controls.Add(this.CboTipo);
            this.PnlContenedor.Controls.Add(this.label13);
            this.PnlContenedor.Controls.Add(this.TxtPass);
            this.PnlContenedor.Controls.Add(this.label11);
            this.PnlContenedor.Controls.Add(this.TxtPhone);
            this.PnlContenedor.Controls.Add(this.label7);
            this.PnlContenedor.Controls.Add(this.TxtEMail);
            this.PnlContenedor.Controls.Add(this.label9);
            this.PnlContenedor.Controls.Add(this.TxtDireccion);
            this.PnlContenedor.Controls.Add(this.label2);
            this.PnlContenedor.Controls.Add(this.TxtNacionalidad);
            this.PnlContenedor.Controls.Add(this.label16);
            this.PnlContenedor.Controls.Add(this.CboGenero);
            this.PnlContenedor.Controls.Add(this.label15);
            this.PnlContenedor.Controls.Add(this.DTPFechaNac);
            this.PnlContenedor.Controls.Add(this.CboEstadoCivil);
            this.PnlContenedor.Controls.Add(this.TxtCodigo);
            this.PnlContenedor.Controls.Add(this.label8);
            this.PnlContenedor.Controls.Add(this.label5);
            this.PnlContenedor.Controls.Add(this.label4);
            this.PnlContenedor.Controls.Add(this.TxtNombre);
            this.PnlContenedor.Controls.Add(this.label1);
            this.PnlContenedor.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlContenedor.ForeColor = System.Drawing.Color.White;
            this.PnlContenedor.Location = new System.Drawing.Point(855, 0);
            this.PnlContenedor.Name = "PnlContenedor";
            this.PnlContenedor.Size = new System.Drawing.Size(294, 717);
            this.PnlContenedor.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Ebrima", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(67, 34);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(166, 37);
            this.label18.TabIndex = 74;
            this.label18.Text = "Crear cuenta";
            // 
            // TxtConfPass
            // 
            this.TxtConfPass.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConfPass.Location = new System.Drawing.Point(33, 575);
            this.TxtConfPass.MaxLength = 20;
            this.TxtConfPass.Name = "TxtConfPass";
            this.TxtConfPass.PasswordChar = '*';
            this.TxtConfPass.Size = new System.Drawing.Size(230, 22);
            this.TxtConfPass.TabIndex = 104;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(32, 559);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 13);
            this.label17.TabIndex = 105;
            this.label17.Text = "Confirmar Contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(35, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 103;
            this.label6.Text = "Cedula";
            // 
            // TxtCedula
            // 
            this.TxtCedula.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCedula.Location = new System.Drawing.Point(34, 273);
            this.TxtCedula.MaxLength = 10;
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(230, 22);
            this.TxtCedula.TabIndex = 102;
            // 
            // CboSalida
            // 
            this.CboSalida.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CboSalida.DataSource = this.tBHORARIOBindingSource;
            this.CboSalida.DisplayMember = "Hora_Salida";
            this.CboSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboSalida.Enabled = false;
            this.CboSalida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CboSalida.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboSalida.FormattingEnabled = true;
            this.CboSalida.Location = new System.Drawing.Point(155, 495);
            this.CboSalida.Name = "CboSalida";
            this.CboSalida.Size = new System.Drawing.Size(108, 21);
            this.CboSalida.TabIndex = 101;
            this.CboSalida.ValueMember = "IdHorario";
            // 
            // tBHORARIOBindingSource
            // 
            this.tBHORARIOBindingSource.DataMember = "TB_HORARIO";
            this.tBHORARIOBindingSource.DataSource = this.bD_Recarga_TarjetaDataSet;
            // 
            // bD_Recarga_TarjetaDataSet
            // 
            this.bD_Recarga_TarjetaDataSet.DataSetName = "BD_Recarga_TarjetaDataSet";
            this.bD_Recarga_TarjetaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(152, 479);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 100;
            this.label12.Text = "Salida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 479);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 99;
            this.label3.Text = "Entrada";
            // 
            // CboEntrada
            // 
            this.CboEntrada.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CboEntrada.DataSource = this.tBHORARIOBindingSource;
            this.CboEntrada.DisplayMember = "Hora_Ingreso";
            this.CboEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CboEntrada.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboEntrada.FormattingEnabled = true;
            this.CboEntrada.Location = new System.Drawing.Point(34, 494);
            this.CboEntrada.Name = "CboEntrada";
            this.CboEntrada.Size = new System.Drawing.Size(108, 21);
            this.CboEntrada.TabIndex = 97;
            this.CboEntrada.ValueMember = "IdHorario";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(36, 462);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 98;
            this.label10.Text = "Horario";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(48)))), ((int)(((byte)(100)))));
            this.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnGuardar.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.BtnGuardar.IconColor = System.Drawing.Color.White;
            this.BtnGuardar.IconSize = 40;
            this.BtnGuardar.Location = new System.Drawing.Point(33, 622);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Rotation = 0D;
            this.BtnGuardar.Size = new System.Drawing.Size(230, 57);
            this.BtnGuardar.TabIndex = 96;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // CboTipo
            // 
            this.CboTipo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CboTipo.DataSource = this.tBTIPOUSUARIOBindingSource;
            this.CboTipo.DisplayMember = "Tipo_Usuario";
            this.CboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CboTipo.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboTipo.FormattingEnabled = true;
            this.CboTipo.Location = new System.Drawing.Point(154, 108);
            this.CboTipo.Name = "CboTipo";
            this.CboTipo.Size = new System.Drawing.Size(109, 21);
            this.CboTipo.TabIndex = 94;
            this.CboTipo.ValueMember = "IdTipoUsu";
            // 
            // tBTIPOUSUARIOBindingSource
            // 
            this.tBTIPOUSUARIOBindingSource.DataMember = "TB_TIPO_USUARIO";
            this.tBTIPOUSUARIOBindingSource.DataSource = this.bD_Recarga_TarjetaDataSet;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(153, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 95;
            this.label13.Text = "Cargo";
            // 
            // TxtPass
            // 
            this.TxtPass.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPass.Location = new System.Drawing.Point(33, 534);
            this.TxtPass.MaxLength = 20;
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.PasswordChar = '*';
            this.TxtPass.Size = new System.Drawing.Size(230, 22);
            this.TxtPass.TabIndex = 92;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(32, 518);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 93;
            this.label11.Text = "Contraseña";
            // 
            // TxtPhone
            // 
            this.TxtPhone.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPhone.Location = new System.Drawing.Point(34, 355);
            this.TxtPhone.MaxLength = 10;
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(230, 22);
            this.TxtPhone.TabIndex = 90;
            this.TxtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPhone_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(35, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 91;
            this.label7.Text = "Telefono-Celular";
            // 
            // TxtEMail
            // 
            this.TxtEMail.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEMail.Location = new System.Drawing.Point(35, 396);
            this.TxtEMail.MaxLength = 70;
            this.TxtEMail.Name = "TxtEMail";
            this.TxtEMail.Size = new System.Drawing.Size(229, 22);
            this.TxtEMail.TabIndex = 87;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(35, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 89;
            this.label9.Text = "E_Mail";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(34, 437);
            this.TxtDireccion.MaxLength = 100;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(231, 22);
            this.TxtDireccion.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 88;
            this.label2.Text = "Direccion";
            // 
            // TxtNacionalidad
            // 
            this.TxtNacionalidad.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNacionalidad.Location = new System.Drawing.Point(34, 314);
            this.TxtNacionalidad.MaxLength = 50;
            this.TxtNacionalidad.Name = "TxtNacionalidad";
            this.TxtNacionalidad.Size = new System.Drawing.Size(230, 22);
            this.TxtNacionalidad.TabIndex = 84;
            this.TxtNacionalidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNacionalidad_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(36, 298);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 13);
            this.label16.TabIndex = 85;
            this.label16.Text = "Nacionalidad";
            // 
            // CboGenero
            // 
            this.CboGenero.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboGenero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CboGenero.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboGenero.FormattingEnabled = true;
            this.CboGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.CboGenero.Location = new System.Drawing.Point(155, 230);
            this.CboGenero.Name = "CboGenero";
            this.CboGenero.Size = new System.Drawing.Size(109, 21);
            this.CboGenero.TabIndex = 81;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(162, 214);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 80;
            this.label15.Text = "Genero";
            // 
            // DTPFechaNac
            // 
            this.DTPFechaNac.CalendarTitleBackColor = System.Drawing.Color.DarkRed;
            this.DTPFechaNac.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPFechaNac.Location = new System.Drawing.Point(34, 189);
            this.DTPFechaNac.MaxDate = new System.DateTime(2020, 12, 25, 23, 59, 0, 0);
            this.DTPFechaNac.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.DTPFechaNac.Name = "DTPFechaNac";
            this.DTPFechaNac.Size = new System.Drawing.Size(230, 22);
            this.DTPFechaNac.TabIndex = 73;
            // 
            // CboEstadoCivil
            // 
            this.CboEstadoCivil.BackColor = System.Drawing.Color.GhostWhite;
            this.CboEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboEstadoCivil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CboEstadoCivil.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboEstadoCivil.FormattingEnabled = true;
            this.CboEstadoCivil.Items.AddRange(new object[] {
            "Soltero/a",
            "Union de Hecho",
            "Casado/a",
            "Divorsiado/a",
            "Viudo/a"});
            this.CboEstadoCivil.Location = new System.Drawing.Point(34, 230);
            this.CboEstadoCivil.MaxLength = 15;
            this.CboEstadoCivil.Name = "CboEstadoCivil";
            this.CboEstadoCivil.Size = new System.Drawing.Size(109, 21);
            this.CboEstadoCivil.TabIndex = 74;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.Location = new System.Drawing.Point(33, 107);
            this.TxtCodigo.MaxLength = 10;
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(109, 22);
            this.TxtCodigo.TabIndex = 70;
            this.TxtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigo_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(34, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 79;
            this.label8.Text = "Codigo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(34, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 77;
            this.label5.Text = "Fecha Nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(34, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "Estado Civil";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(33, 148);
            this.TxtNombre.MaxLength = 100;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(230, 22);
            this.TxtNombre.TabIndex = 71;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 75;
            this.label1.Text = "Nombre";
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnNuevo.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ForeColor = System.Drawing.Color.White;
            this.BtnNuevo.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.BtnNuevo.IconColor = System.Drawing.Color.White;
            this.BtnNuevo.IconSize = 30;
            this.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNuevo.Location = new System.Drawing.Point(725, 633);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Rotation = 0D;
            this.BtnNuevo.Size = new System.Drawing.Size(112, 40);
            this.BtnNuevo.TabIndex = 27;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnEditar.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.BtnEditar.IconColor = System.Drawing.Color.White;
            this.BtnEditar.IconSize = 30;
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEditar.Location = new System.Drawing.Point(607, 633);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Rotation = 0D;
            this.BtnEditar.Size = new System.Drawing.Size(112, 40);
            this.BtnEditar.TabIndex = 26;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Crimson;
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnEliminar.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.RemoveFormat;
            this.BtnEliminar.IconColor = System.Drawing.Color.White;
            this.BtnEliminar.IconSize = 30;
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEliminar.Location = new System.Drawing.Point(489, 633);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Rotation = 0D;
            this.BtnEliminar.Size = new System.Drawing.Size(112, 40);
            this.BtnEliminar.TabIndex = 25;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBuscar.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.Location = new System.Drawing.Point(11, 84);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(719, 29);
            this.TxtBuscar.TabIndex = 71;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnBuscar.Enabled = false;
            this.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnBuscar.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.DimGray;
            this.BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.SearchPlus;
            this.BtnBuscar.IconColor = System.Drawing.Color.DarkGray;
            this.BtnBuscar.IconSize = 25;
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.Location = new System.Drawing.Point(729, 84);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Rotation = 0D;
            this.BtnBuscar.Size = new System.Drawing.Size(109, 29);
            this.BtnBuscar.TabIndex = 72;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // tB_HORARIOTableAdapter
            // 
            this.tB_HORARIOTableAdapter.ClearBeforeFill = true;
            // 
            // tB_TIPO_USUARIOTableAdapter
            // 
            this.tB_TIPO_USUARIOTableAdapter.ClearBeforeFill = true;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Ebrima", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(325, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(241, 50);
            this.label14.TabIndex = 73;
            this.label14.Text = "EMPLEADOS";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1149, 717);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.PnlContenedor);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Empleado";
            this.Text = "EMPLEADO";
            this.Load += new System.EventHandler(this.Empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PnlContenedor.ResumeLayout(false);
            this.PnlContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBHORARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_Recarga_TarjetaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBTIPOUSUARIOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel PnlContenedor;
        private System.Windows.Forms.TextBox TxtNacionalidad;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox CboGenero;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker DTPFechaNac;
        private System.Windows.Forms.ComboBox CboEstadoCivil;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtEMail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CboTipo;
        private System.Windows.Forms.Label label13;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private FontAwesome.Sharp.IconButton BtnNuevo;
        private FontAwesome.Sharp.IconButton BtnEditar;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private System.Windows.Forms.ComboBox CboEntrada;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CboSalida;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private BD_Recarga_TarjetaDataSet bD_Recarga_TarjetaDataSet;
        private System.Windows.Forms.BindingSource tBHORARIOBindingSource;
        private BD_Recarga_TarjetaDataSetTableAdapters.TB_HORARIOTableAdapter tB_HORARIOTableAdapter;
        private System.Windows.Forms.BindingSource tBTIPOUSUARIOBindingSource;
        private BD_Recarga_TarjetaDataSetTableAdapters.TB_TIPO_USUARIOTableAdapter tB_TIPO_USUARIOTableAdapter;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TxtConfPass;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCedula;
    }
}