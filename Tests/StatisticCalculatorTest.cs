using Advisor.Models;
using Advisor.Service.Statistics;
using System.Collections.Generic;
using Xunit;

namespace Advisor.Tests
{
    public class StatisticCalculatorTest
    {
        [Fact]
        public void CalcReviewAverageEmptyTest()
        {
            StatisticCalculator calc = new StatisticCalculator();
            List<Review> reviews = new List<Review>();

            Assert.Equal(0, calc.CalcReviewAverage(reviews, r => r.Id, 2));
            Assert.Equal(0, calc.CalcReviewAverage(reviews, r => r.Id, 1));
            Assert.NotEqual(1, calc.CalcReviewAverage(reviews, r => r.Id, 2));
            Assert.NotEqual(1, calc.CalcReviewAverage(reviews, r => r.Id, 1));
        }

        [Fact]
        public void CalcReviewAverageTest()
        {
            StatisticCalculator calc = new StatisticCalculator();
            List<Review> reviews = new List<Review>();
            for(int i = 1; i < 3; i++)
            {
                reviews.Add(
                    new Review()
                    {
                        CareerStartYear = i,
                        UserId = i,
                        Competence = i,
                        Delivery = i,
                        Difficulty = i,
                        Interesting = i,
                        OveralRating = i,
                        Personality = i,
                        PracticePercentage = i * 10,
                        Salary = i * 100,
                        Satisfaction = i,
                        Usefulness = i
                    }    
                );
            }

            Assert.Equal(1.5f, calc.CalcReviewAverage(reviews, r => r.CareerStartYear, 2));
            Assert.Equal(1.5f, calc.CalcReviewAverage(reviews, r => r.Competence, 2));
            Assert.Equal(1.5f, calc.CalcReviewAverage(reviews, r => r.Delivery, 2));
            Assert.Equal(1.5f, calc.CalcReviewAverage(reviews, r => r.Difficulty, 2));
            Assert.Equal(1.5f, calc.CalcReviewAverage(reviews, r => r.Interesting, 2));
            Assert.Equal(1.5f, calc.CalcReviewAverage(reviews, r => r.OveralRating, 2));
            Assert.Equal(1.5f, calc.CalcReviewAverage(reviews, r => r.Personality, 2));
            Assert.Equal(15f, calc.CalcReviewAverage(reviews, r => r.PracticePercentage, 2));
            Assert.Equal(150f, calc.CalcReviewAverage(reviews, r => r.Salary, 2));
            Assert.Equal(1.5f, calc.CalcReviewAverage(reviews, r => r.Satisfaction, 2));
            Assert.Equal(1.5f, calc.CalcReviewAverage(reviews, r => r.Usefulness, 2));

            Assert.IsType<float>(calc.CalcReviewAverage(reviews, r => r.Usefulness, 2));
            Assert.IsType<float>(calc.CalcReviewAverage(reviews, r => r.Usefulness, 0));
        }
    }
}
