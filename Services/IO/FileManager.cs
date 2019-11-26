using Advisor.Models;
using System;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace Advisor.Services.IO
{
    public class FileManager : IFileManager
    {
        public string? UploadFile(HttpPostedFileBase file)
        {
            if (file.ContentLength < 0)
            {
                return null;
            }

            string basePath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName + "\\App_Data\\uploads\\";

            if (!Directory.Exists(basePath))
            {
                Directory.CreateDirectory(basePath);
            }

            string fileTimestamp = DateTime.Now.ToFileTime().ToString();
            string extension = Path.GetExtension(file.FileName);
            file.SaveAs(basePath + fileTimestamp + extension);

            return fileTimestamp;
        }

        public FileResult DownloadFile(UploadedFile file)
        {
            try
            {
                string filePath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName + "\\App_Data\\uploads\\" + file.Hash;
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
