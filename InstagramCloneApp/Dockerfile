FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["InstagramCloneApp/InstagramCloneApp.csproj", "InstagramCloneApp/"]
RUN dotnet restore "InstagramCloneApp/InstagramCloneApp.csproj"
COPY . .
WORKDIR "/src/InstagramCloneApp"
RUN dotnet build "InstagramCloneApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "InstagramCloneApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "InstagramCloneApp.dll"]