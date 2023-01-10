using Microsoft.EntityFrameworkCore;
using Directory = FileManager.Models.Directory;
using File = FileManager.Models.File;

namespace FileManager.Data;

public class DataContext: DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    public DbSet<Directory> Directories { get; set; }
    public DbSet<File> Files { get; set; }
    public DbSet<Models.User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Directory>(entity =>
        {
            entity.HasKey(x => x.DirectoryId);
            entity.Property(x => x.IsRoot);
            entity.Property(x => x.DirectoryName);
            entity.Property(x => x.Description);
            entity.Property(x => x.ChildLimit);
            entity.HasOne(x => x.ParentDirectory)
                .WithMany(x => x.SubDirectories)
                .HasForeignKey(x => x.ParentDirectoryId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);
            entity.HasMany(x => x.Files)
                .WithOne(x => x.Directory)
                .HasForeignKey(x => x.DirectoryId);
        });
        modelBuilder.Entity<File>(entity =>
        {
            entity.HasKey(x => x.FileId);
            entity.Property(x => x.FileName);
            entity.Property(x => x.Description);
            entity.Property(x => x.AdditionTime);
            entity.Property(x => x.ModificationTime);
            entity.Property(x => x.Extension);
            entity.HasOne(x => x.Directory)
                .WithMany(x => x.Files)
                .IsRequired(true);
        });
    }

}