using System;
using System.Linq;
using System.Text;
using BLL_GRBL.DomainValidation;
using ENT_Sender_GRBL;

namespace BLL_Sender_GRBL.GCodeGenerator.ShapeGCodeGenerator
{
    internal class GCodeRectangle : IGCodeGenerator
    {
        public override StringBuilder GenerateGCode(Geometric shape)
        {
            Rectangle rectangle = (Rectangle)shape;
            return GenerateGcode(rectangle, true);
        }

        public override StringBuilder GenerateSimulatorGCode(Geometric shape)
        {
            Rectangle rectangle = (Rectangle)shape;
            return GenerateGcode(rectangle, true);
        }

        private StringBuilder GenerateGcode(Rectangle rectangle, bool isSimulator)
        {
            var validation = new RectangleIsValid().Validate(rectangle);

            if (!validation.IsValid)
                throw new Exception(string.Join(",", validation.Erros.Select(w => w.Message)));

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(GMovement(rectangle.Start, "G0"));

            if (!isSimulator)
                sb.AppendLine(ToggleRele(true));

            sb.AppendLine(GMovement(rectangle.A, rectangle.Feed, "G1"));
            sb.AppendLine(GMovement(rectangle.B, rectangle.Feed, "G1"));
            sb.AppendLine(GMovement(rectangle.C, rectangle.Feed, "G1"));
            sb.AppendLine(GMovement(rectangle.Start, rectangle.Feed, "G1"));

            if (!isSimulator)
                sb.AppendLine(ToggleRele(false));

            sb.AppendLine(ReturnToHome(rectangle.SafetyHeightZ));
            return sb;
        }
    }
}
