using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenderTask.BusinessLogic.DataTransferObjects;
using TenderTask.DataAccess.Models;

namespace TenderTask.BusinessLogic.Services.Interfaces
{
    public interface ITenderService
    {
        Task<IEnumerable<TenderDTO>> GetAllTendersAsync(); 
        Task<IEnumerable<TenderDTO>> GetTendersByCategoryAsync(int categoryId);
        Task<IEnumerable<TenderDTO>> GetTendersByStatusAsync(TenderStatus status);
        Task<CategoryDTO> GetCategoryWithTendersAsync(int categoryId);
        Task<PaginatedResult<TenderDTO>> GetPaginatedTendersAsync(int pageIndex, int pageSize);
        Task<IEnumerable<Category>> GetAllCategoriesAsync();

    }
}
