using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using ThiKyNangNghe.Models;

namespace ThiKyNangNghe.Repository
{
    public interface IEmployeeRepository
    {
    }

    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly string _connectionString;

        public EmployeeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

    }

}
