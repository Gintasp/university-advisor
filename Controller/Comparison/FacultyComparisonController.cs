using System;
using System.Collections.Generic;
using System.Linq;
using Advisor.Model;
using Advisor.View.Comparison;

namespace Advisor.Controller
{
    public class FacultyComparisonController : IFacultyComparisonController
    {
        public FacultyComparisonView FacultyComparisonView { get; set; }
        public void LoadUniversities()
        {
            List<University> unis = DB.Instance.Universities.ToList();
            FacultyComparisonView.UniversitySelectBox1.Items.Clear();
            FacultyComparisonView.UniversitySelectBox2.Items.Clear();
            foreach (University uni in unis)
            {
                FacultyComparisonView.UniversitySelectBox1.Items.Add(uni);
                FacultyComparisonView.UniversitySelectBox2.Items.Add(uni);
            }

        }
        public void LoadFaculties1()
        {
            FacultyComparisonView.FacultySelectBox1.Items.Clear();
            FacultyComparisonView.FacultySelectBox1.ResetText();
            University selectedUni = (University)FacultyComparisonView.UniversitySelectBox1.SelectedItem;
            List<Faculty> faculties = DB.Instance.Faculties.Where(f => f.University.Id == selectedUni.Id).ToList();
            foreach (Faculty fac in faculties)
            {
                FacultyComparisonView.FacultySelectBox1.Items.Add(fac);
            }
        }
        public void LoadFaculties2()
        {
            FacultyComparisonView.FacultySelectBox2.Items.Clear();
            FacultyComparisonView.FacultySelectBox2.ResetText();
            University selectedUni = (University)FacultyComparisonView.UniversitySelectBox2.SelectedItem;
            List<Faculty> faculties = DB.Instance.Faculties.Where(f => f.University.Id == selectedUni.Id).ToList();
            foreach (Faculty fac in faculties)
            {
                FacultyComparisonView.FacultySelectBox2.Items.Add(fac);
            }
        }
    }
}
