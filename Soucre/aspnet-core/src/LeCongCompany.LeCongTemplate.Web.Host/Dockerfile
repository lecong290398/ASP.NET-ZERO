#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/LeCongCompany.LeCongTemplate.Web.Host/LeCongCompany.LeCongTemplate.Web.Host.csproj", "src/LeCongCompany.LeCongTemplate.Web.Host/"]
COPY ["src/LeCongCompany.LeCongTemplate.Web.Core/LeCongCompany.LeCongTemplate.Web.Core.csproj", "src/LeCongCompany.LeCongTemplate.Web.Core/"]
COPY ["src/LeCongCompany.LeCongTemplate.Application/LeCongCompany.LeCongTemplate.Application.csproj", "src/LeCongCompany.LeCongTemplate.Application/"]
COPY ["src/LeCongCompany.LeCongTemplate.Application.Shared/LeCongCompany.LeCongTemplate.Application.Shared.csproj", "src/LeCongCompany.LeCongTemplate.Application.Shared/"]
COPY ["src/LeCongCompany.LeCongTemplate.Core.Shared/LeCongCompany.LeCongTemplate.Core.Shared.csproj", "src/LeCongCompany.LeCongTemplate.Core.Shared/"]
COPY ["src/LeCongCompany.LeCongTemplate.Core/LeCongCompany.LeCongTemplate.Core.csproj", "src/LeCongCompany.LeCongTemplate.Core/"]
COPY ["src/LeCongCompany.LeCongTemplate.EntityFrameworkCore/LeCongCompany.LeCongTemplate.EntityFrameworkCore.csproj", "src/LeCongCompany.LeCongTemplate.EntityFrameworkCore/"]
COPY ["src/LeCongCompany.LeCongTemplate.GraphQL/LeCongCompany.LeCongTemplate.GraphQL.csproj", "src/LeCongCompany.LeCongTemplate.GraphQL/"]
RUN dotnet restore "src/LeCongCompany.LeCongTemplate.Web.Host/LeCongCompany.LeCongTemplate.Web.Host.csproj"
COPY . .
WORKDIR "/src/src/LeCongCompany.LeCongTemplate.Web.Host"
RUN dotnet build "LeCongCompany.LeCongTemplate.Web.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LeCongCompany.LeCongTemplate.Web.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LeCongCompany.LeCongTemplate.Web.Host.dll"]
