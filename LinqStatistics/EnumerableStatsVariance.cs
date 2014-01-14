﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqStatistics
{
    public static partial class EnumerableStats
    {
        //
        // Summary:
        //     Computes the Variance of a sequence of nullable System.Decimal values.
        //
        // Parameters:
        //   source:
        //     A sequence of nullable System.Decimal values to calculate the Variance of.
        //
        // Returns:
        //     The Variance of the sequence of values, or null if the source sequence is
        //     empty or contains only values that are null.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source is null.
        //
        //   System.OverflowException:
        //     The sum of the elements in the sequence is larger than System.Decimal.MaxValue.
        public static decimal? Variance(this IEnumerable<decimal?> source)
        {
            IEnumerable<decimal> values = source.AllValues();
            if (values.Any())
                return values.Variance();

            return null;
        }
        //
        // Summary:
        //     Computes the Variance of a sequence of System.Decimal values.
        //
        // Parameters:
        //   source:
        //     A sequence of System.Decimal values to calculate the Variance of.
        //
        // Returns:
        //     The Variance of the sequence of values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source is null.
        //
        //   System.InvalidOperationException:
        //     source contains no elements.
        //
        //   System.OverflowException:
        //     The sum of the elements in the sequence is larger than System.Decimal.MaxValue.
        public static decimal Variance(this IEnumerable<decimal> source)
        {
            return (decimal)source.Select(x => (double)x).Variance();
        }
        //
        // Summary:
        //     Computes the Variance of a sequence of nullable System.Double values.
        //
        // Parameters:
        //   source:
        //     A sequence of nullable System.Double values to calculate the Variance of.
        //
        // Returns:
        //     The Variance of the sequence of values, or null if the source sequence is
        //     empty or contains only values that are null.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source is null.
        public static double? Variance(this IEnumerable<double?> source)
        {
            IEnumerable<double> values = source.AllValues();
            if (values.Any())
                return values.Variance();

            return null;
        }
        //
        // Summary:
        //     Computes the Variance of a sequence of System.Double values.
        //
        // Parameters:
        //   source:
        //     A sequence of System.Double values to calculate the Variance of.
        //
        // Returns:
        //     The Variance of the sequence of values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source is null.
        //
        //   System.InvalidOperationException:
        //     source contains less than 2 elements.
        public static double Variance(this IEnumerable<double> source)
        {
            if (source.Count() < 2)
                throw new InvalidOperationException("Source must have at least 2 elements");

            int n = 0;
            double mean = 0;
            double M2 = 0;

            foreach (double x in source)
            {
                n = n + 1;
                double delta = x - mean;
                mean += delta / n;
                M2 += delta * (x - mean);
            }
            return M2 / (n - 1);
        }
        //
        // Summary:
        //     Computes the Variance of a sequence of nullable System.Single values.
        //
        // Parameters:
        //   source:
        //     A sequence of nullable System.Single values to calculate the Variance of.
        //
        // Returns:
        //     The Variance of the sequence of values, or null if the source sequence is
        //     empty or contains only values that are null.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source is null.
        public static float? Variance(this IEnumerable<float?> source)
        {
            IEnumerable<float> values = source.AllValues();
            if (values.Any())
                return values.Variance();

            return null;
        }
        //
        // Summary:
        //     Computes the Variance of a sequence of System.Single values.
        //
        // Parameters:
        //   source:
        //     A sequence of System.Single values to calculate the Variance of.
        //
        // Returns:
        //     The Variance of the sequence of values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source is null.
        //
        //   System.InvalidOperationException:
        //     source contains no elements.
        public static float Variance(this IEnumerable<float> source)
        {
            return (float)source.Select(x => (double)x).Variance();
        }
        //
        // Summary:
        //     Computes the Variance of a sequence of nullable System.Int32 values.
        //
        // Parameters:
        //   source:
        //     A sequence of nullable System.Int32values to calculate the Variance of.
        //
        // Returns:
        //     The Variance of the sequence of values, or null if the source sequence is
        //     empty or contains only values that are null.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source is null.
        //
        //   System.OverflowException:
        //     The sum of the elements in the sequence is larger than System.Int64.MaxValue.
        public static double? Variance(this IEnumerable<int?> source)
        {
            IEnumerable<int> values = source.AllValues();
            if (values.Any())
                return values.Variance();

            return null;
        }
        //
        // Summary:
        //     Computes the Variance of a sequence of System.Int32 values.
        //
        // Parameters:
        //   source:
        //     A sequence of System.Int32 values to calculate the Variance of.
        //
        // Returns:
        //     The Variance of the sequence of values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source is null.
        //
        //   System.InvalidOperationException:
        //     source contains no elements.
        //
        //   System.OverflowException:
        //     The sum of the elements in the sequence is larger than System.Int64.MaxValue.
        public static double Variance(this IEnumerable<int> source)
        {
            return source.Select(x => (double)x).Variance();
        }
        //
        // Summary:
        //     Computes the Variance of a sequence of nullable System.Int64 values.
        //
        // Parameters:
        //   source:
        //     A sequence of nullable System.Int64 values to calculate the Variance of.
        //
        // Returns:
        //     The Variance of the sequence of values, or null if the source sequence is
        //     empty or contains only values that are null.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source is null.
        //
        //   System.OverflowException:
        //     The sum of the elements in the sequence is larger than System.Int64.MaxValue.
        public static double? Variance(this IEnumerable<long?> source)
        {
            IEnumerable<long> values = source.AllValues();
            if (values.Any())
                return values.Variance();

            return null;
        }
        //
        // Summary:
        //     Computes the Variance of a sequence of System.Int64 values.
        //
        // Parameters:
        //   source:
        //     A sequence of System.Int64 values to calculate the Variance of.
        //
        // Returns:
        //     The Variance of the sequence of values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source is null.
        //
        //   System.InvalidOperationException:
        //     source contains no elements.
        //
        //   System.OverflowException:
        //     The sum of the elements in the sequence is larger than System.Int64.MaxValue.
        public static double Variance(this IEnumerable<long> source)
        {
            return source.Select(x => (double)x).Variance();
        }
        //
        // Summary:
        //     Computes the Variance of a sequence of nullable System.Decimal values that
        //     are obtained by invoking a transform function on each element of the input
        //     sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to calculate the Variance of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The Variance of the sequence of values, or null if the source sequence is
        //     empty or contains only values that are null.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null.
        //
        //   System.OverflowException:
        //     The sum of the elements in the sequence is larger than System.Decimal.MaxValue.
        public static decimal? Variance<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal?> selector)
        {
            return source.Select(selector).Variance();
        }
        //
        // Summary:
        //     Computes the Variance of a sequence of System.Decimal values that are obtained
        //     by invoking a transform function on each element of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values that are used to calculate an Variance.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The Variance of the sequence of values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null.
        //
        //   System.InvalidOperationException:
        //     source contains no elements.
        //
        //   System.OverflowException:
        //     The sum of the elements in the sequence is larger than System.Decimal.MaxValue.
        public static decimal Variance<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector)
        {
            return source.Select(selector).Variance();
        }
        //
        // Summary:
        //     Computes the Variance of a sequence of nullable System.Double values that
        //     are obtained by invoking a transform function on each element of the input
        //     sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to calculate the Variance of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The Variance of the sequence of values, or null if the source sequence is
        //     empty or contains only values that are null.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null.
        public static double? Variance<TSource>(this IEnumerable<TSource> source, Func<TSource, double?> selector)
        {
            return source.Select(selector).Variance();
        }
        //
        // Summary:
        //     Computes the Variance of a sequence of System.Double values that are obtained
        //     by invoking a transform function on each element of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to calculate the Variance of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The Variance of the sequence of values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null.
        //
        //   System.InvalidOperationException:
        //     source contains no elements.
        public static double Variance<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector)
        {
            return source.Select(selector).Variance();
        }
        //
        // Summary:
        //     Computes the Variance of a sequence of nullable System.Single values that
        //     are obtained by invoking a transform function on each element of the input
        //     sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to calculate the Variance of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The Variance of the sequence of values, or null if the source sequence is
        //     empty or contains only values that are null.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null.
        public static float? Variance<TSource>(this IEnumerable<TSource> source, Func<TSource, float?> selector)
        {
            return source.Select(selector).Variance();
        }
        //
        // Summary:
        //     Computes the Variance of a sequence of System.Single values that are obtained
        //     by invoking a transform function on each element of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to calculate the Variance of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The Variance of the sequence of values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null.
        //
        //   System.InvalidOperationException:
        //     source contains no elements.
        public static float Variance<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector)
        {
            return source.Select(selector).Variance();
        }
        //
        // Summary:
        //     Computes the Variance of a sequence of nullable System.Int32 values that are
        //     obtained by invoking a transform function on each element of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to calculate the Variance of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The Variance of the sequence of values, or null if the source sequence is
        //     empty or contains only values that are null.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null.
        //
        //   System.OverflowException:
        //     The sum of the elements in the sequence is larger than System.Int64.MaxValue.
        public static double? Variance<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector)
        {
            return source.Select(selector).Variance();
        }
        //
        // Summary:
        //     Computes the Variance of a sequence of System.Int32 values that are obtained
        //     by invoking a transform function on each element of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to calculate the Variance of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The Variance of the sequence of values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null.
        //
        //   System.InvalidOperationException:
        //     source contains no elements.
        //
        //   System.OverflowException:
        //     The sum of the elements in the sequence is larger than System.Int64.MaxValue.
        public static double Variance<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
        {
            return source.Select(selector).Variance();
        }
        //
        // Summary:
        //     Computes the Variance of a sequence of nullable System.Int64 values that are
        //     obtained by invoking a transform function on each element of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to calculate the Variance of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The Variance of the sequence of values, or null if the source sequence is
        //     empty or contains only values that are null.
        public static double? Variance<TSource>(this IEnumerable<TSource> source, Func<TSource, long?> selector)
        {
            return source.Select(selector).Variance();
        }
        //
        // Summary:
        //     Computes the Variance of a sequence of System.Int64 values that are obtained
        //     by invoking a transform function on each element of the input sequence.
        //
        // Parameters:
        //   source:
        //     A sequence of values to calculate the Variance of.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The Variance of the sequence of values.
        //
        // Exceptions:
        //   System.ArgumentNullException:
        //     source or selector is null.
        //
        //   System.InvalidOperationException:
        //     source contains no elements.
        //
        //   System.OverflowException:
        //     The sum of the elements in the sequence is larger than System.Int64.MaxValue.
        public static double Variance<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector)
        {
            return source.Select(selector).Variance();
        }
    }
}
