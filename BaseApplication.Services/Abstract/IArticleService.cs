using BaseApplication.Entities.Concrete;
using BaseApplication.Entities.Dtos;
using BaseApplication.Shared.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApplication.Services.Abstract
{
    public interface IArticleService
    {
        Task<IDataResult<Article>> Get(int articleId);
        Task<IDataResult<IList<Article>>> GetAll();
        Task<IDataResult<IList<Article>>> GetAllByNonDeleted();
        Task<IDataResult<IList<Article>>> GetAllByCategory(int categoryId);
        Task<IResult> Add(ArticleAddDto articleAddDto);
        Task<IResult> Update(ArticleUpdateDto articleUpdateDto);
        Task<IResult> Delete(int articleId);
        Task<IResult> HardDelete(int articleId);

    }
}
