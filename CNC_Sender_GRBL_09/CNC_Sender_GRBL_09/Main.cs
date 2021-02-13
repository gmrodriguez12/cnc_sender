using BLL_Sender_GRBL.GCodeGenerator;
using BLL_Sender_GRBL.GCodeGenerator.SimpleMovements;
using BLL_Sender_GRBL.SerialPortManager;
using ENT_GRBL.Config;
using ENT_Sender_GRBL;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CNC_Sender_GRBL_09
{
    public partial class Main : Form
    {
        const int SAFE_VERTICAL_HEIGHT_CM = 10;
        StringBuilder bufferCode = new StringBuilder();
        GCodeSimpleMovements simpleMovements = null;
        double feed = 0;

        public Main()
        {
            InitializeComponent();
            LoadSerialPorts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboShape.SelectedIndex = 1;
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

                SerialPortManager.ReceiveDataFromGRBLDelegate delegateGrbl = new SerialPortManager.ReceiveDataFromGRBLDelegate(ShowResponse);
                SerialPortManager.ReceiveDataEvent += delegateGrbl;

                feed = !string.IsNullOrEmpty(txtFeed.Text) ? double.Parse(txtFeed.Text) : 500;
                lblStatus.Text = "Idle";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Error";
            }
        }

        private void ShowResponse(string data)
        {
            CheckForIllegalCrossThreadCalls = false;
            txtLog.AppendText(data);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            SerialPortManager.CloseConnection();
        }

        private void BtnSetHome_Click(object sender, EventArgs e)
        {
            GCodeHome home = new GCodeHome();
            string gCode = home.SetHomePoint();
            txtLog.Text = gCode;

            SerialPortManager.ExecuteCommand(gCode);
        }

        private void BtnHoming_Click(object sender, EventArgs e)
        {
            GCodeHome home = new GCodeHome();
            string gCode = home.ReturnToHome(SAFE_VERTICAL_HEIGHT_CM);
            txtLog.Text = gCode;

            SerialPortManager.ExecuteCommand(gCode);
        }

        private void BtnGenerateSquare_Click(object sender, EventArgs e)
        {
            try
            {
                bool simulate = chkSimulateSquare.Checked;
                string[] points = txtSquareOrigin.Text.Split(',');

                Square square = new Square()
                {
                    Start = new Point(double.Parse(points[0]), double.Parse(points[1]), simulate ? (double)SAFE_VERTICAL_HEIGHT_CM : 0),
                    Feed = int.Parse(txtFeed.Text),
                    SafetyHeightZ = SAFE_VERTICAL_HEIGHT_CM,
                    Side = double.Parse(txtSquareSide.Text)
                };

                GenerateShapeCode((short)ENT_Sender_GRBL.Enum.EnumHelpers.TypeGeometric.Square, square, simulate);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateShapeCode(short typeGeometric, Geometric shape, bool simulate)
        {
            GCodeShapeFactory gcodeFactory = new GCodeShapeFactory();
            IGCodeGenerator shapeGenerator = gcodeFactory.Build(typeGeometric);
            StringBuilder gCodeCmd = simulate ? shapeGenerator.GenerateSimulatorGCode(shape) : shapeGenerator.GenerateGCode(shape);

            txtLog.Text = gCodeCmd.ToString();

            bufferCode = new StringBuilder();
            bufferCode = gCodeCmd;

            if(gCodeCmd != null)
                SerialPortManager.ExecuteCommands(gCodeCmd);
        }

        private void BtnCutSquare_Click(object sender, EventArgs e)
        {
            SerialPortManager.ExecuteCommands(bufferCode);
        }

        private void btnXleft_Click(object sender, EventArgs e)
        {
            double distance = double.Parse(txtDistance.Text) * -1;
            StringBuilder sb = simpleMovements.MoveX(distance, feed);
            txtLog.Text = sb.ToString();

            SerialPortManager.ExecuteCommands(sb);
        }

        private void btnXright_Click(object sender, EventArgs e)
        {
            double distance = double.Parse(txtDistance.Text);
            StringBuilder sb = simpleMovements.MoveX(distance, feed);
            txtLog.Text = sb.ToString();

            SerialPortManager.ExecuteCommands(sb);
        }

        private void btnYleft_Click(object sender, EventArgs e)
        {
            double distance = double.Parse(txtDistance.Text) * -1;
            StringBuilder sb = simpleMovements.MoveY(distance, feed);
            txtLog.Text = sb.ToString();

            SerialPortManager.ExecuteCommands(sb);
        }

        private void btnYrigth_Click(object sender, EventArgs e)
        {
            double distance = double.Parse(txtDistance.Text);
            StringBuilder sb = simpleMovements.MoveY(distance, feed);
            txtLog.Text = sb.ToString();

            SerialPortManager.ExecuteCommands(sb);
        }

        private void btnZUp_Click(object sender, EventArgs e)
        {
            double distance = double.Parse(txtDistance.Text);
            StringBuilder sb = simpleMovements.MoveZ(distance, feed);
            txtLog.Text = sb.ToString();

            SerialPortManager.ExecuteCommands(sb);
        }

        private void btnZDown_Click(object sender, EventArgs e)
        {
            double distance = double.Parse(txtDistance.Text) * -1;
            StringBuilder sb = simpleMovements.MoveZ(distance, feed);
            txtLog.Text = sb.ToString();

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

            GenerateShapeCode((short)ENT_Sender_GRBL.Enum.EnumHelpers.TypeGeometric.TriangleRectangle, triangle, simulate);
        }

        private void btnGenCircleCode_Click(object sender, EventArgs e)
        {
            try
            {
                bool simulate = chkSimulateSquare.Checked;
                string[] start = txtCenterCircle.Text.Split(',');

                Circle circle = new Circle()
                {
                    Feed = int.Parse(txtFeed.Text),
                    Center = new Point(double.Parse(start[0]), double.Parse(start[1]), simulate ? (double)SAFE_VERTICAL_HEIGHT_CM : 0),
                    SafetyHeightZ = SAFE_VERTICAL_HEIGHT_CM,
                    Radio = double.Parse(txtRadius.Text)
                };

                GenerateShapeCode((short)ENT_Sender_GRBL.Enum.EnumHelpers.TypeGeometric.Circle, circle, simulate);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenLineCode_Click(object sender, EventArgs e)
        {
            try
            {
                bool simulate = chkSimulateSquare.Checked;
                string[] start = txtLinePointA.Text.Split(',');
                string[] finish = txtLinePointB.Text.Split(',');

                Line line = new Line()
                {
                    Feed = int.Parse(txtFeed.Text),
                    Start = new Point(double.Parse(start[0]), double.Parse(start[1]), simulate ? (double)SAFE_VERTICAL_HEIGHT_CM : 0),
                    Finish = new Point(double.Parse(finish[0]), double.Parse(finish[1]), simulate ? (double)SAFE_VERTICAL_HEIGHT_CM : 0),
                    SafetyHeightZ = SAFE_VERTICAL_HEIGHT_CM
                };

                GenerateShapeCode((short)ENT_Sender_GRBL.Enum.EnumHelpers.TypeGeometric.Line, line, simulate);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenCodeRectangle_Click(object sender, EventArgs e)
        {
            try
            {
                bool simulate = chkSimulateSquare.Checked;
                string[] start = txtRectangleOrigin.Text.Split(',');

                Rectangle rectangle = new Rectangle()
                {
                    Feed = int.Parse(txtFeed.Text),
                    Start = new Point(double.Parse(start[0]), double.Parse(start[1]), simulate ? (double)SAFE_VERTICAL_HEIGHT_CM : 0),
                    Height = double.Parse(txtRectangleSideA.Text),
                    Width = double.Parse(txtRectangleSideB.Text),
                    SafetyHeightZ = SAFE_VERTICAL_HEIGHT_CM
                };

                GenerateShapeCode((short)ENT_Sender_GRBL.Enum.EnumHelpers.TypeGeometric.Rectangle, rectangle, simulate);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnProperties_Click(object sender, EventArgs e)
        {
            SerialPortManager.serial.WriteLine("$$");
            txtLog.Text = SerialPortManager.Properties;
        }

        private void CboShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedShape = cboShape.SelectedIndex;
            grpSquare.Visible = selectedShape == 0;
            grpRectangle.Visible = selectedShape == 1;
            grpTriangle.Visible = selectedShape == 2;
            grpCircle.Visible = selectedShape == 3;
            grpLine.Visible = selectedShape == 4;
         }

        private void TxtCmd_MouseClick(object sender, MouseEventArgs e)
        {
            txtCmd.Text = string.Empty;
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            SerialPortManager.ExecuteCommand(txtCmd.Text);
        }
    }
}
