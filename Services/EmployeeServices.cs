using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThiKyNangNghe.Models;
using ThiKyNangNghe.Repository;


namespace ThiKyNangNghe.Services
{
    interface IEmployeeService
    {
    }

    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _userRepository;

        public EmployeeService(IEmployeeRepository userRepository)
        {
            _userRepository = userRepository;
        }
    }
}
