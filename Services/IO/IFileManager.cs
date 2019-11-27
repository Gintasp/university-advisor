using Advisor.Models;
using System.Web;
using System.Web.Mvc;

namespace Advisor.Services.IO
{
    public interface IFileManager
    {
        string? UploadFile(HttpPostedFileBase file);
        FileResult DownloadFile(UploadedFile file);
    }
}
