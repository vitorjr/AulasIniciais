using Empresa.Entities;
using Empresa.Services;
using Empresa.Entities.Enums;
using Empresa.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solução sem interface para projeto aluguel de carros com taxa
            Console.WriteLine("Enter retal data: ");
            Console.WriteLine("Car model:");
            string model = Console.ReadLine();
            Console.WriteLine("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            Console.WriteLine("Enter price per hour: ");
            double priceporhour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Enter price per day: ");
            double priceporday = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            RentalService rentalService = new RentalService(priceporhour, priceporday,new BrazilTaxService());

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("Invoice: ");
            Console.WriteLine(carRental.Invoice);

        }
    }
}
