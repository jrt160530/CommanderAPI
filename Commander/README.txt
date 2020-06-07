REST API using .NET Core 3.1. Some patterns applied for this project include MVC, Repository, Dependency Injection, Entity Framework, Data Transfer Objects and AutoMapper. 

The application is used to Create, Read, Update, and Delete data resources which hold information on command line operations. 
For example, "dotnet run" would be entered into the terminal to build and run a dotnet project. More information in the project and see the video for a more descriptive explanation.
------------------------------------------------------------------------------------------------------------------------------------------
Followed tutorial here: https://www.youtube.com/watch?v=fmvcAzHpsk8

In the appsettings.json replace <ServerName> with the name of your SQL database server, replace <Username> and <password> with the login information for your SQL server. 

Also, in Startup.cs there is a line of code specific to Microsoft SQL Server. This will be dependent on what SQL Server you are using. 
------------------------------------------------------------------------------------------------------------------------------------------

There is some redundant code in the project. For example, the MockCommanderRepo.cs was a class used to help set the project up initial and test some operations before we included the SQL database. I believe that is the only class not being used, but there are some lines and comments that were part of that build up process. Since this was a learning project, they are being left in the source code. 

------------------------------------------------------------------------------------------------------------------------------------------
JSON_sample.txt has two example JSON objects that were used to test throughout the project. 
I used in conjunction with POSTMAN application which worked well to test the API. 