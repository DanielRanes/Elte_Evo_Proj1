Elte_Evo_Proj1 — Weather Data Management App

A C# Windows Forms desktop application for recording, managing, and visualizing weather measurements, built as a university course project (Evosoft C# class, ELTE). The app uses Entity Framework Core with SQL Server for data storage and supports two user roles: regular users and admins.

About the project

This was a course project focused on practicing database management and C# programming in a Windows Forms application — covering user authentication, CRUD operations, data filtering, charting, and XML export.

Features

Authentication

User registration and login with SHA-512 password hashing.
Two roles: User and SuperAdmin, with different access levels.

Measurements

Users can log indoor measurements (temperature, dew point) or outdoor measurements (temperature, air pressure, precipitation).
A filterable data grid shows all measurements (indoor/outdoor, own/others', by date range), with the day's maximum temperature highlighted.
Users can edit or delete their own measurements.
Average temperature is calculated live for the currently filtered data.

Admin panel

Line chart showing humidity trends over a selected date range.
Pie chart showing the distribution of outdoor temperatures by range, for a selected week.
User management (view, edit role/name, delete users).
Weekly XML export of average air pressure data.

Export

Users can export their filtered measurements (average temperature and precipitation over a date range) to XML.
Tech stack
C# / .NET, Windows Forms
Entity Framework Core (SQL Server / LocalDB)
MSTest unit tests for password hashing and username validation
Project structure
Forms/ — UI (Login, Registration, User site, Admin site, measurement forms)
Logics/ — business logic (AuthService, UserLogic, AdminLogic)
Models/ — data models and database context (User, Meresek, Bead_Database, view/export models)
Tests/ — unit tests for authentication logic
Running the project
Clone the repository.
Requires SQL Server / LocalDB — the connection string in Bead_Database.cs currently points to a local development database and will need to be updated to your own environment.
Open and run with Visual Studio (.NET / Windows Forms).
Status

Course project for a university C# class. Not actively maintained, but feel free to open an issue with suggestions or bugs.
