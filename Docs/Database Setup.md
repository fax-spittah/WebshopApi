## Database Setup

### Installation of Entity Framework (EF)

First, install `Entity Framework (EF)` using the following commands:

```bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design

dotnet tool install --global dotnet-ef   # EF CLI tool
```

Verify the installation by running:

```bash
dotnet-ef
```

---

### Database Provider Installation

Install the appropriate EF Core provider for your database:

- **MySQL**:

```
dotnet add package Pomelo.EntityFrameworkCore.MySql
```

- **SQL Server**

```
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```

---

### Establishing the connection

Configure the connection to your database by updating the connection string in `appsettings.Development.json` with your database credentials.

---

### Migrations

To create migrations based on your `DbContext`, use:

```
dotnet ef migrations add <MigrationName>
```

This generates migration files (tables, columns, constraints, etc.) and stores them in the `/Migrations` directory.

To apply the migrations and create the database schema, run:

```
dotnet ef database update
```

---

### Seeding the DB (optional)

To optionally seed the database with initial data, an initialization script has been provided:
[Initialization script](./DatabaseInitializationScript.sql).

- **Note:** Running this script is optional. It will populate the database with sample users, products, categories, and their relationships.
  This does not affect migrations or EF Core functionality.
