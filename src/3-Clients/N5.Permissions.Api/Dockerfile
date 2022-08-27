FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/3-Clients/N5.Permissions.Api/N5.Permissions.Api.csproj", "src/3-Clients/N5.Permissions.Api/"]
RUN dotnet restore "src/3-Clients/N5.Permissions.Api/N5.Permissions.Api.csproj"
COPY . .
WORKDIR "/src/src/3-Clients/N5.Permissions.Api"
RUN dotnet build "N5.Permissions.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "N5.Permissions.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "N5.Permissions.Api.dll"]