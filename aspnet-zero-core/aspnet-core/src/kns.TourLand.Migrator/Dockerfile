#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/kns.TourLand.Migrator/kns.TourLand.Migrator.csproj", "src/kns.TourLand.Migrator/"]
COPY ["src/kns.TourLand.EntityFrameworkCore/kns.TourLand.EntityFrameworkCore.csproj", "src/kns.TourLand.EntityFrameworkCore/"]
COPY ["src/kns.TourLand.Core/kns.TourLand.Core.csproj", "src/kns.TourLand.Core/"]
COPY ["src/kns.TourLand.Core.Shared/kns.TourLand.Core.Shared.csproj", "src/kns.TourLand.Core.Shared/"]
RUN dotnet restore "src/kns.TourLand.Migrator/kns.TourLand.Migrator.csproj"
COPY . .
WORKDIR "/src/src/kns.TourLand.Migrator"
RUN dotnet build "kns.TourLand.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "kns.TourLand.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "kns.TourLand.Migrator.dll"]
