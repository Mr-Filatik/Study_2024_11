# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081


# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Applications/Web/Applications.Web.ApiApp/Applications.Web.ApiApp.csproj", "Applications/Web/Applications.Web.ApiApp/"]
COPY ["Shared/Cache/Shared.Cache.Redis/Shared.Cache.Redis.csproj", "Shared/Cache/Shared.Cache.Redis/"]
COPY ["Shared/Database/Shared.Database.MainDatabase/Shared.Database.MainDatabase.csproj", "Shared/Database/Shared.Database.MainDatabase/"]
COPY ["Shared/Shared.Entities/Shared.Entities.csproj", "Shared/Shared.Entities/"]
COPY ["Applications/Web/Application.Web.Shared/Application.Web.Shared.csproj", "Applications/Web/Application.Web.Shared/"]
RUN dotnet restore "./Applications/Web/Applications.Web.ApiApp/Applications.Web.ApiApp.csproj"
COPY . .
WORKDIR "/src/Applications/Web/Applications.Web.ApiApp"
RUN dotnet build "./Applications.Web.ApiApp.csproj" -c $BUILD_CONFIGURATION -o /app/build

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Applications.Web.ApiApp.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Applications.Web.ApiApp.dll"]