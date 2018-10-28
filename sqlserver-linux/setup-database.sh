echo 'Please wait while SQL Server 2017 warms up'
sleep 10s

echo 'Initializing database after 10 seconds of wait'
/opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P mordi1234567! -d master -i init_db.sql

echo 'Finished initializing the database'