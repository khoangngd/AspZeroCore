#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/tls.demo.Migrator/tls.demo.Migrator.csproj", "src/tls.demo.Migrator/"]
COPY ["src/tls.demo.EntityFrameworkCore/tls.demo.EntityFrameworkCore.csproj", "src/tls.demo.EntityFrameworkCore/"]
COPY ["src/tls.demo.Core/tls.demo.Core.csproj", "src/tls.demo.Core/"]
COPY ["src/tls.demo.Core.Shared/tls.demo.Core.Shared.csproj", "src/tls.demo.Core.Shared/"]
RUN dotnet restore "src/tls.demo.Migrator/tls.demo.Migrator.csproj"
COPY . .
WORKDIR "/src/src/tls.demo.Migrator"
RUN dotnet build "tls.demo.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "tls.demo.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "tls.demo.Migrator.dll"]
