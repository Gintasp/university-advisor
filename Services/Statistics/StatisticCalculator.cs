using Advisor.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Advisor.Service.Statistics
{
    public class StatisticCalculator : IStatisticCalculator
    {
        public float CalcReviewAverage(List<Review> list, Func<Review, int> prop, int decimalPlaces)
        {
            if (list.Count != 0)
            {
                return (float) Math.Round((double) list.Sum(r => prop(r)) / list.Count, decimalPlaces);
            }

            return 0;
        }
    }
}
