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

        public int Hours { get; set; }

        public Double ValueporHours { get; set; }

        public Employee() { }

        public Employee(string name, int hours, double valueporHours)
        {
            Name = name;
            Hours = hours;
            ValueporHours = valueporHours;
        }

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

        public virtual Double Payment()
        {
            Double Total = Hours * ValueporHours;
            return Total;
        }
    }
}
