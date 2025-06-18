using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenderTask.DataAccess.Models;

namespace TenderTask.DataAccess.Reporsitries.Interfaces
{
   public interface ITenderRepoistory : IGenericRepoistory<Tender>
    {

       
        Task<IEnumerable<Tender>> GetByCategoryIdAsync(int categoryId);
        Task<IEnumerable<Tender>> GetByCompanyIdAsync(int companyId);
        Task<IEnumerable<Tender>> GetByStatusAsync(TenderStatus tenderStatus);
        Task<Category?> GetCategoryWithTendersAsync(int categoryId);
        IQueryable<Tender> GetQueryable();



    }
}
