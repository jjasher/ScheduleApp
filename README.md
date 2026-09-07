# ScheduleApp

A desktop scheduling application built in C# with a MySQL backend. It supports full customer and appointment management, business rule validation, and multiple appointment reports through a Windows Forms interface.

## Features

**Customer Management**
- Add, update, and view customer records

**Appointment Scheduling**
- Add, update, and view appointments
- Prevents double booking by checking for overlapping appointments per user
- Enforces business hours (9:00 AM to 5:00 PM local time)
- Stores appointment times in UTC and converts them to the user's local time zone for display

**Authentication and User Experience**
- Login screen with input validation and a login attempt log for auditing
- Alerts the user to any appointment starting within 15 minutes of login
- Interface text localizes to English or Spanish based on the system's language setting

**Reporting**
- Total appointments by month and type
- Full appointment schedule grouped by user
- Daily appointment counts

## Tech Stack

- C# (.NET, Windows Forms)
- MySQL, accessed through MySQL Connector/NET (MySql.Data.MySqlClient)
- ADO.NET with parameterized queries to prevent SQL injection

## Project Structure

```
ScheduleApp/
├── DataAccess/
│   └── DBconnection.cs        Handles the MySQL connection
├── Forms/
│   ├── LoginForm.cs           Login, validation, and login history
│   ├── MainForm.cs            Main navigation
│   ├── CustomersForm.cs       Customer list and management
│   ├── AddCustomerForm.cs
│   ├── UpdateCustomerForm.cs
│   ├── AppointmentForm.cs     Appointment list and management
│   ├── AddAppointmentForm.cs  Overlap and business hours checks
│   ├── UpdateAppointmentForm.cs
│   └── ReportsForm.cs         Monthly, user, and daily reports
├── Appointment.cs             Appointment model
├── AppointmentReport.cs       Report data model
└── App.config                 Connection string configuration
```

## Getting Started

### Prerequisites
- Visual Studio 2019 or later
- MySQL Server
- MySQL Connector/NET

### Setup
1. Clone the repository.
2. Create a MySQL database with the required `customer` and `appointment` tables.
3. Update the connection string in `App.config` to point to your database.
4. Open `C969.slnx` in Visual Studio and run the project.

## About

This project was originally built as a coursework project to practice full CRUD operations, relational database integration, and real world scheduling logic such as time zone handling and conflict detection in a desktop application.
