# Use the official ASP.NET image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ./backend/ ./backend/
WORKDIR /src/backend
RUN dotnet restore "AuctionAPI.csproj"
RUN dotnet publish "AuctionAPI.csproj" -c Release -o /app/publish

# Final stage
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "AuctionAPI.dll"]
