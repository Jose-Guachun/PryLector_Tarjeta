namespace Presentation
{
    partial class Recargar
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUid = new System.Windows.Forms.TextBox();
            this.RtxtDatos = new System.Windows.Forms.RichTextBox();
            this.BtnScan = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.LblPuerto = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnRecargar = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSaldo = new System.Windows.Forms.TextBox();
            this.BtnCancelar = new FontAwesome.Sharp.IconButton();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(72, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Valor :";
            // 
            // TxtValor
            // 
            this.TxtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValor.Location = new System.Drawing.Point(138, 317);
            this.TxtValor.MaxLength = 6;
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(121, 26);
            this.TxtValor.TabIndex = 10;
            this.TxtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValor_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "UID :";
            // 
            // TxtUid
            // 
            this.TxtUid.Enabled = false;
            this.TxtUid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUid.Location = new System.Drawing.Point(138, 191);
            this.TxtUid.Name = "TxtUid";
            this.TxtUid.Size = new System.Drawing.Size(121, 26);
            this.TxtUid.TabIndex = 8;
            // 
            // RtxtDatos
            // 
            this.RtxtDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtxtDatos.Enabled = false;
            this.RtxtDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtxtDatos.Location = new System.Drawing.Point(283, 149);
            this.RtxtDatos.Name = "RtxtDatos";
            this.RtxtDatos.Size = new System.Drawing.Size(373, 357);
            this.RtxtDatos.TabIndex = 15;
            this.RtxtDatos.Text = "";
            // 
            // BtnScan
            // 
            this.BtnScan.BackColor = System.Drawing.Color.Teal;
            this.BtnScan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnScan.FlatAppearance.BorderSize = 0;
            this.BtnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnScan.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnScan.ForeColor = System.Drawing.Color.White;
            this.BtnScan.IconChar = FontAwesome.Sharp.IconChar._500Px;
            this.BtnScan.IconColor = System.Drawing.Color.White;
            this.BtnScan.IconSize = 30;
            this.BtnScan.Location = new System.Drawing.Point(672, 170);
            this.BtnScan.Name = "BtnScan";
            this.BtnScan.Rotation = 0D;
            this.BtnScan.Size = new System.Drawing.Size(139, 58);
            this.BtnScan.TabIndex = 16;
            this.BtnScan.Text = "Scanear";
            this.BtnScan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnScan.UseVisualStyleBackColor = false;
            this.BtnScan.Click += new System.EventHandler(this.BtnScan_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.LblPuerto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 28);
            this.panel1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Puerto : ";
            // 
            // LblPuerto
            // 
            this.LblPuerto.AutoSize = true;
            this.LblPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPuerto.ForeColor = System.Drawing.Color.MediumPurple;
            this.LblPuerto.Location = new System.Drawing.Point(67, 9);
            this.LblPuerto.Name = "LblPuerto";
            this.LblPuerto.Size = new System.Drawing.Size(86, 16);
            this.LblPuerto.TabIndex = 15;
            this.LblPuerto.Text = "Sin Conexion";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(925, 1);
            this.panel2.TabIndex = 18;
            // 
            // BtnRecargar
            // 
            this.BtnRecargar.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnRecargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnRecargar.Enabled = false;
            this.BtnRecargar.FlatAppearance.BorderSize = 0;
            this.BtnRecargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRecargar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnRecargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRecargar.ForeColor = System.Drawing.Color.White;
            this.BtnRecargar.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.BtnRecargar.IconColor = System.Drawing.Color.White;
            this.BtnRecargar.IconSize = 30;
            this.BtnRecargar.Location = new System.Drawing.Point(672, 255);
            this.BtnRecargar.Name = "BtnRecargar";
            this.BtnRecargar.Rotation = 0D;
            this.BtnRecargar.Size = new System.Drawing.Size(139, 58);
            this.BtnRecargar.TabIndex = 20;
            this.BtnRecargar.Text = "Recargar";
            this.BtnRecargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRecargar.UseVisualStyleBackColor = false;
            this.BtnRecargar.Click += new System.EventHandler(this.BtnRecargar_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(72, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Saldo :";
            // 
            // TxtSaldo
            // 
            this.TxtSaldo.Enabled = false;
            this.TxtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSaldo.Location = new System.Drawing.Point(138, 255);
            this.TxtSaldo.Name = "TxtSaldo";
            this.TxtSaldo.Size = new System.Drawing.Size(121, 26);
            this.TxtSaldo.TabIndex = 22;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Maroon;
            this.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.BtnCancelar.IconColor = System.Drawing.Color.White;
            this.BtnCancelar.IconSize = 30;
            this.BtnCancelar.Location = new System.Drawing.Point(672, 340);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Rotation = 0D;
            this.BtnCancelar.Size = new System.Drawing.Size(139, 58);
            this.BtnCancelar.TabIndex = 24;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Ebrima", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(293, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(363, 45);
            this.label14.TabIndex = 64;
            this.label14.Text = "RECARGA DE TARJETA";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Recargar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(925, 587);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSaldo);
            this.Controls.Add(this.BtnRecargar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnScan);
            this.Controls.Add(this.RtxtDatos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtUid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Recargar";
            this.Text = "Recargar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Recargar_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Recargar_FormClosed);
            this.Load += new System.EventHandler(this.Recargar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUid;
        private System.Windows.Forms.RichTextBox RtxtDatos;
        private FontAwesome.Sharp.IconButton BtnScan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblPuerto;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton BtnRecargar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSaldo;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private System.Windows.Forms.Label label14;
    }
}