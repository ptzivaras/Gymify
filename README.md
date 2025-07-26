**Gymify API** is a RESTful ASP.NET Core Web API for managing gym members, subscriptions, and payments. This project demonstrates industry-standard practices including layered architecture, dependency injection, validation, exception handling, logging, and Docker support.

## Features

- **CRUD** operations for customers, subscriptions & payments
- **JWT Authentication** with role-based access control (Admin, User)
- **Layered Architecture**: Controllers, Services, Repositories, Data
- **DTOs & Validation** via FluentValidation
- **Global Exception Handling**
- **Structured Logging** with Serilog (console & file)
- **Swagger UI** for interactive API docs
- **Stored Procedures & Indexes** for optimized queries
- **Docker** support for containerization

### Run Migrations

```bash
dotnet tool install --global dotnet-ef # if not already installed
dotnet ef database update
```

### Run Application

```bash
dotnet run
```
## ADDED SWAGGER
## Testing with Postman

## Project Structure
GymifyAPI/
├─ Controllers/             # API controllers
├─ DTOs/                    # Data Transfer Objects
├─ Data/                    # ApplicationDbContext, migrations, SQL scripts
├─ Middleware/              # Global exception handling
├─ Models/                  # Domain entities
├─ Repositories/            # Data access layer
│  └─ Interfaces/           # Repository interfaces
├─ Services/                # Business logic layer
│  └─ Interfaces/           # Service interfaces
├─ Validators/              # FluentValidation rules
├─ postman/                 # Postman collection
├─ Dockerfile
├─ Dockerignore
├─ Program.cs
├─ appsettings.json
└─ README.md

## Technologies

- ASP.NET Core 8
- Entity Framework Core
- FluentValidation
- Serilog
- Swashbuckle (Swagger)
- SQL Server / PostgreSQL
- Docker
