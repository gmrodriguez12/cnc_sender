using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_GRBL.GCodeValidation
{
    public static class OriginValidation
    {
        public static bool IsValid(double x, double y, double z)
        {
            double maxXAxis = double.Parse(ConfigurationManager.AppSettings["MAX_X_AXIS_mm"]);
            double maxYAxis = double.Parse(ConfigurationManager.AppSettings["MAX_Y_AXIS_mm"]);
            double maxZAxis = double.Parse(ConfigurationManager.AppSettings["MAX_Z_AXIS_mm"]);
            return ((x >= 0 && x <= maxXAxis) && (y >= 0 && y <= maxYAxis) && (z >= 0 && z <= maxZAxis));

            //This validation works on machines that do not require drilling the surface, such as Plasma or Laser.
        }
    }
}