using BaseApplication.Entities.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApplication.Entities.Validators
{
    public class CategoryAddDtoValidator:AbstractValidator<CategoryAddDto>
    {
        public CategoryAddDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name cannot be empty").
                MaximumLength(70).WithMessage("Maxiumum 70 characters allowed").MinimumLength(3).WithMessage("Minimum of 3 characters must be entered");
            RuleFor(x => x.Description).MaximumLength(70).WithMessage("Maxiumum 500 characters allowed");
        }
    }
}
