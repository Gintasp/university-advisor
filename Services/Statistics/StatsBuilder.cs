using Advisor.Models;
using System.Collections.Generic;
using System.Linq;

namespace Advisor.Services.Statistics
{
    public class StatsBuilder
    {
        public IStatisticCalculator Calculator { get; set; }

        public StatsBuilder(IStatisticCalculator statisticCalculator)
        {
            Calculator = statisticCalculator;
        }

        public dynamic BuildCourseStats(Course course)
        {
            List<Review> reviews = course.Reviews.ToList();
            var stats = new
            {
                review_count = reviews.Count,
                satisfaction = Calculator.CalcReviewAverage(reviews, r => r.Satisfaction, 1),
                difficulty = Calculator.CalcReviewAverage(reviews, r => r.Difficulty, 1),
                usefulness = Calculator.CalcReviewAverage(reviews, r => r.Usefulness, 1),
                interesting = Calculator.CalcReviewAverage(reviews, r => r.Interesting, 1),
                theory = Calculator.CalcReviewAverage(reviews, r => r.TheoryPercentage, 1),
                practice = Calculator.CalcReviewAverage(reviews, r => r.PracticePercentage, 1),
                overal = Calculator.CalcReviewAverage(reviews, r => r.OveralRating, 1)
            };

            return stats;
        }

        public dynamic BuildLecturerStats(Lecturer lecturer)
        {
            List<Review> reviews = lecturer.Reviews.ToList();
            var stats = new
            {
                review_count = reviews.Count,
                overal = Calculator.CalcReviewAverage(reviews, r => r.OveralRating, 1),
                competence = Calculator.CalcReviewAverage(reviews, r => r.Competence, 1),
                strictness = Calculator.CalcReviewAverage(reviews, r => r.Strictness, 1),
                delivery = Calculator.CalcReviewAverage(reviews, r => r.Delivery, 1),
                personality = Calculator.CalcReviewAverage(reviews, r => r.Personality, 1),
            };

            return stats;
        }

        public dynamic BuildStudyProgramStats(StudyProgram program)
        {
            List<Review> programReviews = program.Reviews.ToList();
            var stats = new
            {
                review_count = programReviews.Count,
                overal = Calculator.CalcReviewAverage(programReviews, r => r.OveralRating, 1),
                satisfaction = Calculator.CalcReviewAverage(programReviews, r => r.Satisfaction, 1),
                salary = Calculator.CalcReviewAverage(programReviews, r => r.Salary, 1),
                course_count = program.Courses.Count,
                relevant_industry = programReviews.Count > 0 ? programReviews.Count(r => r.RelevantIndustry == true) * 100 / programReviews.Count : 0
            };

            return stats;
        }

        public dynamic BuildFacultyStats(Faculty faculty)
        {
            List<Review> reviews = (from r in DB.Instance.Reviews
                                    join p in DB.Instance.StudyPrograms on r.StudyProgram.Id equals p.Id
                                    join f in DB.Instance.Faculties on p.Faculty.Id equals f.Id
                                    where f.Id == faculty.Id
                                    select r).ToList();
            var stats = new
            {
                review_count = reviews.Count,
                overal = Calculator.CalcReviewAverage(reviews, r => r.OveralRating, 1),
                satisfaction = Calculator.CalcReviewAverage(reviews, r => r.Satisfaction, 1),
                salary = Calculator.CalcReviewAverage(reviews, r => r.Salary, 1),
                lecturer_count = faculty.Lecturers.Count,
                study_program_count = faculty.StudyPrograms.Count,
                relevant_industry = reviews.Count > 0 ? reviews.Count(r => r.RelevantIndustry == true) * 100 / reviews.Count : 0
            };

            return stats;
        }

        public dynamic BuildUniversityStats(University uni)
        {
            List<Review> reviews = (from r in DB.Instance.Reviews
                                    join p in DB.Instance.StudyPrograms on r.StudyProgram.Id equals p.Id
                                    join f in DB.Instance.Faculties on p.Faculty.Id equals f.Id
                                    join u in DB.Instance.Universities on f.University.Id equals u.Id
                                    where u.Id == uni.Id
                                    select r).ToList();
            List<Faculty> faculties = uni.Faculties.ToList();
            int programCount = 0;
            faculties.ForEach(f => programCount += f.StudyPrograms.Count);
            var stats = new
            {
                salary = Calculator.CalcReviewAverage(reviews, r => r.Salary, 2),
                overal = Calculator.CalcReviewAverage(reviews, r => r.OveralRating, 1),
                satisfaction = Calculator.CalcReviewAverage(reviews, r => r.Satisfaction, 1),
                faculty_count = uni.Faculties.Count,
                review_count = reviews.Count,
                study_program_count = programCount,
                relevant_industry = reviews.Count > 0 ? reviews.Count(r => r.RelevantIndustry == true) * 100 / reviews.Count : 0
            };

            return stats;
        }
    }
}
