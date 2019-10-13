using Advisor.Model;
using Advisor.Service.Auth;
using System.Linq;

namespace Advisor.Service.Validator
{
    public class ReviewValidator : IReviewValidator
    {
        public bool Validate(Course course)
        {
            var review = DB.Instance.Reviews
                .Where(r => r.User.Id == SessionStorage.Instance.User.Id && r.Course.Id == course.Id)
                .FirstOrDefault();

            return review == null;
        }

        public bool Validate(StudyProgram program)
        {
            var review = DB.Instance.Reviews
                .Where(r => r.User.Id == SessionStorage.Instance.User.Id && r.StudyProgram.Id == program.Id)
                .FirstOrDefault();

            return review == null;
        }

        public bool Validate(Lecturer lecturer)
        {
            var review = DB.Instance.Reviews
                .Where(r => r.User.Id == SessionStorage.Instance.User.Id && r.Lecturer.Id == lecturer.Id)
                .FirstOrDefault();

            return review == null;
        }
    }
}
