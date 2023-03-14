using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ThiKyNangNghe.Connection
{
    class Connection
    {

        private readonly static string dataSource = "Tien-Player";
        private readonly static string myDatabase = "Session2";

        public static string getConnectionString()
        {
            return $"Data Source={dataSource};Initial Catalog={myDatabase};Integrated Security=True;";
        }

        public static SqlConnection GetConnection()
        {
            try
            {
                return new SqlConnection("Data Source =.; Initial Catalog = Session2; Integrated Security = True");
            } catch (SqlException ex)
            {
                throw new Exception("connect error");
            }
        }
    }
}
