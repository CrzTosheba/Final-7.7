FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Delivery.Console/Delivery.Console.csproj", "Delivery.Console/"]
RUN dotnet restore "Delivery.Console/Delivery.Console.csproj"
COPY . .
WORKDIR "/src/Delivery.Console"
RUN dotnet build "Delivery.Console.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Delivery.Console.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Delivery.Console.dll"]
