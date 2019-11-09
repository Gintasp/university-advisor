using System;
using System.IO;
using System.Web;

namespace Advisor.Services.IO
{
    public class FileUploader : IFileUploader
    {
        public bool UploadFile(HttpPostedFileBase file)
        {
            if (file.ContentLength < 0)
            {
                return false;
            }

            string fileName = Path.GetFileName(file.FileName);
            string path = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName + "\\App_Data\\uploads\\" + fileName;
            file.SaveAs(path);

            return true;
        }
    }
}
