# Import ASP.NET core into the container
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1

# TCP Port where the container will be listening
EXPOSE 80

# Working directory
WORKDIR /ForecastApp

# Copy the publish folder to image
COPY ./src/ForecastApp/publish .

# Define entrypoint of the app
ENTRYPOINT ["dotnet", "ForecastApp.dll"]



