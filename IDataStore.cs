using System;
using System.Data;

namespace DataAccess
{
    public interface IDataStore
    {
        string Name { get; set; }
        string ConnectionString {get; set;}
        IDbConnection Connection(); 
        IDbCommand Command();        
    }
}