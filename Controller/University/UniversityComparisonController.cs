using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advisor.View;
using Advisor.View.Comparison;
using Advisor.Model;

namespace Advisor.Controller
{
    class UniversityComparisonController : IUniversityComparisonController
    {
        public UniversityComparisonView UniversityComparisonView { get; set; }
        public UniversityView UniversityView { get; set; }
        public void LoadUniversityList()
        {

        }
        public void HandlePreviousButtonClick(University uni)
        {
            UniversityComparisonView.Hide();
            UniversityView = new UniversityView(new UniversityController(uni));
            UniversityView.ShowDialog();
        }
    }
}
