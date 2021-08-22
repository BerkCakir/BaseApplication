using BaseApplication.Entities.Concrete;
using BaseApplication.Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApplication.Data.Abstract
{
    public interface IArticleRepository:IEntityRepository<Article>
    {
    }
}
