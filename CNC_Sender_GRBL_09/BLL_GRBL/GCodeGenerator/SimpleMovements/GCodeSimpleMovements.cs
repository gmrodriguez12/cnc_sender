using System.Text;

namespace BLL_Sender_GRBL.GCodeGenerator.SimpleMovements
{
    public class GCodeSimpleMovements : GCodeHome, IGCodeSimpleMovements
    {
        public GCodeSimpleMovements()
        {
        }

        public StringBuilder MoveX(double distance, double feed)
        {
            return GenerateAxisMove("X", distance, feed);
        }

        public StringBuilder MoveY(double distance, double feed)
        {
            return GenerateAxisMove("Y", distance, feed);
        }

        public StringBuilder MoveZ(double distance, double feed)
        {
            return GenerateAxisMove("Z", distance, feed);
        }

        private StringBuilder GenerateAxisMove(string axis, double distance, double feed)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("G91");
            sb.AppendLine($"G0{axis}{distance}F{feed}");
            sb.AppendLine("G90");

            return sb;
        }
    }
}
