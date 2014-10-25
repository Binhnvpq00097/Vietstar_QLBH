using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace binhnvpq00097_QLBH.DAL
{
    class Database
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=COMPUTER\SQL2012;Database=binhnvpq00097_QLBH;User Id=sa;Password=binh2013;";
            con.Open();

            return con;
        }
    }
}
