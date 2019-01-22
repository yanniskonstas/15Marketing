# 15Marketing

Dev Task 2018

-	This is a simple test. Relax. Don’t overthink it. The question is written from an OOP perspective; if OOP isn’t your prefered paradigm please solve the problem in a way that would handle the same concerns listed below. 
-	We’re looking for good design and demonstration of engineering concepts. Functioning code is not a requirement.

-	In your favourite language and programming paradigm write the following. 
-	Write an abstract class or interface that models a SQL database connection
-	You may build a single interface or compose multiple areas of concerns
-	You can make some assumptions that we’re working with a relational database schema. 
-	Write a factory to create two different types of database connections
-	They don’t have to be real database engines. Make some up, but demonstrate how a factory deals with differences in concrete implementations
-	Implement a class that models some entity (e.g. cat, car, person, foo or bar etc) that will be persisted to a database created by your factory
-	Your class should demonstrates dependency injection
-	If you think dependency model is wrong, model it some other way and tell us why your way is better.
-	Write a test that tests your classes
-	Demonstrate how mocking works

Implementation notes

- This is a simplified task implementation
- The DataStore interface should incorporate all the implementation that a database engine needs to connect, CRUD operations etc. It's rather minimal now having some dummy properties and methods as a reference in order to establish a connection and to perform a command
- The DataAccess layer supplies the database-based implementations of the Domain classes
- ProductRepository is an abstract class that in our case is implemented by the SqlProductRepository
- SqlProductRepository uses the DataStoreFactory to establish a SQL connection to a specific SQL engine
- ProductService class uses construction injection and the code is loosely coupled as it consumes the abstraction
- In a production application is preferable to use DI containers
