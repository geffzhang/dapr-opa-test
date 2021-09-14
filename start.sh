cd ./foo-service
./build-image.sh
cd ..

cd ./bar-service
./build-image.sh
cd ..

docker-compose up
