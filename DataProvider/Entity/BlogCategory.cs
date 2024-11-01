using DataProvider.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider.Entity;
public class BlogCategory: BaseEntity
{
    public string CategoryName { get; set; }
    public string CategoryIconAddress { get; set; }
    public virtual List<Blog> Blogs { get; set; }
}

public class BlogCategoryConfiguration : IEntityTypeConfiguration<BlogCategory>
{
    public void Configure(EntityTypeBuilder<BlogCategory> builder)
    {
        #region Properties features

        builder.HasKey(e => e.Id);
        builder.Property(e => e.CategoryName).IsRequired().HasMaxLength(100);
        builder.Property(e => e.CategoryIconAddress).IsRequired();
        #endregion
    }
}