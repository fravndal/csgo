## Counter-Strike Global Offensive Backend

This application is created in C# .net core. 

## Installation
1.  Move `CSGO Weapon Dataset.csv` to `import/Data/` and set property `Copy to Output Directory` to `Copy if newer`

2.  Create a migration from Persistence: 
`dotnet ef migrations add initialcreate`

3.  Update migration:
`dotnet ef database update`