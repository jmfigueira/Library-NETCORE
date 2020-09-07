# Library-NETCORE
- Projeto para apresentações (DDD).
- Git WorkFlow (Actions).

# WebApi - .NET CORE 3.0;

Steps:
  - Run Build;
  - Run Tests;
  - Run Migration.
    - dotnet tool install --global dotnet-ef
    - dotnet ef migrations add InitialCreate
    - dotnet ef database update
  - Start API;
