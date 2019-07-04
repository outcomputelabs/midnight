FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["test/Midnight.Testing.WebApp/Midnight.Testing.WebApp.csproj", "test/Midnight.Testing.WebApp/"]
RUN dotnet restore "test/Midnight.Testing.WebApp/Midnight.Testing.WebApp.csproj"
COPY . .
WORKDIR "/src/test/Midnight.Testing.WebApp"
RUN dotnet build "Midnight.Testing.WebApp.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Midnight.Testing.WebApp.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Midnight.Testing.WebApp.dll"]