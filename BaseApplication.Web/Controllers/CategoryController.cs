using AutoMapper;
using BaseApplication.Entities.Dtos;
using BaseApplication.Services.Abstract;
using BaseApplication.Shared.Utilities.Results.ComplexTypes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseApplication.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _categoryService.GetAll();
            if (result.ResultStatus != ResultStatus.Success)
            {
                TempData["errorMessage"] = result.Message;
            }
            return View(result.Data);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(CategoryAddDto categoryAddDto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var result = await _categoryService.Add(categoryAddDto);
            //if (result.ResultStatus != ResultStatus.Success)
            //{
            //    TempData["errorMessage"] = result.Message;
            //    return View();
            //}
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int Id)
        {
            var result = await _categoryService.HardDelete(Id);
            if(result.ResultStatus != ResultStatus.Success)
            {
                TempData["errorMessage"] = result.Message;
            }

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Update(int Id)
        {
            var result = await _categoryService.Get(Id);
            if (result.ResultStatus != ResultStatus.Success)
            {
                TempData["errorMessage"] = result.Message;
                return RedirectToAction(nameof(Index));
            }
            var categoryUpdateDto = _mapper.Map<CategoryUpdateDto>(result.Data);
            return View(categoryUpdateDto);
        }
        [HttpPost]
        public async Task<IActionResult> Update(CategoryUpdateDto categoryUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var result = await _categoryService.Update(categoryUpdateDto);
            //if (result.ResultStatus != ResultStatus.Success)
            //{
            //    TempData["errorMessage"] = result.Message;
            //    return View();
            //}
            return RedirectToAction(nameof(Index));
        }
    }
}
