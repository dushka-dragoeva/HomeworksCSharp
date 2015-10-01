## Database Systems - Overview
### _Homework_

#### Answer following questions in Markdown format (`.md` file)
1.  What database models do you know?
    * Hierarchial (tree) model
    * Network/graph model
    * Relational(table) model
    * Object-orientated

1.  Which are the main functions performed by a Relational Database Management System (RDBMS)?
   * RBDMS manage date stored in tables
      * Creating, altering, deleting tables and relationship between them
      * Adding, changing, deleting, searching and retreving of data stored in tables
      * Support for SQL language
      * Transaction managment(optional)
1.  Define what is "table" in database terms.

   Database tables consist datta, arrange in raws and columns. 
   * All rows have same structure. 
   * Columns have name and type (string, number, date, inmage or other) 
   
   The schema of a table is an ordered sequence of column spacifications - name and type.

1.  Explain the difference between a primary and a foreign key.

   Major diggrences are:
   *  Primary key is a column of the table that uniquely identifies its rows, and The foreign key is an identifier of a record located in another table witch is 
   *  The table has only one primary key, but it can have many foreign keys
   
1.  Explain the different kinds of relationships between tables in relational databases.
  
* One-to many - A single record in the first table has many  coresponding records in the second table
* Many -to many - many record in a table coresponds to a single records in the other table - shows inheritance between tables. Implemented throgh additional table
* One-to -one -  A single record in the first table has many  coresponding records in the second table
1.  When is a certain database schema normalized?

Database schema is normalized when there isn't repeating data.

  * What are the advantages of normalized databases?
      * Smaller database: By eliminating duplicate data, you will be able to reduce the overall size of the database.
      * Better performance:
        + Narrow tables: Having more fine-tuned tables allows your tables to have less columns and allows you to fit more records per data page
        + Fewer indexes per table mean faster maintenance tasks such as index rebuilds
        + Only join tables that you need 
  1.  What are database integrity constraints and when are they used?

They inforce data rules which cannot be violated  and they enshure data integrity in the database tables.
1.  Point out the pros and cons of using indexes in a database.

__Pros__
1.  What's the main purpose of the SQL language?
1.  What are transactions used for?
  * Give an example.
1.  What is a NoSQL database?
1.  Explain the classical non-relational data models.
1.  Give few examples of NoSQL databases and their pros and cons.



