Consulta de dados de Cliente

How to

1 - dotnet publish -c Release
2 - docker build -t client-data-service .
3 - docker volume create client-data-dbvolume
4 - docker run --name client-data-database -e MYSQL_ROOT_PASSWORD=root*123!@# -e MYSQL_DATABASE=ClientDb -e MYSQL_USER=client-user-dev -e MYSQL_PASSWORD=client-data123!@# -v client-data-dbvolume:/var/lib/mysql -p 33060:33060 -d mysql/mysql-server:5.7
5 - docker run -d -p 8000:80 --name client-data-service --link client-data-database -it client-data-service
6 - run scripts
