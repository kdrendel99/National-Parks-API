# _National Parks API_

## Description <a id="description"></a>

#### A web API made utilizing  C#, .NET5, MySQL, and Entity that contains a database for all the National Parks in the United States. The API uses authentication for POST requests, requiring users who have an account to make POST requests.

#### _By **Karlson Drendel**_

#### _Table of Contents_

1. [Preview](#preview)
2. [Technologies Used](#technologies)
3. [Description](#description)
4. [Setup/Installation Requirements](#setup)
5. [Additional Setup/Installation Note for Windows Users](#windows)
6. [Specifications](#specs)
7. [Known Bugs](#bugs)
8. [License](#license)
9. [Contact Information](#contact)


## Technologies Used <a id="technologies"></a>

* _C# 8.0_
* _.NET 5 Framework_
* _ASP.NET Core_
* _MVC 2.2_
* _MySQL + MySQL Workbench -v 8.0.15_
* _RESTful Routing_
* _CRUD Functionality_
* _Git_
* _Microsoft Visual Studio Code_
* _Entity_

## Authentication Technology

* _For the API Authentication, I used Token-based JSON Authentication, or JWT. The user is required to have their login information in the List in line 15 of JwtAuthenticationManager.cs (for the time being). JWT is based access token created for claims. It's a self-contained and compact standard for access token to securely transfer claims._

* _In ASP.Net Core, the authentication middleware is added in the Startup class, inside the Configure method. It is done by calling UseAuthentication method on the IApplicationBuilder instance passed to the method._

_Authentication schemes are registered in the Startup class inside of the ConfigureServices method. It's done by calling AddAuthentication method on the IServiceCollection instance passed to the method._

_For this project, I used JWT. For creating a JWT, one can use different hash algorithms. I used HS256 algorithm for this project._

## Setup/Installation Requirements <a id="setup"></a>

* _Open terminal._

* _Install Microsoft .NET Version 5._

* _Clone this project with the following git command `$ git clone https://github.com/kdrendel99/National-Parks-API.git`_

* _Open project using your preferred code editor._

* _Create appsettings.json in ParksAPI.Solution/ParksAPI, and add this code into it:_

    ```
    {
        "ConnectionStrings": {
            "DefaultConnection": "Server=localhost;Port=3306;database=Firstname_Lastname;uid=root;pwd=[YOUR-PASSWORD-HERE];"
        }
    }
    ```

* _Navigate to ParksAPI.Solution/ParksAPI_

* _Enter 'dotnet restore' into terminal and press enter to restore dependencies._

* _Enter 'dotnet ef database update' into the terminal to create local database from migration._

* _Enter 'dotnet run' into terminal, and run the project._

## Endpoints <a id="endpoints"></a>

## GET Requests 
* _http://localhost:5000/api/parks/_

* _Retrieves all National Parks from the database. All 63 National Parks are available to all with GET requests._ 
* _http://localhost:5000/api/parks/?state=alaska_

* _An example query. Follow the GET all endpoint with '?' + the category you want to filter by, =, and what you'd like to query for. The query also works with the Main Attraction category, and you can search for activities/places such as "shipwreck", "hiking", "Old Faithful", etc. You can categorize your query with the following filters: 'parkId', 'name', 'state', and 'attraction'._ 

* _http://localhost:5000/api/parks/5_
* _Search by Park Id (alphabetized by park name, 1-63)._

## POST Requests 
**To make a POST request, the user must be on the authentication list (note: create user functionality and database containing users are not yet built).**
For beta version POST functionality, follow the steps below
* _In Postman, set your endpoint to http://localhost:5000/api/name/authenticate_
* _Click on the Body tab below the endpoint search bar, and enter the following:_
```{"username":"testUser1", "password": "password1"}```
* _Ensure the input type is set to JSON, and send the post request._
* _In the return, you'll receive your API token. Save this for the next step._


* _Navigate to either of the GET request endpoints, and click on the Authorization tab under the endpoint box._
* _Select 'Bearer Token', and paste your token in the token box on the right._
* _In the body box, format your post request in the following way for POST, DELETE, or PUT:_
```
    {
        "parkId": 63,
        "name": "Zion",
        "state": "Utah",
        "mainAttraction": "Sandstone formations, and the Virgin River"
    }
    
```


## Known Bugs <a id="bugs"></a>
* _No way to create new users for authorization._
* _User permission/authenticate list is stored in a List type instead of an encripted database (very low security)_


## License <a id="license"></a>

* _Copyright <2021> Karlson Drendel_

* _Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:_

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.


*[MIT](https://choosealicense.com/licenses/mit/)*

Copyright (c) **_2021 Karlson Drendel_**

## Contact Information <a id="contact"></a>
**_Karlson Drendel kdrendel99@gmail.com_**
