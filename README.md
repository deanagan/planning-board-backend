[![.NET](https://github.com/deanagan/planning-board-backend/actions/workflows/dotnet.yml/badge.svg)](https://github.com/deanagan/planning-board-backend/actions/workflows/dotnet.yml)
[![Docker](https://github.com/deanagan/planning-board-backend/actions/workflows/docker-publish.yml/badge.svg)](https://github.com/deanagan/planning-board-backend/actions/workflows/docker-publish.yml)
# Docker image created with:
docker build --pull -t planningboard .

# Docker run
docker run -d -p 8090:80 --name planningboard planningboard

# Docker stop
docker stop planningboard

# Docker check container in use
docker ps -a

# Docker remove container
docker rm [CONTAINER ID]

# Docker commit
docker commit -m "Add comment here" -a "[full name]" planningboard [docker hub username]/planningboard:latest

# Docker login and push committed image
docker login
docker push [docker hub username]/planningboard:latest

# To run docker compose
`docker-compose up --build`
or
`docker-compose build` followed by `docker-compose up`

# To run sql server as a container (note password may vary)
`docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=1Secure*Password1" -p 14331:1433 -d mcr.microsoft.com/mssql/server:2019-latest`

# EFCore Notes
For tool updates, e.g. _The Entity Framework tools version '3.1.6' is older than that of the runtime '5.0.4'. Update the tools for the latest features and bug fixes._:
    `dotnet tool update --global dotnet-ef`

Sometimes, dotnet-ef isn't in the path. Check here ->  %USERPROFILE%\.dotnet\tools to make sure it is there. Otherwise, add to environment variable -> PATH

Add migration
    `dotnet ef migrations add [migration name] [options]`
    Options can be -o <PATH> and -n <NAMESPACE>

    For this project's initial migration, I did(note this was done from PlanningBoard.Api folder):
    ```
    dotnet ef migrations add Initial -o ./Data/Migrations -n Data.Migrations
    ```
To remove migration:
    `dotnet ef migrations remove`

To apply to database:
    `To do efcore migration, run:
    `dotnet ef database update`

** Note that migrations need to be done where program.cs is.

# Testing Notes
To run tests with verbosity enabled:
`dotnet test -l:"console;verbosity=detailed"`
