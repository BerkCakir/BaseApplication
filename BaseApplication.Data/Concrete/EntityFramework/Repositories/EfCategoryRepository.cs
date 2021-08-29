using BaseApplication.Data.Abstract;
using BaseApplication.Data.Concrete.EntityFramework.Contexts;
using BaseApplication.Entities.Concrete;
using BaseApplication.Shared.Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApplication.Data.Concrete.EntityFramework.Repositories
{
    class EfCategoryRepository : EfEntityRepositoryBase<Category>, ICategoryRepository
    {
        public EfCategoryRepository(DbContext dbContext) : base(dbContext)
        {
        }
        //public async Task<Category> GetById(int categoryId)
        //{
        //    return await BaseApplicationContext.Categories.SingleOrDefaultAsync(c => c.Id == categoryId);
        //}

        //private BaseApplicationContext BaseApplicationContext
        //{
        //    get
        //    {
        //        return _dbContext as BaseApplicationContext;
        //    }
        //}
    }
}
