using BLL_Sender_GRBL.GCodeGenerator;
using ENT_Sender_GRBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_GRBL.GCodeGenerator.ShapeGCodeGenerator
{
    public class GCodeTriangle : IGCodeGenerator
    {
        public override StringBuilder GenerateGCode(Geometric shape)
        {
            throw new NotImplementedException();
        }

        public override StringBuilder GenerateSimulatorGCode(Geometric shape)
        {
            throw new NotImplementedException();
        }
    }
}
