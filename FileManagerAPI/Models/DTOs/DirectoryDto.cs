using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace FileManager.Models.DTOs
{
    public class DirectoryDto
    {
        [Key]
        public int DirectoryId { get; set; }
        [Required]
        public string DirectoryName { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
    }
}
