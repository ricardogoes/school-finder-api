FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src

COPY *.sln .
COPY src/SchoolFinder.Api/*.csproj ./src/SchoolFinder.Api/
COPY src/SchoolFinder.Application/*.csproj ./src/SchoolFinder.Application/
COPY src/SchoolFinder.Domain/*.csproj ./src/SchoolFinder.Domain/
COPY src/SchoolFinder.Infra.Data.Dapper/*.csproj ./src/SchoolFinder.Infra.Data.Dapper/
COPY src/SchoolFinder.Infra.Messaging/*.csproj ./src/SchoolFinder.Infra.Messaging/
COPY tests/SchoolFinder.UnitTests/*.csproj ./tests/SchoolFinder.UnitTests/
COPY tests/SchoolFinder.EndToEndTests/*.csproj ./tests/SchoolFinder.EndToEndTests/

RUN dotnet restore

# copy everything else and build app
COPY src/SchoolFinder.Api/. ./src/SchoolFinder.Api/
COPY src/SchoolFinder.Application/. ./src/SchoolFinder.Application/
COPY src/SchoolFinder.Domain/. ./src/SchoolFinder.Domain/
COPY src/SchoolFinder.Infra.Data.Dapper/. ./src/SchoolFinder.Infra.Data.Dapper/ 
COPY src/SchoolFinder.Infra.Messaging/. ./src/SchoolFinder.Infra.Messaging/ 

#WORKDIR "/src/SchoolFinder.Api"
RUN dotnet build "./src/SchoolFinder.Api/SchoolFinder.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "./src/SchoolFinder.Api/SchoolFinder.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SchoolFinder.Api.dll"]