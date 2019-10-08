using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advisor.View.Comparison;
using Advisor.Model;

namespace Advisor.Controller
{
    public interface IUniversityComparisonController
    {
       UniversityComparisonView UniversityComparisonView { get; set; }
        void LoadUniversityList();
        void HandlePreviousButtonClick(University uni);
    }
}
