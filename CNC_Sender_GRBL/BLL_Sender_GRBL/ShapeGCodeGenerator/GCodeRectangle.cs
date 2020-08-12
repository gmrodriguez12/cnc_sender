﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT_Sender_GRBL;

namespace BLL_Sender_GRBL.ShapeGCodeGenerator
{
    internal class GCodeRectangle : IGCodeGenerator
    {
        public override StringBuilder GenerateGCode(Geometric shape)
        {
            /*
             G0 X2 Y2
                G1 X2 Y6 F150
                G1 X4 Y6 F150
                G1 X4 Y2 F150
                G1 X2 Y2 F150
                G0 X0 Y0
             */
            throw new NotImplementedException();
        }

        public override StringBuilder GenerateSimulatorGCode(Geometric shape)
        {
            throw new NotImplementedException();
        }
    }
}