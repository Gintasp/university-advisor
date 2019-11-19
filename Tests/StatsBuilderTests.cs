using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Advisor.Models;
using Advisor.Services.Statistics;
using Xunit;

namespace Advisor.Tests
{
    public class StatsBuilderTests
    {
        [Fact]
        public void BuildCourseStatsTest()
        {
            //Arrange
            StatsBuilder statsBuilder = new StatsBuilder(new StatisticCalculator());
            Course course = new Course();
            course.Reviews = new List<Review>();
            
            for (int i = 1; i < 3; i++)
            {
                course.Reviews.Add(
                    new Review()
                    {
                        TheoryPercentage = i,
                        PracticePercentage = i,
                        Difficulty = i,
                        Interesting = i,
                        OveralRating = i,
                        Satisfaction = i,
                        Usefulness = i
                    }
                );
            }

            var expected = new
            {
                review_count = 2,
                satisfaction = 1.5,
                difficulty = 1.5,
                usefulness = 1.5,
                interesting = 1.5,
                theory = 1.5,
                practice = 1.5,
                overal = 1.5
            };

            //Act
            var actual = statsBuilder.BuildCourseStats(course);

            //Assert
            Assert.Equal(expected.review_count, actual.review_count);
            Assert.Equal(expected.satisfaction, actual.satisfaction);
            Assert.Equal(expected.difficulty, actual.difficulty);
            Assert.Equal(expected.usefulness, actual.usefulness);
            Assert.Equal(expected.interesting, actual.interesting);
            Assert.Equal(expected.theory, actual.theory);
            Assert.Equal(expected.practice, actual.practice);
            Assert.Equal(expected.overal, actual.overal);
        }

        [Fact]
        public void BuildLecturerStatsTest()
        {
            //Arrange
            StatsBuilder statsBuilder = new StatsBuilder(new StatisticCalculator());
            Lecturer lecturer = new Lecturer();
            lecturer.Reviews = new List<Review>();

            for (int i = 1; i < 3; i++)
            {
                lecturer.Reviews.Add(
                    new Review()
                    {
                        OveralRating = i,
                        Competence = i,
                        Strictness = i,
                        Delivery = i,
                        Personality = i
                    }
                );
            }

            var expected = new
            {
                review_count = 2,
                competence = 1.5,
                strictness = 1.5,
                delivery = 1.5,
                personality = 1.5,
                overal = 1.5
            };

            //Act
            var actual = statsBuilder.BuildLecturerStats(lecturer);

            //Assert
            Assert.Equal(expected.review_count, actual.review_count);
            Assert.Equal(expected.competence, actual.competence);
            Assert.Equal(expected.strictness, actual.strictness);
            Assert.Equal(expected.delivery, actual.delivery);
            Assert.Equal(expected.personality, actual.personality);
            Assert.Equal(expected.overal, actual.overal);
        }

        [Fact]
        public void BuildStudyProgramStatsTest()
        {
            //Arrange
            StatsBuilder statsBuilder = new StatsBuilder(new StatisticCalculator());
            StudyProgram studyProgram = new StudyProgram();
            studyProgram.Reviews = new List<Review>();
            studyProgram.Courses = new List<Course>();

            for (int i = 1; i < 3; i++)
            {
                studyProgram.Reviews.Add(
                    new Review()
                    {
                        OveralRating = i,
                        Satisfaction = i,
                        Salary = i,
                        RelevantIndustry = true,
                    }
                );
            }

            var expected = new
            {
                review_count = 2,
                overal = 1.5,
                satisfaction = 1.5,
                salary = 1.5,
                course_count = 0,
                relevant_industry = 100
            };

            //Act
            var actual = statsBuilder.BuildStudyProgramStats(studyProgram);

            //Assert
            Assert.Equal(expected.review_count, actual.review_count);
            Assert.Equal(expected.overal, actual.overal);
            Assert.Equal(expected.satisfaction, actual.satisfaction);
            Assert.Equal(expected.salary, actual.salary);
            Assert.Equal(expected.course_count, actual.course_count);
            Assert.Equal(expected.relevant_industry, actual.relevant_industry);
        }

    }
}