# Schools Database Management System

## Overview

This is a C# Windows Forms application that connects to a Microsoft SQL Server database to manage and retrieve school-related information. The system stores data about school boards, students, teachers, and dependents, and allows users to run various SQL queries to view specific information from the database. The application leverages SQL `JOIN` operations to retrieve and display structured data in a user-friendly interface.

## Features

- **Database Connection**: Establishes a connection to a Microsoft SQL Server database using a connection string.
- **SQL Queries**: Supports various SQL queries to retrieve data from multiple tables (e.g., `schoolBoard`, `students`, `members`, `teachers`, etc.).
- **Data Display**: Displays query results in a `DataGridView` control.
- **Query Information**: Each query is explained through informative message boxes that describe the SQL operations.
- **Data Filtering**: Filters and groups data based on conditions such as student age, salary, and pay scale.

## Technologies Used

- **C#**: The application is built using C# in a Windows Forms environment.
- **SQL Server**: The backend database is powered by Microsoft SQL Server.
- **Windows Forms**: Used for the graphical user interface (GUI) to interact with the database.

## Setup Instructions

1. **Clone the repository**:
   git clone [https://github.com/ppatel2301/Database-Group-Project.git](https://github.com/ppatel2301/Database-Group-Project.git)

2. **Install Visual Studio**: Make sure you have Visual Studio installed with support for C# and Windows Forms applications.

3. **Database Connection**:
   - Ensure you have access to the Microsoft SQL Server database with the necessary credentials.
   - Update the connection string in the `connect()` method in `Form1.cs` to match your database server details.
     ```csharp
     string connectionString = "Data Source=your_server;Initial Catalog=cs3380;User=your_username;Password=your_password;";
     ```

4. **Run the Application**:
   - Open the project in Visual Studio.
   - Build and run the application. The form will display, and you can click on the buttons to execute various SQL queries and view the results.

## Functionality

- **Retrieve School Board Information**: View details like board number, phone number, name, email, and address.
- **Retrieve Student Information**: View student details such as name, grade, DOB, gender, and admission date.
- **Filter Students by Age**: Retrieve student details for students older than 12 years and sort by age and admission grade.
- **View Teacher Information**: View teacher details such as name, school email, and faculty department.

## SQL Queries

1. **Query 1**: Retrieves school board information along with the corresponding address.
2. **Query 2**: Retrieves student and member details sorted by the first name of the member.
3. **Query 3**: Retrieves student and member details for students over the age of 12, grouped and ordered by age and admission grade.
4. **Query 4**: Retrieves dependent information for non-academic staff and teachers based on salary/pay scale.
5. **Query 5**: Retrieves teacher details including their name, school email, and faculty department.
