using BLL_Sender_GRBL;
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

            Square square = new Square()
            {
                Start = new Point(2, 3, 1),
                Feed = 150,
                SafetyHeightZ = 10,
                Length = 5
            };

            var geometric = GCodeFactory.Build((short)TypeGeometric.Square);
            StringBuilder sb = geometric.GenerateSimulatorGCode(square);

            Console.WriteLine(sb.ToString());

            Console.ReadLine();
        }
    }
}
