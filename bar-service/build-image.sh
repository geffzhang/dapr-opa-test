cd src/Example.Bar.Api/
dotnet publish -c Release
cd ../..
docker build -t bar-service:latest .
