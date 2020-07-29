 # Condominium

This is a solution with Angular 8 and ASP.NET Core 3 following the principles of Clean Architecture.

## Technologies
* .NET Core 3.1
* ASP .NET Core 3.1
* Entity Framework Core 3.1
* Angular 8

LAYERS Explanation (follow according to the Clean Architecture principles)

### Domain

This will contain all entities, enums, exceptions, interfaces, types and logic specific to the domain layer.


### Application

This layer contains all application logic. It is dependent on the domain layer, but has no dependencies on any other layer or project. 
This layer defines interfaces that are implemented by outside layers. For example, 
if the application need to access a notification service, a new interface would be added to application and an implementation
would be created within infrastructure.


### Infrastructure

This layer contains classes for accessing external resources such as file systems, web services, smtp, and so on. 
These classes should be based on interfaces defined within the application layer.

### WebUI

This layer is a single page application based on Angular 8 and ASP.NET Core 3. This layer depends on both the Application and 
Infrastructure layers, however, the dependency on Infrastructure is only to support dependency injection. 
Therefore only *Startup.cs* should reference Infrastructure.

CondominiumCleanArchitecture
Condominium project on Net core using clean architecture according to the Robert C martin Book

Condominium core Project
The Core project is the center of the Clean Architecture design used in this project, and all other project dependencies should point toward it. As such, it has very few external dependencies. include things like: • Entities • Aggregates • Domain Events • DTOs • Interfaces • Event Handlers • Domain Services • Specifications

Condominium infrastructure Project
The infrastructure project o layer, implement interfaces defined in Core. (In some case it’s needed many infrastructure projects as a Infrastructure.Data), but in my case one Infrastructure project with folders works fine. includes data access and domain event implementations, email providers, file access, web api clients, The purpose it’s no adding coupling to the Core project, or UI project. This project depends on Microsoft.EntityFrameworkCore.SqlServer and Autofac. EntityFrameworkCore.SqlServer is used because it's built into the default ASP.NET Core templates and is the least common denominator of data access. If desired, it can easily be replaced with a lighter-weight ORM like Dapper. Autofac (formerly StructureMap) is used to allow wireup of dependencies to take place closest to where the implementations reside. In this case, an InfrastructureRegistry class can be used in the Infrastructure class to allow wireup of dependencies there, without the entry point of the application even having to have a reference to the project or its types.

Condominium web Project
The entry point of the application is the ASP.NET Core web project. This is actually a console application, with a public static void Main method in Program.cs. It currently uses the default MVC organization (Controllers and Views folders) as well as most of the default ASP.NET Core project template code. This includes its configuration system, which uses the default appsettings.json file plus environment variables, and is configured in Startup.cs. The project delegates to the Infrastructure project to wire up its services using Autofac.

Condominium test projects
The test projects are organized based on the kind of test, with unit, functional and integration test projects existing in this solution. In terms of dependencies, there are three worth noting: • xunit that's what ASP.NET Core uses internally to test the product. It works great and as new versions of ASP.NET Core ship, I'm confident it will continue to work well with it. • Moq Moq is as a mocking framework for white box behavior-based tests. If I have a method that, under certain circumstances, should perform an action that isn't evident from the object's observable state, mocks provide a way to test that. I could also use my own Fake implementation, but that requires a lot more typing and files. Moq is great once you get the hang of it, and assuming you don't have to mock the world (which we don't in this case because of good, modular design). • Microsoft.AspNetCore.TestHost to test my web project using its full stack, not just unit testing action methods. Using TestHost, you make actual HttpClient requests without going over the wire (so no firewall or port configuration issues). Tests run in memory and are very fast, and requests exercise the full MVC stack, including routing, model binding, model validation, filters, etc.

Patterns Used
This solution template has code built in to support a few common patterns, especially Domain-Driven Design patterns. Here is a brief overview of how a few of them work.

Domain Events
Domain events are a great pattern for decoupling a trigger for an operation from its implementation. This is especially useful from within domain entities since the handlers of the events can have dependencies while the entities themselves typically do not.
