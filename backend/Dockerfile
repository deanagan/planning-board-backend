FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env

WORKDIR /app

COPY *.sln .
COPY Api/*.csproj ./Api/
COPY Api.Tests/*.csproj ./Api.Tests/
RUN dotnet restore

COPY . ./

RUN dotnet publish -c Release -o ./out --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:5.0

WORKDIR /app
COPY --from=build-env app/out ./
RUN ls -la

ENTRYPOINT ["dotnet", "planningboard.dll"]
