namespace Presentation
{
    partial class Ganancias
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CboInicio = new System.Windows.Forms.ComboBox();
            this.CboFin = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(181, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 551);
            this.dataGridView1.TabIndex = 0;
            // 
            // CboInicio
            // 
            this.CboInicio.FormattingEnabled = true;
            this.CboInicio.Location = new System.Drawing.Point(224, 63);
            this.CboInicio.Name = "CboInicio";
            this.CboInicio.Size = new System.Drawing.Size(184, 21);
            this.CboInicio.TabIndex = 1;
            // 
            // CboFin
            // 
            this.CboFin.FormattingEnabled = true;
            this.CboFin.Location = new System.Drawing.Point(594, 63);
            this.CboFin.Name = "CboFin";
            this.CboFin.Size = new System.Drawing.Size(184, 21);
            this.CboFin.TabIndex = 2;
            // 
            // Ganancias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1147, 717);
            this.Controls.Add(this.CboFin);
            this.Controls.Add(this.CboInicio);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ganancias";
            this.Text = "Ganancias";
            this.Load += new System.EventHandler(this.Ganancias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox CboInicio;
        private System.Windows.Forms.ComboBox CboFin;
    }
}