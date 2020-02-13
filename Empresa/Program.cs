using Empresa.Entities;
using Empresa.Services;
using Empresa.Devices;
using Empresa.Extensions; 
using Empresa.Entities.Enums;
using Empresa.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Empresa
{
    class Program
    {
        //delegate double BinaryNumericOperation(double n1, double n2);

        //delegate void BinaryNumericOperation(double n1, double n2);

        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach(T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine( );
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o caminho do arquivo: ");
            string caminho = Console.ReadLine();

            List<EmployeeFile> list = new List<EmployeeFile>();

            using (StreamReader sr = File.OpenText(caminho))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    
                    list.Add(new EmployeeFile(name,email,salary));
                }
            }

            //var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            //Console.WriteLine("Media dos preços: " + avg.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Informe um salário: ");
            double sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            var emails = list.Where(p => p.Salary > sal).OrderBy(p => p.Email).Select(p => p.Email);
            foreach (string name in emails)
            {
                Console.WriteLine(name);
            }

            var soma = list.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);
            Console.WriteLine("Soma dos funcionários iniciando com o a Letra 'M': "+soma.ToString("F2", CultureInfo.InvariantCulture));


            /*
            Console.WriteLine("Entre com o caminho do arquivo: ");
            string caminho = Console.ReadLine();

            List<ProductFile> list = new List<ProductFile>();

            using(StreamReader sr = File.OpenText(caminho))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    list.Add(new ProductFile(name, price));
                }
            }

            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Media dos preços: "+avg.ToString("F2",CultureInfo.InvariantCulture));

            var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }*/
            /*
            String s1 = "Good morning dear students!";

            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            op.Invoke(a, b);
            */

            /*
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum;

            double igual = op(30, 50);

            double result = CalculationService.Sum(a, b);
            Console.WriteLine(result);
            Console.WriteLine(igual);

            Console.WriteLine(s1.Cut(2));
            DateTime dt = new DateTime(2020, 02, 07, 09, 43, 00);
            Console.WriteLine(dt.ElapsedTime());*/
        }
        /*
         * Funções utilizadas em Predicate,Func, Action(Remove, Update, Touper)
        public static bool TesteProduto(Product p)
        {
            return p.Price >= 100.0;
        }

        static void AtualizarPreco(Product p)
        {
            p.Price += p.Price * 0.1;
        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
        */
    }

}
