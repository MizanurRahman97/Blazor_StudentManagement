# Student Management System - Blazor Project

## Overview
This Student Management System is a Blazor project designed to manage student information, courses, and enrollment. It provides a web-based interface for administrators to perform various tasks related to student and course management.

## Features
- **Student Management**: Add, edit, and delete student information.
- **Course Management**: Create, update, and remove courses offered by the institution.
- **Enrollment System**: Enroll and unenroll students in courses.
- **Grading System**: Record and manage student grades.
- **User Authentication**: Secure access with user roles (admin, faculty, etc.).
- **Responsive UI**: A user-friendly interface that adapts to different devices.

## Technologies Used
- **C#**: The primary programming language for the application.
- **Blazor WebAssembly**: The framework used for building interactive web applications.
- **ASP.NET Core**: Used for server-side functionality and API endpoints.
- **Entity Framework Core**: ORM for database interactions.
- **SQL Server**: The database management system used to store and retrieve data.

## Setup Instructions
1. **Database Setup**:
    - Open SQL Server Management Studio.
    - Execute the SQL scripts in the `DatabaseScripts` folder to create the necessary tables and stored procedures.

2. **Connection String**:
    - Open the project in Visual Studio.
    - Locate the `appsettings.json` file and update the connection string with your SQL Server details.

    ```json
    {
      "ConnectionStrings": {
        "DefaultConnection": "Server=YOUR_SERVER;Database=StudentManagementDB;Integrated Security=True;"
      }
    }
    ```

3. **Build and Run**:
    - Build and run the project in Visual Studio.

4. **Access the Application**:
    - Open a web browser and navigate to the specified URL (usually `https://localhost:5001`).

## Folder Structure
- **/DatabaseScripts**: Contains SQL scripts for creating the database and tables.
- **/Pages**: Blazor components for different pages (Student, Course, Enrollment, etc.).
- **/Data**: Data models and Entity Framework context.
- **/Services**: Business logic and services.
- **/wwwroot**: Static files, such as images or stylesheets.

## Contributors
- [Mizanur Rahman]

## License
This project is licensed under the [MIT License](LICENSE).

Feel free to contribute, report issues, or provide feedback!
