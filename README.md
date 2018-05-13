# kings-award-api
# In kings-award-api root folder run bellow commands 
## dotnet restore
# install 'Microsoft.EntityFrameworkCore.Design' 2.0 vir cmd or / nuget managers
## dotnet add package Microsoft.EntityFrameworkCore.Design
## dotnet ef migrations add testMigration
## dotnet ef database update
# For muntible context need to --context name
## dotnet ef migrations add testMigration --context=KingsAwardDataBase
## dotnet ef database update --context=KingsAwardDataBase
# For kingsaward data
## dotnet ef migrations add kingsawardMigration --context=KingsAwardDataBase
## dotnet ef database update --context=KingsAwardDataBase
# Download this one and install to run app in iis 
## https://go.microsoft.com/fwlink/?linkid=844461