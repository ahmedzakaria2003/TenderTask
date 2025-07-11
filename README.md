
This project is a RESTful API for categories, companies, and tenders for a government tenders platform in Saudi Arabia.

---

 🛠️ Technologies Used

- .NET 8 Web API
- Entity Framework Core
- SQL Server
- AutoMapper
- Swagger UI – for interactive API documentation

---

  
  Running the Project Locally

1. **Clone the repository
   ```bash
   git clone https://github.com/your-username/your-backend-repo.git
   cd your-backend-repo
---
2. Restore Dependencies
dotnet restore

---
3. Apply Database Migrations
dotnet ef database update

---
4. Run the Project
dotnet run


--- 
erDiagram
    Category ||--o{ Company : contains
    Company ||--o{ Tender : owns

    Category {
        int Id
        string Name
    }

    Company {
        int Id
        string Name
        string Description
        int CategoryId
        string Location
    }

    Tender {
        int Id
        string Title
        DateTime Deadline
        int CompanyId
    }




    

## 🔹 API Endpoints

 📦 Tenders

| Method | Endpoint                                         | Description                                  |
|--------|--------------------------------------------------|----------------------------------------------|
| GET    | `/api/Tender/all`                                | Get all tenders                              |
| GET    | `/api/Tender/by-category/{categoryId}`           | Get tenders filtered by specific category    |
| GET    | `/api/Tender/by-status/{status}`                 | Get tenders filtered by their status         |
| GET    | `/api/Tender/category-with-tenders/{categoryId}` | Get a category with all related tenders      |

 📂 Categories

| Method | Endpoint                            | Description                |
|--------|-------------------------------------|----------------------------|
| GET    | `/api/Tender/get-all-categories`    | Get all available categories |

---

📄 API Documentation 
You can explore and test the API using Swagger at:  
(http://localhost:5279/swagger/index.html)



The solution follows a layered architecture:

Controllers for API endpoints

Services for business logic

Repositories for database access

DTOs for data transfer

Models for entity definitions

The project adheres to Separation of Concerns

Ready for future expansion (e.g., adding user accounts, bidding system, reviews, etc.)

Swagger UI is enabled by default for easy testing


   
