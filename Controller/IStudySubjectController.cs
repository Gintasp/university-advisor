using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advisor.View;
using System.Windows.Forms;


namespace Advisor.Controller
{
    public interface IStudySubjectController
    {
        StudySubjectView studySubjectView { get; set; }
        void LoadReviews();
        void HandleAddReview();
    }
}
