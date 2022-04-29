#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/LeCong.AbpZeroTemplate.Web.Host/LeCong.AbpZeroTemplate.Web.Host.csproj", "src/LeCong.AbpZeroTemplate.Web.Host/"]
COPY ["src/LeCong.AbpZeroTemplate.Web.Core/LeCong.AbpZeroTemplate.Web.Core.csproj", "src/LeCong.AbpZeroTemplate.Web.Core/"]
COPY ["src/LeCong.AbpZeroTemplate.Application/LeCong.AbpZeroTemplate.Application.csproj", "src/LeCong.AbpZeroTemplate.Application/"]
COPY ["src/LeCong.AbpZeroTemplate.Application.Shared/LeCong.AbpZeroTemplate.Application.Shared.csproj", "src/LeCong.AbpZeroTemplate.Application.Shared/"]
COPY ["src/LeCong.AbpZeroTemplate.Core.Shared/LeCong.AbpZeroTemplate.Core.Shared.csproj", "src/LeCong.AbpZeroTemplate.Core.Shared/"]
COPY ["src/LeCong.AbpZeroTemplate.Core/LeCong.AbpZeroTemplate.Core.csproj", "src/LeCong.AbpZeroTemplate.Core/"]
COPY ["src/LeCong.AbpZeroTemplate.EntityFrameworkCore/LeCong.AbpZeroTemplate.EntityFrameworkCore.csproj", "src/LeCong.AbpZeroTemplate.EntityFrameworkCore/"]
COPY ["src/LeCong.AbpZeroTemplate.GraphQL/LeCong.AbpZeroTemplate.GraphQL.csproj", "src/LeCong.AbpZeroTemplate.GraphQL/"]
RUN dotnet restore "src/LeCong.AbpZeroTemplate.Web.Host/LeCong.AbpZeroTemplate.Web.Host.csproj"
COPY . .
WORKDIR "/src/src/LeCong.AbpZeroTemplate.Web.Host"
RUN dotnet build "LeCong.AbpZeroTemplate.Web.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LeCong.AbpZeroTemplate.Web.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LeCong.AbpZeroTemplate.Web.Host.dll"]
