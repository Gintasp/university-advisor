using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advisor.View;

namespace Advisor.Controller
{
    public class StudySubjectController : IStudySubjectController
    {
       
        public StudySubjectView studySubjectView { get; set; }

        public void HandleAddReview()
        {
            throw new NotImplementedException();
        }

        public void LoadReviews()
        {
            throw new NotImplementedException();
        }
    }
}
