Certainly! Here is the revised `README.md`:

---

# Pharmacy Application Management System

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
12. [Contacts](#contacts)

## Authors

- [S. S. Zobaer Ahmed](https://www.github.com/sszobaer)

## Prerequisites

Before starting, ensure you have the following installed:
- **Visual Studio:** [Download the latest version](https://visualstudio.microsoft.com/)
- **.NET Framework:** Available via Visual Studio or [Microsoft's official site](https://dotnet.microsoft.com/en-us/download/visual-studio-sdks)
- **SQL Server Management Studio (SSMS):** [Download the latest version](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16)

## Get Started

1. **Clone the Repository:**
   Obtain your own copy of the project with:
    ```bash
    git clone https://github.com/sszobaer/PharmacyManagementSystem.git
    cd PharmacyManagementSystem
    ```

2. **Database Configuration:**

   **Database Setup Instructions:**

   1. **Create a New Server in SSMS:**
      - Open SQL Server Management Studio (SSMS).
      - Connect to your server by entering the server details. For a new server, use default settings or consult your IT team or leave a massage to me at my [Contacts Section](#contacts).
      - Click "Connect" to establish the connection.
      - To create a new database, right-click on "Databases" in the Object Explorer pane, select "New Database...", enter `PharmacyManagementSystem`, and click "OK."

   2. **Access Database Files:**
      - Navigate to the "database" section in your repository.
      - Download the SQL script files for each table.

   3. **Execute SQL Scripts:**
      - Open a new query window in SSMS by clicking "New Query."
      - Copy and paste the SQL scripts from the downloaded files into the query window.

   4. **Script Execution Order:**
      - Execute the SQL scripts in the following order to maintain table relationships:
        - `SignUpTable`
        - `AdminTable`
        - `DepartmentTable`
        - `EmployeeTable`
        - `SalaryTable`
      - **Note:** For the initial script (e.g., `SignUpTable`), use `CREATE DATABASE PharmacyManagementSystem;` instead of `USE PharmacyManagementSystem;` if the database does not already exist.

   5. **Run the Scripts:**
      - Execute each script in the specified order to set up your database.

   Adjust the sequence or add additional tables as necessary for your setup.

3. **Library Dependencies:**
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

## Contacts

Feel free to reach out to me at [ahmedsszobaer@gmail.com](mailto:ahmedsszobaer@gmail.com) or connect with me on [LinkedIn](https://www.linkedin.com/in/s-s-zobaer-ahmed-209bab296/).

---