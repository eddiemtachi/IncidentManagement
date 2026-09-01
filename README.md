# Incident Management System (IMS)

##  Project Overview

The **Incident Management System (IMS)** is a web-based application designed to allow community members to report service-related incidents and track the progress of their reports.

The system aims to improve communication between citizens and administrators by providing a centralised platform where incidents such as **water outages, electricity problems, infrastructure damage, and other service-delivery issues** can be reported, managed, and monitored.

Instead of relying solely on traditional reporting methods such as telephone calls, emails, or visiting municipal offices, users can submit incidents through the system and receive a unique incident reference number that can be used to track the status of their report.

---

##  Project Objectives

The main objectives of the Incident Management System are to:

* Allow users to register and securely log into the system.
* Allow registered users to submit service-related incidents.
* Allow users to select an incident category.
* Allow users to provide an incident description and location.
* Automatically generate a unique incident identification number.
* Allow users to view their submitted incidents.
* Allow users to track the progress of their incidents.
* Allow administrators to view and manage reported incidents.
* Allow administrators to update incident statuses.
* Store incident information securely in a database.
* Restrict administrative functionality to authorised users.

---

##  Features

###  User Features

* User registration
* User login
* Secure authentication
* Incident submission
* Incident category selection
* Incident description
* Incident location
* Unique incident reference number
* View submitted incidents
* Track incident progress
* View incident status

###  Administrator Features

* Administrator authentication
* View reported incidents
* View incident details
* Assign incidents
* Update incident status
* Manage incident information
* Track incident history
* Manage user-related information

---

##  System Architecture

The system follows a layered architecture separating the presentation, business logic, data access, and database components.

```text
┌───────────────────────────────┐
│          User Interface       │
│       Blazor / Razor UI       │
└───────────────┬───────────────┘
                │
                ▼
┌───────────────────────────────┐
│       ASP.NET Core API        │
│         Controllers           │
└───────────────┬───────────────┘
                │
                ▼
┌───────────────────────────────┐
│       Business Logic          │
│       Services / DTOs         │
└───────────────┬───────────────┘
                │
                ▼
┌───────────────────────────────┐
│      Entity Framework Core    │
│          DbContext            │
└───────────────┬───────────────┘
                │
                ▼
┌───────────────────────────────┐
│          SQL Server           │
│           Database            │
└───────────────────────────────┘
```

---

##  Technologies Used

| Technology                | Purpose                                      |
| ------------------------- | -------------------------------------------- |
| **C#**                    | Main programming language                    |
| **ASP.NET Core**          | Backend/API development                      |
| **Blazor / Razor**        | Frontend development                         |
| **Entity Framework Core** | Database access and ORM                      |
| **SQL Server**            | Database management                          |
| **DTOs**                  | Data transfer between application layers     |
| **REST API**              | Communication between frontend and backend   |
| **Swagger / OpenAPI**     | API testing and documentation                |
| **JWT Authentication**    | Secure user authentication and authorisation |
| **Git / GitHub**          | Version control                              |

---

##  Database Structure

The system uses a relational SQL Server database.

The main entities include:

```text
User
 │
 ├── UserRole ─────────── Role
 │
 ├── IncidentAssignment ─ Incident
 │
 ├── FileAttachment
 │
 ├── IncidentHistory
 │
 ├── Notification
 │
 ├── PasswordResetToken
 │
 └── RefreshToken


Incident
 │
 ├── FileAttachment
 ├── IncidentAssignment
 ├── IncidentHistory
 ├── Notification
 ├── IncidentCategory
 ├── IncidentSeverity
 ├── IncidentStatus
 └── Priority


Notification
 │
 └── NotificationChannel
```

This structure allows the system to maintain relationships between users, incidents, administrators, notifications, assignments, and incident history.

---

##  Security

Security is an important component of the system.

The application is designed to:

* Authenticate registered users.
* Authorise users based on their roles.
* Restrict administrator functionality to authorised users.
* Protect sensitive user information.
* Use secure password storage.
* Use JWT-based authentication where applicable.
* Validate incoming data.
* Prevent unauthorised access to incidents and administrative functionality.

---

##  Incident Reporting Process

The general incident reporting process is:

```text
User Registers
      │
      ▼
User Logs In
      │
      ▼
Submits Incident
      │
      ▼
Selects Category
      │
      ▼
Provides Description
      │
      ▼
Provides Location
      │
      ▼
System Generates Reference Number
      │
      ▼
Administrator Reviews Incident
      │
      ▼
Incident Assigned
      │
      ▼
Administrator Updates Status
      │
      ▼
User Tracks Progress
      │
      ▼
Incident Resolved
```

---

##  Incident Statuses

Incidents can progress through different statuses depending on their current state.

Example:

| Status           | Description                                             |
| ---------------- | ------------------------------------------------------- |
| **Submitted**    | Incident has been successfully reported                 |
| **Under Review** | Administrator is reviewing the incident                 |
| **Assigned**     | Incident has been assigned to a responsible person/team |
| **In Progress**  | Work is currently being performed                       |
| **Resolved**     | The reported issue has been resolved                    |
| **Closed**       | Incident has been completed and closed                  |

---

##  Project Structure

An example project structure is:

```text
IncidentManagementSystem/
│
├── Controllers/
│   ├── AuthController.cs
│   ├── IncidentController.cs
│   └── AdminController.cs
│
├── Data/
│   └── ApplicationDbContext.cs
│
├── DTOs/
│   ├── UserDto.cs
│   ├── LoginDto.cs
│   ├── RegisterDto.cs
│   └── IncidentDto.cs
│
├── Models/
│   ├── User.cs
│   ├── Incident.cs
│   ├── Role.cs
│   ├── IncidentHistory.cs
│   └── Notification.cs
│
├── Services/
│   ├── AuthService.cs
│   └── IncidentService.cs
│
├── Repositories/
│   └── IncidentRepository.cs
│
├── Pages/
│   ├── Login.razor
│   ├── Register.razor
│   ├── SubmitIncident.razor
│   └── MyIncidents.razor
│
├── Components/
│
├── Migrations/
│
├── appsettings.json
├── Program.cs
└── README.md
```

*The exact structure may differ depending on the final implementation.*

---

##  Installation and Setup

### 1. Clone the Repository

```bash
git clone https://github.com/your-username/IncidentManagementSystem.git
```

Navigate into the project:

```bash
cd IncidentManagementSystem
```

### 2. Configure the Database

Update the connection string in:

```text
appsettings.json
```

Example:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=IncidentManagementDB;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
```

Replace `YOUR_SERVER` with your SQL Server instance.

### 3. Apply Entity Framework Migrations

Run:

```bash
dotnet ef database update
```

If Entity Framework tools are not installed:

```bash
dotnet tool install --global dotnet-ef
```

### 4. Restore Dependencies

```bash
dotnet restore
```

### 5. Build the Project

```bash
dotnet build
```

### 6. Run the Application

```bash
dotnet run
```

The application can then be accessed through the URL provided by ASP.NET Core.

---

##  API Documentation

The backend API can be tested using **Swagger**.

Example endpoints may include:

```text
POST   /api/auth/register
POST   /api/auth/login

POST   /api/incidents
GET    /api/incidents
GET    /api/incidents/{id}
PUT    /api/incidents/{id}

GET    /api/incidents/my-incidents

PUT    /api/admin/incidents/{id}/status
PUT    /api/admin/incidents/{id}/assign
```

The exact endpoints depend on the final implementation.

---

##  User Roles

The system supports role-based access control.

### Citizen/User

Can:

* Register
* Login
* Submit incidents
* View their incidents
* Track incident progress

### Administrator

Can:

* Login
* View reported incidents
* Manage incidents
* Assign incidents
* Update statuses
* View incident history

---

##  Future Improvements

Potential future improvements include:

*  Interactive map-based incident locations
*  Image/file attachments
*  Real-time notifications
*  Email notifications
*  Mobile application
*  Administrator dashboard and analytics
*  Advanced incident searching and filtering
*  Geographic incident visualisation
*  User feedback after incident resolution
*  Incident statistics and reporting
*  Integration with municipal systems

---

##  Known Limitations

The current system may have limitations depending on the implemented version, including:

* Reliance on internet connectivity.
* Limited integration with external municipal systems.
* Incident resolution depends on administrators or responsible personnel.
* Notification functionality may require additional external services.
* The system is primarily designed as a web-based solution.

---

##  Project Context

The Incident Management System was developed as a software engineering project to explore how technology can improve the reporting and management of community service-related incidents.

The system provides a centralised platform for reporting problems and monitoring their progress, with the goal of improving transparency, accountability, and communication between citizens and administrators.

---

##  Development

**Project:** Incident Management System
**Language:** C#
**Framework:** ASP.NET Core
**Frontend:** Blazor / Razor
**Database:** Microsoft SQL Server
**ORM:** Entity Framework Core
**API:** REST API
**Documentation:** Swagger

---

## 📄 License

This project was developed for educational and academic purposes.

Unless otherwise stated, the source code is not intended for commercial redistribution.
