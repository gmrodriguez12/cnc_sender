using System;
using System.Text;
using ENT_Sender_GRBL;

namespace BLL_Sender_GRBL.GCodeGenerator.SimpleMovements
{
    public class GCodeSimpleMovements : GCodeHome, IGCodeSimpleMovements
    {
        public GCodeSimpleMovements()
        {
        }

        public StringBuilder MoveX(double distance, double feed)
        {
            throw new NotImplementedException();
        }

        public StringBuilder MoveY(double distance, double feed)
        {
            throw new NotImplementedException();
        }

        public StringBuilder MoveZ(double distance, double feed)
        {
            throw new NotImplementedException();
        }
    }
}
