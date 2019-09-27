using System;
using System.Windows.Forms;

namespace Advisor.View
{
    public partial class StudyProgramView : Form
    {
        public StudyProgramView()
        {
            InitializeComponent();
        }

        private void OnViewLoad(object sender, EventArgs e)
        {
            //TODO: load StudyProgram data from DB
        }

        private void OnLeaveReviewButtonClick(object sender, EventArgs e)
        {
            //TODO: Handle leave a review button click and display review form
        }

        private void OnStudySubjectsButtonClick(object sender, EventArgs e)
        {
            //TODO: Handle displaying study subjects list
        }

        private void OnPreviousFormButtonClick(object sender, EventArgs e)
        {
            //TODO: Display previous form
        }
    }
}
