# 15Marketing

Database factory

- This is a simplified task implementation
- The DataStore interface should incorporate all the implementation that a database engine needs to connect, CRUD operations etc. It's rather minimal now having some dummy properties and methods as a reference in order to establish a connection and to perform a command
- The DataAccess layer supplies the database-based implementations of the Domain classes
- ProductRepository is an abstract class that in our case is implemented by the SqlProductRepository
- SqlProductRepository uses the DataStoreFactory to establish a SQL connection to a specific SQL engine
- ProductService class uses construction injection and the code is loosely coupled as it consumes the abstraction
- In a production application is preferable to use DI containers
