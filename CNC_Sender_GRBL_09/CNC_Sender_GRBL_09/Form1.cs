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
                txtGCode.Text = ex.Message;
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
            txtGCode.Text = gCode;

            SerialPortManager.ExecuteCommand(gCode);
        }

        private void BtnHoming_Click(object sender, EventArgs e)
        {
            GCodeHome home = new GCodeHome();
            string gCode = home.ReturnToHome(SAFE_VERTICAL_HEIGHT_CM);
            txtGCode.Text = gCode;

            SerialPortManager.ExecuteCommand(gCode);
        }

        private void BtnGenerateSquare_Click(object sender, EventArgs e)
        {           
            bool simulate = chkSimulateSquare.Checked;
            string[] points = txtTriangleStart.Text.Split(',');

            Square square = new Square()
            {
                Start = new Point(double.Parse(points[0]), double.Parse(points[1]), simulate ? (double)SAFE_VERTICAL_HEIGHT_CM : double.Parse(points[2])),
                Feed = int.Parse(txtFeed.Text),
                SafetyHeightZ = SAFE_VERTICAL_HEIGHT_CM,
                Length = double.Parse(txtSquareSide.Text)
            };

            GenerateShapeCode((short)ENT_Sender_GRBL.Enum.EnumHelpers.TypeGeometric.Square, square);
        }

        private void GenerateShapeCode(short typeGeometric, Geometric shape)
        {
            GCodeShapeFactory gcodeFactory = new GCodeShapeFactory();
            IGCodeGenerator shapeGenerator = gcodeFactory.Build(typeGeometric);
            StringBuilder gCodeCmd = shapeGenerator.GenerateSimulatorGCode(shape);

            txtGCode.Text = gCodeCmd.ToString();
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
            txtGCode.Text = sb.ToString();

            SerialPortManager.ExecuteCommands(sb);
        }

        private void btnXright_Click(object sender, EventArgs e)
        {
            double distance = double.Parse(txtDistance.Text);
            StringBuilder sb = simpleMovements.MoveX(distance, feed);
            txtGCode.Text = sb.ToString();

            SerialPortManager.ExecuteCommands(sb);
        }

        private void btnYleft_Click(object sender, EventArgs e)
        {
            double distance = double.Parse(txtDistance.Text) * -1;
            StringBuilder sb = simpleMovements.MoveY(distance, feed);
            txtGCode.Text = sb.ToString();

            SerialPortManager.ExecuteCommands(sb);
        }

        private void btnYrigth_Click(object sender, EventArgs e)
        {
            double distance = double.Parse(txtDistance.Text);
            StringBuilder sb = simpleMovements.MoveY(distance, feed);
            txtGCode.Text = sb.ToString();

            SerialPortManager.ExecuteCommands(sb);
        }

        private void btnZUp_Click(object sender, EventArgs e)
        {
            double distance = double.Parse(txtDistance.Text);
            StringBuilder sb = simpleMovements.MoveZ(distance, feed);
            txtGCode.Text = sb.ToString();

            SerialPortManager.ExecuteCommands(sb);
        }

        private void btnZDown_Click(object sender, EventArgs e)
        {
            double distance = double.Parse(txtDistance.Text) * -1;
            StringBuilder sb = simpleMovements.MoveZ(distance, feed);
            txtGCode.Text = sb.ToString();

            SerialPortManager.ExecuteCommands(sb);
        }

        private void btnGenCodeTriangle_Click(object sender, EventArgs e)
        {
            bool simulate = chkSimulateSquare.Checked;
            string[] points = txtTriangleStart.Text.Split(',');

            TriangleRectangle triangle = new TriangleRectangle()
            {
                Start = new Point(double.Parse(points[0]), double.Parse(points[1]), simulate ? (double)SAFE_VERTICAL_HEIGHT_CM : double.Parse(points[2])),
                Feed = int.Parse(txtFeed.Text),
                SafetyHeightZ = SAFE_VERTICAL_HEIGHT_CM,
                Length = double.Parse(txtTriangleWidth.Text),
                Heigth = double.Parse(txtTriangleHeight.Text)
            };

            GenerateShapeCode((short)ENT_Sender_GRBL.Enum.EnumHelpers.TypeGeometric.TriangleRectangle, triangle);
        }

        private void btnGenCircleCode_Click(object sender, EventArgs e)
        {
            bool simulate = chkSimulateSquare.Checked;
            string[] points = txtCenterCircle.Text.Split(',');

            Circle circle = new Circle()
            {
                Feed = int.Parse(txtFeed.Text),
                Center = new Point(double.Parse(points[0]), double.Parse(points[1]), simulate ? (double)SAFE_VERTICAL_HEIGHT_CM : double.Parse(points[2])),
                SafetyHeightZ = SAFE_VERTICAL_HEIGHT_CM,
                Radio = double.Parse(txtRadius.Text)
            };

            GenerateShapeCode((short)ENT_Sender_GRBL.Enum.EnumHelpers.TypeGeometric.Circle, circle);
        }
    }
}
