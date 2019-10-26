using Advisor.Model;
using System;
using System.Collections.Generic;

namespace Advisor.Service.Statistics
{
    public interface IStatisticCalculator
    {
        float CalcReviewAverage(List<Review> list, Func<Review, int> prop, int decimalPlaces);
    }
}