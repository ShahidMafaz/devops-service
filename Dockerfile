FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS BUILDIMG
WORKDIR /app
COPY . ./

RUN dotnet restore
RUN dotnet build -c Release
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2
WORKDIR /app
COPY --from=BUILDIMG /app/devops-service/out .
ENTRYPOINT ["dotnet", "devops-service.dll"]