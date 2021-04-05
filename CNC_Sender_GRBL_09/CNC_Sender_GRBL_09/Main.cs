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
using static ENT_Sender_GRBL.Enum.EnumHelpers;

namespace CNC_Sender_GRBL_09
{
    public partial class Main : Form
    {
        const int SAFE_VERTICAL_HEIGHT_CM = 10;
        //StringBuilder bufferCode = new StringBuilder();
        List<string> grblCode = new List<string>();
        int numberExpectedRespones = 0;
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
            grpAxesMoves.Enabled = false;
            simpleMovements = new GCodeSimpleMovements();
            ManageInputs(SystemEvents.Load);
        }

        #region Control Machine

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
                ManageInputs(SystemEvents.Open);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Error";
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            SerialPortManager.CloseConnection();
            ManageInputs(SystemEvents.Close);
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

        private void CboCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManageInputs(SystemEvents.PortSelected);
        }

        private void ShowResponse(string data)
        {
            CheckForIllegalCrossThreadCalls = false;
            txtLog.AppendText(data);

            if (data.Contains("ok"))
            {
                numberExpectedRespones = (numberExpectedRespones - data.Split('\n').Length-1);
            }
            else if (data.Contains("error"))
            {
                //pending implement solution to show in red the affected line.
                txtLog.AppendText("Execution end with error");
                numberExpectedRespones = (numberExpectedRespones - data.Split('\n').Length-1);
            }
            
            if(numberExpectedRespones <= 0)
            {
                //txtLog.AppendText("Execution end success\n");
                ManageInputs(SystemEvents.Finish);
            }
        }

        #endregion

        #region Axis movement
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

        #endregion

        #region Events for cutting geometric shapes
        private void btnGenCodeTriangle_Click(object sender, EventArgs e)
        {
            bool simulate = chkSimulateSquare.Checked;
            string[] start = txtRectangleOrigin.Text.Split(',');

            TriangleRectangle triangle = new TriangleRectangle()
            {
                Start = new Point(double.Parse(start[0]), double.Parse(start[1]), simulate ? (double)SAFE_VERTICAL_HEIGHT_CM : 0),
                Feed = int.Parse(txtFeed.Text),
                SafetyHeightZ = SAFE_VERTICAL_HEIGHT_CM,
                Base = double.Parse(txtTriangleBase.Text),
                Height = double.Parse(txtTriangleHeight.Text)
            };

            GenerateShapeCode((short)TypeGeometric.TriangleRectangle, triangle, simulate);
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

                GenerateShapeCode((short)TypeGeometric.Circle, circle, simulate);
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

                GenerateShapeCode((short)TypeGeometric.Line, line, simulate);
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

                GenerateShapeCode((short)TypeGeometric.Rectangle, rectangle, simulate);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void CboShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedShape = cboShape.SelectedIndex;
            grpSquare.Visible = selectedShape == 0;
            grpRectangle.Visible = selectedShape == 1;
            grpTriangle.Visible = selectedShape == 2;
            grpCircle.Visible = selectedShape == 3;
            grpLine.Visible = selectedShape == 4;
        }

        private void GenerateShapeCode(short typeGeometric, Geometric shape, bool simulate)
        {
            GCodeShapeFactory gcodeFactory = new GCodeShapeFactory();
            IGCodeGenerator shapeGenerator = gcodeFactory.Build(typeGeometric);
            StringBuilder gCodeCmd = simulate ? shapeGenerator.GenerateSimulatorGCode(shape) : shapeGenerator.GenerateGCode(shape);

            //bufferCode = new StringBuilder();
            //bufferCode = gCodeCmd;
            
            if (gCodeCmd != null && gCodeCmd.Length > 0)
            {
                numberExpectedRespones = 0;
                txtLog.AppendText(gCodeCmd.ToString());

                //GRBL returns ok/error for each line sent. This variable is used to know when the excecution has finished.
                numberExpectedRespones = gCodeCmd.ToString().Split('\n').Length - 1;

                //ManageInputs(SystemEvents.Run);
                SerialPortManager.ExecuteCommands(gCodeCmd);
            }
        }

        #endregion

        #region Command
        private void TxtCmd_MouseClick(object sender, MouseEventArgs e)
        {
            txtCmd.Text = string.Empty;
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            ManageInputs(SystemEvents.Run);
            SerialPortManager.ExecuteCommand(txtCmd.Text);
        }

        #endregion

        #region Controls Enabled/Disabled
        private void ManageInputs(SystemEvents eventSystem)
        {
            switch (eventSystem)
            {
                case SystemEvents.Load:
                    LoadCloseEvent();
                    break;
                case SystemEvents.Close:
                    LoadCloseEvent();
                    break;
                case SystemEvents.PortSelected:
                    PortSelectedEvent();
                    break;
                case SystemEvents.Open:
                    OpenFinishEvent();
                    break;
                case SystemEvents.Finish:
                    OpenFinishEvent();
                    break;
                case SystemEvents.Stop:
                    OpenFinishEvent();
                    break;
                case SystemEvents.ErrorMachine:
                    OpenFinishEvent();
                    break;
                case SystemEvents.Run:
                    RunEvent();
                    break;
            }
        }

        private void RunEvent()
        {
            grpAxesMoves.Enabled = false;
            //grpLog.Enabled = false;
            grpTraceConfig.Enabled = false;
            txtFeed.Enabled = false;
            btnHoming.Enabled = false;
            //btnStop.Enabled = true;
            //btnStop.Visible = true;
        }

        private void OpenFinishEvent()
        {
            grpAxesMoves.Enabled = true;
            grpLog.Enabled = true;
            grpTraceConfig.Enabled = true;
            btnClose.Enabled = true;
            txtFeed.Enabled = true;
            btnHoming.Enabled = true;
            btnSetHome.Enabled = true;
            //btnStop.Visible = false;
            btnOpen.Enabled = false;
        }

        private void PortSelectedEvent()
        {
            btnOpen.Enabled = true;
        }

        private void LoadCloseEvent()
        {
            grpAxesMoves.Enabled = false;
            grpLog.Enabled = false;
            grpTraceConfig.Enabled = false;
            btnClose.Enabled = false;
            txtFeed.Enabled = false;
            btnHoming.Enabled = false;
            btnSetHome.Enabled = false;
            //btnStop.Visible = false;
            btnOpen.Enabled = true;
        }
        #endregion

    }
}
