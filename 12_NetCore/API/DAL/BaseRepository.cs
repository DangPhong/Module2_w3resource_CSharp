using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL
{
   public class BaseRepository
    {
        protected IDbConnection con;
        public BaseRepository()
        {
            string connectString = @"Data Source=DESKTOP-DRHRVKR;Initial Catalog=DataManagement;Integrated Security=True";
            con = new SqlConnection(connectString);
        }
    }
}
