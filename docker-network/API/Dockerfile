FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/RestAPI/RestAPI.csproj", "/src/RestAPI/"]
RUN dotnet restore "/src/RestAPI/RestAPI.csproj"
COPY ["src/RestAPI", "RestAPI"]
WORKDIR "/src/RestAPI/"
RUN ls

RUN dotnet build "RestAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RestAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app 
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RestAPI.dll"]
