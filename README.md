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
