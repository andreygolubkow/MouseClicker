using System;
using System.Drawing;

namespace MouseClicker
{
    public class MousePoint
    {
        private Point _point;
        private int _interval;

        public MousePoint(int x, int y, int interval)
        {
           Point = new Point(x,y);
           Interval = interval;
        }

        public  MousePoint(Point point, int interval)
        {
            Point = point;
            Interval = interval;
        }

        public Point Point
        {
            set
            {
                if ( value.X<0 || value.Y<0)
                {
                    throw new ArgumentNullException();
                }
                _point = value;
            }
            get
            {
                return _point;
            }
        }

        public int Interval
        {
            set
            {
                if ( value <= 0 )
                {
                    throw new ArgumentOutOfRangeException();
                }
                _interval = value;
            }
            get
            {
                return _interval;
            }
        }
    }
}