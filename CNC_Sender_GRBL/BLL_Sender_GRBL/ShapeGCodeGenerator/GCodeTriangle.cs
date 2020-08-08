using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT_Sender_GRBL;

namespace BLL_Sender_GRBL.ShapeGCodeGenerator
{
    internal class GCodeTriangle : IGCodeGenerator
    {
        public override StringBuilder GenerateGCode(Geometric shape)
        {
            /*
             G0 X1
            G1 X6 Y0 F150
            G1 X2.5 Y5 F150
            G1 X1 Y0

            G0 es movimiento rápido a una posición específica.
            G1 es para mover a la velocidad establecida por el feed a la posición x e y establecida

            Después de G0 debería ir un G1 para poner el z a la altura de corte
             */

            throw new NotImplementedException();
        }

        public override StringBuilder GenerateSimulatorGCode(Geometric shape)
        {
            throw new NotImplementedException();
        }
    }
}
