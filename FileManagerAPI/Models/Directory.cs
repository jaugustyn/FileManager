using System.ComponentModel.DataAnnotations;

namespace FileManager.Models;

public class Directory
{
    [Key]
    public int DirectoryId { get; set; }
    public bool IsRoot { get; set; } = false;
    [Required]
    [StringLength(30, ErrorMessage = "Directory name cannot be longer than 30 characters")]
    public string DirectoryName { get; set; }
    public string Description { get; set; }
    public short ChildLimit { get; set; } = 32;
    public int? ParentDirectoryId { get; set; } // Self referencing key
    public Directory ParentDirectory { get; set; }

    public ICollection<Directory> SubDirectories { get; set; }
    public ICollection<File> Files { get; set; }
}