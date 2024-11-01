using DataProvider.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DataProvider.Entity;
public class Blog : BaseEntity
{
    public string Title { get; set; }
    public string Content { get; set; }
    public string BlogImageAddress { get; set; }
    public int BlogCategoryId { get; set; }
    public virtual BlogCategory BlogCategory { get; set; }
}

public class BlogConfiguration : IEntityTypeConfiguration<Blog>
{
    public void Configure(EntityTypeBuilder<Blog> builder)
    {
        #region Properties features

        builder.HasKey(e => e.Id);
        builder.Property(e => e.Title).IsRequired().HasMaxLength(100);
        builder.Property(e => e.Content).IsRequired();
        builder.Property(e => e.BlogImageAddress).IsRequired();
        #endregion

        builder.HasOne(x=> x.BlogCategory).WithMany(x=> x.Blogs).HasForeignKey(x=>x.BlogCategoryId).OnDelete(DeleteBehavior.Cascade);
    }
}