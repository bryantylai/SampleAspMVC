# SampleAspMVC
Sample ASP.NET Web MVC for MSPBootcamp2016

# Required Tools
[1] Download SQL Server Compact from https://visualstudiogallery.msdn.microsoft.com/0e313dfd-be80-4afb-b5e9-6e74d369f7a1

[2] Download EntityFramework.SqlServerCompact from Nuget Package (Right click on reference then click on Manage Nuget Packages)

# Deploy to Azure
1) Create a WebApp in Azure
2) Download the publish settings
3) Import it to your project when publishing from Visual Studio

# Creating a database file
1) Open up Sql Server Compact tool
2) Right click on Data Connections and add a new Server Compact connection to App_Data folder
3) Include the .sdf which was generated to your Visual Studio project
4) Right click on Models folder and Add a new ADO.NET Entity Model
5) Select EF Designer from database or Code First from database
6) Follow the steps in the Entity Data Model Wizard to generate the class files required

## Make sure to tick 'Exclude files from the App_Data folder' when publishing your web app to azure after you've done it the first time.

The rests are codes which you can refer to the projects.

If you have any enquiries regarding the issues faced in these projects or if you want to know the conventional way of creating a Sql Server separately, you can contact me at:
Email: blty_2312@hotmail.my
Facebook Name: Bryan Lai 
Facebook Id: bryantylai