using System.Collections.Generic;
using System.Web;

namespace Advisor.Services.Validator
{
    public class FileValidator : IFileValidator
    {
        private List<string> AllowedFileTypes = new List<string>()
        {
            "image/jpeg",
            "image/png",
            "application/pdf",
            "text/plain",
            "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
        };

        public FileValidator()
        {
        }

        public bool Validate(HttpPostedFileBase file)
        {
            return AllowedFileTypes.Contains(file.ContentType);
        }
    }
}
