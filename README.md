# Net_2026_Victor_Leano

Technical Test - .NET MVC

## Description

This project is an ASP.NET MVC web application that consumes an external API to authenticate a user and retrieve company information.

The application follows MVC architecture and applies SOLID principles using a Service Layer for API communication.

## Technologies

- ASP.NET Core 8 MVC
- HttpClient
- Dependency Injection
- Bootstrap 5
- Clean Architecture (Controllers / Services / ViewModels)

## Architecture

Controllers → Handle requests  
Services → API communication  
ViewModels → Data for Views  
Views → Razor UI

## API Credentials

UserName  
sopscih

Password  
dbfleetsapqa

Company Name  
SCI TEST

App Type  
Web

## API Endpoints

### Login

POST  
https://fleetsapapiqa2.azurewebsites.net/Api/SignIn

### Company

GET  
https://fleetsapapiqa2.azurewebsites.net/Api/Company?CompanyId=NQAwADIA

Authorization  
Bearer Token

## How to Run

1 Clone repository

git clone https://github.com/YOURUSER/Net_2026_Victor_Leano

2 Open with Visual Studio

3 Run project

4 Login and view company information

## Author

Victor Leano  
Senior .NET Developer
