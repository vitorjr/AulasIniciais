using Empresa.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public double baseSalary { get; set; }
        public WorkerLevel level { get; set; }

        public Department department { get; set; }

        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker() { }

        public Worker(string name, double baseSalary, WorkerLevel level, Department department)
        {
            Name = name;
            this.baseSalary = baseSalary;
            this.level = level;
            this.department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public Double Income(int ano, int mes)
        {
            double sum = baseSalary;

        }
    }
}
