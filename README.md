# Pharmacy Application Management System

Welcome to the Pharmacy Management System project! 🚀 This project empowers you to efficiently manage a Pharmacy, handle products, employees, departments, salaries, users by admin and handle cart, order by users in C#(.Net) and integrated with a Microsoft SQL database, it ensures seamless data storage and retrieval.

## Table of Contents

1. [Authors](#authors)
2. [Prerequisites](#prerequisites)
3. [Get Started](#get-started)
   - [Clone to this repository](#clone-to-this-repository)
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
Before starting make sure you have the following:
- **Visual Studio:** Download the latest version from [Official Microsoft Website](https://visualstudio.microsoft.com/)
- **.Net Framework:** Download .Net Desktop Development from Visual Studio or you can download from here [Microsoft official website](https://dotnet.microsoft.com/en-us/download/visual-studio-sdks)
- **SQL Server Management System:** Download the latest version of SSMS from [Official Microsoft Website](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16)

## Get Started

1. **Clone to this repository:** Obtain your own copy of the project:

    ```bash
    git clone https://github.com/sszobaer/PharmacyManagementSystem.git
    cd sszobaerahmed.dev
    ```
2. **Database Configuration:** 

   **Database Setup Instructions**

1. **Create a New Server in SSMS:**
   - **Open SQL Server Management Studio (SSMS).**
   - **Connect to a Server:**
     - In the "Connect to Server" window, enter your server details. If you're setting up a new server, use the default settings or consult your IT team for specifics.
     - Click "Connect" to establish a connection to the server.
   - **Create a New Database (if needed):**
     - Right-click on "Databases" in the Object Explorer pane.
     - Select "New Database..."
     - Enter the database name (e.g., `PharmacyManagementSystem`), and click "OK."

2. **Access Database Files:**
   - Go to your repository and navigate to the "database" section.
   - Locate and download the SQL script files for each table.

3. **Execute SQL Scripts:**
   - Open a new query window in SSMS by clicking "New Query."
   - Copy and paste the SQL scripts from the downloaded files into the query window.

4. **Script Execution Order:**
   - Execute the SQL scripts in the following order to ensure proper table relationships:
     - `SignUpTable`
     - `AdminTable`
     - `DepartmentTable`
     - `EmployeeTable`
     - `SalaryTable`
   - **Note:** For the initial script (e.g., `SignUpTable`), use `CREATE DATABASE PharmacyManagementSystem;` instead of `USE PharmacyManagementSystem;` to create the database if it doesn’t already exist.

5. **Run the Scripts:**
   - Execute each script in the specified order to set up your database.

Adjust the sequence or add additional tables as necessary for your setup.
3. **Library Dependencies:** Add the MSSQL developer tool:
   - Get the [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

## Features
Coming Soon

## Technology Used

- [C#](https://learn.microsoft.com/en-us/dotnet/csharp/): The C# language is the most popular language for the .NET platform, a free, cross-platform, open-source development environment. C# programs can run on many different devices, from Internet of Things (IoT) devices to the cloud and everywhere in between. You can write apps for phones, desktops, laptops, and servers.
- [.Net Framework](https://dotnet.microsoft.com/en-us/learn/dotnet/what-is-dotnet-framework): .NET is a developer platform made up of tools, programming languages, and libraries for building many different types of applications. Each implementation allows .NET code to execute in different places—Linux, macOS, Windows, iOS, Android, and more.

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

If you have any feedback, please reach out to us at ahmedsszobaer@gmail.com

## License

This project is licensed under the [MIT](https://github.com/sszobaer/Pharmacy-Manamgement-System?tab=MIT-1-ov-file) License - see the LICENSE file for details.

## Acknowledgements

We extend our sincere gratitude to our esteemed professor:

🎓 DR. MD IFTEKHARUL MOBIN  
🎓 ASSISTANT PROFESSOR, Faculty, DEPARTMENT OF COMPUTER SCIENCE

Your invaluable guidance has played a pivotal role in shaping this project, fostering a deep understanding of database management and software development principles.

## Contacts
Feel free to reach out to me through my mail: ahmedsszobaer@gmail.com

Or connect with me through my [LinkedIn](https://www.linkedin.com/in/s-s-zobaer-ahmed-209bab296/).
