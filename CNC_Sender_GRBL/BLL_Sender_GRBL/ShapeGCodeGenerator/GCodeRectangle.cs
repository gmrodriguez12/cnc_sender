using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT_Sender_GRBL;

namespace BLL_Sender_GRBL.ShapeGCodeGenerator
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

        /*
            G0 X2 Y2
            G1 X2 Y6 F150
            G1 X4 Y6 F150
            G1 X4 Y2 F150
            G1 X2 Y2 F150
            G0 X0 Y0
         */
    }
}
