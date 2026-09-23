## Создание базы данных
> docker run --name wh-database   -e POSTGRES_DB=mydb   -e POSTGRES_USER=postgres   -e POSTGRES_PASSWORD=mysecretpassword   -p 5432:5432   -d postgres