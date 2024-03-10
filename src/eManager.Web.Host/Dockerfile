FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/eManager.Web.Host/eManager.Web.Host.csproj", "src/eManager.Web.Host/"]
COPY ["src/eManager.Web.Core/eManager.Web.Core.csproj", "src/eManager.Web.Core/"]
COPY ["src/eManager.Application/eManager.Application.csproj", "src/eManager.Application/"]
COPY ["src/eManager.Core/eManager.Core.csproj", "src/eManager.Core/"]
COPY ["src/eManager.EntityFrameworkCore/eManager.EntityFrameworkCore.csproj", "src/eManager.EntityFrameworkCore/"]
WORKDIR "/src/src/eManager.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/eManager.Web.Host", "src/eManager.Web.Host"]
COPY ["src/eManager.Web.Core", "src/eManager.Web.Core"]
COPY ["src/eManager.Application", "src/eManager.Application"]
COPY ["src/eManager.Core", "src/eManager.Core"]
COPY ["src/eManager.EntityFrameworkCore", "src/eManager.EntityFrameworkCore"]
WORKDIR "/src/src/eManager.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "eManager.Web.Host.dll"]
