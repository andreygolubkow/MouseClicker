using System;
using System.Collections.Generic;

namespace MouseClicker
{
    [Serializable]
    public class Project
    {
        public List<MousePoint> PointsList;
        private int _repeatInterval;

        public bool Repeat { get; set; }

        public int RepeatInterval
        {
            get
            {
                return _repeatInterval;
            }
            set
            {
                if ( value < 0 )
                {
                    throw new ArgumentOutOfRangeException();
                }
                _repeatInterval = value;
            }
        }

        public Project()
        {
            PointsList = new List<MousePoint>();
            Repeat = false;
            RepeatInterval = 0;
        }
    }
}