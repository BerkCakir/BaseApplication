using AutoMapper;
using BaseApplication.Data.Abstract;
using BaseApplication.Entities.Concrete;
using BaseApplication.Entities.Dtos;
using BaseApplication.Services.Abstract;
using BaseApplication.Shared.Utilities.Messages;
using BaseApplication.Shared.Utilities.Results.Abstract;
using BaseApplication.Shared.Utilities.Results.ComplexTypes;
using BaseApplication.Shared.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApplication.Services.Concrete
{
    public class ArticleManager : IArticleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ArticleManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IDataResult<Article>> Get(int articleId)
        {
            var article = await _unitOfWork.Articles.GetAsync(a => a.Id == articleId, a => a.Category);
            if (article != null)
            {
                return new DataResult<Article>(ResultStatus.Success, article);
            }
            return new DataResult<Article>(ResultStatus.Error, Messages.Article.NotFound(), null);
        }

        public async Task<IDataResult<IList<Article>>> GetAll()
        {
            var articles = await _unitOfWork.Articles.GetAllAsync(null, a => a.Category);
            if (articles.Count > -1)
            {
                return new DataResult<IList<Article>>(ResultStatus.Success, articles);
            }
            return new DataResult<IList<Article>>(ResultStatus.Error, Messages.Article.NotFound(true), null);
        }

        public async Task<IDataResult<IList<Article>>> GetAllByCategory(int categoryId)
        {
            var result = await _unitOfWork.Categories.AnyAsync(c => c.Id == categoryId);
            if (result)
            {
                var articles = await _unitOfWork.Articles.GetAllAsync(a => a.CategoryId == categoryId && !a.IsDeleted && a.IsActive, a => a.Category);
                if (articles.Count > -1)
                {
                    return new DataResult<IList<Article>>(ResultStatus.Success, articles);
                }
                return new DataResult<IList<Article>>(ResultStatus.Error, Messages.Article.NotFound(true), null);
            }
            return new DataResult<IList<Article>>(ResultStatus.Error, Messages.Category.NotFound(), null);
        }

        public async Task<IDataResult<IList<Article>>> GetAllByNonDeleted()
        {
            var articles = await _unitOfWork.Articles.GetAllAsync(a => !a.IsDeleted, a => a.Category);
            if (articles.Count > -1)
            {
                return new DataResult<IList<Article>>(ResultStatus.Success, articles);
            }
            return new DataResult<IList<Article>>(ResultStatus.Error, Messages.Article.NotFound(true), null);
        }
        public async Task<IResult> Add(ArticleAddDto articleAddDto)
        {
            var article = _mapper.Map<Article>(articleAddDto);
            await _unitOfWork.Articles.AddAsync(article);
            await _unitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, Messages.Article.Add(articleAddDto.Title));
        }

        public async Task<IResult> Update(ArticleUpdateDto articleUpdateDto)
        {
            var article = _mapper.Map<Article>(articleUpdateDto);
            await _unitOfWork.Articles.UpdateAsync(article);
            await _unitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, Messages.Article.Update(articleUpdateDto.Title));
        }
        public async Task<IResult> Delete(int articleId)
        {
            var result = await _unitOfWork.Articles.AnyAsync(a => a.Id == articleId);
            if (result)
            {
                var article = await _unitOfWork.Articles.GetAsync(a => a.Id == articleId);
                article.ModifiedDate = DateTime.Now;
                article.IsDeleted = true;
                await _unitOfWork.Articles.UpdateAsync(article);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.Article.Delete(article.Title));
            }
            return new Result(ResultStatus.Error, Messages.Article.NotFound());
        }

        public async Task<IResult> HardDelete(int articleId)
        {
            var result = await _unitOfWork.Articles.AnyAsync(a => a.Id == articleId);
            if (result)
            {
                var article = await _unitOfWork.Articles.GetAsync(a => a.Id == articleId);
                await _unitOfWork.Articles.DeleteAsync(article);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, Messages.Article.HardDelete(article.Title));
            }
            return new Result(ResultStatus.Error, Messages.Article.NotFound());
        }
    }
}
