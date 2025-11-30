FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
ENV ASPNETCORE_URLS=http://+:8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["src/MarkMobileMechanic.Api/MarkMobileMechanic.Api.csproj", "src/MarkMobileMechanic.Api/"]
COPY ["src/MarkMobileMechanic.Core/MarkMobileMechanic.Core.csproj", "src/MarkMobileMechanic.Core/"]
COPY ["src/MarkMobileMechanic.Infrastructure/MarkMobileMechanic.Infrastructure.csproj", "src/MarkMobileMechanic.Infrastructure/"]
RUN dotnet restore "src/MarkMobileMechanic.Api/MarkMobileMechanic.Api.csproj"
COPY . .
WORKDIR "/src/src/MarkMobileMechanic.Api"
RUN dotnet publish "MarkMobileMechanic.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "MarkMobileMechanic.Api.dll"]
