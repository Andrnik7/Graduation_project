# Electronic Journal System

## Overview
This project is an electronic journal system built with ASP.NET Core MVC. It is designed to digitize the educational workflow by allowing teachers to record student attendance, grades, and comments. Both students and teachers can securely access and monitor this information online in real-time.
## Features
* **Role-Based Access :** Distinct workflows for teachers (inputting data) and students (viewing data).
* **Real-Time Updates:** Immediate access to grades and attendance records.
* **Secure Sessions:** Implemented HTTP-only, essential cookies with a 30-minute idle timeout for secure user sessions.
* **MVC Architecture:** Clean separation of concerns using the Model-View-Controller pattern.
* **Database Integration:** Reliable data storage using SQL Server and Entity Framework Core.
##  Tech Stack
* **Framework:** .NET 8.0
* **Web Architecture:** ASP.NET Core MVC
* **Database:** Microsoft SQL Server
* **ORM:** Entity Framework Core (v8.0.8)
* **IDE:** Visual Studio 2022 (v17.10.3+)
##  Prerequisites
To run this project locally, ensure you have the following installed:
* .NET 8.0 SDK
* Microsoft SQL Server (Express or Developer edition)
* Visual Studio 2022 (or JetBrains Rider / VS Code)
##  Getting Started
### 1. Clone the Repository
```bash
git clone [https://github.com/your-username/your-repo-name.git](https://github.com/your-username/your-repo-name.git)
cd your-repo-name
```
### 2. Configure the Database
1. Open the `Graduation_project.sln` solution file in Visual Studio.
2. Open `appsettings.json` and configure your database connection string:
    JSON
    ```
    {
      "ConnectionStrings": {
        "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=ElectronicJournalDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;"
      }
    }
    ```
### 3. Apply Migrations
Open the **Package Manager Console** in Visual Studio and run the following command to create the database schema:
PowerShell
```
Update-Database
```
### 4. Run the Application
Press `F5` in Visual Studio or run the following command in your terminal:
Bash
```
dotnet run
```
By default, the application routes to the `Login/Sign_in` page.
## Project Structure highlights
- `/Controllers` - Contains routing and business logic handling (e.g., `LoginController`).
- `/Models` - Entity classes and the `DataContext` for Entity Framework.
- `/Views` - Razor pages for the UI.
- `/wwwroot` - Static assets, including CSS, JS, and images (e.g., `journal-book.png`).
- `/Migrations` - EF Core database migration files.
