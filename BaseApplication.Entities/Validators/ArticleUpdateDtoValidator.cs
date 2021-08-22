using BaseApplication.Entities.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApplication.Entities.Validators
{
    class ArticleUpdateDtoValidator : AbstractValidator<ArticleUpdateDto>
    {
        public ArticleUpdateDtoValidator()
        {
            RuleFor(x => x.Id).NotNull();
             RuleFor(x => x.Title).NotEmpty().WithMessage("Title cannot be empty").
                MaximumLength(100).WithMessage("Maxiumum 100 characters allowed").MinimumLength(5).WithMessage("Minimum of 5 characters must be entered");

            RuleFor(x => x.Content).NotEmpty().WithMessage("Content cannot be empty").
                MinimumLength(20).WithMessage("Minimum of 20 characters must be entered");

            RuleFor(x => x.Thumbnail).NotEmpty().WithMessage("Thumbnail cannot be empty");
            RuleFor(x => x.Date).NotEmpty().WithMessage("Date cannot be empty");
            RuleFor(x => x.CategoryId).NotNull().WithMessage("Category cannot be empty");
        }
    }
}
