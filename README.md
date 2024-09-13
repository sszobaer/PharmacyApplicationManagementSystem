# Pharmacy Management System

Welcome to the Pharmacy Management System project! This application is designed to efficiently manage a pharmacy, including handling products, employees, departments, salaries, and user orders. Built with C# (.NET) and integrated with a Microsoft SQL Server database, it ensures seamless data storage and retrieval.

## Table of Contents

1. [Authors](#authors)
2. [Prerequisites](#prerequisites)
3. [Get Started](#get-started)
   - [Clone the Repository](#clone-the-repository)
   - [Database Configuration](#database-configuration)
   - [Library Dependencies](#library-dependencies)
4. [Features](#features)
5. [Technology Used](#technology-used)
6. [Color Reference](#color-reference)
7. [Roadmap](#roadmap)
8. [Lessons Learned](#lessons-learned)
9. [Feedback](#feedback)
10. [License](#license)
11. [Acknowledgements](#acknowledgements)
12. [Contact](#contact)

## Authors

- [S. S. Zobaer Ahmed](https://www.github.com/sszobaer)

## Prerequisites

Before starting, ensure you have the following installed:
- **Visual Studio:** [Download the latest version](https://visualstudio.microsoft.com/)
- **.NET Framework:** Available via Visual Studio or [Microsoft's official site](https://dotnet.microsoft.com/en-us/download/visual-studio-sdks)
- **SQL Server Management Studio (SSMS):** [Download the latest version](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16)

## Get Started

### Clone the Repository

Obtain your own copy of the project with:
    
```bash
git clone https://github.com/sszobaer/PharmacyManagementSystem.git
cd PharmacyManagementSystem
```

### Database Configuration

**Database Setup Instructions:**

1. **Create a New Server in SSMS:**
   - Open **SQL Server Management Studio (SSMS)**.
   - Connect to your server using the appropriate credentials.
   - To create a new database, right-click on "Databases" in the Object Explorer pane, select "New Database...", enter `PharmacyManagementSystem`, and click "OK."

2. **Access Database Files:**
   - Navigate to the "database" section in this repository.
   - Download the SQL script files for each table.

3. **Execute SQL Scripts:**
   - Open a new query window in SSMS.
   - Copy and paste or directly open the SQL scripts from the downloaded files into the query window.

4. **Script Execution Order:**
   - Run the SQL scripts in this order:
     1. `SignUpTable`
     2. `AdminTable`
     3. `DepartmentTable`
     4. `EmployeeTable`
     5. `SalaryTable`
   - **Note:** When setting up the database for the first time, use `CREATE DATABASE PharmacyManagementSystem;` if the database doesn't exist, rather than `USE PharmacyManagementSystem;`.

5. **Configure Connection String:**
   - In the **app.config** or **web.config** file of your WinForms application, update the connection string with your SQL Server details:

   ```xml
   <connectionStrings>
     <add name="PharmacyDB"
          connectionString="Data Source=YOUR_SERVER_NAME;Initial Catalog=PharmacyManagementSystem;Integrated Security=True"
          providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```

   - Replace `YOUR_SERVER_NAME` with the name of your SQL Server instance (for example, `localhost` or `.\SQLEXPRESS`).

6. **Integrated Security:**
   - If you're using **Windows Authentication** to access your database, the `Integrated Security=True` setting should work fine.
   - If you're using **SQL Server Authentication**, replace `Integrated Security=True` with the `User ID` and `Password` for your SQL Server credentials:

   ```xml
   <connectionStrings>
     <add name="PharmacyDB"
          connectionString="Data Source=YOUR_SERVER_NAME;Initial Catalog=PharmacyManagementSystem;User ID=yourUsername;Password=yourPassword"
          providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```

Make sure the connection string is set up properly to ensure smooth communication between your application and the database.

### Library Dependencies

- Ensure you have the [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) developer tools installed.

## Features

Coming Soon

## Technology Used

- **[C#](https://learn.microsoft.com/en-us/dotnet/csharp/):** A versatile programming language for the .NET platform, used for developing a wide range of applications.
- **[.NET Framework](https://dotnet.microsoft.com/en-us/learn/dotnet/what-is-dotnet-framework):** A comprehensive developer platform for building various types of applications across different operating systems.

## Color Reference

| Color   | Hex                                                                |
|---------|--------------------------------------------------------------------|
| Black   | ![#0a192f](https://via.placeholder.com/10/0a192f?text=+) #0a192f   |
| White   | ![#f8f8f8](https://via.placeholder.com/10/f8f8f8?text=+) #f8f8f8   |
| Orange  | ![#ff4522](https://via.placeholder.com/10/ff4522?text=+) #ff4522   |

## Roadmap

Coming Soon

## Lessons Learned

Coming Soon

## Feedback

For feedback, please reach out to us at [ahmedsszobaer@gmail.com](mailto:ahmedsszobaer@gmail.com).

## License

This project is licensed under the [MIT License](https://github.com/sszobaer/PharmacyManagementSystem/blob/main/LICENSE).

## Acknowledgements

Special thanks to:

🎓 **Dr. Md. Iftekharul Mobin**  
🎓 Assistant Professor, Department of Computer Science

Your guidance has been instrumental in the development of this project.

## Contact

Feel free to reach out to me at [ahmedsszobaer@gmail.com](mailto:ahmedsszobaer@gmail.com) or connect with me on [LinkedIn](https://www.linkedin.com/in/s-s-zobaer-ahmed-209bab296/).
