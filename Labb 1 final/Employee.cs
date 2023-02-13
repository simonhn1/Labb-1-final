using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekssystem
{
    public class Employee
    {
    public int EmployeeNo { get; set; }
    private string Password { get; set; }
    public string Name { get; set; }
    public string Role { get; set; }

        public Employee(int employeeNo, string password, string name, string role)
        {
            EmployeeNo = employeeNo;
            Password = password;
            Name = name;
            Role = role;
        }
    }
}

