# /Dockerfile.integration

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
COPY . /app
WORKDIR /app/PlanningBoard.Api
RUN dotnet restore


# ENTRYPOINT ["dotnet", "PlanningBoard.Api.dll"]