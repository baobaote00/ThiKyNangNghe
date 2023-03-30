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

        public static SqlConnection GetConnection()
        {
            try
            {
                return new SqlConnection("Data Source =.; Initial Catalog = Session2; Integrated Security = True");
            } catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
