using System.ComponentModel.DataAnnotations;

namespace FileManager.Models.DTOs
{
    public class FileDto
    {
        public int FileId { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
    }
}
