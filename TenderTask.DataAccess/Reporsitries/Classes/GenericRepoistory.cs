using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenderTask.DataAccess.Context;
using TenderTask.DataAccess.Reporsitries.Interfaces;

namespace TenderTask.DataAccess.Reporsitries.Classes
{
    public class GenericRepoistory<T>(ApplicationDbContext _dbContext) : IGenericRepoistory<T> where T : class
    {
      
        public virtual  async Task<IEnumerable<T>> GetAllAsync()
        {
       return    await _dbContext.Set<T>().ToListAsync(); 

        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }
    }
}
