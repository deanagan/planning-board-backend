FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build

WORKDIR /src
COPY ["Api/planningboard.csproj", "./Api/"]
COPY ["Setup.sh", "./Api/"]

RUN dotnet tool install --global dotnet-ef

RUN dotnet restore "Api/planningboard.csproj"
COPY . .
WORKDIR "/src/Api/"

RUN /root/.dotnet/tools/dotnet-ef migrations add InitialMigrations


RUN chmod +x ./Setup.sh
CMD /bin/bash ./Setup.sh