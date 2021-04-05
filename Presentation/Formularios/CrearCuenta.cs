using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Domain.Models;
using Domain.ValorObjetos;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Presentation
{
    public partial class CrearCuenta : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        Login Iniciar = new Login();
        private ModeloEmpleado empleado = new ModeloEmpleado();
        public CrearCuenta()
        {
            InitializeComponent();
        }
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void CrearCuenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_Recarga_TarjetaDataSet.TB_TIPO_USUARIO' Puede moverla o quitarla según sea necesario.
            this.tB_TIPO_USUARIOTableAdapter.Fill(this.bD_Recarga_TarjetaDataSet.TB_TIPO_USUARIO);
            // TODO: esta línea de código carga datos en la tabla 'bD_Recarga_TarjetaDataSet.TB_HORARIO' Puede moverla o quitarla según sea necesario.
            this.tB_HORARIOTableAdapter.Fill(this.bD_Recarga_TarjetaDataSet.TB_HORARIO);
            this.CenterToScreen();
        }
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Iniciar.Show();
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (ClsOpciones.bandera)
            {
                this.Close();
                Iniciar.Show();
            }
            else
            {
                Limpiar();

            }
        }

        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsValidar.SoloNumeros(e);
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsValidar.SoloLetrasConEspacio(e);
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsValidar.SoloLetras(e);
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsValidar.SoloNumeros(e);
        }
        public void Limpiar() {
            TxtCedula.Clear();
            TxtCodigo.Clear();
            TxtDireccion.Clear();
            TxtEMail.Clear();
            TxtNombre.Clear();
            TxtNacionalidad.Clear();
            TxtPass.Clear();
            TxtConPass.Clear();
            TxtPhone.Clear();
            CboEstadoCivil.Text="";
            CboTipo.Text="";
    }

        private void Panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            empleado.estado = EstadoEntidad.Agregar;
            try
            {
                empleado.IdTipoUsuario = Convert.ToInt32(CboTipo.SelectedValue);
                empleado.IdHorarios = Convert.ToInt32(CboEntrada.SelectedValue);
                empleado.Codigo = TxtCodigo.Text;
                empleado.Nombre_Apellido = TxtNombre.Text;
                empleado.Fecha_Nacimiento = DTPFechaNac.Value.Date;
                empleado.Estado_Civil = CboEstadoCivil.Text;
                empleado.Genero = CboGenero.Text.Substring(0, 1);
                empleado.Nacionalidad = TxtNacionalidad.Text;
                empleado.Telefono = TxtPhone.Text;
                empleado.E_mail = TxtEMail.Text;
                empleado.Direccion = TxtDireccion.Text;
                empleado.Cedula_usuario = TxtCedula.Text;
                empleado.Contraseña = TxtPass.Text;
                bool valid = new Helps.ValidacionDatos(empleado).Validar();
                if (ClsValidar.ComprobarFormatoEmail(TxtEMail.Text))
                {
                    if (valid == true)
                    {
                        string result = empleado.Guardar();
                        MessageBox.Show(result);
                        Limpiar();
                    }
                }
                else MessageBox.Show("E_mail incorrecto");

            }
            catch (Exception)
            {

                MessageBox.Show("Llene todos los campos");
            }
        }

        private void BtnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMinimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
