using Advisor.View;
using Advisor.Model;
using System;

namespace Advisor.Controller
{
    public class LecturerListController : ILecturerListController
    {
        public LecturerListView LecturerListView { get; set; }
        public AddFormView AddFormView { get; set; }
        public Faculty Faculty { get; set; }

        public LecturerListController(Faculty faculty)
        {
            Faculty = faculty;
        }

        public void LoadLecturerData()
        {
            if(Faculty.Lecturers != null)
            {
                foreach (Lecturer lecturer in Faculty.Lecturers)
                {
                    LecturerListView.LecturerList.Items.Add(lecturer);
                }
            }
        }

        public void HandleAddLecturerButtonClick()
        {
            AddFormView = new AddFormView();
            AddFormView.TitleLabel.Text = "Add new lecturer";
            AddFormView.TextFieldLabel.Text = "Name:";
            AddFormView.DescriptionInput.Visible = false;
            AddFormView.DescriptionLabel.Visible = false;
            AddFormView.AddButtonClicked += HandleAddLecturer;
            AddFormView.ShowDialog();
        }

        public void HandleAddLecturer(object sender, EventArgs e)
        {
            Lecturer lecturer = new Lecturer()
            {
                Name = AddFormView.TitleInput.Text,
                Faculty = Faculty
            };
            DB.Instance.Lecturers.Add(lecturer);
            DB.Instance.SaveChanges();
            LecturerListView.LecturerList.Items.Add(lecturer);
            AddFormView.Close();
        }

        public void HandlePreviousFormButtonClick()
        {
            LecturerListView.Hide();
            FacultyView FacultyView = new FacultyView(new FacultyController(), Faculty, Faculty.University);
            FacultyView.Show();
        }

        public void HandleSelectedLecturer(Lecturer lecturer)
        {
            //TODO: Show individual lecturers view
        }
    }
}
