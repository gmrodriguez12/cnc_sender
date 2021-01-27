using System;
using System.Linq;
using System.Text;
using BLL_GRBL.GCodeValidation.Circle;
using ENT_Sender_GRBL;

namespace BLL_Sender_GRBL.GCodeGenerator.ShapeGCodeGenerator
{
    internal class GCodeCircle : IGCodeGenerator
    {
        public override StringBuilder GenerateGCode(Geometric shape)
        {
            Circle circle = (Circle)shape;
            return GenerateGcode(circle, false);
        }

        public override StringBuilder GenerateSimulatorGCode(Geometric shape)
        {
            Circle circle = (Circle)shape;
            return GenerateGcode(circle, true);
        }

        private StringBuilder GenerateGcode(Circle circle, bool isSimulator)
        {
            var validation = new CircleIsValid().Validate(circle);

            if (!validation.IsValid)
                throw new Exception(string.Join("\n", validation.Erros.Select(w => w.Message)));

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(GMovement(circle.Start, "G0"));

            if (!isSimulator)
                sb.AppendLine(ToggleRele(true));

            sb.AppendLine(GMovement(circle.Start, circle.Feed, "G1"));
            sb.AppendLine(GArc(circle.End, circle.Radio, 0, true));

            if (!isSimulator)
                sb.AppendLine(ToggleRele(false));

            sb.AppendLine(ReturnToHome(circle.SafetyHeightZ));
            return sb;
        }
    }
}
