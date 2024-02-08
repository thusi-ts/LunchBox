# Sheetcheet
In Package Manager Console You have to select "LunchBox.Shared" as default project when you migrate this

Only 2 steps:
add-migration "Init text"
update-database

If you want to verify sql before update databse.
dotnet ef migrations script --output migrate.sql