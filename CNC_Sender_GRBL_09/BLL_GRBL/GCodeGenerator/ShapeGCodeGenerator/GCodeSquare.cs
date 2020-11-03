using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT_Sender_GRBL;

namespace BLL_Sender_GRBL.GCodeGenerator.ShapeGCodeGenerator
{
    internal class GCodeSquare : IGCodeGenerator
    {
        public override StringBuilder GenerateGCode(Geometric shape)
        {
            Square square = (Square)shape;
            return GenerateGcode(square, false);
        }

        public override StringBuilder GenerateSimulatorGCode(Geometric shape)
        {
            Square square = (Square)shape;
            return GenerateGcode(square, true);
        }

        private StringBuilder GenerateGcode(Square square, bool isSimulator)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(GMovement(square.Start, "G0"));

            if (!isSimulator)
                sb.AppendLine(ToggleRele(true));

            sb.AppendLine(GMovement(square.A, square.Feed, "G1"));
            sb.AppendLine(GMovement(square.B, square.Feed, "G1"));
            sb.AppendLine(GMovement(square.C, square.Feed, "G1"));
            sb.AppendLine(GMovement(square.Start, square.Feed, "G1"));

            if (!isSimulator)
                sb.AppendLine(ToggleRele(false));

            sb.AppendLine(ReturnToHome(square.SafetyHeightZ));
            return sb;
        }
    }
}
