FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base

WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

COPY ["Imoveis-Api/Imoveis-Api.csproj", "Imoveis-Api/"]
COPY ["Domain/Domain.csproj", "Domain/"]
COPY ["CrossCutting/CrossCutting.csproj", "CrossCutting/"]
COPY ["Infra.Data/Infra.Data.csproj", "Infra.Data/"]
COPY ["Services/Services.csproj", "Services/"]
RUN dotnet restore "Imoveis-Api/Imoveis-Api.csproj"
COPY . .
WORKDIR "/src/Imoveis-Api/"
RUN dotnet build "Imoveis-Api.csproj" -c Release -o /app/build


FROM build AS publish
RUN dotnet publish "Imoveis-Api.csproj" -c Release -o /app/publish
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Imoveis-Api.dll"]