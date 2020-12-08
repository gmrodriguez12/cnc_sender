using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_GRBL.GCodeValidation
{
    public static class WidthValidation
    {
        public static bool IsValid(double width, double startX)
        {
            double max = double.Parse(ConfigurationManager.AppSettings["Max_Width_mm"]);
            double aux = width + startX;

            return (aux > 0 && aux <= max);
        }
    }
}