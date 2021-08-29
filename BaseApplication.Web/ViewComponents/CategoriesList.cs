using BaseApplication.Services.Abstract;
using BaseApplication.Shared.Utilities.Results.ComplexTypes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseApplication.Web.ViewComponents
{
    public class CategoriesList : ViewComponent
    {
        private readonly ICategoryService _categoryService;
        public CategoriesList(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var result = await _categoryService.GetAll();
            if (result.ResultStatus != ResultStatus.Success)
            {
                TempData["errorMessage"] = result.Message;
            }
            return View(result.Data);
        }
    }
}
