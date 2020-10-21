
using System;
using System.Text;
using System.Windows.Forms;
using BLL_GRBL_Sender;

namespace TestForms
{
    public partial class Form1 : Form
    {
        const int SAFE_VERTICAL_HEIGHT_CM = 10;
        StringBuilder bufferCode = new StringBuilder();

        public Form1()
        {
            InitializeComponent();
            LoadSerialPorts();
        }

        private void LoadSerialPorts()
        {
            //string[] ports = SerialPortManager.ListAvailablePorts();
            //cboCom.DataSource = ports;
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            //SerialPortManager.OpenConnection(cboCom.SelectedItem.ToString());
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            //SerialPortManager.CloseConnection();
        }

        private void BtnSetHome_Click(object sender, EventArgs e)
        {
            //GCodeHome home = new GCodeHome();
            //home.SetHomePoint();
        }

        private void BtnHoming_Click(object sender, EventArgs e)
        {
            //GCodeHome home = new GCodeHome();
            //home.ReturnToHome(SAFE_VERTICAL_HEIGHT_CM);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //GCodeShapeFactory gcodeFactory = new GCodeShapeFactory();

            //bool simulate = chkSimulateSquare.Checked;

            //Square squareTest = new Square()
            //{
            //    Start = new ENT_Sender_GRBL.Point(2, 2, simulate ? 5 : 0),
            //    Feed = 150,
            //    SafetyHeightZ = SAFE_VERTICAL_HEIGHT_CM,
            //    Length = double.Parse(txtSquareSide.Text)
            //};

            //IGCodeGenerator shapeGenerator = gcodeFactory.Build((short)ENT_Sender_GRBL.Enum.EnumHelpers.TypeGeometric.Square);
            //StringBuilder gCodeCmd = shapeGenerator.GenerateSimulatorGCode(squareTest);
            //txtGCodeSquare.Text = gCodeCmd.ToString();
            //bufferCode = gCodeCmd;
        }

        private void BtnCutSquare_Click(object sender, EventArgs e)
        {
            //SerialPortManager.ExecuteCommands(bufferCode);
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
