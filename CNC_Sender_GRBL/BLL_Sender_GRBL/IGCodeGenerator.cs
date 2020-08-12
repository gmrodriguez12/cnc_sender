﻿using ENT_Sender_GRBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Sender_GRBL
{
    public abstract class IGCodeGenerator
    {
        public abstract StringBuilder GenerateGCode(Geometric shape);
        public abstract StringBuilder GenerateSimulatorGCode(Geometric shape);

        public string ReturnToHome(decimal safetyHeightZ)
        {
            return $"G0 X0 Y0 Z{safetyHeightZ}";
        }

        public string ToggleRele(bool on)
        {
            return on ? "M3" : "M5";
        }

        public string GMovement(Point point, decimal feed, string typeMovement)
        {
            return $"{typeMovement} X{point.X} Y{point.Y} Z{point.Z} F{feed}";
        }
    }
}