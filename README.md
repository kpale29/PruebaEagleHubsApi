# PruebaEagleHubsApi
Resolucion de prueba tecnica Eagle Hubs - Kevin Palencia Gil

## Tecnologias

* ASP.NET Core 7
* Entity Framework Core 7
* PostgreSql
* XUnit

## Instalación y ejecucion del proyecto

1. Instalar la ultima versino de .NET 7 SDK.
2. Ejecutar comando de instalacion de dependencias. 
    ```bash
        dotnet restore
    ``` 
3. Instalar una base de datos local Postgresql.
4. Instalar herramienta de CLI de .Net Core.

    ```bash
        dotnet tool install --global dotnet-ef
    ``` 
5. Agregar string de conexion en appSettings.json con el siguiente formato: 
    ```json
        {
        "ConnectionStrings": {
            "EagleHubsDatabase": "server=localhost;database=Consumption_DB;uid=postgres;pwd=1234"
        },
    ```
6. Ejecutar comando de migration entity framework desde la carpeta raiz del proyecto.
    ```bash
        dotnet ef database update 
        o 
        dotnet-ef database update
    ``` 




