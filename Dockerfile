FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS deploy

COPY /app/publish ./app
WORKDIR "/app"
ENTRYPOINT ["dotnet", "./PerformanceDifferences.dll"]