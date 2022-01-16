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
        /// Computes the sample Kurtosis of a sequence of nullable int values
        /// </summary>
        /// <param name="source">A sequence of nullable int values to calculate the Kurtosis of.</param>
        /// <returns>The Kurtosis of the sequence of values.</returns>
        public static double? KurtosisNaN(this IEnumerable<int?> source)
        {
            var values = source.AllValues();
            if (values.Any())
                return values.KurtosisNaN();

            return null;
        }

        /// <summary>
        /// Computes the sample Kurtosis of a sequence of int values
        /// </summary>
        /// <param name="source">A sequence of int values to calculate the Kurtosis of.</param>
        /// <returns>The Kurtosis of the sequence of values.</returns>
        public static double KurtosisNaN(this IEnumerable<int> source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            var mean = (double)source.AverageNaN();

            if (double.IsNaN(mean))
                return double.NaN;

            long n = 0;
            var meanv = 0.0;
            var M2 = 0.0;
            var M4 = 0.0;
             
            checked
            { 
                foreach (var x in source)
                {
                    n++;

                    var delta = (double)x - meanv;
                    meanv += delta / n;
                    M2 += delta * ((double)x - meanv);
                    M4 += Math.Pow((double)x - mean, 4);
                }
            }

            if (n < 4)
                return double.NaN;

            var s = Math.Sqrt((double)(M2 / (n - 1))); // stdev

            double term1 = (n * (n + 1.0)) / ((n - 1.0) * (n - 2.0) * (n - 3.0));
            double term2 = M4 / Math.Pow(s, 4);
            double term3 = (3 * Math.Pow(n - 1, 2)) / ((n - 2.0) * (n - 3.0));

            return (double)(term1 * term2 - term3);
        }

        /// <summary>
        ///     Computes the sample Kurtosis of a sequence of int values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">A sequence of values that are used to calculate a Kurtosis</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The Kurtosis of the sequence of values.</returns>
        public static double KurtosisNaN<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return source.Select(selector).KurtosisNaN();
        }

        /// <summary>
        ///     Computes the sample Kurtosis of a sequence of nullable int values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">A sequence of values that are used to calculate a Kurtosis</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The Kurtosis of the sequence of values.</returns>
        public static double? KurtosisNaN<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return source.Select(selector).KurtosisNaN();
        }
 	
        /// <summary>
        /// Computes the sample Kurtosis of a sequence of nullable long values
        /// </summary>
        /// <param name="source">A sequence of nullable long values to calculate the Kurtosis of.</param>
        /// <returns>The Kurtosis of the sequence of values.</returns>
        public static double? KurtosisNaN(this IEnumerable<long?> source)
        {
            var values = source.AllValues();
            if (values.Any())
                return values.KurtosisNaN();

            return null;
        }

        /// <summary>
        /// Computes the sample Kurtosis of a sequence of long values
        /// </summary>
        /// <param name="source">A sequence of long values to calculate the Kurtosis of.</param>
        /// <returns>The Kurtosis of the sequence of values.</returns>
        public static double KurtosisNaN(this IEnumerable<long> source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            var mean = (double)source.AverageNaN();

            if (double.IsNaN(mean))
                return double.NaN;

            long n = 0;
            var meanv = 0.0;
            var M2 = 0.0;
            var M4 = 0.0;
             
            checked
            { 
                foreach (var x in source)
                {
                    n++;

                    var delta = (double)x - meanv;
                    meanv += delta / n;
                    M2 += delta * ((double)x - meanv);
                    M4 += Math.Pow((double)x - mean, 4);
                }
            }

            if (n < 4)
                return double.NaN;

            var s = Math.Sqrt((double)(M2 / (n - 1))); // stdev

            double term1 = (n * (n + 1.0)) / ((n - 1.0) * (n - 2.0) * (n - 3.0));
            double term2 = M4 / Math.Pow(s, 4);
            double term3 = (3 * Math.Pow(n - 1, 2)) / ((n - 2.0) * (n - 3.0));

            return (double)(term1 * term2 - term3);
        }

        /// <summary>
        ///     Computes the sample Kurtosis of a sequence of long values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">A sequence of values that are used to calculate a Kurtosis</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The Kurtosis of the sequence of values.</returns>
        public static double KurtosisNaN<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return source.Select(selector).KurtosisNaN();
        }

        /// <summary>
        ///     Computes the sample Kurtosis of a sequence of nullable long values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">A sequence of values that are used to calculate a Kurtosis</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The Kurtosis of the sequence of values.</returns>
        public static double? KurtosisNaN<TSource>(this IEnumerable<TSource> source, Func<TSource, long?> selector)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return source.Select(selector).KurtosisNaN();
        }
 	
        /// <summary>
        /// Computes the sample Kurtosis of a sequence of nullable float values
        /// </summary>
        /// <param name="source">A sequence of nullable float values to calculate the Kurtosis of.</param>
        /// <returns>The Kurtosis of the sequence of values.</returns>
        public static float? KurtosisNaN(this IEnumerable<float?> source)
        {
            var values = source.AllValues();
            if (values.Any())
                return values.KurtosisNaN();

            return null;
        }

        /// <summary>
        /// Computes the sample Kurtosis of a sequence of float values
        /// </summary>
        /// <param name="source">A sequence of float values to calculate the Kurtosis of.</param>
        /// <returns>The Kurtosis of the sequence of values.</returns>
        public static float KurtosisNaN(this IEnumerable<float> source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            var mean = (double)source.AverageNaN();

            if (double.IsNaN(mean))
                return float.NaN;

            long n = 0;
            var meanv = 0.0;
            var M2 = 0.0;
            var M4 = 0.0;
             
            checked
            { 
                foreach (var x in source)
                {
                    n++;

                    var delta = (double)x - meanv;
                    meanv += delta / n;
                    M2 += delta * ((double)x - meanv);
                    M4 += Math.Pow((double)x - mean, 4);
                }
            }

            if (n < 4)
                return float.NaN;

            var s = Math.Sqrt((double)(M2 / (n - 1))); // stdev

            double term1 = (n * (n + 1.0)) / ((n - 1.0) * (n - 2.0) * (n - 3.0));
            double term2 = M4 / Math.Pow(s, 4);
            double term3 = (3 * Math.Pow(n - 1, 2)) / ((n - 2.0) * (n - 3.0));

            return (float)(term1 * term2 - term3);
        }

        /// <summary>
        ///     Computes the sample Kurtosis of a sequence of float values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">A sequence of values that are used to calculate a Kurtosis</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The Kurtosis of the sequence of values.</returns>
        public static float KurtosisNaN<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return source.Select(selector).KurtosisNaN();
        }

        /// <summary>
        ///     Computes the sample Kurtosis of a sequence of nullable float values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">A sequence of values that are used to calculate a Kurtosis</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The Kurtosis of the sequence of values.</returns>
        public static float? KurtosisNaN<TSource>(this IEnumerable<TSource> source, Func<TSource, float?> selector)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return source.Select(selector).KurtosisNaN();
        }
 	
        /// <summary>
        /// Computes the sample Kurtosis of a sequence of nullable double values
        /// </summary>
        /// <param name="source">A sequence of nullable double values to calculate the Kurtosis of.</param>
        /// <returns>The Kurtosis of the sequence of values.</returns>
        public static double? KurtosisNaN(this IEnumerable<double?> source)
        {
            var values = source.AllValues();
            if (values.Any())
                return values.KurtosisNaN();

            return null;
        }

        /// <summary>
        /// Computes the sample Kurtosis of a sequence of double values
        /// </summary>
        /// <param name="source">A sequence of double values to calculate the Kurtosis of.</param>
        /// <returns>The Kurtosis of the sequence of values.</returns>
        public static double KurtosisNaN(this IEnumerable<double> source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            var mean = (double)source.AverageNaN();

            if (double.IsNaN(mean))
                return double.NaN;

            long n = 0;
            var meanv = 0.0;
            var M2 = 0.0;
            var M4 = 0.0;
             
            checked
            { 
                foreach (var x in source)
                {
                    n++;

                    var delta = (double)x - meanv;
                    meanv += delta / n;
                    M2 += delta * ((double)x - meanv);
                    M4 += Math.Pow((double)x - mean, 4);
                }
            }

            if (n < 4)
                return double.NaN;

            var s = Math.Sqrt((double)(M2 / (n - 1))); // stdev

            double term1 = (n * (n + 1.0)) / ((n - 1.0) * (n - 2.0) * (n - 3.0));
            double term2 = M4 / Math.Pow(s, 4);
            double term3 = (3 * Math.Pow(n - 1, 2)) / ((n - 2.0) * (n - 3.0));

            return (double)(term1 * term2 - term3);
        }

        /// <summary>
        ///     Computes the sample Kurtosis of a sequence of double values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">A sequence of values that are used to calculate a Kurtosis</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The Kurtosis of the sequence of values.</returns>
        public static double KurtosisNaN<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return source.Select(selector).KurtosisNaN();
        }

        /// <summary>
        ///     Computes the sample Kurtosis of a sequence of nullable double values that are obtained
        ///     by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of source.</typeparam>
        /// <param name="source">A sequence of values that are used to calculate a Kurtosis</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <returns>The Kurtosis of the sequence of values.</returns>
        public static double? KurtosisNaN<TSource>(this IEnumerable<TSource> source, Func<TSource, double?> selector)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return source.Select(selector).KurtosisNaN();
        }
     }
}