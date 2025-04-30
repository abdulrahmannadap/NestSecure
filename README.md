# NestSecure
🚀 NestSecure Microservices Architecture
NestSecure is a modular society management system built using .NET 8 Web API following microservice architecture. It supports multiple roles including Security Guard, House Owner, Secretary, and Admin (Company Dashboard) with full JWT Authentication integration and is designed for future integration with Android/Desktop apps.

🧱 Project Structure

NestSecure

├── NestSecure.AuthService            → Handles user authentication, JWT issuing

├── NestSecure.UserService           → Manages users: house owners, guards, secretaries, societies

├── NestSecure.ComplaintService      → Complaint logging and tracking

├── NestSecure.MaintenanceService    → Maintenance records and status

├── NestSecure.VisitorService        → Visitor entry logging

├── NestSecure.NotificationService   → (Planned) Notifications and alerts

└── NestSecure.Shared                → Shared entities (e.g., Role), reusable by all services


🔐 AuthService Highlights
✅ JWT Authentication implemented via AuthController

📦 LoginDto and AuthResponseDto manage login and token responses

🧠 Business logic encapsulated in AuthService.cs

🛡️ Role-based entities and repositories

🔧 Modular service registration (Persistence, Repositories, Mappings)

🗃️ ApplicationDbContext for EF Core

📁 Common Folder Structure (per service)

Controllers/            → API Endpoints

Core/                   → Interfaces and DbContext

Entities/               → Domain Models

Repositories/           → Concrete implementations

Services/               → Business Logic (e.g., UnitOfWork)

Mappings/               → AutoMapper profiles

Dtos/                   → Request/Response DTOs

Configuration Files     → appsettings.json, DependencyInjection.cs, etc.

✅ Implemented Features
 JWT Authentication (NestSecure.AuthService)

 Role-based login handling

 Separated services for core domains

 Clean layered architecture

 Shared project for entity reuse

 AutoMapper and DI configurations



Used across microservices via project references





```
NestSecure
├── NestSecure.AuthService            → Handles user authentication, JWT issuing
│   ├── Connected Services            → External service references
│   ├── Dependencies                  → Project dependencies
│   ├── Properties                    → Project properties
│   ├── Controllers                   → API endpoints
│   │   └── AuthController.cs         → Handles authentication requests
│   ├── Core                          → Core components and interfaces
│   │   ├── ApplicationDbContext.cs   → EF Core database context
│   │   ├── IRepository.cs            → Base repository interface
│   │   ├── IRoleRepo.cs              → Role repository interface
│   │   └── IUserRepo.cs              → User repository interface
│   ├── Dtos                          → Data Transfer Objects
│   │   ├── AuthResponseDto.cs        → Authentication response model
│   │   └── LoginDto.cs               → Login request model
│   ├── Entities                      → Domain entities
│   │   ├── BaseEntity.cs             → Base entity with common properties
│   │   ├── Role.cs                   → User role entity
│   │   └── User.cs                   → User entity
│   ├── Mappings                      → Object mappings
│   │   └── MappingProfile.cs         → AutoMapper configuration
│   ├── Repositories                  → Data access implementations
│   │   ├── Repository.cs             → Generic repository implementation
│   │   ├── RoleRepo.cs               → Role repository implementation
│   │   └── UserRepo.cs               → User repository implementation
│   ├── Services                      → Business logic services
│   │   ├── AuthService.cs            → Authentication service implementation
│   │   ├── IAuthService.cs           → Authentication service interface
│   │   ├── IUnitOfWork.cs            → Unit of work pattern interface
│   │   └── UnitOfWork.cs             → Unit of work implementation
│   ├── appsettings.json              → Application configuration
│   ├── DependencyInjection.cs        → Service registration
│   ├── MappingConfiguration.cs       → AutoMapper configuration
│   ├── NestSecure.AuthService.http   → HTTP client definition
│   ├── PersistenceConfiguration.cs   → Database configuration
│   ├── Program.cs                    → Application entry point
│   └── RepositoryConfiguration.cs    → Repository registration

├── NestSecure.ComplaintService       → Manages resident complaints
│   ├── Connected Services            → External service references
│   ├── Dependencies                  → Project dependencies
│   ├── Properties                    → Project properties
│   ├── Controllers                   → API endpoints for complaints
│   ├── Core                          → Core components and interfaces
│   │   ├── ApplicationDbContext.cs   → EF Core database context
│   │   ├── IComplaintRepo.cs         → Complaint repository interface
│   │   └── IRepository.cs            → Base repository interface
│   ├── Dtos                          → Data Transfer Objects
│   ├── Entities                      → Domain entities
│   │   ├── BaseEntity.cs             → Base entity with common properties
│   │   └── Complaint.cs              → Complaint entity
│   ├── Mappings                      → Object mappings
│   │   └── MappingProfile.cs         → AutoMapper configuration
│   ├── Repositories                  → Data access implementations
│   │   ├── ComplaintRepo.cs          → Complaint repository implementation
│   │   └── Repository.cs             → Generic repository implementation
│   ├── Services                      → Business logic services
│   │   ├── IUnitOfWork.cs            → Unit of work pattern interface
│   │   └── UnitOfWork.cs             → Unit of work implementation
│   ├── appsettings.json              → Application configuration
│   ├── DependencyInjection.cs        → Service registration
│   ├── MappingConfiguration.cs       → AutoMapper configuration
│   ├── NestSecure.ComplaintService.http → HTTP client definition
│   ├── PersistenceConfiguration.cs   → Database configuration
│   ├── Program.cs                    → Application entry point
│   └── RepositoryConfiguration.cs    → Repository registration

├── NestSecure.MaintenanceService     → Handles property maintenance requests
│   ├── Connected Services            → External service references
│   ├── Dependencies                  → Project dependencies
│   ├── Properties                    → Project properties
│   ├── Controllers                   → API endpoints for maintenance
│   ├── Core                          → Core components and interfaces
│   │   ├── ApplicationDbContext.cs   → EF Core database context
│   │   ├── IMaintenanceRepo.cs       → Maintenance repository interface
│   │   └── IRepository.cs            → Base repository interface
│   ├── Dtos                          → Data Transfer Objects
│   ├── Entities                      → Domain entities
│   │   ├── BaseEntity.cs             → Base entity with common properties
│   │   └── Complaint.cs              → Maintenance request entity
│   ├── Mappings                      → Object mappings
│   │   └── MappingProfile.cs         → AutoMapper configuration
│   ├── Repositories                  → Data access implementations
│   │   ├── MaintenanceRepo.cs        → Maintenance repository implementation
│   │   └── Repository.cs             → Generic repository implementation
│   ├── Services                      → Business logic services
│   │   ├── IUnitOfWork.cs            → Unit of work pattern interface
│   │   └── UnitOfWork.cs             → Unit of work implementation
│   ├── appsettings.json              → Application configuration
│   ├── DependencyInjection.cs        → Service registration
│   ├── MappingConfiguration.cs       → AutoMapper configuration
│   ├── NestSecure.MaintenanceService.http → HTTP client definition
│   ├── PersistenceConfiguration.cs   → Database configuration
│   ├── Program.cs                    → Application entry point
│   └── RepositoryConfiguration.cs    → Repository registration

├── NestSecure.NotificationService    → Manages alerts and notifications
│   ├── Connected Services            → External service references
│   ├── Dependencies                  → Project dependencies
│   ├── Properties                    → Project properties
│   ├── Controllers                   → API endpoints for notifications
│   ├── appsettings.json              → Application configuration
│   ├── NestSecure.NotificationService.http → HTTP client definition
│   └── Program.cs                    → Application entry point

├── NestSecure.Shared                 → Common components across services
│   ├── Connected Services            → External service references
│   ├── Dependencies                  → Project dependencies
│   ├── Properties                    → Project properties
│   ├── Entities                      → Shared entities
│   │   └── Role.cs                   → Role entity definition
│   ├── appsettings.json              → Application configuration
│   ├── NestSecure.Shared.http        → HTTP client definition
│   └── Program.cs                    → Application entry point

├── NestSecure.UserService            → Manages different user types
│   ├── Connected Services            → External service references
│   ├── Dependencies                  → Project dependencies
│   ├── Properties                    → Project properties
│   ├── Controllers                   → API endpoints for user management
│   ├── Core                          → Core components and interfaces
│   │   ├── ApplicationDbContext.cs   → EF Core database context
│   │   ├── IHouseOwnerRepo.cs        → House owner repository interface
│   │   ├── IRepository.cs            → Base repository interface
│   │   ├── ISecretaryRepo.cs         → Secretary repository interface
│   │   ├── ISecurityGuardRepo.cs     → Security guard repository interface
│   │   └── ISocietyRepo.cs           → Society repository interface
│   ├── Dtos                          → Data Transfer Objects
│   ├── Entities                      → Domain entities
│   │   ├── BaseEntity.cs             → Base entity with common properties
│   │   ├── HouseOwner.cs             → House owner entity
│   │   ├── Secretary.cs              → Secretary entity
│   │   ├── SecurityGuard.cs          → Security guard entity
│   │   └── Society.cs                → Society/community entity
│   ├── Mappings                      → Object mappings
│   │   └── MappingProfile.cs         → AutoMapper configuration
│   ├── Repositories                  → Data access implementations
│   │   ├── HouseOwnerRepo.cs         → House owner repository implementation
│   │   ├── Repository.cs             → Generic repository implementation
│   │   ├── SecretaryRepo.cs          → Secretary repository implementation
│   │   ├── SecurityGuardRepo.cs      → Security guard repository implementation
│   │   └── SocietyRepo.cs            → Society repository implementation
│   ├── Services                      → Business logic services
│   │   ├── IUnitOfWork.cs            → Unit of work pattern interface
│   │   └── UnitOfWork.cs             → Unit of work implementation
│   ├── appsettings.json              → Application configuration
│   ├── DependencyInjection.cs        → Service registration
│   ├── MappingConfiguration.cs       → AutoMapper configuration
│   ├── NestSecure.UserService.http   → HTTP client definition
│   ├── PersistenceConfiguration.cs   → Database configuration
│   ├── Program.cs                    → Application entry point
│   └── RepositoryConfiguration.cs    → Repository registration

└── NestSecure.VisitorService         → Manages visitor entries and access
    ├── Connected Services            → External service references
    ├── Dependencies                  → Project dependencies
    ├── Properties                    → Project properties
    ├── Controllers                   → API endpoints for visitor management
    ├── Core                          → Core components and interfaces
    │   ├── ApplicationDbContext.cs   → EF Core database context
    │   ├── IRepository.cs            → Base repository interface
    │   └── IVisitorRepo.cs           → Visitor repository interface
    ├── Dtos                          → Data Transfer Objects
    ├── Entities                      → Domain entities
    │   ├── BaseEntity.cs             → Base entity with common properties
    │   └── Visitor.cs                → Visitor entity
    ├── Mappings                      → Object mappings
    │   └── MappingProfile.cs         → AutoMapper configuration
    ├── Repositories                  → Data access implementations
    │   ├── Repository.cs             → Generic repository implementation
    │   └── VisitorRepo.cs            → Visitor repository implementation
    ├── Services                      → Business logic services
    │   ├── IUnitOfWork.cs            → Unit of work pattern interface
    │   └── UnitOfWork.cs             → Unit of work implementation
    ├── appsettings.json              → Application configuration
    ├── DependencyInjection.cs        → Service registration
    ├── MappingConfiguration.cs       → AutoMapper configuration
    ├── NestSecure.VisitorService.http → HTTP client definition
    ├── PersistenceConfiguration.cs   → Database configuration
    ├── Program.cs                    → Application entry point
    └── RepositoryConfiguration.cs    → Repository registration
```
