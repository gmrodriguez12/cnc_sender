using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_GRBL.GCodeValidation
{
    public static class HeightValidation
    {
        public static bool IsValid(double height, double startY)
        {
            double max = double.Parse(ConfigurationManager.AppSettings["Max_Height_mm"]);
            double aux = height + startY;

            return (aux > 0 && aux <= max);
        }
    }
}
