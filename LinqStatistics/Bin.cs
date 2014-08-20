﻿using System;

namespace LinqStatistics
{
    public class Bin : ItemCount<double>
    {
        private readonly Range<double> _range;

        public Range<double> Range { get { return _range; } }

        public double Width { get { return _range.Max - _range.Min; } }

        public Bin(double v, double min, double max, int count, bool maxInclusive = false)
            : base(v, count)
        {
            _range = new Range<double>(min, max, maxInclusive);
        }

        internal Bin(double v, double min, double max, bool maxInclusive = false)
            : this(v, min, max, 0, maxInclusive)
        {
            
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ _range.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is Bin && base.Equals(obj))
            {
                return ((Bin)obj)._range == this._range;
            }

            return false;
        }

        public override string ToString()
        {
            return base.ToString() + " " + _range.ToString();
        }
    }
}
