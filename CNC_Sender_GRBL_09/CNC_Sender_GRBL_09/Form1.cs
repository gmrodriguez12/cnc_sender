using BLL_Sender_GRBL.GCodeGenerator;
using BLL_Sender_GRBL.GCodeGenerator.SimpleMovements;
using BLL_Sender_GRBL.SerialPortManager;
using ENT_Sender_GRBL;
using System;
using System.Text;
using System.Windows.Forms;

namespace CNC_Sender_GRBL_09
{
    public partial class Form1 : Form
    {
        const int SAFE_VERTICAL_HEIGHT_CM = 10;
        StringBuilder bufferCode = new StringBuilder();
        GCodeSimpleMovements simpleMovements = null;
        double feed;

        public Form1()
        {
            InitializeComponent();
            LoadSerialPorts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoadSerialPorts()
        {
            string[] ports = SerialPortManager.ListAvailablePorts();
            cboCom.DataSource = ports;
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPortManager.OpenConnection(cboCom.SelectedItem.ToString());
                simpleMovements = new GCodeSimpleMovements();
                feed = !string.IsNullOrEmpty(txtFeed.Text) ? double.Parse(txtFeed.Text) : 500;
                lblStatus.Text = "Conexión Abierta";
            }
            catch(Exception ex)
            {
                txtGCodeSquare.Text = ex.Message;
                lblStatus.Text = "Error";
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            SerialPortManager.CloseConnection();
        }

        private void BtnSetHome_Click(object sender, EventArgs e)
        {
            GCodeHome home = new GCodeHome();
            string gCode = home.SetHomePoint();
            txtGCodeSquare.Text = gCode;

            SerialPortManager.ExecuteCommand(gCode);
        }

        private void BtnHoming_Click(object sender, EventArgs e)
        {
            GCodeHome home = new GCodeHome();
            string gCode = home.ReturnToHome(SAFE_VERTICAL_HEIGHT_CM);
            txtGCodeSquare.Text = gCode;

            SerialPortManager.ExecuteCommand(gCode);
        }

        private void BtnGenerateSquare_Click(object sender, EventArgs e)
        {
            GCodeShapeFactory gcodeFactory = new GCodeShapeFactory();

            bool simulate = chkSimulateSquare.Checked;

            Square squareTest = new Square()
            {
                Start = new ENT_Sender_GRBL.Point(2, 2, simulate ? 5 : 0),
                Feed = int.Parse(txtFeed.Text),
                SafetyHeightZ = SAFE_VERTICAL_HEIGHT_CM,
                Length = double.Parse(txtSquareSide.Text)
            };

            IGCodeGenerator shapeGenerator = gcodeFactory.Build((short)ENT_Sender_GRBL.Enum.EnumHelpers.TypeGeometric.Square);
            StringBuilder gCodeCmd = shapeGenerator.GenerateSimulatorGCode(squareTest);
            txtGCodeSquare.Text = gCodeCmd.ToString();
            bufferCode = gCodeCmd;
        }

        private void BtnCutSquare_Click(object sender, EventArgs e)
        {
            SerialPortManager.ExecuteCommands(bufferCode);
        }

        private void btnXleft_Click(object sender, EventArgs e)
        {
            double distance = double.Parse(txtDistance.Text)* -1;
            StringBuilder sb = simpleMovements.MoveX(distance, feed);
            txtGCodeSquare.Text = sb.ToString();

            SerialPortManager.ExecuteCommands(sb);
        }

        private void btnXright_Click(object sender, EventArgs e)
        {
            double distance = double.Parse(txtDistance.Text);
            StringBuilder sb = simpleMovements.MoveX(distance, feed);
            txtGCodeSquare.Text = sb.ToString();

            SerialPortManager.ExecuteCommands(sb);
        }

        private void btnYleft_Click(object sender, EventArgs e)
        {
            double distance = double.Parse(txtDistance.Text) * -1;
            StringBuilder sb = simpleMovements.MoveY(distance, feed);
            txtGCodeSquare.Text = sb.ToString();

            SerialPortManager.ExecuteCommands(sb);
        }

        private void btnYrigth_Click(object sender, EventArgs e)
        {
            double distance = double.Parse(txtDistance.Text);
            StringBuilder sb = simpleMovements.MoveY(distance, feed);
            txtGCodeSquare.Text = sb.ToString();

            SerialPortManager.ExecuteCommands(sb);
        }

        private void btnZUp_Click(object sender, EventArgs e)
        {
            double distance = double.Parse(txtDistance.Text);
            StringBuilder sb = simpleMovements.MoveZ(distance, feed);
            txtGCodeSquare.Text = sb.ToString();

            SerialPortManager.ExecuteCommands(sb);
        }

        private void btnZDown_Click(object sender, EventArgs e)
        {
            double distance = double.Parse(txtDistance.Text) * -1;
            StringBuilder sb = simpleMovements.MoveZ(distance, feed);
            txtGCodeSquare.Text = sb.ToString();

            SerialPortManager.ExecuteCommands(sb);
        }
    }
}
