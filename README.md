# UOW-Repository-Using-EF-in-MVC
A repository is nothing but a class defined for an entity, with all the possible database operations. For example, a repository for an Employee entity will have the basic CRUD operations and any other possible operations related to the Employee entity. The Repository Pattern can be implemented in two ways:

### One repository per entity (non-generic): 
This type of implementation involves the use of one repository class for each entity. For example, if you have two entities, Employee, and Customer, each entity will have its own repository. 
https://github.com/Rohitshrm627/RepositoryUsingEFinMVC

### Generic repository:
A generic repository is the one that can be used for all the entities. In other words, it can be either used for Employee or Customer or any other entity.

## Unit of Work in C# Repository Pattern
The Unit of Work pattern is used to group one or more operations (usually database CRUD operations) into a single transaction or “unit of work” so that all operations either pass or fail as one. In simple word we can say that for a specific user action, say booking on a website, all the transactions like insert/update/delete and so on are done in one single transaction, rather than doing multiple database transactions. This means, one unit of work here involves insert/update/delete operations, all in one single transaction so that all operations either pass or fail as one.

#### This the demo project for creating Unit of work pattern based application.

