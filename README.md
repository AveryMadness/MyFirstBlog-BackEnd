## Getting Started

First, we're going to install Postgres. This will be the database that the app uses to store data. [Here is the link to instructions on installing postgres](https://www.postgresql.org/download/).

Then, you need to install dotnet 7. You can download the installer [from the dotnet.microsoft page](https://dotnet.microsoft.com/en-us/download).

1. Once the download is finished, restart your terminal and go the following directory:
``cd MyFirstBlogBackEnd``
``cd MyFirstBlog``

2. Set up an SSL certificate by running 
``dotnet dev-certs https --trust`` 

3. Run the following command to run the backend server:
``dotnet run``

You can now interact with the server through your browser. Try navigating to [http://localhost:5000/swagger/index.html](http://localhost:5000/swagger/index.html).
This is an interface where you're able to see and interact with all the endpoints available to the app. You can use this endpoint for testing. 
