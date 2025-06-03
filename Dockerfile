# Use the official ASP.NET Core runtime image as the base
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 10000
EXPOSE 443

# Use the official .NET SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src

# Copy csproj and restore as distinct layers
COPY ["listOccurrenceCounterAPI.csproj", "./"]
RUN dotnet restore "./listOccurrenceCounterAPI.csproj"

# Copy everything else and build
COPY . .
RUN dotnet build "listOccurrenceCounterAPI.csproj" -c Release -o /app/build

# Publish the app
FROM build AS publish
RUN dotnet publish "listOccurrenceCounterAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Final runtime image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "listOccurrenceCounterAPI.dll"]
