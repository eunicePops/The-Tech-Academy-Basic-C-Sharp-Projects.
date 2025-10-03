# C# Projects

Listed below are some of the projects I made with C# and .NET Framework

## Projects: 

* [Car Insurance](https://github.com/eunicePops/CarInsuranceASP.NET-MVC-FRAMEWORK-)
* [Server Time App](https://github.com/eunicePops/ServerTimeApp)
* [CodeFirstDemo](http://github.com/eunicePops/CodeFirstDemo)
* [ShippingQuote](https://github.com/eunicePops/ShippingQuote)

### Car Insurance 

The Car Insurance web application is an ASP.NET MVC project designed to manage user insurance data and calculate insurance quotes automatically. The application uses Entity Framework to interact with a SQL database (Insurance.mdf) that stores customer information such as name, age, car details, and driving history.

The project follows the MVC architecture:

Models define the data structure (Insuree class).

Controllers (like InsureeController) contain the logic for handling user input and performing operations such as calculating quotes.

Views provide user interfaces for creating, editing, viewing, and deleting records.

A key feature of the application is the Quote Calculator, which determines an insurance quote based on user inputs. The application also supports features like a Quote Summary view, where administrators can view total, highest, lowest, and average quotes.

This project demonstrates the use of:

ASP.NET MVC for structured web development.

Entity Framework (Database-First or Code-First) for database access.

Razor views for dynamic rendering.

Basic CRUD operations (Create, Read, Update, Delete).

### Server Time App
The Server Time web application is a simple ASP.NET Core MVC project that displays the current server time in the browser. It uses a controller (HomeController) to fetch the system’s DateTime.Now value and passes it to a Razor view (Index.cshtml) for display. The element in the view is customized with user-defined text, making the app both functional and personalized. This project demonstrates the basics of ASP.NET Core MVC, including controllers, views, Razor syntax, and dynamic data rendering.

### Code First Demo App
The Code-First demo is a simple console application that demonstrates how to create a database using Entity Framework Code-First. In this approach, the database is generated from C# classes rather than designing the database first. The demo defines a Student class to represent the data model and a SchoolContext class to manage the database connection. When the application runs, Entity Framework automatically creates a database called SchoolDB, generates a Students table, and inserts a sample student record. This shows how developers can start with code, and let Entity Framework build and manage the database structure.

### Shipping Quote 
The Shipping Quote app is a simple MVC application that calculates shipping costs based on user input such as package weight, dimensions, and destination. The application uses controllers to handle the logic, models to represent the data, and views to display results to the user. It demonstrates how MVC architecture can be used to process user input, apply business rules, and return a dynamically calculated shipping quote.
