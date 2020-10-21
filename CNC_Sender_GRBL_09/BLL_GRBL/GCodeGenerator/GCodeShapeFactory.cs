using BLL_Sender_GRBL.GCodeGenerator.ShapeGCodeGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ENT_Sender_GRBL.Enum.EnumHelpers;

namespace BLL_Sender_GRBL.GCodeGenerator
{
    public class GCodeShapeFactory
    {
        public IGCodeGenerator Build(short geometricType)
        {
            switch(geometricType)
            {
                case (short)TypeGeometric.Square:
                    return new GCodeSquare();

                case (short)TypeGeometric.Rectangle:
                    return new GCodeRectangle();

                case (short)TypeGeometric.Circle:
                    return new GCodeCircle();

                case (short)TypeGeometric.TriangleRectangle:
                    return new GCodeTriangleRectangle();

                default:
                    return new GCodeLines();
            }
        }
    }
}
