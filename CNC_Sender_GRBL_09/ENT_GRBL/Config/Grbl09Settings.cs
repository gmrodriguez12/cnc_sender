namespace ENT_GRBL.Config
{
    /// <summary>
    /// Class for save in memory config of GRBL 0.9
    /// </summary>
    public class Grbl09Settings
    {
        /// <summary>
        /// $0=VAL (step pulse, usec)
        /// </summary>
        public string StepPulse { get; set; }

        /// <summary>
        /// $1=VAL (step idle delay, msec)
        /// </summary>
        public string StepIdleDelay { get; set; }

        /// <summary>
        /// $2=VAL (step port invert mask:00000000)
        /// </summary>
        public string StepPortInvert { get; set; }

        /// <summary>
        /// $3=VAL (dir port invert mask:00000000)
        /// </summary>
        public string DirPortInvert { get; set; }

        /// <summary>
        /// $4=VAL (step enable invert, bool)
        /// </summary>
        public string StepEnableInvert { get; set; }

        /// <summary>
        /// $5=VAL (limit pins invert, bool)
        /// </summary>
        public string LimitPinsInvert { get; set; }

        /// <summary>
        /// $6=VAL (probe pin invert, bool)
        /// </summary>
        public string ProbePinInvert { get; set; }

        /// <summary>
        /// $10=VAL (status report mask:00000011)
        /// </summary>
        public string StatusReport { get; set; }

        /// <summary>
        /// $11=VAL (junction deviation, mm)
        /// </summary>
        public string JunctionDeviation { get; set; }

        /// <summary>
        /// $12=VAL (arc tolerance, mm)
        /// </summary>
        public string ArcTolerance { get; set; }

        /// <summary>
        /// $13=VAL (report inches, bool)
        /// </summary>
        public string ReportInches { get; set; }

        /// <summary>
        /// $20=VAL (soft limits, bool)
        /// </summary>
        public string SoftLimits { get; set; }

        /// <summary>
        /// $21=VAL (hard limits, bool)
        /// </summary>
        public string HardLimits { get; set; }

        /// <summary>
        /// $22=VAL (homing cycle, bool)
        /// </summary>
        public string HomingCycle { get; set; }

        /// <summary>
        /// $23=VAL (homing dir invert mask:00000000)
        /// </summary>
        public string HomingDirInvert { get; set; }

        /// <summary>
        /// $24=VAL (homing feed, mm/min)
        /// </summary>
        public string HomingFeed { get; set; }

        /// <summary>
        /// $25=VAL (homing seek, mm/min)
        /// </summary>
        public string HomingSeek { get; set; }

        /// <summary>
        /// $26=VAL (homing debounce, msec)
        /// </summary>
        public string HomingDebounce { get; set; }

        /// <summary>
        /// $27=VAL (homing pull-off, mm)
        /// </summary>
        public string HomingPullOff { get; set; }

        /// <summary>
        /// $100=VAL (x, step/mm)
        /// </summary>
        public string xStepBymm { get; set; }

        /// <summary>
        /// $101=VAL (y, step/mm)
        /// </summary>
        public string yStepBymm { get; set; }

        /// <summary>
        /// $102=VAL (z, step/mm)
        /// </summary>
        public string zStepBymm { get; set; }

        /// <summary>
        /// $110=VAL (x max rate, mm/min)
        /// </summary>
        public string xMaxRate { get; set; }

        /// <summary>
        /// $111=VAL (y max rate, mm/min)
        /// </summary>
        public string yMaxRate { get; set; }

        /// <summary>
        /// $112=VAL (z max rate, mm/min)
        /// </summary>
        public string zMaxRate { get; set; }

        /// <summary>
        /// $120=VAL (x accel, mm/sec^2)
        /// </summary>
        public string xAcceleration { get; set; }

        /// <summary>
        /// $121=VAL (y accel, mm/sec^2)
        /// </summary>
        public string yAcceleration { get; set; }

        /// <summary>
        /// $122=VAL (z accel, mm/sec^2)
        /// </summary>
        public string zAcceleration { get; set; }

        /// <summary>
        /// $130=VAL (x max travel, mm)
        /// </summary>
        public string xMaxTravel { get; set; }

        /// <summary>
        /// $131=VAL (y max travel, mm)
        /// </summary>
        public string yMaxTravel { get; set; }

        /// <summary>
        /// $132=VAL (z max travel, mm)
        /// </summary>
        public string zMaxTravel { get; set; }
    }
}
