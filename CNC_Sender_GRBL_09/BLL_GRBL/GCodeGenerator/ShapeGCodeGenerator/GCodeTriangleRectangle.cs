using System.Text;
using ENT_Sender_GRBL;

namespace BLL_Sender_GRBL.GCodeGenerator.ShapeGCodeGenerator
{
    internal class GCodeTriangleRectangle : IGCodeGenerator
    {
        public override StringBuilder GenerateGCode(Geometric shape)
        {
            TriangleRectangle triangle = (TriangleRectangle)shape;
            return GenerateGcode(triangle, false);
        }

        public override StringBuilder GenerateSimulatorGCode(Geometric shape)
        {
            TriangleRectangle triangle = (TriangleRectangle)shape;
            return GenerateGcode(triangle, true);
        }

        private StringBuilder GenerateGcode(TriangleRectangle triangle, bool isSimulator)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(GMovement(triangle.Start, "G0"));

            if (!isSimulator)
                sb.AppendLine(ToggleRele(true));

            sb.AppendLine(GMovement(triangle.A, triangle.Feed, "G1"));
            sb.AppendLine(GMovement(triangle.B, triangle.Feed, "G1"));
            sb.AppendLine(GMovement(triangle.Start, triangle.Feed, "G1"));

            if (!isSimulator)
                sb.AppendLine(ToggleRele(false));

            sb.AppendLine(ReturnToHome(triangle.SafetyHeightZ));
            return sb;
        }
    }
}
