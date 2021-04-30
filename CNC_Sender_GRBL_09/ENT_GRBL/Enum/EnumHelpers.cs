namespace ENT_Sender_GRBL.Enum
{
    public class EnumHelpers
    {
        public enum TypeGeometric : short
        {
            Line,
            Square,
            Rectangle,
            Circle,
            TriangleRectangle
        }

        public enum SystemEvents : short
        {
            Load,
            Open,
            Run,
            PortSelected,
            Close,
            Finish,
            Stop,
            ErrorMachine
        }
    }
}
