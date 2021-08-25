using AutoMapper;
using BaseApplication.Entities.Dtos;
using BaseApplication.Services.Abstract;
using BaseApplication.Shared.Utilities.Results.ComplexTypes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseApplication.Web.Controllers
{
    public class ArticleController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IArticleService _articleService;
        private readonly IMapper _mapper;

        public ArticleController(ICategoryService categoryService, IArticleService articleService, IMapper mapper)
        {
            _categoryService = categoryService;
            _articleService = articleService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _articleService.GetAll();
            if (result.ResultStatus != ResultStatus.Success)
            {
                TempData["errorMessage"] = result.Message;
            }
            return View(result.Data);
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var categoryResult = await _categoryService.GetAll();
            ViewBag.categoryList = new SelectList(categoryResult.Data, "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(ArticleAddDto articleAddDto)
        {
            var categoryResult = await _categoryService.GetAll();
            ViewBag.categoryList = new SelectList(categoryResult.Data, "Id", "Name");
            if (!ModelState.IsValid)
            {
                return View();
            }
            var result = await _articleService.Add(articleAddDto);
            //if (result.ResultStatus != ResultStatus.Success)
            //{
            //    TempData["errorMessage"] = result.Message;
            //    return View();
            //}
            return RedirectToAction(nameof(Index));
        }
    }
}
