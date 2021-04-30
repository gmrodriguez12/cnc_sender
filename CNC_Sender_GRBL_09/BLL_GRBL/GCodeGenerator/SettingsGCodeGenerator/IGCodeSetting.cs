using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_GRBL.GCodeGenerator.SettingsGCodeGenerator
{
    public interface IGCodeSetting
    {
        string ApplySetting(short property, double value);
    }
}
