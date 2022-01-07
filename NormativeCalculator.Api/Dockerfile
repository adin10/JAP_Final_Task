#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["NormativeCalculator.Api/NormativeCalculator.Api.csproj", "NormativeCalculator.Api/"]
COPY ["NormativeCalculator.Common/NormativeCalculator.Common.csproj", "NormativeCalculator.Common/"]
COPY ["NormativeCalculator.Infrastructure/NormativeCalculator.Infrastructure.csproj", "NormativeCalculator.Infrastructure/"]
COPY ["NormativeCalculator.Database/NormativeCalculator.Database.csproj", "NormativeCalculator.Database/"]
COPY ["NormativeCalculator.Core/NormativeCalculator.Core.csproj", "NormativeCalculator.Core/"]
COPY ["NormativeCalculator.Logger/NormativeCalculator.Logger.csproj", "NormativeCalculator.Logger/"]
COPY ["NormativeCalculator.Mapper/NormativeCalculator.Mapper.csproj", "NormativeCalculator.Mapper/"]
RUN dotnet restore "NormativeCalculator.Api/NormativeCalculator.Api.csproj"
COPY . .
WORKDIR "/src/NormativeCalculator.Api"
RUN dotnet build "NormativeCalculator.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NormativeCalculator.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NormativeCalculator.Api.dll"]
