using ENT_Sender_GRBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Sender_GRBL
{
    public abstract class IGCodeGenerator
    {
        public abstract StringBuilder GenerateGCode(Geometric shape);
        public abstract StringBuilder GenerateSimulatorGCode(Geometric shape);

        public string ReturnToOrigin()
        {
            return "G0 X0 Y0 Z0";
        }

        public string ToggleRele(bool on)
        {
            return on ? "M3" : "M5";
        }
    }
}
