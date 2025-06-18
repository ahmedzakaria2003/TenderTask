using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace TenderTask.DataAccess.Models
{
    public class Tender
    {

        public int TenderId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public TenderStatus Status { get; set; }
        public string DetailsLink { get; set; }

     
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
