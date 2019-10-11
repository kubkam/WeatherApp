# WeatherApp

Web application which is using Web API from [OpenWeatherMap](https://openweathermap.org/). I am using free subscription which contains:
- Current weather
- 5 days every 3 hours forecast
- UV index
- Weather maps
- Weather alerts

This web application is with [ASP.NET Core 2.2](https://dotnet.microsoft.com/download/dotnet-core/2.2 "ASP.NET CORE 2.2") and [EF Core](https://docs.microsoft.com/en-us/ef/core "EF CORE").

**WeatherApp** is still under development.

## Database

To load the database you should go to SQL_scripts folder. You will see 2 SQL script files:
- WeatherApp-createObjects.sql - this file is for creating tables and schemas
- WeatherApp-loadData.sql - this file is for inserting data into tables

### Step 1

Connect to the SQL Server Management Studio by choosing the server name, user name and password.

### Step 2

Add new Database by clicking on Databases folder in Object Explorer. Name new database as WeatherApp. Click Ok to create new database.

### Step 3

From the File menu, choose Open and then File to open sql script. Select the WeatherApp-createObjects.sql and click open. Click Execute option to execute the SQL script.

### Step 4

Repeat step 3 but now choose WeatherApp-loadData.sql file. Click Execute to exectute SQL script.
