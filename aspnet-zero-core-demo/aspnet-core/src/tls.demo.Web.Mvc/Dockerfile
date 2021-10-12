#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/tls.demo.Web.Mvc/tls.demo.Web.Mvc.csproj", "src/tls.demo.Web.Mvc/"]
COPY ["src/tls.demo.Web.Core/tls.demo.Web.Core.csproj", "src/tls.demo.Web.Core/"]
COPY ["src/tls.demo.Application/tls.demo.Application.csproj", "src/tls.demo.Application/"]
COPY ["src/tls.demo.Application.Shared/tls.demo.Application.Shared.csproj", "src/tls.demo.Application.Shared/"]
COPY ["src/tls.demo.Core.Shared/tls.demo.Core.Shared.csproj", "src/tls.demo.Core.Shared/"]
COPY ["src/tls.demo.Core/tls.demo.Core.csproj", "src/tls.demo.Core/"]
COPY ["src/tls.demo.EntityFrameworkCore/tls.demo.EntityFrameworkCore.csproj", "src/tls.demo.EntityFrameworkCore/"]
COPY ["src/tls.demo.GraphQL/tls.demo.GraphQL.csproj", "src/tls.demo.GraphQL/"]
RUN dotnet restore "src/tls.demo.Web.Mvc/tls.demo.Web.Mvc.csproj"
COPY . .
WORKDIR "/src/src/tls.demo.Web.Mvc"
RUN dotnet build "tls.demo.Web.Mvc.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "tls.demo.Web.Mvc.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "tls.demo.Web.Mvc.dll"]
