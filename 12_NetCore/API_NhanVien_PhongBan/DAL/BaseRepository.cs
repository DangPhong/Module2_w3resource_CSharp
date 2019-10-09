using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
   public class BaseRepository
    {
       protected  IDbConnection con;

        public BaseRepository()
        {
            string connectString = @"Data Source=DESKTOP-DRHRVKR;Initial Catalog=QLNhanSu;Integrated Security=True";
            con = new SqlConnection(connectString);
        }
    }
}
