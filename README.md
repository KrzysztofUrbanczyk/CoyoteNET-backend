# Coyote.NETCore

An implementation of Coyote forum engine in .NET Core 

## Getting started

### Prerequisites

* [.NET Core 2.2](https://dotnet.microsoft.com/download/dotnet-core/2.2)

### Installing

#### Setup Database

1. First approach (using SQL Express): 

	* Download & Install [SQL Express](https://www.microsoft.com/pl-pl/sql-server/sql-server-editions-express)

    * change connection string in **appsettings.json** to ``Server=.\\SQLExpress;Database=CoyoteNET;Trusted_Connection=Yes;``

2. Second approach (using MSSQL Docker image):
  
    * Get docker

        - [Docker for Windows](https://docs.docker.com/docker-for-windows/install/)

        - [Docker for Linux](https://docs.docker.com/install/linux/docker-ce/centos/)

    * Follow this [guide](https://docs.microsoft.com/en-us/sql/linux/quickstart-install-connect-docker?view=sql-server-2017) or just copy/paste from next step: 

    * Bash:

        ```bash
        sudo docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=<YourStrong!Passw0rd>' \
        -p 1433:1433 --name sql1 \
        -d mcr.microsoft.com/mssql/server:2017-latest
        ```

    * Powershell

        ```powershell
        docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=<YourStrong!Passw0rd>" `
        -p 1433:1433 --name sql1 `
        -d mcr.microsoft.com/mssql/server:2017-latest
        ```

#### Settings update

Change connection string in [appsettings.json](https://github.com/dotNETSanta/Coyote.NETCore/blob/master/Runner/appsettings.json) to:

```string
Server=localhost,1433;Database=CoyoteNET;User Id=sa;Password=<YourStrong!Passw0rd>
```

#### Make it run

Go into `Runner` folder and use below command to run project

```bash
dotnet run
```

## Links

- 💬 Chat: [Slack](https://join.slack.com/t/coyotenetcore/shared_invite/enQtNTg3NDQ5NzA5OTcyLTNlYWU1YmY1Yjg0Yzc2MDFjMzU3NTZkNjIzNDdkODE1NGE5NTQwZDA4Y2UyMWRkOWMyZGJkYmIzZTlkYjA5OWE)

## Built With

* [ASP.NET Core 2.2](https://docs.microsoft.com/pl-pl/aspnet/core/?view=aspnetcore-2.2) - The web framework used
* [EntityFrameworkCore](https://github.com/aspnet/EntityFrameworkCore) - ORM

## Contributors

Thank you to all our [contributors](https://github.com/dotNETSanta/Coyote.NETCore/graphs/contributors)!
