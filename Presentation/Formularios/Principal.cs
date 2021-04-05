using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO.Ports;
using FontAwesome.Sharp;
using Common.Cache;
using Domain;
namespace Presentation
{
    public partial class Principal : Form
    {
        private IconButton BtnCurrent;
        private Panel BtnLeftBordes;
        private Form FormHijoActual;
        public static DateTime fecha;
        //constructor
        public Principal()
        {
            InitializeComponent();
            this.CenterToScreen();
            BtnLeftBordes = new Panel();
            BtnLeftBordes.Size = new Size(7, 60);
            PanelMenu.Controls.Add(BtnLeftBordes);
            // fromulario
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //Structs
        private void Principal_Load(object sender, EventArgs e)
        {
            CargarUsuario();
            timer1.Start();
        }
        public void CargarUsuario()
        {
            LblNombre.Text = UserCache.Nombre+", "+UserCache.Apellido;
            LblTipo.Text=Convert.ToString(UserCache.IdTipoUser);
            LblE_mail.Text = UserCache.E_mail;
            UserModel tipo = new UserModel();
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void ActivarBoton(object BtnRemitente, Color color)
        {
            if (BtnRemitente!=null)
            {
                DesactivarBoton();
                BtnCurrent = (IconButton)BtnRemitente;
                BtnCurrent.BackColor = Color.FromArgb(37, 36, 81);
                BtnCurrent.ForeColor = color;
                BtnCurrent.TextAlign = ContentAlignment.MiddleCenter;
                BtnCurrent.IconColor = color;
                BtnCurrent.TextImageRelation = TextImageRelation.TextBeforeImage;
                BtnCurrent.ImageAlign = ContentAlignment.MiddleRight;
                //bordes de boton izquierdo
                BtnLeftBordes.BackColor = color;
                BtnLeftBordes.Location = new Point(0, BtnCurrent.Location.Y);
                BtnLeftBordes.Visible = true;
                BtnLeftBordes.BringToFront();
                //Current Child Form Icon
                IconEstado.IconChar = BtnCurrent.IconChar;
                IconEstado.IconColor = color;
            }
        }
        private void DesactivarBoton()
        {
            if (BtnCurrent != null)
            {
                CerrarMenu();
                BtnCurrent.BackColor = Color.FromArgb(30, 38, 44);
                BtnCurrent.ForeColor = Color.White;
                BtnCurrent.TextAlign = ContentAlignment.MiddleLeft;
                BtnCurrent.IconColor = Color.White;
                BtnCurrent.TextImageRelation = TextImageRelation.ImageBeforeText;
                BtnCurrent.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void AbrirFormHijo(Form FrmHijo)
        {
            if (FormHijoActual!=null)
            {
                FormHijoActual.Close();
            }
            FormHijoActual = FrmHijo;
            FrmHijo.TopLevel = false;
            FrmHijo.FormBorderStyle = FormBorderStyle.None;
            FrmHijo.Dock = DockStyle.Fill;
            PnlEscritorio.Controls.Add(FrmHijo);
            PnlEscritorio.Tag = FrmHijo;
            FrmHijo.BringToFront();
            FrmHijo.Show();
            LblTitleChildForm.Text = FrmHijo.Text;
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void iconButton6_Click_1(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color6);
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            try
            {
               Recargar.serialPort1.Close();
                Application.Exit();
            }
            catch (Exception)
            {
                Application.Exit();
            }   
        }
        private void BtnMaximisar_Click(object sender, EventArgs e)
        {
            {
                if (WindowState == FormWindowState.Normal)
                    WindowState = FormWindowState.Maximized;
                else
                    WindowState = FormWindowState.Normal;
            }
        }
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void Reset()
        {
            DesactivarBoton();
            BtnLeftBordes.Visible = false;
            IconEstado.IconChar = IconChar.Home;
            IconEstado.IconColor = Color.LightSalmon;
            LblTitleChildForm.Text = "Home";
        }

        private void BtnRecarga_Click_1(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color1);
            AbrirFormHijo(new Recargar());
        }
        private void BtnHome_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color2);
            AbrirFormHijo(new Cuadre());

        }

        private void BtnCrud_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color3);
            AbrirFormHijo(new Ganancias());
        }

        private void BtnConsultaEmpleado_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color4);
            AbrirFormHijo(new Empleado());
        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color5);
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            if (BtnCerrarSesion.Visible!=true)
            {
                BtnEditarCuenta.Visible = true;
                BtnCerrarSesion.Visible = true;
            }
            else
            {
                CerrarMenu();
            }
        }
        private void PanelMenu_MouseClick(object sender, MouseEventArgs e)
        {
            CerrarMenu();
        }
       public void CerrarMenu()
        {
            if (BtnCerrarSesion.Visible==true)
            {
                BtnCerrarSesion.Visible = false;
                BtnEditarCuenta.Visible = false;
            }
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea cerrar sesión", "ADVERTENCIA",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
