﻿//
// THIS FILE IS AUTOGENERATED - DO NOT EDIT
// In order to make changes make sure to edit the t4 template file (*.tt)
//

using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqStatistics.NaN
{
    public static partial class EnumerableStats
    {
    	
        /// <summary>
        /// Computes the MinMax of a sequence of nullable float values.
        /// </summary>
        /// <param name="source">The sequence of elements.</param>
        /// <returns>The MinMax.</returns>
        public static Range<float>? MinMaxNaN(this IEnumerable<float?> source)
        {
            IEnumerable<float> values = source.AllValues();
            if (values.Any())
                return values.MinMaxNaN();

            return null;
        }

        /// <summary>
        /// Computes the MinMax of a sequence of float values.
        /// </summary>
        /// <param name="source">The sequence of elements.</param>
        /// <returns>The MinMax.</returns>
        public static Range<float> MinMaxNaN(this IEnumerable<float> source)
        {            
            if (source == null)
                throw new ArgumentNullException("source");

            if (!source.Any())
                return new Range<float>(float.NaN, float.NaN);

            // initialize minimum to max possible value and maximum to minimum possible value
            // so that the first comparisons in the aggregate function work as expected
            var minMax = new Range<float>(float.MaxValue, float.MinValue, true);

            return source.Aggregate<float, Range<float>>(minMax, (accumulator, value) =>
            {
                var min = Math.Min(accumulator.Min, value);
                var max = Math.Max(accumulator.Max, value);
                
                return new Range<float>(min, max);
            });
        }

        /// <summary>
        ///     Computes the MinMax of a sequence of nullable float values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">The sequence of elements.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The MinMax.</returns>
        public static Range<float>? MinMaxNaN<TSource>(this IEnumerable<TSource> source, Func<TSource, float?> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).MinMaxNaN();
        }

        /// <summary>
        ///     Computes the MinMax of a sequence of float values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">The sequence of elements.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The MinMax.</returns>
        public static Range<float> MinMaxNaN<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).MinMaxNaN();
        }
 	
        /// <summary>
        /// Computes the MinMax of a sequence of nullable double values.
        /// </summary>
        /// <param name="source">The sequence of elements.</param>
        /// <returns>The MinMax.</returns>
        public static Range<double>? MinMaxNaN(this IEnumerable<double?> source)
        {
            IEnumerable<double> values = source.AllValues();
            if (values.Any())
                return values.MinMaxNaN();

            return null;
        }

        /// <summary>
        /// Computes the MinMax of a sequence of double values.
        /// </summary>
        /// <param name="source">The sequence of elements.</param>
        /// <returns>The MinMax.</returns>
        public static Range<double> MinMaxNaN(this IEnumerable<double> source)
        {            
            if (source == null)
                throw new ArgumentNullException("source");

            if (!source.Any())
                return new Range<double>(double.NaN, double.NaN);

            // initialize minimum to max possible value and maximum to minimum possible value
            // so that the first comparisons in the aggregate function work as expected
            var minMax = new Range<double>(double.MaxValue, double.MinValue, true);

            return source.Aggregate<double, Range<double>>(minMax, (accumulator, value) =>
            {
                var min = Math.Min(accumulator.Min, value);
                var max = Math.Max(accumulator.Max, value);
                
                return new Range<double>(min, max);
            });
        }

        /// <summary>
        ///     Computes the MinMax of a sequence of nullable double values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">The sequence of elements.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The MinMax.</returns>
        public static Range<double>? MinMaxNaN<TSource>(this IEnumerable<TSource> source, Func<TSource, double?> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).MinMaxNaN();
        }

        /// <summary>
        ///     Computes the MinMax of a sequence of double values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">The sequence of elements.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The MinMax.</returns>
        public static Range<double> MinMaxNaN<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (selector == null)
                throw new ArgumentNullException("selector");

            return source.Select(selector).MinMaxNaN();
        }
     }
}