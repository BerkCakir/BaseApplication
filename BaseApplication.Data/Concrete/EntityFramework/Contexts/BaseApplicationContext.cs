using BaseApplication.Data.Concrete.EntityFramework.Mappings;
using BaseApplication.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApplication.Data.Concrete.EntityFramework.Contexts
{
    public class BaseApplicationContext:DbContext
    {
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Category> Articles{ get; set; }

        public BaseApplicationContext(DbContextOptions<BaseApplicationContext> options) : base(options)
        {

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=BasicApplication;Integrated Security=True");
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new ArticleMap());
        }
    }
}
