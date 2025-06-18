using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenderTask.DataAccess.Models
{
public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; } = null!;
        public string? Location { get; set; }  

        public ICollection<Tender> Tenders { get; set; }


    }
}
