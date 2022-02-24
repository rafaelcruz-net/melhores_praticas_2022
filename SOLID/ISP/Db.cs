namespace ISP
{
    public class DbSqlServer : IRepositoryReadOnly<Cliente>
    {

        public DbSqlServer(SqlClient sql)
        {
            
        }
        public Cliente Get()
        {
            throw new System.NotImplementedException();
        }

        public Cliente GetAll()
        {
            throw new System.NotImplementedException();
        }

    }

    public class DbOracle : IRepositoryWriteOnly<Cliente>
    {

        public DbOracle(OracleClient sql)
        {

        }

        public void Delete(Cliente obj)
        {
            throw new System.NotImplementedException();
        }

        public void Save(Cliente obj)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Cliente obj)
        {
            throw new System.NotImplementedException();
        }
    }



    public class Cliente 
    {

    }
    
}


