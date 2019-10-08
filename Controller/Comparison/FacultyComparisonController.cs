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
    }
}
