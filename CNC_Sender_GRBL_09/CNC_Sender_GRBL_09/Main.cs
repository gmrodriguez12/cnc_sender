using BLL_GRBL.DomainValidation;
using BLL_Sender_GRBL.GCodeGenerator;
using BLL_Sender_GRBL.GCodeGenerator.SimpleMovements;
using BLL_Sender_GRBL.SerialPortManager;
using ENT_Sender_GRBL;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace CNC_Sender_GRBL_09
{
    public partial class Main : Form
    {
        const int SAFE_VERTICAL_HEIGHT_CM = 10;
        StringBuilder bufferCode = new StringBuilder();
        GCodeSimpleMovements simpleMovements = null;
        double feed;

        public Main()
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
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            try
            {
                bool simulate = chkSimulateSquare.Checked;
                string[] points = txtStartSquare.Text.Split(',');

                Square square = new Square()
                {
                    Start = new Point(double.Parse(points[0]), double.Parse(points[1]), simulate ? (double)SAFE_VERTICAL_HEIGHT_CM : double.Parse(points[2])),
                    Feed = int.Parse(txtFeed.Text),
                    SafetyHeightZ = SAFE_VERTICAL_HEIGHT_CM,
                    Side = double.Parse(txtSquareSide.Text)
                };

                GenerateShapeCode((short)ENT_Sender_GRBL.Enum.EnumHelpers.TypeGeometric.Square, square, simulate);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateShapeCode(short typeGeometric, Geometric shape, bool simulate)
        {
            GCodeShapeFactory gcodeFactory = new GCodeShapeFactory();
            IGCodeGenerator shapeGenerator = gcodeFactory.Build(typeGeometric);
            StringBuilder gCodeCmd = simulate ? shapeGenerator.GenerateSimulatorGCode(shape) : shapeGenerator.GenerateGCode(shape);

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
                Lenght = double.Parse(txtTriangleWidth.Text),
                Height = double.Parse(txtTriangleHeight.Text)
            };

            //if triangle is valid

            GenerateShapeCode((short)ENT_Sender_GRBL.Enum.EnumHelpers.TypeGeometric.TriangleRectangle, triangle, simulate);
        }

        private void btnGenCircleCode_Click(object sender, EventArgs e)
        {
            bool simulate = chkSimulateSquare.Checked;
            string[] start = txtCenterCircle.Text.Split(',');

            Circle circle = new Circle()
            {
                Feed = int.Parse(txtFeed.Text),
                Center = new Point(double.Parse(start[0]), double.Parse(start[1]), simulate ? (double)SAFE_VERTICAL_HEIGHT_CM : double.Parse(start[2])),
                SafetyHeightZ = SAFE_VERTICAL_HEIGHT_CM,
                Radio = double.Parse(txtRadius.Text)
            };

            GenerateShapeCode((short)ENT_Sender_GRBL.Enum.EnumHelpers.TypeGeometric.Circle, circle, simulate);
        }

        private void btnGenLineCode_Click(object sender, EventArgs e)
        {
            bool simulate = chkSimulateSquare.Checked;
            string[] start = txtStartLine.Text.Split(',');
            string[] finish = txtFinishLine.Text.Split(',');

            Line line = new Line()
            {
                Feed = int.Parse(txtFeed.Text),
                Start = new Point(double.Parse(start[0]), double.Parse(start[1]), simulate ? (double)SAFE_VERTICAL_HEIGHT_CM : double.Parse(start[2])),
                Finish = new Point(double.Parse(finish[0]), double.Parse(finish[1]), simulate ? (double)SAFE_VERTICAL_HEIGHT_CM : double.Parse(finish[2])),
                SafetyHeightZ = SAFE_VERTICAL_HEIGHT_CM
            };

            GenerateShapeCode((short)ENT_Sender_GRBL.Enum.EnumHelpers.TypeGeometric.Line, line, simulate);
        }

        private void btnGenCodeRectangle_Click(object sender, EventArgs e)
        {
            try
            {
                bool simulate = chkSimulateSquare.Checked;
                string[] start = txtStartRectangle.Text.Split(',');

                Rectangle rectangle = new Rectangle()
                {
                    Feed = int.Parse(txtFeed.Text),
                    Start = new Point(double.Parse(start[0]), double.Parse(start[1]), simulate ? (double)SAFE_VERTICAL_HEIGHT_CM : double.Parse(start[2])),
                    Width = double.Parse(txtWidthRectangle.Text),
                    Height = double.Parse(txtHeightRectangle.Text),
                    SafetyHeightZ = SAFE_VERTICAL_HEIGHT_CM
                };
           
                GenerateShapeCode((short)ENT_Sender_GRBL.Enum.EnumHelpers.TypeGeometric.Rectangle, rectangle, simulate);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnProperties_Click(object sender, EventArgs e)
        {
            SerialPortManager.serial.WriteLine("$$");
            txtGCode.Text = SerialPortManager.Properties;
        }
    }
} 
