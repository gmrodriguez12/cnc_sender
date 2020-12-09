using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_GRBL.GCodeValidation
{
    public static class LineValidation
    {
        //public static bool IsValid(double lenght, double starAxis)
        //{
        //    double max = double.Parse(ConfigurationManager.AppSettings["Max_Height_mm"]);
        //    double aux = lenght + starAxis;

        //    return (aux > 0 && aux <= max);
        //}

        public static bool IsValid(double lenght, double starAxis, double max)
        {
            double aux = lenght + starAxis;
            return (aux > 0 && aux <= max);
        }
    }
}