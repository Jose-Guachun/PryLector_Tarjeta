using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Globalization;
using Domain.ValorObjetos;
using Domain.Models;
using System.Runtime.InteropServices;
using Common.Cache;
namespace Presentation
{
    public partial class Recargar : Form
    {
        public static SerialPort serialPort1;
        public static bool IsClosed=false;
        bool b;
        int cont=0;
        private ModeloTarjeta tarjeta = new ModeloTarjeta();
        public Recargar()
        {
            
            InitializeComponent();
            ScanearPuerto();
          
            serialPort1 = new SerialPort();
            serialPort1.BaudRate = 9600;
            serialPort1.ReadTimeout = 500;
            serialPort1.DtrEnable = true;
            try
            {
                serialPort1.PortName = LblPuerto.Text;
                BtnCancelar.Enabled = true;
                BtnScan.Enabled = true;
            }

            catch (Exception)
            {
                MessageBox.Show("No se detecto ningun puerto conectado");
                BtnCancelar.Enabled = false;
                BtnScan.Enabled = false;
                LblPuerto.Text = "Sin Conexion";
                LblPuerto.ForeColor = Color.FromArgb(255, 128, 128);
            }  
        }
        private void Recargar_Load(object sender, EventArgs e)
        {
            //Thread Hilo = new Thread(EscucharSerial);
            //Hilo.Start();
        }
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {

                string line = serialPort1.ReadLine();
                this.BeginInvoke(new LineReceivedEvent(LineReceived), line);
                
            }
            catch (Exception)
            {

            }
        }
        private delegate void LineReceivedEvent(string line);
        private void LineReceived(string line)
        {
            
            string lin = line.Replace("\n", "\r\n");
            switch (cont)
            {
                case 0:
                    TxtUid.Text = line;   
                    cont++;
                    break;
                case 1:
                    RtxtDatos.Text += lin;
                    RtxtDatos.Text += ("UID: " + TxtUid.Text);
                    cont++;
                    break;
                case 2:
                    RtxtDatos.Text +=("Saldo: $"  +lin);
                    TxtSaldo.Text = lin;
                    cont++;
                    break;
                case 3:
                    RtxtDatos.Text += lin;
                    cerrar();
                    break;
                default:
                    break;
            }
  
        }
       
        //public void EscucharSerial()
        //{
        //    while (!IsClosed)
        //    {
        //        try
        //        {
        //            string cadena;
        //            cadena = serialPort1.ReadLine();
        //            lblDato.Invoke(new MethodInvoker(
        //            delegate
        //            {
        //                RtxtDatos.Text= cadena;
        //                if (!b)
        //                {

        //                    TxtUid.Text = LblDato.Text;
        //                    b = false;
        //                }
        //                else
        //                {
        //                    TxtValor.Text = LblDato.Text;
        //                    b = true;
        //                }

        //            }));
        //        }
        //        catch (Exception)
        //        {

        //        }

        //    }
        //}
        private void ScanearPuerto()
        {
            try
            {
                string[] ports = SerialPort.GetPortNames();
                string cad = "";
                for (int i = 0; i < ports.Length; i++)
                {
                    cad += ports[i];
                }
                LblPuerto.Text = cad;
                LblPuerto.ForeColor = Color.MediumPurple;
            }
            catch (Exception)
            {
                LblPuerto.Text = "Sin Conexion";
                LblPuerto.ForeColor = Color.FromArgb(255, 128, 128);
            }
            //CboPuerto.Items.Clear();
            //string[] ports = SerialPort.GetPortNames();
            //CboPuerto.Items.AddRange(ports);
            //int i;
            //i = CboPuerto.Items.Count;
            //i = i - i;
            //try
            //{
            //    CboPuerto.SelectedIndex = i;

            //}
            //catch
            //{
            //    CboPuerto.Text = "";
            //    CboPuerto.Items.Clear();
            //}
            //CboPuerto.DroppedDown = true;
        }
        private void Recargar_FormClosed(object sender, FormClosedEventArgs e)
        {
            IsClosed = true;
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            }
        private void BtnRecargar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (TxtValor.Text != "")
                {
                    
                    float  Saldo = float.Parse(TxtSaldo.Text, CultureInfo.InvariantCulture);
                    float  Valor = float.Parse(TxtValor.Text, CultureInfo.InvariantCulture);
                    float total = Saldo + Valor;
                    string val = Convert.ToString(total);
                    int count = val.Length;
                    char[] arr;
                    arr = val.ToCharArray(0, count);
                    for (int i = 0; i < count; i++)
                    {
                        if (arr[i] == ',')
                        {
                            arr[i] = '.';
                        }
                    }
                    string dato = new string(arr);
                    serialPort1.Write(dato + "#");
                    RtxtDatos.Text += ("Valor Recarga: $" + Valor + "\r\n");
                    RtxtDatos.Text += "Total: $" + dato + "\r\n";

                    tarjeta.estado = EstadoEntidad.Agregar;
                    tarjeta.IdEmpleado = UserCache.IdEmpleado;
                    tarjeta.Uid = TxtUid.Text;
                    tarjeta.Fecha = DateTime.Now;
                    tarjeta.Valor_Recarga =Valor;
                   
                    string result=tarjeta.Guardar();
                    MessageBox.Show(result);
                }
                else
                {
                    MessageBox.Show("Ingrese un valor a recargar");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Algo salio mal");
            }
           
            // enviar datos por char
            //string cadena = TxtValor.Text;
            //string count = "";
            //count= Convert.ToString(TxtValor.Text.Length);
            //char[] arr;
            //arr = cadena.ToCharArray(0, Convert.ToInt32(count));
            //for (int i = 0; i < Convert.ToInt32(count); i++)
            //{
            //    string dato = Convert.ToString(arr[i]);
            //        serialPort1.Write(dato);
            //}
        }
        private void BtnScan_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                RtxtDatos.Clear();
                serialPort1.Open();
                serialPort1.DataReceived += serialPort1_DataReceived;
                BtnRecargar.Enabled = true;
                BtnScan.Enabled = false;
            }
            else
            {
                serialPort1.Close();
            }
            
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            cerrar();
        }
        public void cerrar()
        {
            BtnRecargar.Enabled = false;
            BtnScan.Enabled = true;
            serialPort1.Close();
            TxtSaldo.Clear();
            TxtUid.Clear();
            TxtValor.Clear();
            cont = 0;
        }

        private void Recargar_FormClosing(object sender, FormClosingEventArgs e)
        {
            cerrar();
        }

        private void TxtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
    
    
}
