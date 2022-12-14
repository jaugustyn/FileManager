namespace FileManager.Models;

public class Directory
{
    public int DirectoryId { get; set; }
    public bool IsRoot { get; set; } = false;
    public string DirectoryName { get; set; }
    public string Description { get; set; }
    public int OrderInRow { get; set; } = -1;
    public short ChildLimit { get; set; } = 32;
    
    public int? ParentId { get; set; } // Self referencing key

    public ICollection<Directory> SubFolders { get; } = new List<Directory>();
}