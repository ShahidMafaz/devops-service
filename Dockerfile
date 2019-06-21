FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS BUILD
WORKDIR /app
COPY . ./

RUN dotnet restore
RUN dotnet build -c Release
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2
WORKDIR /app
COPY --from=BUILD /app/out .
ENTRYPOINT ["dotnet", "devops-service.dll"]