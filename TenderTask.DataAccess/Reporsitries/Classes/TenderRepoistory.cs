using Microsoft.EntityFrameworkCore;
using TenderTask.DataAccess.Context;
using TenderTask.DataAccess.Models;
using TenderTask.DataAccess.Reporsitries.Classes;
using TenderTask.DataAccess.Reporsitries.Interfaces;

public class TenderRepoistory(ApplicationDbContext _dbContext)
    : GenericRepoistory<Tender>(_dbContext), ITenderRepoistory
{
    public async Task<IEnumerable<Tender>> GetByCategoryIdAsync(int categoryId)
    {
        return await _dbContext.Tenders
            .Include(t => t.Company)
            .Include(t => t.Category)
            .Where(t => t.CategoryId == categoryId)
            .ToListAsync();
    }

    public async Task<IEnumerable<Tender>> GetByCompanyIdAsync(int companyId)
    {
        return await _dbContext.Tenders
            .Include(t => t.Company)
            .Include(t => t.Category)
            .Where(t => t.CompanyId == companyId)
            .ToListAsync();
    }

    public async Task<IEnumerable<Tender>> GetByStatusAsync(TenderStatus status)
    {
        return await _dbContext.Tenders
            .Include(t => t.Company)
            .Include(t => t.Category)
            .Where(t => t.Status == status)
            .ToListAsync();
    }

    public async Task<Category?> GetCategoryWithTendersAsync(int categoryId)
    {
        return await _dbContext.Categories
            .Include(c => c.Tenders)
                .ThenInclude(t => t.Company)
            .FirstOrDefaultAsync(c => c.CategoryId == categoryId);
    }
    public override async Task<IEnumerable<Tender>> GetAllAsync()
    {
        return await _dbContext.Tenders
            .Include(t => t.Company)
            .Include(t => t.Category)
            .ToListAsync();
    }

    public IQueryable<Tender> GetQueryable()
    {
        return _dbContext.Tenders
       .Include(t => t.Company)
       .Include(t => t.Category)
       .AsQueryable();
    }
    public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
    {
        return await _dbContext.Categories.ToListAsync();
    }
}
