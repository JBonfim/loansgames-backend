#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /src






FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build

# copy csproj and restore as distinct layers
COPY Api.Application/application.csproj Api.Application/
RUN dotnet restore Api.Application/application.csproj
COPY . .
WORKDIR /Api.Application
RUN dotnet publish application.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish application.csproj -c Release -o /app

FROM base AS final
WORKDIR /app

COPY --from=publish /app .

EXPOSE 80
ENTRYPOINT ["dotnet", "application.dll"]

