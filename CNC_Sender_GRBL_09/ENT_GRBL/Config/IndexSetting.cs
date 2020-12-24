using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_GRBL.Config
{
    public static class IndexSetting
    {
        public enum Settings_GRBL_09 {
            StepPulse = 0,
            StepIdleDelay,
            StepPortInvert,
            DirPortInvert,
            StepEnableInvert,
            ProbePinInvert,
            StatusReport,
            JunctionDeviation,
            ArcTolerance,
            ReportInches,
            SoftLimits,
            HardLimits,
            HomingCycle,
            HomingDirInvert,
            HomingFeed,
            HomingSeek,
            HomingDebounce,
            HomingPullOff,
            xStepBymm,
            yStepBymm,
            zStepBymm,
            xMaxRate,
            yMaxRate,
            zMaxRate,
            xAcceleration,
            yAcceleration,
            zAcceleration,
            xMaxTravel,
            yMaxTravel,
            zMaxTravel
        }
    }
}

