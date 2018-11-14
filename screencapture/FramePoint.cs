using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace screencapture
{
    public struct FramePoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int cluster { get; set; }
        public int mouseX { get; set; }
        public int mouseY { get; set; }
        public double timeStamp { get; set; }
        public double timeGazeFixed { get; set; }

        public FramePoint(int gazeX, int gazeY, int mouseY = 0, int mouseX = 0, double timeStamp = 0, double timeGazeFixed = 0, int cluster = 0)
        {
            this.X = gazeX;
            this.Y = gazeY;
            this.cluster = cluster;
            this.mouseY = mouseY;
            this.mouseX = mouseX;
            this.timeStamp = timeStamp;
            this.timeGazeFixed = timeGazeFixed;
        }

        //public static FramePoint operator +(FramePoint a, FramePoint b)
        //{
        //    return new FramePoint(a.X + b.X, a.Y + b.Y);
        //}
        //public static FramePoint operator -(FramePoint a, FramePoint b)
        //{
        //    return new FramePoint(Math.Abs(a.X - b.X), Math.Abs(a.Y - b.Y));
        //}


        //public static bool operator >(FramePoint a, FramePoint b)
        //{
        //    return (a.X + a.Y) > (b.X + b.Y);
        //}
        //public static bool operator <(FramePoint a, FramePoint b)
        //{
        //    return (a.X + a.Y) < (b.X + b.Y);
        //}


        //public static bool operator >=(FramePoint a, int b)
        //{
        //    return (a.X >= b) && (a.Y >= b);
        //}
        //public static bool operator <=(FramePoint a, int b)
        //{
        //    return (a.X <= b) && (a.Y <= b);
        //}
    }
}
