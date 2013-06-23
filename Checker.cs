using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Checkers
{
    public class Checker
    {
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

        public Point Coord
        {
            get { return _coord = ParseStringToCoord(Location); }  // if Location == null?
            set { _coord = value; }
        }

        private string _color;
        private string _location;
        private Point _coord;

        private Point ParseStringToCoord(string location)
        {
            Point tempPoint = new Point();
            tempPoint.X = (int)location[0] - 64;
            tempPoint.Y = (int)location[1] - 48;
            return tempPoint;
        }
    }
}
