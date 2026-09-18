Urban Fleet & Maintenance Hub

A desktop app (C# WinForms) for managing a vehicle fleet — vehicles, mechanics, maintenance logs, spare parts, and inspections, all backed by a SQL Server database.

I built this as a database systems project, focused on relational schema design (7 entities, proper normalization) with a working front-end on top.

What it does
Add, update, and delete vehicles and mechanics
Track maintenance logs and close them out when work is done
Run 6 analytical queries — like finding the vehicle that needed the most repairs last month, or which mechanic closed the most tasks

## Entity diagram

![ER Diagram](er-diagram.png)

How to run it
Install Visual Studio (with the ".NET desktop development" workload) and SQL Server Express
Run schema.sql in SQL Server Management Studio to create the database
Open TransportDB_GUI.sln, restore NuGet packages, hit F5

Full setup details are in the sections below if you get stuck.

Built with

C# · WinForms · SQL Server · ADO.NET
