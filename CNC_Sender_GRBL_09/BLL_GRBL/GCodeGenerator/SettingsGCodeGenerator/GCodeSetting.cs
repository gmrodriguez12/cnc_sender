﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_GRBL.GCodeGenerator.SettingsGCodeGenerator
{
    public class GCodeSetting : IGCodeSetting
    {
        public string ApplySetting(short property, double value)
        {
            return $"${property}={value}";
        }
    }
}
