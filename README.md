Urban Fleet & Maintenance Hub

A relational database design project — modeling a transit agency's fleet operations (vehicles, depots, mechanics, maintenance logs, spare parts, inspections) as a normalized 7-entity schema, with a C# WinForms front-end built on top to demonstrate it working end-to-end.

Database design

The core of this project is the data model: identifying the entities, working out the relationships between them (1:N and M:N), and normalizing the schema before writing a single line of application code.

(ER diagram)

Entities: Vehicle, Depot, Mechanic, Maintenance_Log, Spare_Part, Log_Part, Inspection

Key relationships:
   - A vehicle has many maintenance logs
   - A mechanic is assigned to many logs, and is stationed at one depot
   - A maintenance log uses many spare parts (resolved via the Log_Part junction table)
   - A vehicle is scheduled for many inspections

## Entity diagram

![ER Diagram](er-diagram.png)

The application

To prove the model out, I built a C# WinForms app on top of it — add/update/delete vehicles and mechanics, track and close maintenance logs, and run 6 analytical queries.

Built with
SQL Server (schema design) · C# · WinForms · ADO.NET

How to run it
Install Visual Studio (with the ".NET desktop development" workload) and SQL Server Express
Run schema.sql in SQL Server Management Studio to create the database
Open TransportDB_GUI.sln, restore NuGet packages, hit F5



