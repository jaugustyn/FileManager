using FileManager.Models.Enums;

namespace FileManager.Models;

public class File
{
    public int FileId { get; set; }
    public string FileName { get; set; }
    public FileExtension Extension { get; set; }
}