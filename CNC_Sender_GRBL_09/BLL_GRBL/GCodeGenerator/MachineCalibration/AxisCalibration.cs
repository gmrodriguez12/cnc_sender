using BLL_GRBL.GCodeGenerator.SettingsGCodeGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using static ENT_GRBL.Config.IndexSetting;

namespace BLL_GRBL.GCodeGenerator.MachineCalibration
{
    public class AxisCalibration
    {
        /// <summary>
        /// Adjust the step value to imporve the precision of each axis of the machine
        /// </summary>
        /// <param name="axisMove">Total mm the axis moved when the movement was executed a fixed distance</param>
        /// <param name="fixedDistance">Fixed distance used to calibrate the axis</param>
        /// <param name="currentStep">GRBL Step/mm property value</param>
        /// <returns>GRBL Setting with new Step/mm</returns>
        public string CalibrateAxis(double axisMove, double fixedDistance, string currentStep, StepBymmAxis axis)
        {
            GCodeSetting gSetting = new GCodeSetting();

            double currentStep_mm = double.Parse(currentStep);
            double newStep_mm = (fixedDistance * currentStep_mm) / axisMove;

            return gSetting.ApplySetting((short) axis, newStep_mm);
        }
    }
}
