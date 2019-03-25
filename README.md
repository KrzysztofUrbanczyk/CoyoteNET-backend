# Coyote.NETCore


[MSSQL(temporary?) @ Docker installation guide](https://docs.microsoft.com/en-us/sql/linux/quickstart-install-connect-docker?view=sql-server-2017)

	sudo docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=<YourStrong!Passw0rd>' \
	   -p 1433:1433 --name sql1 \
	   -d mcr.microsoft.com/mssql/server:2017-latest