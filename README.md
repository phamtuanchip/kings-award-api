# kings-award-api
# In kings-award-api root folder run bellow commands 
dotnet restore
# install 'Microsoft.EntityFrameworkCore.Design' 2.0 vir cmd or / nuget managers
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet ef migrations add testMigration
dotnet ef database update
