# Application Architecture

## Overview

The application follows the **Model-View-Controller (MVC)** architectural pattern provided by ASP.NET Core.

This structure separates responsibilities between:

- Presentation Layer
- Business Logic
- Data Communication

This improves:

- Maintainability
- Scalability
- Testability

---

## Architecture Layers

### Controllers

Controllers handle incoming HTTP requests and coordinate the interaction between services and views.

Example:

AccountController  
Handles authentication requests.

CompanyController  
Handles company information retrieval.

---

### Services

The Service Layer abstracts communication with external APIs.

Responsibilities:

- Handle HttpClient calls
- Manage API endpoints
- Process API responses
- Return structured models

Example:

IApiService  
Defines API communication contract.

ApiService  
Implements the API calls.

---

### Models

Models represent the structure of data received from the API.

Examples:

LoginRequest  
LoginResponse  
Company

---

### ViewModels

ViewModels transform models into UI-ready structures for the Views.

Example:

CompanyViewModel

---

### Views

Views are Razor pages responsible for rendering the user interface.

Example:

Login Page  
Company Information Page

---

## Dependency Injection

ASP.NET Core built-in Dependency Injection is used to register services.

Example:
builder.Services.AddHttpClient<IApiService, ApiService>();

This allows controllers to consume services through constructor injection.

---

## Benefits of This Architecture

- Separation of concerns
- Clean code organization
- Easier maintenance
- Better scalability
- Testability of services

---
