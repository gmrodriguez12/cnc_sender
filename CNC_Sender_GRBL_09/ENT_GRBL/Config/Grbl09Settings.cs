using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public double StepPulse_usec { get; set; }

        /// <summary>
        /// $1=VAL (step idle delay, msec)
        /// </summary>
        public double StepIdleDelay { get; set; }

        /// <summary>
        /// $2=VAL (step port invert mask:00000000)
        /// </summary>
        public double StepPortInvert { get; set; }

        /// <summary>
        /// $3=VAL (dir port invert mask:00000000)
        /// </summary>
        public double DirPortInvert { get; set; }

        /// <summary>
        /// $4=VAL (step enable invert, bool)
        /// </summary>
        public bool StepEnableInvert { get; set; }

        /// <summary>
        /// $5=VAL (limit pins invert, bool)
        /// </summary>
        public bool LimitPinsInvert { get; set; }

        /// <summary>
        /// $6=VAL (probe pin invert, bool)
        /// </summary>
        public bool ProbePinInvert { get; set; }

        /// <summary>
        /// $10=VAL (status report mask:00000011)
        /// </summary>
        public double StatusReport { get; set; }

        /// <summary>
        /// $11=VAL (junction deviation, mm)
        /// </summary>
        public double JunctionDeviation { get; set; }

        /// <summary>
        /// $12=VAL (arc tolerance, mm)
        /// </summary>
        public double ArcTolerance { get; set; }

        /// <summary>
        /// $13=VAL (report inches, bool)
        /// </summary>
        public bool ReportInches { get; set; }

        /// <summary>
        /// $20=VAL (soft limits, bool)
        /// </summary>
        public bool SoftLimits { get; set; }

        /// <summary>
        /// $21=VAL (hard limits, bool)
        /// </summary>
        public bool HardLimits { get; set; }

        /// <summary>
        /// $22=VAL (homing cycle, bool)
        /// </summary>
        public bool HomingCycle { get; set; }

        /// <summary>
        /// $23=VAL (homing dir invert mask:00000000)
        /// </summary>
        public double HomingDirInvert { get; set; }

        /// <summary>
        /// $24=VAL (homing feed, mm/min)
        /// </summary>
        public double HomingFeed { get; set; }

        /// <summary>
        /// $25=VAL (homing seek, mm/min)
        /// </summary>
        public double HomingSeek { get; set; }

        /// <summary>
        /// $26=VAL (homing debounce, msec)
        /// </summary>
        public double HomingDebounce { get; set; }

        /// <summary>
        /// $27=VAL (homing pull-off, mm)
        /// </summary>
        public double HomingPullOff { get; set; }

        /// <summary>
        /// $100=VAL (x, step/mm)
        /// </summary>
        public double xStepBymm { get; set; }

        /// <summary>
        /// $101=VAL (y, step/mm)
        /// </summary>
        public double yStepBymm { get; set; }

        /// <summary>
        /// $102=VAL (z, step/mm)
        /// </summary>
        public double zStepBymm { get; set; }

        /// <summary>
        /// $110=VAL (x max rate, mm/min)
        /// </summary>
        public double xMaxRate { get; set; }

        /// <summary>
        /// $111=VAL (y max rate, mm/min)
        /// </summary>
        public double yMaxRate { get; set; }

        /// <summary>
        /// $112=VAL (z max rate, mm/min)
        /// </summary>
        public double zMaxRate { get; set; }

        /// <summary>
        /// $120=VAL (x accel, mm/sec^2)
        /// </summary>
        public double xAcceleration { get; set; }

        /// <summary>
        /// $121=VAL (y accel, mm/sec^2)
        /// </summary>
        public double yAcceleration { get; set; }

        /// <summary>
        /// $122=VAL (z accel, mm/sec^2)
        /// </summary>
        public double zAcceleration { get; set; }

        /// <summary>
        /// $130=VAL (x max travel, mm)
        /// </summary>
        public double xMaxTravel { get; set; }

        /// <summary>
        /// $131=VAL (y max travel, mm)
        /// </summary>
        public double yMaxTravel { get; set; }

        /// <summary>
        /// $132=VAL (z max travel, mm)
        /// </summary>
        public double zMaxTravel { get; set; }
    }
}
