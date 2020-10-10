using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PcBuilder.Services.Implementation;
using PcBuilder.Services.Interfaces;

namespace PcBuilder.Web.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet("Get")]
        public JsonResult Get()
        {
            var x = _categoryService.GetCategories();

            return new JsonResult(x);
        }
    }
}
