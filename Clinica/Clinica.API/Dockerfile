#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Clinica.API/Clinica.API.csproj", "Clinica.API/"]
COPY ["Clinica.Infra.IoC/Clinica.Infra.IoC.csproj", "Clinica.Infra.IoC/"]
COPY ["Clinica.Domain/Clinica.Domain/Clinica.Domain.csproj", "Clinica.Domain/Clinica.Domain/"]
COPY ["Clinica.AppService/Clinica.AppService.csproj", "Clinica.AppService/"]
COPY ["Clinica.Infra/Clinica.Infra.csproj", "Clinica.Infra/"]
RUN dotnet restore "Clinica.API/Clinica.API.csproj"
COPY . .
WORKDIR "/src/Clinica.API"
RUN dotnet build "Clinica.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Clinica.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Clinica.API.dll"]