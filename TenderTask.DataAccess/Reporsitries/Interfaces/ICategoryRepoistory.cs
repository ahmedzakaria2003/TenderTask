using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenderTask.DataAccess.Models;

namespace TenderTask.DataAccess.Reporsitries.Interfaces
{
    public interface ICategoryRepoistory : IGenericRepoistory<Category>
    {

        Task<IEnumerable<Category>> GetAllCategoriesAsync();

    }
}
