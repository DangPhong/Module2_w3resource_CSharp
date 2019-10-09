using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace QLNV.DAL
{
    public class BaseReponsitory
    {
        protected IDbConnection con;
        public BaseReponsitory()
        {
            string connectString = @"Data Source=DESKTOP-DRHRVKR;Initial Catalog=QuanLyNhanVien;Integrated Security=True";
            con = new SqlConnection(connectString);
        }
    }
}
