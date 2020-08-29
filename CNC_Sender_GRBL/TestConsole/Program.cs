using BLL_Sender_GRBL;
using BLL_Sender_GRBL.GCodeGenerator;
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
            StringBuilder sb1 = new StringBuilder();
            sb1.AppendLine("Ln1");
            sb1.AppendLine("Ln2");
            sb1.AppendLine("Ln3");

            string[] lines = sb1.ToString().Split(Environment.NewLine.ToCharArray());

            foreach(var line in lines)
            {
                Console.WriteLine("line: " + line);
            }

            Console.ReadLine();

            Circle circle = new Circle(1, 1, 1, 500);
            GCodeShapeFactory gcodeFactory = new GCodeShapeFactory();

            IGCodeGenerator shapeGenerator = gcodeFactory.Build((short)TypeGeometric.Circle);
            StringBuilder sb = shapeGenerator.GenerateSimulatorGCode(circle);

            Console.WriteLine(sb.ToString());

            Console.ReadLine();
        }
    }
}
