#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/kns.TourLand.Web.Mvc/kns.TourLand.Web.Mvc.csproj", "src/kns.TourLand.Web.Mvc/"]
COPY ["src/kns.TourLand.Web.Core/kns.TourLand.Web.Core.csproj", "src/kns.TourLand.Web.Core/"]
COPY ["src/kns.TourLand.Application/kns.TourLand.Application.csproj", "src/kns.TourLand.Application/"]
COPY ["src/kns.TourLand.Application.Shared/kns.TourLand.Application.Shared.csproj", "src/kns.TourLand.Application.Shared/"]
COPY ["src/kns.TourLand.Core.Shared/kns.TourLand.Core.Shared.csproj", "src/kns.TourLand.Core.Shared/"]
COPY ["src/kns.TourLand.Core/kns.TourLand.Core.csproj", "src/kns.TourLand.Core/"]
COPY ["src/kns.TourLand.EntityFrameworkCore/kns.TourLand.EntityFrameworkCore.csproj", "src/kns.TourLand.EntityFrameworkCore/"]
COPY ["src/kns.TourLand.GraphQL/kns.TourLand.GraphQL.csproj", "src/kns.TourLand.GraphQL/"]
RUN dotnet restore "src/kns.TourLand.Web.Mvc/kns.TourLand.Web.Mvc.csproj"
COPY . .
WORKDIR "/src/src/kns.TourLand.Web.Mvc"
RUN dotnet build "kns.TourLand.Web.Mvc.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "kns.TourLand.Web.Mvc.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "kns.TourLand.Web.Mvc.dll"]
