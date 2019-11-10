using Advisor.Models;
using System;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace Advisor.Services.IO
{
    public class FileManager : IFileManager
    {
        public bool UploadFile(HttpPostedFileBase file)
        {
            if (file.ContentLength < 0)
            {
                return false;
            }

            string basePath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName + "\\App_Data\\uploads\\";

            if (!Directory.Exists(basePath))
            {
                Directory.CreateDirectory(basePath);
            }

            string fileName = Path.GetFileName(file.FileName);
            file.SaveAs(basePath + fileName);

            return true;
        }

        public FileResult DownloadFile(UploadedFile file)
        {
            try
            {
                string filePath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName + "\\App_Data\\uploads\\" + file.FileName;
                byte[] fileBytes = File.ReadAllBytes(filePath);
                var fileResponse = new FileContentResult(fileBytes, "application/octet-stream")
                {
                    FileDownloadName = file.FileName,
                };

                return fileResponse;
            }
            catch (Exception e)
            {
                throw new IOException(nameof(file), e);
            }
        }
    }
}
