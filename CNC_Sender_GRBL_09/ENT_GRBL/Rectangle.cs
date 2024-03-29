﻿namespace ENT_Sender_GRBL
{
    public class Rectangle : Geometric
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Point A
        {
            get
            {
                return new Point(Start.X, Start.Y + Height, Start.Z);
            }
        }

        public Point B
        {
            get
            {
                return new Point(Start.X + Width, Start.Y + Height, Start.Z);
            }
        }

        public Point C
        {
            get
            {
                return new Point(Start.X + Width, Start.Y, Start.Z);
            }
        }
    }

    //publicdouble Length { get; set; }


    //A = X Y+l Z F
    //B = X+w Y+l Z F
    //C = X+w Y Z F
    //D = X Y Z F

}
