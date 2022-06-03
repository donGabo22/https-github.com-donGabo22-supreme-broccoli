using System;
using System.Data.SqlClient;
using DataAccess;

//using.Data.sqlClient;
namespace DataAccess
{
    public abstract class ConnectionToSql
    {
        private readonly string connectionString;
        public ConnectionToSql()
        {
            connectionString = "server-DESKTOP-JUGSUS0;Database=BasedeDatosLety; integrated security= true";

        }
        protected SqlConnection Getconnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
