using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenderTask.DataAccess.Models
{
   public class Category
    {

        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;

        public ICollection<Tender> Tenders { get; set; }
    

    }
}
