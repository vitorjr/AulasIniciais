using System;
using System.Collections.Generic;
using System.Globalization;

namespace Empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quantos funcionários serão inseridos? "); 
            int n = int.Parse(Console.ReadLine());

            List<Employee> lista = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(); 
                Console.WriteLine($"Funcionario #{i}:");
                Console.Write("Id: "); 
                int id = int.Parse(Console.ReadLine()); 
                Console.Write("Email: "); 
                string nome = Console.ReadLine(); 
                Console.Write("Salario: "); 
                double salario = double.Parse(Console.ReadLine());
                lista.Add(new Employee(id, nome, salario));
                Console.WriteLine();
            }

            Console.WriteLine("Entre com o id do funcionário caso queira aumentar o salário:");
            int id_incre = int.Parse(Console.ReadLine());

            Employee emp = lista.Find(x => x.Id == id_incre);
            if(emp != null)
            {
                Console.Write("Enter the percentage: ");
                double porcetagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.increaseSalary(porcetagem);

            }
            else
            {
                Console.WriteLine("Informe um id valido!");
            }

            Console.WriteLine();
            Console.WriteLine("Funcionario atualizado:");

            foreach (Employee obj in lista)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
