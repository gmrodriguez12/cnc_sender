﻿using BLL_Sender_GRBL.GCodeGenerator.SimpleMovements;
using ENT_Sender_GRBL;
using System.Text;

namespace BLL_Sender_GRBL.GCodeGenerator
{
    public abstract class IGCodeGenerator : GCodeHome
    {
        public abstract StringBuilder GenerateGCode(Geometric shape);
        public abstract StringBuilder GenerateSimulatorGCode(Geometric shape);

        public string ToggleRele(bool on)
        {
            return on ? "M4" : "M5";
        }

        public string GMovement(Point point,double feed, string typeMovement)
        {
            return $"{typeMovement} X{point.X} Y{point.Y} Z{point.Z} F{feed}";
        }

        public string GMovement(Point point, string typeMovement)
        {
            return $"{typeMovement} X{point.X} Y{point.Y} Z{point.Z}";
        }

        public string GArc(Point end, double i, double j, bool clockWise)
        {
            string typeMovement = clockWise ? "G2" : "G3";
            return $"{typeMovement} X{end.X} Y{end.Y} I{i} J{j}";
        }
    }
}
