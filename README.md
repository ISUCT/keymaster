# Keymaster

To run database server simply run `docker-compose up -d` and then you may connect to postgres database via `5432` port and connect via adminer in browser on `http://localhost:8080`

# Database and migrations

## Via Packge Manager

To add migrations use the following command:

```
add-migration -v "InitialMigration" -Context DatabaseContext
```
To update database use the following command:
```
update-database -Context DatabaseContext
```
## Via CLI
To add migrations use the following command:
```
dotnet ef -v --startup-project WebApi/WebApi.csproj migrations add InitialMigration -p Infrastructure/Infrastructure.csproj
```
To update database use the following command:
```
dotnet ef -v --startup-project WebApi/WebApi.csproj database update
```
