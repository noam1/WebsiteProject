using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.SqlClient;

namespace WebsiteProject
{
    public class DBUtil
    {
        private const string ConnectionString = "";
        private SqlConnection connection;

        public DBUtil()
        {
            connection = new SqlConnection(ConnectionString);
        }
        
        public void Open()
        {
            connection.Open();
        }

        public void Close()
        {
            connection.Close();
        }
    }
}