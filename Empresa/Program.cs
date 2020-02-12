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

        delegate void BinaryNumericOperation(double n1, double n2);
        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

            List<Product> products = new List<Product>() { 
                new Product() {Id = 1, Name = "Computer", Price = 1100.0, Category = c2},
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            var r1 = products.Where(p => p.Category.Id == 1 && p.Price < 900.0);
            Console.WriteLine("Tier 1 and Price < 900: ");
            /*
            int[] numbers = new int[] { 2, 3, 4, 5 };

            var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

            foreach(int x in result)
            {
                Console.WriteLine(x);
            }*/



            /*
             * Funções utilizadas em Predicate,Func, Action(Remove, Update, Touper)
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00)); 
            list.Add(new Product("Mouse", 50.00)); 
            list.Add(new Product("Tablet", 350.50)); 
            list.Add(new Product("HD Case", 80.90));

            list.ForEach(AtualizarPreco );

            List<string> result = list.Select(NameUpper).ToList();

            foreach(string s in result)
            {
                Console.WriteLine(s);
            }

            list.RemoveAll(TesteProduto);
            foreach(Product p in list)
            {
                Console.WriteLine(p.ToString());
            }

            */



            String s1 = "Good morning dear students!";

            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            op.Invoke(a, b);


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
