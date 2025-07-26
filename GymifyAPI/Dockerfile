# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["GymifyAPI.csproj", "./"]
RUN dotnet restore "GymifyAPI.csproj"
COPY . .
RUN dotnet build "GymifyAPI.csproj" -c Release -o /app/build
RUN dotnet publish "GymifyAPI.csproj" -c Release -o /app/publish

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 80
EXPOSE 443
ENTRYPOINT ["dotnet", "GymifyAPI.dll"]
