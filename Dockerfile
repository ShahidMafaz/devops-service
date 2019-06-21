FROM microsoft/aspnetcore-build AS BUILD
WORKDIR /app
COPY . ./

RUN dotnet restore
RUN dotnet build -c Release
RUN dotnet publish -c Release -o out

FROM microsoft/aspnetcore
WORKDIR /app
COPY --from=BUILD /app/out .
ENTRYPOINT ["dotnet", "devops-service.dll"]