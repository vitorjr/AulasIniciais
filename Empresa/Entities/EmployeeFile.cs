using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa.Entities
{
    class EmployeeFile
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Double Salary { get; set; }

        public EmployeeFile(string name, string email, double salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }
    }
}
