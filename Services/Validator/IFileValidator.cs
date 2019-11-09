using System.Web;

namespace Advisor.Services.Validator
{
    public interface IFileValidator
    {
        bool Validate(HttpPostedFileBase file);
    }
}