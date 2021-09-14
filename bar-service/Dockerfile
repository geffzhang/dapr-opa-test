FROM mcr.microsoft.com/dotnet/aspnet:5.0-focal
COPY ./src/Example.Bar.Api/bin/Release/net5.0/publish/ /app/
WORKDIR /app/
ENTRYPOINT ["dotnet", "Example.Bar.Api.dll"]
