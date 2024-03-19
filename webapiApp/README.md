# API .NET 6.0 C#

swagger:
```
https://localhost:7196/swagger
```
verificar herramientas instaladas y sus versiones
```
dotnet tool list --global
```

## instalar Entity Framework Core para 6.0

verificar version de Entity Framework Core:
```
dotnet ef --version
```
instalar:
```
dotnet tool install dotnet-ef --global --version 6.0.0
```
agregar referencia al paquete de NuGet y ver lista de paquetes NuGet instalados en el proyecto:
```
dotnet add package Microsoft.EntityFrameworkCore --version 6.0.0
dotnet list package
```
agregar una referencia al paquete NuGet para SqlServer o MySql
```
SqlServer:
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 6.0.0

MySql:
dotnet add package MySql.EntityFrameworkCore --version 6.0.0
dotnet add package Pomelo.EntityFrameworkCore.MySql --version 6.0.0
```
## CORS
agregar una referencia al paquete NuGet para CORS
```
dotnet add package Microsoft.AspNetCore.Cors
```