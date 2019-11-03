using System;
using System.Web.Mvc;

namespace Advisor.Controllers
{
    public interface IUniversityController
    {
        void HandleAddFaculty(object sender, EventArgs e);
        void HandleAddNewUniversity(object sender, EventArgs e);
        ActionResult Index(int? id);
    }
}