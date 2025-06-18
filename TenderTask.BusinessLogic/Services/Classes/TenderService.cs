using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TenderTask.BusinessLogic.DataTransferObjects;
using TenderTask.BusinessLogic.Services.Interfaces;
using TenderTask.DataAccess.Context;
using TenderTask.DataAccess.Models;
using TenderTask.DataAccess.Reporsitries.Interfaces;

namespace TenderTask.BusinessLogic.Services.Classes
{
    public class TenderService : ITenderService
    {
        private readonly ITenderRepoistory _tenderRepository;
        private readonly IMapper _mapper;
        private readonly ICategoryRepoistory _categoryRepository;

        public TenderService(ITenderRepoistory tenderRepository, IMapper mapper , ICategoryRepoistory categoryRepoistory  )
        {
            _tenderRepository = tenderRepository;
            _mapper = mapper;
            _categoryRepository = categoryRepoistory;
        }

        public async Task<IEnumerable<TenderDTO>> GetAllTendersAsync()
        {
            var tenders = await _tenderRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<TenderDTO>>(tenders);
        }

        public async Task<CategoryDTO> GetCategoryWithTendersAsync(int categoryId)
        {
            var category = await _tenderRepository.GetCategoryWithTendersAsync(categoryId);

            if (category is null)
                throw new Exception("Category not found");

            return _mapper.Map<CategoryDTO>(category);
        }

        public async Task<IEnumerable<TenderDTO>> GetTendersByCategoryAsync(int categoryId)
        {
            var tenders = await _tenderRepository.GetByCategoryIdAsync(categoryId);
            return _mapper.Map<IEnumerable<TenderDTO>>(tenders);
        }

        public async Task<IEnumerable<TenderDTO>> GetTendersByStatusAsync(TenderStatus status)
        {
            var tenders = await _tenderRepository.GetByStatusAsync(status);
            return _mapper.Map<IEnumerable<TenderDTO>>(tenders);
        }

        public async Task<PaginatedResult<TenderDTO>> GetPaginatedTendersAsync(int pageIndex, int pageSize)
        {
            var query = _tenderRepository.GetQueryable();

            var totalCount = await query.CountAsync();

            var tenders = await query
                .OrderByDescending(t => t.Date)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            var mappedTenders = _mapper.Map<List<TenderDTO>>(tenders);

            return new PaginatedResult<TenderDTO>
            {
                Items = mappedTenders,
                TotalCount = totalCount,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            return await _categoryRepository.GetAllCategoriesAsync();
        }
    }
}

