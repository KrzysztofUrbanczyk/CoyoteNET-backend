# Coyote.NETCore


How to setup this project:

1. Get [.NET Core 2.2](https://dotnet.microsoft.com/download/dotnet-core/2.2)

2. Setup Database

 1. First approach: 
    * Download & Install [SQL Express](https://www.microsoft.com/pl-pl/sql-server/sql-server-editions-express)

    * change connection string in **appsettings.json** to ``Server=.\\SQLExpress;Database=CoyoteNET;Trusted_Connection=Yes;``

    

  2. Second approach:
  
   * Get docker

   a. [Docker for Windows](https://docs.docker.com/docker-for-windows/install/)

   b. [Docker for Linux](https://docs.docker.com/install/linux/docker-ce/centos/)

   * Follow this guide or just copy/paste from next step: [Guide](https://docs.microsoft.com/en-us/sql/linux/quickstart-install-connect-docker?view=sql-server-2017)

	* Bash:

	sudo docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=<YourStrong!Passw0rd>' \
	-p 1433:1433 --name sql1 \
	-d mcr.microsoft.com/mssql/server:2017-latest

	* Powershell

	docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=<YourStrong!Passw0rd>" `
	-p 1433:1433 --name sql1 `
	-d mcr.microsoft.com/mssql/server:2017-latest

    * change connection string in **appsettings.json** to ``Server=localhost,1433;Database=CoyoteNET;User Id=sa;Password=<YourStrong!Passw0rd>``

3 type ``dotnet run`` inside ``Runner`` folder.
