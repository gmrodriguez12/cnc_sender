using System;
namespace BLL_Sender_GRBL.GCodeGenerator.SimpleMovements
{
    public class GCodeHome
    {
        public GCodeHome()
        {
        }

        public string ReturnToHome(double safetyHeightZ)
        {
            return $"G0 X0 Y0 Z{safetyHeightZ}";
        }

        public string SetHomePoint()
        {
            throw new NotImplementedException();
        }
    }
}
