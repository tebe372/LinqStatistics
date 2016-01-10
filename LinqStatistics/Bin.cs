﻿using System;

namespace LinqStatistics
{
    /// <summary>
    /// A discrete count of items which fall into a given range
    /// </summary>
    public class Bin : ItemCount<double>
    {
        private readonly Range<double> _range;
        private readonly bool _maxInclusive;

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="v">Representative value for the Bin</param>
        /// <param name="min">The minimum value of the Range</param>
        /// <param name="max">The maximum value of the range</param>
        /// <param name="count">The number of items in the Bin</param>
        /// <param name="maxInclusive">Should Max be included in the Range or excluded - default is excluded</param>
        public Bin(double v, double min, double max, int count, bool maxInclusive = false)
            : base(v, count)
        {
            _range = new Range<double>(min, max);
            _maxInclusive = maxInclusive;
        }

        internal Bin(double v, double min, double max, bool maxInclusive = false)
            : this(v, min, max, 0, maxInclusive)
        {            
        }

        /// <summary>
        /// Determines whether Max should be included or excluded in the range
        /// </summary>
        public bool MaxInclusive => _maxInclusive;

        /// <summary>
        /// The range
        /// </summary>
        public Range<double> Range { get { return _range; } }

        /// <summary>
        /// Determines if a value is contained with the segment
        /// </summary>
        /// <param name="item">The item to check</param>
        /// <returns>True if item is contained in the range - taking into acount MaxInclusive</returns>
        public bool Contains(double item)
        {
            if (MaxInclusive)
            {
                return item.CompareTo(Range.Min) >= 0 && item.CompareTo(Range.Max) <= 0;
            }

            return item.CompareTo(Range.Min) >= 0 && item.CompareTo(Range.Max) < 0;
        }

        /// <summary>
        /// <see cref="System.Object.GetHashCode"/>
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode() ^ _range.GetHashCode() ^ _maxInclusive.GetHashCode();
        }

        public static bool operator ==(Bin lhs, Bin rhs)
        {
            if (object.ReferenceEquals(null, lhs) && object.ReferenceEquals(rhs, null))
            {
                return true;
            }

            if (object.ReferenceEquals(null, lhs) || object.ReferenceEquals(rhs, null))
            {
                return false;
            }

            return lhs.Equals(rhs);
        }

        public static bool operator !=(Bin lhs, Bin rhs)
        {
            return !(lhs == rhs);
        }

        /// <summary>
        /// <see cref="System.Object.Equals(object)"/>
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is Bin && base.Equals(obj))
            {
                var other = (Bin)obj;
                return other._range == this._range && other.MaxInclusive == this.MaxInclusive;
            }

            return false;
        }

        /// <summary>
        /// <see cref="System.Object.ToString"/>
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + " " + _range.ToString();
        }
    }
}
