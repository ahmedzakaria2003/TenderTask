using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenderTask.BusinessLogic.DataTransferObjects
{
   public class TenderDTO
    {
        public int TenderId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }= null!;
        public string Status { get; set; } = null!;     

        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;

        public int CompanyId { get; set; }
        public string CompanyName { get; set; } = null!;
    }
}
