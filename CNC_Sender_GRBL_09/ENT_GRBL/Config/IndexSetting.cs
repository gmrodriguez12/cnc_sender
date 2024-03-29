﻿namespace ENT_GRBL.Config
{
    public static class IndexSetting
    {
        public enum Settings_GRBL_09 {
            StepPulse =1,
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

        public enum StepBymmAxis
        {
            x = 100,
            y,
            z
        }
    }
}

