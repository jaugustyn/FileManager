using System.ComponentModel.DataAnnotations;
using FileManager.Models.Enums;

namespace FileManager.Models;

public class File
{
    [Key]
    public int FileId { get; set; }
    
    [Required]
    [StringLength(30, ErrorMessage = "Filename cannot be longer than 30 characters")]
    public string FileName { get; set; }
    public FileExtension Extension { get; set; }
    public string Description { get; set; }
    public DateTime AdditionTime { get; set; } = DateTime.Now;
    public DateTime ModificationTime { get; set; }
    public int? DirectoryId { get; set; }
    
    public Directory Directory { get; set; }
}