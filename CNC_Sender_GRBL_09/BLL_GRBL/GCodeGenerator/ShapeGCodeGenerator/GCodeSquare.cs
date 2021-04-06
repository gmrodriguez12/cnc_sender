using System;
using System.Linq;
using System.Text;
using BLL_GRBL.GCodeValidation.Square;
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
            var validation = new SquareIsValid().Validate(square);

            if (!validation.IsValid)
                throw new Exception(string.Join("\n", validation.Erros.Select(w => w.Message)));

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
