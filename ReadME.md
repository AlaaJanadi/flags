# Flags ASP.NET Project
This project is an ASP.NET web application that provides information about countries and their details using a MongoDB database. It offers endpoints to retrieve country data, including details like country name, capital, continent, population, and more.

### Table of Contents
- [Prerequisites](#pre)
- [Installation](#ins)
- [Usage](#usage)
- [Endpoints](#endpoints)
- [Importing Data](#import)
- [Configuration](#config)
### Prerequisites 
<a name="pre"></a>
- [.NET 6.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- [MongoDB](https://www.mongodb.com/try/download/community)
### Installation
<a name="ins"></a>Clone this repository to your local machine.
Open the project in Visual Studio or your preferred code editor.
### Usage
<a name="usage"></a>Build and run the project.
The API will be available at ```https://localhost:5001/country``` (you can modify the port in the launchSettings.json file).
### Endpoints
<a name="endpoints"></a>
- **GET /country:** Retrieve information about all countries.
- **GET /country/{id}:** Retrieve information about a country by its ID.
- **GET /country/str/{id}:** Retrieve information about a country by its string ID.
- **GET /country/tld/{tld}:** Retrieve information about a country by its top-level domain (TLD).
- **GET /country/con/{continent}:** Retrieve information about countries in a specific continent.
- **GET /country/get4/{id1}/{id2}/{id3}/{id4}:** Retrieve information about four countries by their IDs.
### Importing Data
<a name="import"></a>To import the country data into your MongoDB database:

1. Make sure you have a running MongoDB instance.
2. Use the mongoimport command or MongoDB Compass to import the data from the NewCountries.countries.json file.
### Configuration
<a name="config"></a>The application uses a secrets.json file to store sensitive configuration data. Make sure to add your MongoDB connection string and other settings in this file:

```
{
  "CountryDatabase": {
    "ConnectionString": "your_mongodb_connection_string",
    "DatabaseName": "your_database_name",
    "CountryCollectionName": "your_country_collection_name",
    "UserCollectionName": "your_user_collection_name"
  }
}
```

Make sure to replace the placeholders with your actual MongoDB connection details.
