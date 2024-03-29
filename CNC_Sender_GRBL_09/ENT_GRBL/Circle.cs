﻿namespace ENT_Sender_GRBL
{
    public class Circle : Geometric
    {
        public Point Center { get; set; }
        public double Radio { get; set; }

        public override Point Start
        {
            get
            {
                return new Point(Center.X - Radio, Center.Y, Center.Z);
            }
        }

        public Point End
        {
            get
            {
                return Start;
            }
        }

        public double IG2 {
            get
            {
                return Center.X - Radio;
            }
        }

        public double IG3
        {
            get
            {
                return Center.X + Radio;
            }
        }
    }
}
