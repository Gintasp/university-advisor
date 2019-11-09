using System.Web;

namespace Advisor.Services.IO
{
    public interface IFileUploader
    {
        bool UploadFile(HttpPostedFileBase file);
    }
}
