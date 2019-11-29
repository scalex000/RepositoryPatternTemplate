## Repository Pattern

"Repositories are classes or components that encapsulate the logic required to access data sources. They centralize common data access functionality, providing better maintainability and decoupling the infrastructure or technology used to access databases from the domain model layer. If you use an Object-Relational Mapper (ORM) like Entity Framework, the code that must be implemented is simplified, thanks to LINQ and strong typing. This lets you focus on the data persistence logic rather than on data access plumbing."  Microsoft (https://docs.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/infrastructure-persistence-layer-design)

"A Repository mediates between the domain and data mapping layers, acting like an in-memory domain object collection. Client objects construct query specifications declaratively and submit them to Repository for satisfaction. Objects can be added to and removed from the Repository, as they can from a simple collection of objects, and the mapping code encapsulated by the Repository will carry out the appropriate operations behind the scenes." jgauffin.

### Purpose

The purpose to use Repository pattern is to make abstraction, reduce complexity and make the rest of the code persistent ignorant.  Make your application more testability by doing unit tests instead integration tests.  Another is to reuse query.

### Common mistakes

1. Expose IQuerable<T>
2. Update/Save 
3. Returning view models/DTOs
4. Create one repository for all domain objects
  
  ### Language
  C# 
  
  ### Framework
  Entity Core 2.2.6
  NetStandar Library 2.0.3
  
  
  


