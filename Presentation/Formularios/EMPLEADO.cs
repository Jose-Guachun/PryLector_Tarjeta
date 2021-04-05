using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Domain.ValorObjetos;
using Domain.Models;
namespace Presentation
{
    public partial class Empleado : Form
    {
        private ModeloEmpleado empleado = new ModeloEmpleado();
        private ModeloConsultaEmpleado consulta = new ModeloConsultaEmpleado();
        public Empleado()
        {
            InitializeComponent();
            PnlContenedor.Enabled = false;
        }
        private void Empleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_Recarga_TarjetaDataSet.TB_TIPO_USUARIO' Puede moverla o quitarla según sea necesario.
            this.tB_TIPO_USUARIOTableAdapter.Fill(this.bD_Recarga_TarjetaDataSet.TB_TIPO_USUARIO);
            // TODO: esta línea de código carga datos en la tabla 'bD_Recarga_TarjetaDataSet.TB_EMPLEADO' Puede moverla o quitarla según sea necesario.
            this.tB_HORARIOTableAdapter.Fill(this.bD_Recarga_TarjetaDataSet.TB_HORARIO);
            // TODO: esta línea de código carga datos en la tabla 'bD_Recarga_TarjetaDataSet1.TB_HORARIO' Puede moverla o quitarla según sea necesario.
            ListaEmpleado();
            Limpiar();
        }
        private void ListaEmpleado()
        {
            try
            {
                dataGridView1.DataSource = consulta.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = consulta.FindById(TxtBuscar.Text);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                    empleado.IdTipoUsuario= Convert.ToInt32(CboTipo.SelectedValue);
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
                        ListaEmpleado();
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
        private void Limpiar()
        {
            BtnNuevo.Enabled = true;
            PnlContenedor.Enabled = false;
            TxtCedula.Clear();
            TxtCodigo.Clear();
            TxtDireccion.Clear();
            TxtEMail.Clear();
            TxtNacionalidad.Clear();
            TxtNombre.Clear();
            TxtPass.Clear();
            TxtPhone.Clear();
            CboEstadoCivil.Text="<<Selecciones un estado civil";
            CboGenero.Text = " ";
            CboEntrada.Text= " ";
            CboTipo.Text= " ";
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            PnlContenedor.Enabled = true;
            empleado.estado = EstadoEntidad.Agregar;

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                PnlContenedor.Enabled = true;
                empleado.estado = EstadoEntidad.Modificar;
                empleado.IdEmpleado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                CboTipo.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString().Trim();
                CboEntrada.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString().Trim();
                TxtCodigo.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString().Trim();
                TxtNombre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString().Trim();
                DTPFechaNac.Value =Convert.ToDateTime(dataGridView1.CurrentRow.Cells[6].Value);
                CboEstadoCivil.Text =dataGridView1.CurrentRow.Cells[7].Value.ToString().Trim();
                TxtNacionalidad.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString().Trim();
                TxtPhone.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString().Trim();
                TxtEMail.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString().Trim();
                TxtDireccion.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString().Trim();
                TxtCedula.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString().Trim();
                TxtPass.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString().Trim();
                if (dataGridView1.CurrentRow.Cells[8].Value.ToString()=="M")
                {
                    CboGenero.SelectedIndex= 0;
                }
                else
                {
                    CboGenero.SelectedIndex = 1;
                }
                BtnNuevo.Enabled = false;
            }
            else MessageBox.Show("Selecciones la fila a editar");
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                PnlContenedor.Enabled = true;
                empleado.estado = EstadoEntidad.Eliminar;
                empleado.IdEmpleado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
               string result= empleado.Guardar();
                MessageBox.Show(result);
                ListaEmpleado();
            }
            else MessageBox.Show("Selecciones la fila a editar");
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsValidar.SoloLetrasConEspacio(e);
        }

        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsValidar.SoloNumeros(e);
        }

        private void TxtNacionalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsValidar.SoloLetras(e);
        }

        private void TxtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsValidar.SoloNumeros(e);
        }
    }
    }
    
