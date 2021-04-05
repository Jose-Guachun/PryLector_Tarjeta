using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Domain;
namespace Presentation
{
    
    public partial class Login : Form
    {
        private Principal inicio;
        private CrearCuenta crear;

        public Login()
        {
            InitializeComponent();
            inicio = new Principal();
            
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Login_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
        
        private void LblCrearCuenta_Click(object sender, EventArgs e)
        {
            ClsOpciones.bandera = true;
            crear = new CrearCuenta();
            crear.Show();
            this.Visible=false;
        }

        private void PtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void PtbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LblCrearCuenta_MouseHover(object sender, EventArgs e)
        {
            LblCrearCuenta.ForeColor = Color.SkyBlue;
        }

        private void LblCrearCuenta_MouseLeave(object sender, EventArgs e)
        {
            LblCrearCuenta.ForeColor = Color.Transparent;
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text != "")
            {
                if (txtContraseña.Text != "")
                {
                    UserModel user = new UserModel();
                    var validLogin=user.LoginUser(TxtUsuario.Text, txtContraseña.Text);
                    if (validLogin==true)
                    {
                        inicio.Show();
                        inicio.FormClosed += Logout;
                        this.Hide();
                    }
                    else
                    {
                        msgError("El usuario o contraseña son incorrectos.\n     Por favor intente de nuevo");
                        txtContraseña.Clear();
                        TxtUsuario.Focus();
                    }
                    
                    
                }
                else msgError("Por favor ingrese la Contraseña");
            }
            else msgError("Por favor ingrese el usuario");
            
        }
        private void msgError(string msg)
        {
            LblError.Text = "     " + msg;
            LblError.Visible = true;
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtContraseña.Clear();
            TxtUsuario.Clear();
            LblError.Visible = false;
            this.Show();
            TxtUsuario.Focus();  
        }
    }
}
