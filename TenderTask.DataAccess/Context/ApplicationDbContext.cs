using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenderTask.DataAccess.Models;

namespace TenderTask.DataAccess.Context
{
   public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Tender -> Category (Many-to-One)
            modelBuilder.Entity<Tender>()
                .HasOne(t => t.Category)
                .WithMany(c => c.Tenders)
                .HasForeignKey(t => t.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            // Tender -> Company (Many-to-One)
            modelBuilder.Entity<Tender>()
                .HasOne(t => t.Company)
                .WithMany(c => c.Tenders)
                .HasForeignKey(t => t.CompanyId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Tender>()
    .Property(t => t.Description)
    .HasMaxLength(500)
    .IsRequired();

            modelBuilder.Entity<Category>()
                .Property(c => c.CategoryName)
                .HasMaxLength(90)
                .IsRequired();

            modelBuilder.Entity<Company>()
                .Property(c => c.CompanyName)
                .HasMaxLength(100)
                .IsRequired();


            // Seeding Categories
            modelBuilder.Entity<Category>().HasData(
    new Category { CategoryId = 1, CategoryName = "Oil & Gas" },
    new Category { CategoryId = 2, CategoryName = "Medical Services" },
    new Category { CategoryId = 3, CategoryName = "Construction" },
    new Category { CategoryId = 4, CategoryName = "IT Services" },
    new Category { CategoryId = 5, CategoryName = "Consulting" },
    new Category { CategoryId = 6, CategoryName = "Manufacturing" },
    new Category { CategoryId = 7, CategoryName = "Education" },
    new Category { CategoryId = 8, CategoryName = "Translation Services" },
    new Category { CategoryId = 9, CategoryName = "Maintenance" },
    new Category { CategoryId = 10, CategoryName = "Logistics" },
    new Category { CategoryId = 11, CategoryName = "Financial Services" },
    new Category { CategoryId = 12, CategoryName = "Security" },
    new Category { CategoryId = 13, CategoryName = "Environmental Services" },
    new Category { CategoryId = 14, CategoryName = "Design" },
    new Category { CategoryId = 15, CategoryName = "Agriculture" },
    new Category { CategoryId = 16, CategoryName = "Telecommunications" },
    new Category { CategoryId = 17, CategoryName = "Food & Beverage" },
    new Category { CategoryId = 18, CategoryName = "Transport" },
    new Category { CategoryId = 19, CategoryName = "Real Estate" },
    new Category { CategoryId = 20, CategoryName = "Legal Services" }
);


            // Seeding Companies
            modelBuilder.Entity<Company>().HasData(
       new Company { CompanyId = 1, CompanyName = "Oil Co. 1" },
       new Company { CompanyId = 2, CompanyName = "Oil Co. 2" },
       new Company { CompanyId = 3, CompanyName = "Oil Co. 3" },
       new Company { CompanyId = 4, CompanyName = "Oil Co. 4" },
       new Company { CompanyId = 5, CompanyName = "Medical Co. 1" },
       new Company { CompanyId = 6, CompanyName = "Medical Co. 2" },
       new Company { CompanyId = 7, CompanyName = "Medical Co. 3" },
       new Company { CompanyId = 8, CompanyName = "Construction Co. 1" },
       new Company { CompanyId = 9, CompanyName = "Construction Co. 2" },
       new Company { CompanyId = 10, CompanyName = "Construction Co. 3" },
       new Company { CompanyId = 11, CompanyName = "IT Co. 1" },
       new Company { CompanyId = 12, CompanyName = "IT Co. 2" },
       new Company { CompanyId = 13, CompanyName = "Consulting Co. 1" },
       new Company { CompanyId = 14, CompanyName = "Consulting Co. 2" },
       new Company { CompanyId = 15, CompanyName = "Consulting Co. 3" },
       new Company { CompanyId = 16, CompanyName = "Manufacturing Co. 1" },
       new Company { CompanyId = 17, CompanyName = "Manufacturing Co. 2" },
       new Company { CompanyId = 18, CompanyName = "Manufacturing Co. 3" },
       new Company { CompanyId = 19, CompanyName = "Education Co. 1" },
       new Company { CompanyId = 20, CompanyName = "Education Co. 2" },
       new Company { CompanyId = 21, CompanyName = "Translation Co. 1" },
       new Company { CompanyId = 22, CompanyName = "Translation Co. 2" },
       new Company { CompanyId = 23, CompanyName = "Translation Co. 3" },
       new Company { CompanyId = 24, CompanyName = "Maintenance Co. 1" },
       new Company { CompanyId = 25, CompanyName = "Maintenance Co. 2" },
       new Company { CompanyId = 26, CompanyName = "Logistics Co. 1" },
       new Company { CompanyId = 27, CompanyName = "Logistics Co. 2" },
       new Company { CompanyId = 28, CompanyName = "Logistics Co. 3" },
       new Company { CompanyId = 29, CompanyName = "Logistics Co. 4" },
       new Company { CompanyId = 30, CompanyName = "Financial Co. 1" },
       new Company { CompanyId = 31, CompanyName = "Financial Co. 2" },
       new Company { CompanyId = 32, CompanyName = "Financial Co. 3" },
       new Company { CompanyId = 33, CompanyName = "Financial Co. 4" },
       new Company { CompanyId = 34, CompanyName = "Security Co. 1" },
       new Company { CompanyId = 35, CompanyName = "Security Co. 2" },
       new Company { CompanyId = 36, CompanyName = "Security Co. 3" },
       new Company { CompanyId = 37, CompanyName = "Security Co. 4" },
       new Company { CompanyId = 38, CompanyName = "Environmental Co. 1" },
       new Company { CompanyId = 39, CompanyName = "Environmental Co. 2" },
       new Company { CompanyId = 40, CompanyName = "Design Co. 1" },
       new Company { CompanyId = 41, CompanyName = "Design Co. 2" },
       new Company { CompanyId = 42, CompanyName = "Agriculture Co. 1" },
       new Company { CompanyId = 43, CompanyName = "Agriculture Co. 2" },
       new Company { CompanyId = 44, CompanyName = "Agriculture Co. 3" },
       new Company { CompanyId = 45, CompanyName = "Telecommunications Co. 1" },
       new Company { CompanyId = 46, CompanyName = "Telecommunications Co. 2" },
       new Company { CompanyId = 47, CompanyName = "Telecommunications Co. 3" },
       new Company { CompanyId = 48, CompanyName = "Food Co. 1" },
       new Company { CompanyId = 49, CompanyName = "Food Co. 2" },
       new Company { CompanyId = 50, CompanyName = "Transport Co. 1" },
       new Company { CompanyId = 51, CompanyName = "Transport Co. 2" },
       new Company { CompanyId = 52, CompanyName = "Real Co. 1" },
       new Company { CompanyId = 53, CompanyName = "Real Co. 2" },
       new Company { CompanyId = 54, CompanyName = "Real Co. 3" },
       new Company { CompanyId = 55, CompanyName = "Real Co. 4" },
       new Company { CompanyId = 56, CompanyName = "Legal Co. 1" },
       new Company { CompanyId = 57, CompanyName = "Legal Co. 2" }
   );



            // Seeding Tenders
            modelBuilder.Entity<Tender>().HasData(
                new Tender { TenderId = 1, Description = "Oil & Gas Tender 1 for Oil Co. 1", Date = DateTime.UtcNow.AddDays(-45), Status = TenderStatus.Inactive, CategoryId = 1, CompanyId = 1, DetailsLink = "https://example.com/tenders/1" },
                new Tender { TenderId = 2, Description = "Oil & Gas Tender 1 for Oil Co. 2", Date = DateTime.UtcNow.AddDays(-35), Status = TenderStatus.Inactive, CategoryId = 1, CompanyId = 2, DetailsLink = "https://example.com/tenders/2" },
                new Tender { TenderId = 3, Description = "Oil & Gas Tender 2 for Oil Co. 2", Date = DateTime.UtcNow.AddDays(-30), Status = TenderStatus.Inactive, CategoryId = 1, CompanyId = 2, DetailsLink = "https://example.com/tenders/3" },
                new Tender { TenderId = 4, Description = "Oil & Gas Tender 1 for Oil Co. 3", Date = DateTime.UtcNow.AddDays(-28), Status = TenderStatus.Active, CategoryId = 1, CompanyId = 3, DetailsLink = "https://example.com/tenders/4" },
                new Tender { TenderId = 5, Description = "Oil & Gas Tender 2 for Oil Co. 3", Date = DateTime.UtcNow.AddDays(-25), Status = TenderStatus.Active, CategoryId = 1, CompanyId = 3, DetailsLink = "https://example.com/tenders/5" },
                new Tender { TenderId = 6, Description = "Oil & Gas Tender 3 for Oil Co. 3", Date = DateTime.UtcNow.AddDays(-22), Status = TenderStatus.Active, CategoryId = 1, CompanyId = 3, DetailsLink = "https://example.com/tenders/6" },

                new Tender { TenderId = 7, Description = "Construction Tender 1 for Build Co. 1", Date = DateTime.UtcNow.AddDays(-21), Status = TenderStatus.Active, CategoryId = 2, CompanyId = 4, DetailsLink = "https://example.com/tenders/7" },
                new Tender { TenderId = 8, Description = "Construction Tender 2 for Build Co. 1", Date = DateTime.UtcNow.AddDays(-20), Status = TenderStatus.Active, CategoryId = 2, CompanyId = 4, DetailsLink = "https://example.com/tenders/8" },
                new Tender { TenderId = 9, Description = "Construction Tender 1 for Build Co. 2", Date = DateTime.UtcNow.AddDays(-19), Status = TenderStatus.Inactive, CategoryId = 2, CompanyId = 5, DetailsLink = "https://example.com/tenders/9" },
                new Tender { TenderId = 10, Description = "Construction Tender 2 for Build Co. 2", Date = DateTime.UtcNow.AddDays(-18), Status = TenderStatus.Inactive, CategoryId = 2, CompanyId = 5, DetailsLink = "https://example.com/tenders/10" },

                new Tender { TenderId = 11, Description = "IT Tender 1 for Tech Co. 1", Date = DateTime.UtcNow.AddDays(-17), Status = TenderStatus.Active, CategoryId = 3, CompanyId = 6, DetailsLink = "https://example.com/tenders/11" },
                new Tender { TenderId = 12, Description = "IT Tender 2 for Tech Co. 1", Date = DateTime.UtcNow.AddDays(-16), Status = TenderStatus.Inactive, CategoryId = 3, CompanyId = 6, DetailsLink = "https://example.com/tenders/12" },
                new Tender { TenderId = 13, Description = "IT Tender 1 for Tech Co. 2", Date = DateTime.UtcNow.AddDays(-15), Status = TenderStatus.Inactive, CategoryId = 3, CompanyId = 7, DetailsLink = "https://example.com/tenders/13" },
                new Tender { TenderId = 14, Description = "IT Tender 2 for Tech Co. 2", Date = DateTime.UtcNow.AddDays(-14), Status = TenderStatus.Active, CategoryId = 3, CompanyId = 7, DetailsLink = "https://example.com/tenders/14" },

                new Tender { TenderId = 15, Description = "Medical Tender 1 for Health Co. 1", Date = DateTime.UtcNow.AddDays(-13), Status = TenderStatus.Active, CategoryId = 4, CompanyId = 8, DetailsLink = "https://example.com/tenders/15" },
                new Tender { TenderId = 16, Description = "Medical Tender 2 for Health Co. 1", Date = DateTime.UtcNow.AddDays(-12), Status = TenderStatus.Inactive, CategoryId = 4, CompanyId = 8, DetailsLink = "https://example.com/tenders/16" },
                new Tender { TenderId = 17, Description = "Medical Tender 1 for Health Co. 2", Date = DateTime.UtcNow.AddDays(-11), Status = TenderStatus.Inactive, CategoryId = 4, CompanyId = 9, DetailsLink = "https://example.com/tenders/17" },
                new Tender { TenderId = 18, Description = "Medical Tender 2 for Health Co. 2", Date = DateTime.UtcNow.AddDays(-10), Status = TenderStatus.Active, CategoryId = 4, CompanyId = 9, DetailsLink = "https://example.com/tenders/18" },

                new Tender { TenderId = 19, Description = "Education Tender 1 for Edu Co. 1", Date = DateTime.UtcNow.AddDays(-9), Status = TenderStatus.Inactive, CategoryId = 5, CompanyId = 10, DetailsLink = "https://example.com/tenders/19" },
                new Tender { TenderId = 20, Description = "Education Tender 2 for Edu Co. 1", Date = DateTime.UtcNow.AddDays(-8), Status = TenderStatus.Active, CategoryId = 5, CompanyId = 10, DetailsLink = "https://example.com/tenders/20" },
                new Tender { TenderId = 21, Description = "Education Tender 3 for Edu Co. 1", Date = DateTime.UtcNow.AddDays(-7), Status = TenderStatus.Active, CategoryId = 5, CompanyId = 10, DetailsLink = "https://example.com/tenders/21" },
                new Tender { TenderId = 22, Description = "Education Tender 1 for Edu Co. 2", Date = DateTime.UtcNow.AddDays(-6), Status = TenderStatus.Inactive, CategoryId = 5, CompanyId = 11, DetailsLink = "https://example.com/tenders/22" },
                new Tender { TenderId = 23, Description = "Education Tender 2 for Edu Co. 2", Date = DateTime.UtcNow.AddDays(-5), Status = TenderStatus.Active, CategoryId = 5, CompanyId = 11, DetailsLink = "https://example.com/tenders/23" },

                new Tender { TenderId = 24, Description = "Agriculture Tender 1 for Agro Co. 1", Date = DateTime.UtcNow.AddDays(-4), Status = TenderStatus.Active, CategoryId = 6, CompanyId = 12, DetailsLink = "https://example.com/tenders/24" },
                new Tender { TenderId = 25, Description = "Agriculture Tender 2 for Agro Co. 1", Date = DateTime.UtcNow.AddDays(-3), Status = TenderStatus.Inactive, CategoryId = 6, CompanyId = 12, DetailsLink = "https://example.com/tenders/25" },
                new Tender { TenderId = 26, Description = "Agriculture Tender 1 for Agro Co. 2", Date = DateTime.UtcNow.AddDays(-2), Status = TenderStatus.Inactive, CategoryId = 6, CompanyId = 13, DetailsLink = "https://example.com/tenders/26" },
                new Tender { TenderId = 27, Description = "Agriculture Tender 2 for Agro Co. 2", Date = DateTime.UtcNow.AddDays(-1), Status = TenderStatus.Active, CategoryId = 6, CompanyId = 13, DetailsLink = "https://example.com/tenders/27" },

                new Tender { TenderId = 28, Description = "Transport Tender 1 for Trans Co. 1", Date = DateTime.UtcNow.AddDays(0), Status = TenderStatus.Active, CategoryId = 7, CompanyId = 14, DetailsLink = "https://example.com/tenders/28" },
                new Tender { TenderId = 29, Description = "Transport Tender 2 for Trans Co. 1", Date = DateTime.UtcNow.AddDays(1), Status = TenderStatus.Inactive, CategoryId = 7, CompanyId = 14, DetailsLink = "https://example.com/tenders/29" },
                new Tender { TenderId = 30, Description = "Transport Tender 1 for Trans Co. 2", Date = DateTime.UtcNow.AddDays(2), Status = TenderStatus.Inactive, CategoryId = 7, CompanyId = 15, DetailsLink = "https://example.com/tenders/30" },

                new Tender { TenderId = 31, Description = "Transport Tender 2 for Trans Co. 2", Date = DateTime.UtcNow.AddDays(3), Status = TenderStatus.Active, CategoryId = 7, CompanyId = 15, DetailsLink = "https://example.com/tenders/31" },
                new Tender { TenderId = 32, Description = "Energy Tender 1 for Energy Co. 1", Date = DateTime.UtcNow.AddDays(4), Status = TenderStatus.Active, CategoryId = 8, CompanyId = 16, DetailsLink = "https://example.com/tenders/32" },
                new Tender { TenderId = 33, Description = "Energy Tender 2 for Energy Co. 1", Date = DateTime.UtcNow.AddDays(5), Status = TenderStatus.Inactive, CategoryId = 8, CompanyId = 16, DetailsLink = "https://example.com/tenders/33" },
                new Tender { TenderId = 34, Description = "Energy Tender 1 for Energy Co. 2", Date = DateTime.UtcNow.AddDays(6), Status = TenderStatus.Active, CategoryId = 8, CompanyId = 17, DetailsLink = "https://example.com/tenders/34" },
                new Tender { TenderId = 35, Description = "Energy Tender 2 for Energy Co. 2", Date = DateTime.UtcNow.AddDays(7), Status = TenderStatus.Inactive, CategoryId = 8, CompanyId = 17, DetailsLink = "https://example.com/tenders/35" },

                new Tender { TenderId = 36, Description = "Finance Tender 1 for Finance Co. 1", Date = DateTime.UtcNow.AddDays(8), Status = TenderStatus.Active, CategoryId = 9, CompanyId = 18, DetailsLink = "https://example.com/tenders/36" },
                new Tender { TenderId = 37, Description = "Finance Tender 2 for Finance Co. 1", Date = DateTime.UtcNow.AddDays(9), Status = TenderStatus.Inactive, CategoryId = 9, CompanyId = 18, DetailsLink = "https://example.com/tenders/37" },
                new Tender { TenderId = 38, Description = "Finance Tender 1 for Finance Co. 2", Date = DateTime.UtcNow.AddDays(10), Status = TenderStatus.Active, CategoryId = 9, CompanyId = 19, DetailsLink = "https://example.com/tenders/38" },
                new Tender { TenderId = 39, Description = "Finance Tender 2 for Finance Co. 2", Date = DateTime.UtcNow.AddDays(11), Status = TenderStatus.Inactive, CategoryId = 9, CompanyId = 19, DetailsLink = "https://example.com/tenders/39" },
                new Tender { TenderId = 40, Description = "Legal Tender 1 for Legal Co. 1", Date = DateTime.UtcNow.AddDays(12), Status = TenderStatus.Active, CategoryId = 10, CompanyId = 20, DetailsLink = "https://example.com/tenders/40" },

                new Tender { TenderId = 41, Description = "Legal Tender 2 for Legal Co. 1", Date = DateTime.UtcNow.AddDays(13), Status = TenderStatus.Inactive, CategoryId = 10, CompanyId = 20, DetailsLink = "https://example.com/tenders/41" },
                new Tender { TenderId = 42, Description = "Legal Tender 1 for Legal Co. 2", Date = DateTime.UtcNow.AddDays(14), Status = TenderStatus.Active, CategoryId = 10, CompanyId = 21, DetailsLink = "https://example.com/tenders/42" },
                new Tender { TenderId = 43, Description = "Legal Tender 2 for Legal Co. 2", Date = DateTime.UtcNow.AddDays(15), Status = TenderStatus.Inactive, CategoryId = 10, CompanyId = 21, DetailsLink = "https://example.com/tenders/43" },
                new Tender { TenderId = 44, Description = "Telecom Tender 1 for Telecom Co. 1", Date = DateTime.UtcNow.AddDays(16), Status = TenderStatus.Active, CategoryId = 11, CompanyId = 22, DetailsLink = "https://example.com/tenders/44" },
                new Tender { TenderId = 45, Description = "Telecom Tender 2 for Telecom Co. 1", Date = DateTime.UtcNow.AddDays(17), Status = TenderStatus.Inactive, CategoryId = 11, CompanyId = 22, DetailsLink = "https://example.com/tenders/45" });
        }

        public DbSet<Tender> Tenders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Company> Companies { get; set; }



    }
}
