using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Checkers
{
    public class Figure
    {
        public string CheckColor
        {
            get { return _checkColor; }
            set { _checkColor = value; }
        }

        public string CurrentLocation
        {
            get { return _currentLocation; }
            set { _currentLocation = value; }
        }

        public bool IsAlive
        {
            get { return _isAlive; }
            set { _isAlive = value; }
        }

        public bool IsUnderAttack
        {
            get { return _isUnderAttack; }
            set { _isUnderAttack = value; }
        }

        public double MaxScore
        {
            get { return _maxScore; }
            set { _maxScore = value; }
        }

        public string LocationWithMaxScore
        {
            get { return _locationWithMaxScore; }
            set { _locationWithMaxScore = value; }
        }

        protected string _checkColor;
        protected string _currentLocation;
        protected Dictionary<string, double> dictOfEstimation = new Dictionary<string, double>();
        protected bool _isAlive;
        protected bool _isUnderAttack;
        protected List<string> listOfMoves = new List<string>();
        protected double _maxScore;
        protected string _locationWithMaxScore;
    }
}
