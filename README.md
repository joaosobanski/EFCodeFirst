

# DATABASE DOCKER


docker run  -e ‘ACCEPT_EULA=Y’ -e ‘SA_PASSWORD=1234’ -p 1433:1433 -d mcr.microsoft.com/azure-sql-edge


docker run --cap-add SYS_PTRACE -e 'ACCEPT_EULA=1' -e 'MSSQL_SA_PASSWORD=P@ssw0rd' -p 1433:1433 --name sqledge -d mcr.microsoft.com/azure-sql-edge:latest
