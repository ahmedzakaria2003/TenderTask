using Microsoft.AspNetCore.Mvc;
using TenderTask.BusinessLogic.Services.Interfaces;
using TenderTask.DataAccess.Models;

namespace TenderTaskAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TenderController : ControllerBase
    {

        private readonly ITenderService _tenderService;

        public TenderController(ITenderService tenderService)
        {
            _tenderService = tenderService;
        }
        [HttpGet("all")]
        public async Task<IActionResult> GetPaginatedTenders([FromQuery] int pageIndex = 1, [FromQuery] int pageSize = 10)
        {
            var result = await _tenderService.GetPaginatedTendersAsync(pageIndex, pageSize);
            return Ok(result);
        }

        [HttpGet("by-category/{categoryId}")]
        public async Task<IActionResult> GetTendersByCategory(int categoryId)
        {
            var tenders = await _tenderService.GetTendersByCategoryAsync(categoryId);
            return Ok(tenders);
        }
        [HttpGet("by-status/{status}")]
        public async Task<IActionResult> GetTendersByStatus(TenderStatus status)
        {
            var tenders = await _tenderService.GetTendersByStatusAsync(status);
            return Ok(tenders);
        }

        [HttpGet("category-with-tenders/{categoryId}")]
        public async Task<IActionResult> GetCategoryWithTenders(int categoryId)
        {
            var category = await _tenderService.GetCategoryWithTendersAsync(categoryId);
            return Ok(category);
        }
        [HttpGet("get-all-categories")]
        public async Task<IActionResult> GetAllCategories()
        {
            var categories = await _tenderService.GetAllCategoriesAsync();
            return Ok(categories);
        }


    }
}
