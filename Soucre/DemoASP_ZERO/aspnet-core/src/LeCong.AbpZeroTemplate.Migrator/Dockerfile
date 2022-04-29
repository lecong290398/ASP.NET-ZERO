#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/LeCong.AbpZeroTemplate.Migrator/LeCong.AbpZeroTemplate.Migrator.csproj", "src/LeCong.AbpZeroTemplate.Migrator/"]
COPY ["src/LeCong.AbpZeroTemplate.EntityFrameworkCore/LeCong.AbpZeroTemplate.EntityFrameworkCore.csproj", "src/LeCong.AbpZeroTemplate.EntityFrameworkCore/"]
COPY ["src/LeCong.AbpZeroTemplate.Core/LeCong.AbpZeroTemplate.Core.csproj", "src/LeCong.AbpZeroTemplate.Core/"]
COPY ["src/LeCong.AbpZeroTemplate.Core.Shared/LeCong.AbpZeroTemplate.Core.Shared.csproj", "src/LeCong.AbpZeroTemplate.Core.Shared/"]
RUN dotnet restore "src/LeCong.AbpZeroTemplate.Migrator/LeCong.AbpZeroTemplate.Migrator.csproj"
COPY . .
WORKDIR "/src/src/LeCong.AbpZeroTemplate.Migrator"
RUN dotnet build "LeCong.AbpZeroTemplate.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LeCong.AbpZeroTemplate.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LeCong.AbpZeroTemplate.Migrator.dll", "-s"]
