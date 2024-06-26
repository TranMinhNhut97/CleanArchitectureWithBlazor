#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.
# build stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["CoffeeShop.BlazorServerWebApplication/CoffeeShop.BlazorServerWebApplication.csproj", "CoffeeShop.BlazorServerWebApplication/"]
COPY ["CoffeeShop.Infrastructure/CoffeeShop.Infrastructure.csproj", "CoffeeShop.Infrastructure/"]
COPY ["CoffeeShop.Application/CoffeeShop.Application.csproj", "CoffeeShop.Application/"]
COPY ["CoffeeShop.Domain/CoffeeShop.Domain.csproj", "CoffeeShop.Domain/"]
RUN dotnet restore "./CoffeeShop.BlazorServerWebApplication/./CoffeeShop.BlazorServerWebApplication.csproj"
COPY . .
WORKDIR "/src/CoffeeShop.BlazorServerWebApplication"
RUN dotnet build "./CoffeeShop.BlazorServerWebApplication.csproj" -c $BUILD_CONFIGURATION -o /app/build

#publish out artifact to our directory
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./CoffeeShop.BlazorServerWebApplication.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CoffeeShop.BlazorServerWebApplication.dll"]