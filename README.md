# Coffee Shop App

Coffee Shop is an e-commerce implemented using .NET Core. It features a REST api with CRUD operations on products. This application is modelled by principles of clean architecture. 
Communication between presentational layer and application layer is done through mediatR (CQRS pattern). 

To run the Coffee Shop App locally, follow these steps:

### `git clone`

Clone the repository to your local machine. 

### `Run the project in Visual Studio`

Open the AmdarisBackend.sln file and "Compile and Run".

### `Connect to database`

Porvide a connection string in ECommerceDbContext.cs to your SQL Server and run the migrations in order to create a database. 

Runs the server in the development mode.\
Open ['https://localhost:44320/api']('https://localhost:44320/api') to view it in the browser and make requests. For example: ['https://localhost:44320/api/products/](https://localhost:44320/api/products/) 

## Technologies on backend
* C# with .NET
* Entity Framework
* MediatR
* SQL Server
