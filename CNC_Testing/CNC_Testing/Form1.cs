using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNC_Testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadSerialPorts();

            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                MessageBox.Show("Derecha");

            else if (e.KeyCode == Keys.A)
                MessageBox.Show("A");

            else
                MessageBox.Show(e.KeyCode.ToString());

        }


        //BASIC CODE
        //Only for technical test

        SerialPort serial = new SerialPort();
        List<string> lstInputLines = new List<string>();

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenSerial();

                btnClose.Enabled = true;
                btnOpen.Enabled = false;
                cboCom.Enabled = false;
                lblStatus.Text = "Conexión Abierta";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void OpenSerial()
        {
            serial.PortName = cboCom.SelectedItem.ToString();
            serial.BaudRate = 115200;
            serial.DataBits = 8;
            serial.Parity = Parity.None; //?
            serial.StopBits = StopBits.One; //?
            serial.Handshake = Handshake.None; //?
            serial.NewLine = "\n";
            serial.WriteTimeout = 1000;
            serial.DtrEnable = false; //?
            serial.RtsEnable = false; //?
            serial.Open();
            serial.DiscardOutBuffer();
            serial.DiscardInBuffer();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if(serial.IsOpen)
            {
                serial.Close();

                lblStatus.Text = "Conexión Cerrada";
                btnOpen.Enabled = true;
                btnClose.Enabled = false;
                cboCom.Enabled = true;

                LoadSerialPorts();
            }
            else
                MessageBox.Show("La conexión ya fue cerrada");
        }

        private void LoadSerialPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            cboCom.DataSource = ports;
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            serial.WriteLine("G91");
            serial.WriteLine("G0X-5.0F500");
            serial.WriteLine("G90");

            serial.DiscardOutBuffer();
            serial.DiscardInBuffer();
        }

        private void BtnXLeft_Click(object sender, EventArgs e)
        {
            serial.WriteLine("G91");
            serial.WriteLine("G0X5.0F500");
            serial.WriteLine("G90");

            serial.DiscardOutBuffer();
            serial.DiscardInBuffer();
        }

        private void BtnYRight_Click(object sender, EventArgs e)
        {
            //Probar serial writeline

            serial.WriteLine("G91");
            serial.WriteLine("G0Y-10.0F500");
            serial.WriteLine("G90");

            serial.DiscardOutBuffer();
            serial.DiscardInBuffer();
        }

        private void BtnYLeft_Click(object sender, EventArgs e)
        {
            serial.WriteLine("G91");
            serial.WriteLine("G0Y10.0F500");
            serial.WriteLine("G90");

            serial.DiscardOutBuffer();
            serial.DiscardInBuffer();
        }

        private void BtnZup_Click(object sender, EventArgs e)
        {
            serial.WriteLine("G91");
            serial.WriteLine("G0Z1.0F500");
            serial.WriteLine("G90");

            serial.DiscardOutBuffer();
            serial.DiscardInBuffer();
        }

        private void BtnZDown_Click(object sender, EventArgs e)
        {
            //serial.WriteLine("G91");
            //serial.WriteLine("G0Z-1.0F500");
            //serial.WriteLine("G90");

            serial.WriteLine("G91");
            serial.WriteLine("G0Z-1.0F500");
            serial.WriteLine("G90");

            serial.DiscardOutBuffer();
            serial.DiscardInBuffer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Ejecutando";

            int width_mm = int.Parse(txtWidth.Text);
            int height_mm = int.Parse(txtHeight.Text);
            int z_min_height = chkSimulate.Checked ? 2 : 0;

            if(chkRele.Checked)
                serial.WriteLine("M3");

            serial.WriteLine("G21");
            serial.WriteLine("G00 Z5.000000");
            serial.WriteLine("G00 X0.220703 Y59.779300");
            serial.WriteLine("G01 Z-0.100000 F100.0");
            serial.WriteLine($"G01 X0.000000 Y0.000000 Z-{z_min_height}.000000 F800.000000");
            serial.WriteLine($"G01 X{width_mm}.000000 Y0.000000 Z-{z_min_height}.000000");
            serial.WriteLine($"G01 X{width_mm}.000000 Y{height_mm}.000000 Z-{z_min_height}.000000");
            serial.WriteLine($"G01 X0.000000 Y{height_mm}.000000 Z-{z_min_height}.000000");
            serial.WriteLine("G00 Z5.000000\n");

            if(chkRele.Checked)
                serial.WriteLine("M5");

            serial.WriteLine("G00 X0.0000 Y0.0000");

            if(chkRele.Checked)
                serial.WriteLine("M2");

            lblStatus.Text = "Libre";
        }

        private void BtnReturnZero_Click(object sender, EventArgs e)
        {
            serial.WriteLine("G90 G0 X0 Y0");
            serial.WriteLine("G90 G0 Z0");
        }

        private void BtnExplore_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        lstInputLines.Add(reader.ReadLine());
                        lblImportationResult.Text = $"Archivo importado {filePath}";
                    }
                }
            }
        }

        private void BtnRunImport_Click(object sender, EventArgs e)
        {
            if(lstInputLines.Count > 0)
            {
                foreach(var line in lstInputLines)
                {
                    if(line.StartsWith("G") || line.StartsWith("M"))
                    {
                        serial.WriteLine(line);
                    }
                }
            }
        }

        private void BtnSetHome_Click(object sender, EventArgs e)
        {
            serial.WriteLine("G10 P0 L20 X0 Y0 Z0");
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            serial.Close();
            Thread.Sleep(1000);

            OpenSerial();
        }

        private void BtnSetProperty_Click(object sender, EventArgs e)
        {
            serial.WriteLine("$31=0");
        }
    }
}
