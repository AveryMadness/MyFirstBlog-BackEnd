## Getting Started

### PSQL

First, we're going to install Postgres. This will be the database that the app uses to store data. [Here is the link to instructions on installing postgres](https://www.postgresql.org/download/). Choose the operating system of your computer. 

#### Installation

* If you are using mac, I would suggest using [homebrew](https://brew.sh/).
	* If homebrew is not installed, on the command line run
		``/bin/bash -c "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/HEAD/install.sh)"``
	* Once homebrew is installed, run
		``brew install postgresql@14``
	* After postgresql@14 has been installed, start the server with 
		``brew services start postgresql``
* If you are using windows, download the installer that matches your computer's system [from here](https://www.enterprisedb.com/downloads/postgres-postgresql-downloads). If using Windows x86-32, version 10.23 should work for you for this project.
	* Once you've installed postgres, [start the postgres server](https://www.commandprompt.com/education/how-to-start-stop-or-restart-the-postgresql-server/)

#### DB setup

* To test that postgres was installed correctly and is running, run
	``createdb bvc-blog``
	This creates a database named bvc-blog which we will use for this application. 
* Then run ``psql bvc-blog`` to start the psql command line tool
* We will create a superuser for the application to use to interact with the database. Run the following to create a user called 'postgres' with a password of 'postgres'.
	``CREATE ROLE postgres SUPERUSER LOGIN PASSWORD 'postgres';``
* Verify that the postgres user exists with `\du`.

If you would like to use a different postgres user, you can update the appsettings.Development.json file with the username and password of the user.

### Dotnet

You need to install dotnet 7. You can download the installer [from the dotnet.microsoft page](https://dotnet.microsoft.com/en-us/download).

### Project Setup

1. Once the download is finished, restart your terminal and go to the project's directory. We're going to traverse down one level into the MyFirstBlog directory:
``cd MyFirstBlog``

2. Set up an SSL certificate by running:
``dotnet dev-certs https --trust`` 

3. And finally, start the backend server:
``dotnet run``

You can now interact with the server through your browser. Try navigating to [http://localhost:5000/swagger/index.html](http://localhost:5000/swagger/index.html).
This is an interface where you're able to see and interact with all the endpoints available to the app. You can use this endpoint for testing. 
