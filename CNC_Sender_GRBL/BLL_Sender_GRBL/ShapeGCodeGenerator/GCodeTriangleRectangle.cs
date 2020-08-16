using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT_Sender_GRBL;

namespace BLL_Sender_GRBL.ShapeGCodeGenerator
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

        /*
        G0 X1
        G1 X6 Y0 F150
        G1 X2.5 Y5 F150
        G1 X1 Y0

        G0 es movimiento rápido a una posición específica.
        G1 es para mover a la velocidad establecida por el feed a la posición x e y establecida

        Después de G0 debería ir un G1 para poner el z a la altura de corte
         */

    }
}
