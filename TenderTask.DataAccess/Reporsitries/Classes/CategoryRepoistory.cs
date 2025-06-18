using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenderTask.DataAccess.Context;
using TenderTask.DataAccess.Models;
using TenderTask.DataAccess.Reporsitries.Interfaces;

namespace TenderTask.DataAccess.Reporsitries.Classes
{
    public class CategoryRepoistory(ApplicationDbContext _dbContext) : GenericRepoistory<Category>(_dbContext), ICategoryRepoistory
    {
        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            return await _dbContext.Categories
                .Include(c => c.Tenders).Where(c => c.Tenders.Any())
                .ToListAsync();
        }
    }
}
