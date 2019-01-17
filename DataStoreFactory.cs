using System;

namespace DataAccess
{
    public static class DataStoreFactory
    {
        public static IDataStore Create(string sqltype)
        {;
            switch (sqltype)
            {
                case "sql1":
                    return CreateSql1();
                case "sql2":
                    return CreateSql2();
                default:
                    throw new InvalidOperationException();
            }            
        }

        private static IDataStore CreateSql1()
        {
            throw new NotImplementedException();         
        }

        private static IDataStore CreateSql2()
        {
            throw new NotImplementedException();         
        }
    }
}
