using System;

namespace Advisor.Models
{
    public class UploadedFile
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public DateTime UploadedAt { get; set; }
        public virtual Course Course { get; set; }

        public UploadedFile()
        {
        }
    }
}
