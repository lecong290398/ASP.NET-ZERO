#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/LeCongCompany.LeCongTemplate.Migrator/LeCongCompany.LeCongTemplate.Migrator.csproj", "src/LeCongCompany.LeCongTemplate.Migrator/"]
COPY ["src/LeCongCompany.LeCongTemplate.EntityFrameworkCore/LeCongCompany.LeCongTemplate.EntityFrameworkCore.csproj", "src/LeCongCompany.LeCongTemplate.EntityFrameworkCore/"]
COPY ["src/LeCongCompany.LeCongTemplate.Core/LeCongCompany.LeCongTemplate.Core.csproj", "src/LeCongCompany.LeCongTemplate.Core/"]
COPY ["src/LeCongCompany.LeCongTemplate.Core.Shared/LeCongCompany.LeCongTemplate.Core.Shared.csproj", "src/LeCongCompany.LeCongTemplate.Core.Shared/"]
RUN dotnet restore "src/LeCongCompany.LeCongTemplate.Migrator/LeCongCompany.LeCongTemplate.Migrator.csproj"
COPY . .
WORKDIR "/src/src/LeCongCompany.LeCongTemplate.Migrator"
RUN dotnet build "LeCongCompany.LeCongTemplate.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LeCongCompany.LeCongTemplate.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LeCongCompany.LeCongTemplate.Migrator.dll", "-s"]
