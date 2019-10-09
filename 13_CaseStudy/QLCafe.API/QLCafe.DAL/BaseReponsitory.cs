using System;
using System.Data;
using System.Data.SqlClient;

namespace QLCafe.DAL
{
    public class BaseReponsitory
    {
        protected IDbConnection con;
        public BaseReponsitory()
        {
            string connectString = @"Data Source=DESKTOP-DRHRVKR;Initial Catalog=Cafe;Integrated Security=True";
            con = new SqlConnection(connectString);
        }
    }
}
