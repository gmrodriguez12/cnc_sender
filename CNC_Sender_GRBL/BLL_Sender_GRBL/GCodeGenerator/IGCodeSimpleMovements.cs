using System;
using System.Text;

namespace BLL_Sender_GRBL.GCodeGenerator
{
    public interface IGCodeSimpleMovements
    {
        StringBuilder MoveX(double distance, double feed);

        StringBuilder MoveY(double distance, double feed);

        StringBuilder MoveZ(double distance, double feed);
    }
}
