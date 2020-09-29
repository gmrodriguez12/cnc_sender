using BLL_Sender_GRBL;
using BLL_Sender_GRBL.GCodeGenerator;
using BLL_Sender_GRBL.GCodeGenerator.SimpleMovements;
using BLL_Sender_GRBL.SerialPortManager;
using ENT_Sender_GRBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ENT_Sender_GRBL.Enum.EnumHelpers;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Line lineDefinition = new Line()
            //{
            //    Start = new Point()
            //    {
            //        X = 2,
            //        Y = 3,
            //        Z = 1
            //    },
            //    Feed = 150,
            //    Finish = new Point()
            //    {
            //        X = 5,
            //        Y = 7,
            //        Z = 1
            //    },
            //    SafetyHeightZ = 10
            //};         

            //var geometric = GCodeFactory.Build((short)TypeGeometric.Line);
            //StringBuilder sb = geometric.GenerateSimulatorGCode(lineDefinition);

            //Console.WriteLine(sb.ToString());

            //Rectangle rectangle = new Rectangle()
            //{
            //    Start = new Point(2, 2, 1),
            //    Feed = 150,
            //    SafetyHeightZ = 10,
            //    Length = 6,
            //    Width = 2
            //};

            //TriangleRectangle triangle = new TriangleRectangle()
            //{
            //    Start = new Point(2, 0, 1),
            //    Feed = 150,
            //    SafetyHeightZ = 10,
            //    LengthSide = 1,
            //    HeigthSide = 3
            //};



            //StringBuilder sb1 = new StringBuilder();
            //sb1.AppendLine("Ln1");
            //sb1.AppendLine("Ln2");
            //sb1.AppendLine("Ln3");

            //string[] lines = sb1.ToString().Split(Environment.NewLine.ToCharArray());

            //foreach (var line in lines)
            //{
            //    Console.WriteLine("line: " + line);
            //}

            //Console.ReadLine();

            //Circle circle = new Circle(1, 1, 1, 500);
            //GCodeShapeFactory gcodeFactory = new GCodeShapeFactory();

            //IGCodeGenerator shapeGenerator = gcodeFactory.Build((short)TypeGeometric.Circle);
            //StringBuilder sb = shapeGenerator.GenerateSimulatorGCode(circle);

            //Console.WriteLine(sb.ToString());

            //Console.ReadLine();

            //ListOpenPorts();

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Open Connection");
            Console.WriteLine("2) Close Connection");
            Console.WriteLine("3) Set Home");
            Console.WriteLine("4) Return to Home");
            Console.WriteLine("5) Simulate Square");
            Console.WriteLine("6) Exit");
            Console.WriteLine("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Choose an connection:");
                    string nroConnection = Console.ReadLine();
                    OpenConnection(nroConnection);
                    return true;
                case "2":
                    CloseConnection();
                    Console.WriteLine("Connection closed");
                    return true;
                case "3":
                    SetHome();
                    Console.WriteLine("Home set success");
                    return true;
                case "4":
                    Console.WriteLine("Returning to home");
                    ReturnToHome();
                    return true;
                case "5":
                    Console.WriteLine("Indicate the L in cm");
                    double side = double.Parse(Console.ReadLine());
                    RunSquare(false, side);
                    return true;
                case "6":
                    return false;
            }

            return false;
        }

        private static void ListOpenPorts()
        {
            string[] serialPorts = SerialPortManager.ListAvailablePorts();
            foreach(var item in serialPorts)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        private static void SetHome()
        {
            GCodeHome home = new GCodeHome();
            home.SetHomePoint();
        }

        private static void ReturnToHome()
        {
            GCodeHome home = new GCodeHome();
            home.ReturnToHome(10);
        }

        private static void OpenConnection(string portName)
        {
            SerialPortManager.OpenConnection(portName);
        }

        private static void CloseConnection()
        {
            SerialPortManager.CloseConnection();
        }

        private static void RunSquare(bool simulate, double sideLenght)
        {
            GCodeShapeFactory gcodeFactory = new GCodeShapeFactory();

            Square squareTest = new Square()
            {
                Start = new Point(2, 2, simulate ? 5 : 0),
                Feed = 150,
                SafetyHeightZ = 10,
                Length = sideLenght
            };

            IGCodeGenerator shapeGenerator = gcodeFactory.Build((short)TypeGeometric.Square);
            StringBuilder gCodeCmd = shapeGenerator.GenerateSimulatorGCode(squareTest);

            Console.WriteLine("Square Generated Code");
            Console.WriteLine(gCodeCmd.ToString());
            Console.WriteLine($"Sending codes to machine - {DateTime.Now.ToString()}");

            SerialPortManager.ExecuteCommands(gCodeCmd);

            Console.WriteLine($"Finish machine excution - {DateTime.Now.ToString()}");
        }
    }
}
