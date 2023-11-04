# .NET Core - Base API

**Goal**<br>
To have an extendable controller-based api as starting point to scaffold your own projects.
I'm going to keep the data fields to a minimum so that it's easier to seed data.
At the same time, I want to demonstrate some important annotations required for EF Core to work with complex data relations. <br>
See `Notes` folder for specific how-to's.
Also see my field-notes repository.

## Features

-   Controller-based API
-   PostgreSQL
-   Error Handling
-   Authentication

## Domain Models

## Work Flow

We want to take advantage of `EF Core`'s well designed ORM and its LINQ queries.
To do that we will focus on defining our Entity Models and utlize `EF Core`'s auto migrations.
The work flow is as follows:

1. Define Entity models
2. Run `EF Core` migrations and scaffold controller
3. Refactor scaffolded code into a Repository / Unit of Work pattern

Major Packages

```
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
```

Code Generator and EF Core

```
dotnet tool uninstall -g dotnet-ef
dotnet tool install -g dotnet-ef
dotnet tool uninstall -g dotnet-aspent-codegenerator
dotnet tool install -g dotnet-aspent-codegenerator
```

## Running the project
