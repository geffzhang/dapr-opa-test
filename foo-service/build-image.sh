cd src/Example.Foo.Api/
dotnet publish -c Release
cd ../..
docker build -t foo-service:latest .
