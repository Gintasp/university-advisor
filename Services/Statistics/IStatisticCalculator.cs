using Advisor.Models;
using System;
using System.Collections.Generic;

namespace Advisor.Services.Statistics
{
    public interface IStatisticCalculator
    {
        float CalcReviewAverage(List<Review> list, Func<Review, int> prop, int decimalPlaces);
    }
}