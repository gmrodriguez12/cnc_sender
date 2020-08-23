using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT_Sender_GRBL;

namespace BLL_Sender_GRBL.ShapeGCodeGenerator
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
