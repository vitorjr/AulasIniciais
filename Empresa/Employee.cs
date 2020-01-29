using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void increaseSalary(double porcentagem)
        {
            Salary = Salary * porcentagem / 100;
        }

        public override string ToString()
        {
            return "Id:"+Id+"Nome:"+Name+"Salario"+Salary;

        }
    }
}
