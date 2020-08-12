using BLL_Sender_GRBL.ShapeGCodeGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ENT_Sender_GRBL.Enum.EnumHelpers;

namespace BLL_Sender_GRBL
{
    public static class GCodeFactory
    {
        public static IGCodeGenerator Build(short geometricType)
        {
            switch(geometricType)
            {
                case (short)TypeGeometric.Square:
                    return new GCodeSquare();

                case (short)TypeGeometric.Rectangle:
                    return new GCodeRectangle();

                case (short)TypeGeometric.Circle:
                    return new GCodeCircle();

                case (short)TypeGeometric.Triangle:
                    return new GCodeTriangle();

                default:
                    return new GCodeLines();
            }
        }
    }
}
