using BaseApplication.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApplication.Data.Concrete.EntityFramework.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.Name).HasMaxLength(70);
            builder.Property(a => a.Name).IsRequired();
            builder.Property(a => a.Description).HasMaxLength(500);
            builder.ToTable("Categories");

            builder.HasData(
            new Category 
            {
                Id = 1,
                Name = "C#",
                Description ="C# ile ilgili güncel bilgiler",
                IsDeleted = false,
                IsActive = true,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now            
            },
            new Category 
            {
                Id = 2,
                Name = "C++",
                Description ="C++ ile ilgili güncel bilgiler",
                IsDeleted = false,
                IsActive = true,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now            
            },
            new Category
            {
                Id = 3,
                Name = "JavaScript",
                Description = "JavaScript ile ilgili güncel bilgiler",
                IsDeleted = false,
                IsActive = true,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            });
        }

    }
}
