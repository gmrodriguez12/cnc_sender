using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_GRBL.GCodeValidation
{
    public static class HeightValidation
    {
        public static bool IsValid(double height, double startY)
        {
            double max = 100; //TODO Get this value from config
            double aux = height + startY;
            return (aux >= 0 && aux <= max);
        }
    }
}
