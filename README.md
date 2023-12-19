![Thumbnail GitHub]()

## Users API

UsersAPI is a C# API created to study how the user registration and login process works using JWT tokens and maintaining confidential information through "Secrets".
The MySql database was used to store information related to registered users.
The database can be created through the Migrations present in the project.

## 🔨 Project features

The API has endpoints for inserting and retrieving user-related data. Examples can be obtained through this documentation or through the Swagger API.
#### RegisterUser
- Adds a new user to the database.
- `Endpoint`: `https://localhost:7287/user/register`
- `Body`: 
```json
{
    "UserName": "User",
    "BirthDate": "2001-01-01",
    "Password": "Pass123@",
    "RePassword": "Pass123@"
}
```
---
#### Login
- Logs in to the API and returns a JWT token.
- `Endpoint`: `https://localhost:7287/user/login`
- `Body`: 
```json
{
    "Username": "User",
    "Password": "Pass123@"
}
```
---
#### Validates JWT token
- Validates the user's minimum age according to the JWT token.
- `Endpoint`: `https://localhost:7287/access`

---

## 🛠️ Open and run the project

* To run the API in a testing environment, it is necessary to install and configure the MySql database.
You must enter the connection string and encryption key in the “secrets.json” file present in the “AppData\Roaming\Microsoft\UserSecrets” folder.

* `Creation of 'secret.json':`
```powershell
dotnet user-secrets init
```
* `Addition of 'SymmetricSecurityKey' variable:`
```powershell
dotnet user-secrets set "SymmetricSecurityKey" "1234567890123456789abcdefhijklmnopqrstuvxwyz"
```
* `Addition of variable 'ConnectionStrings:UserConnection':`
```powershell
dotnet user-secrets set "ConnectionStrings:UserConnection": "server=localhost;database=userdb;user=root;password=root"
```