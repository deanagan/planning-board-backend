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


# EFCore Notes
For tool updates, e.g. _The Entity Framework tools version '3.1.6' is older than that of the runtime '5.0.4'. Update the tools for the latest features and bug fixes._:
    `dotnet tool update --global dotnet-ef`

Add migration
    `dotnet ef migrations add [migration name] [options]

To remove migration:
    `dotnet ef migrations remove`

To apply to database:
    `To do efcore migration, run:
    `dotnet ef database update`
`
