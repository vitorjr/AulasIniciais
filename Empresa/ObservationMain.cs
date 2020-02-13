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
    class ObservationMain
    {
        /*
             * Fazendo o Linq usando o SQL e versao normal também, usando a classe Product,e Category
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

            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            Print("Tier 1 and Price < 900: ", r1);

            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("Names of products from tools", r2);

            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name});
            Print("Nome começados com C e objeto anonimoss",r3);

            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("Tier 1 order by price then by name",r4);

            var r5 = r4.Skip(2).Take(4);
            Print("Tier order by price then by name skip 2 take 4", r5);

            var r6 = products.First();
            Console.WriteLine("First test1: ", r6);

            var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
            Console.WriteLine("First or default test2: " + r7);
            Console.WriteLine();



            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Single or default test1: " + r8);
            var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("Single or default test2: " + r9);
            Console.WriteLine();

            var r10 = products.Max(p => p.Price);
            Console.WriteLine("Max price: " + r10);
            var r11 = products.Min(p => p.Price);
            Console.WriteLine("Min price: " + r11);
            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 Sum prices: " + r12);
            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Category 1 Average prices: " + r13);
            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Category 5 Average prices: " + r14); 
            var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Category 1 aggregate sum: " + r15);
            Console.WriteLine();

            var r16 = products.GroupBy(p => p.Category);
            foreach (IGrouping<Category, Product> group in r16){
                Console.WriteLine("Category " + group.Key.Name + ":");
                foreach (Product p in group){
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
            */


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





        /*
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
            */



        /*
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

            RentalService rentalService = new RentalService(priceporhour, priceporday);

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("Invoice: ");
            Console.WriteLine(carRental.Invoice);
            */

        //Projeto de arquivos criados
        /* string origem = @"C:\FitBank\myfolder";
        try
        {
            //string[] lines = File.ReadAllLines(origem);
            IEnumerable<string> folders = Directory.EnumerateDirectories(origem, "*.*", SearchOption.AllDirectories);
            foreach(string s in folders)
            {
                Console.WriteLine(s);
            }

            IEnumerable<string> files = Directory.EnumerateFiles(origem, "*.*", SearchOption.AllDirectories);
            Console.WriteLine();
            foreach (string s in files)
            {
                Console.WriteLine(s);
            }
            Directory.CreateDirectory(origem + "\\newfolder");

        }
        catch (IOException e)
        {
            Console.WriteLine("An error ocurred");
            Console.WriteLine(e.Message);
        }*/
        /*string origem = @"C:\FitBank\texto1.txt";
        string destino = @"C:\FitBank\texto2.txt";
        try
        {
            string[] lines = File.ReadAllLines(origem);
            using(StreamWriter sw = File.AppendText(destino))
            {
                foreach(string line in lines)
                {
                    sw.WriteLine(line.ToUpper());
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("An error ocurred");
            Console.WriteLine(e.Message);
        }*/
        /* string sourcePath = @"C:\FitBank\texto1.txt";

            using(StreamReader sr = File.OpenText(sourcePath))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }*/
        /*string sourcePath = @"C:\FitBank\texto1.txt";
        FileStream fs = null;
        StreamReader sr = null;
        try
        {
            sr = File.OpenText(sourcePath);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("An error ocurred");
            Console.WriteLine(e.Message);
        }
        finally
        {
            if (sr != null) sr.Close();
            if (fs != null) fs.Close();
        }*/
        /*
        string sourcePath = @"C:\FitBank\texto1.txt";
        FileStream fs = null;
        StreamReader sr = null;
        try
        {
            fs = new FileStream(sourcePath, FileMode.Open);
            sr = new StreamReader(fs);
            string line = sr.ReadLine();
            Console.WriteLine(line);
        }
        catch (IOException e)
        {
            Console.WriteLine("An error ocurred");
            Console.WriteLine(e.Message);
        }
        finally
        {
            if (sr != null) sr.Close();
            if (fs != null) fs.Close();
        }*/
        /*
        string sourcePath = @"C:\FitBank\texto1.txt";
        string targetPath = @"C:\FitBank\texto2.txt";
        try
        {
            FileInfo file = new FileInfo(sourcePath);
            //file.CopyTo(targetPath);
            string[] lines = File.ReadAllLines(sourcePath);
            foreach(string line in lines)
            {
                Console.WriteLine(line);
            }
        }catch(IOException e)
        {
            Console.WriteLine("An error ocurred");
            Console.WriteLine(e.Message);
        }
        */

        /*Account acc = new Account(121, "Joao", 0.00);
        BusinessAccount baccount = new BusinessAccount(122, "Maria", 0.00, 1000.00);*/
        /*
        //Projeto com criações de try cath
        try { 
        Console.WriteLine("Room number");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Check-in date (dd/MM/yyyy):");
        DateTime dataentrada = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Check-out date (dd/MM/yyyy):");
        DateTime datasaida = DateTime.Parse(Console.ReadLine());

        Reservation reserva = new Reservation(number, dataentrada, datasaida);
        Console.WriteLine("Reservation:"+reserva);

        Console.WriteLine();
        Console.WriteLine("Enter data to update the reservation:");
        Console.Write("Check-in date (dd/MM/yyyy): ");
        dataentrada = DateTime.Parse(Console.ReadLine());
        Console.Write("Check-out date (dd/MM/yyyy): ");
        datasaida = DateTime.Parse(Console.ReadLine());

        reserva.UpdateDates(dataentrada, datasaida);
        Console.WriteLine("Reservation: " + reserva);
        }
        catch (FormatException e)
        {
            Console.WriteLine("Error in format: " + e.Message);
        }
        catch (DomainException e)
        {
            Console.WriteLine("Error in reservation: " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Unexpected error: " + e.Message);
        }
        */

        /*
        //Projeto Area da figura
        Console.Write("Digite quantas figuras serão inseridas? ");
        int n = int.Parse(Console.ReadLine());

        List<Shape> lista = new List<Shape>();

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine();
            Console.WriteLine($"Figura #{i}:");
            Console.Write("Retangulo ou Circulo (r/c): ");
            char terceirizado = char.Parse(Console.ReadLine());
            Console.Write("Cor (Black/Blue/Red): ");
            Color color = Enum.Parse<Color>(Console.ReadLine());
            if (terceirizado == 'r')
            {

                Console.Write("Largura:");
                double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Altura:");
                double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                lista.Add(new Rectangle(altura,largura,color));

            }
            else {
                Console.Write("Informe o raio do circulo:");
                double raio = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                lista.Add(new Circle(raio, color)); 
            }

            Console.WriteLine();
        }
        Console.WriteLine("Payments:");
        foreach (Shape shape in lista)
        {
            Console.WriteLine(shape.Area().ToString("F2",CultureInfo.InvariantCulture));
        }
        */


        /*
        //Projeto de funcionario terceirizados adicionando uma despesa adicional
        Console.Write("Digite quantos funcionários serão inseridos? "); 
        int n = int.Parse(Console.ReadLine());

        List<Employee> lista = new List<Employee>();

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(); 
            Console.WriteLine($"Funcionario #{i}:");
            Console.Write("Terceirizado (y/n): "); 
            char terceirizado = char.Parse(Console.ReadLine()); 
            Console.Write("Nome: "); 
            string nome = Console.ReadLine(); 
            Console.Write("Horas: ");
            int horas = int.Parse(Console.ReadLine());
            Console.Write("Valor por hora: ");
            double valorporhora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if(terceirizado == 'y')
            {

                Console.Write("Despesa adicional:");
                double adicional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                lista.Add(new OutsourcerEmployee(nome, horas, valorporhora, adicional));

            }
            else { lista.Add(new Employee(nome, horas, valorporhora));  }

            Console.WriteLine();
        }

        Console.WriteLine("Payments:");
        foreach (Employee empe in lista)
        {
            Console.WriteLine($"{empe.Name} - {empe.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
        }

        */


        /*Projeto Worker(funcionarios)
         * string depName, nameWorker;
        double basesalarial;
        WorkerLevel nivel = new WorkerLevel();

        Console.WriteLine("Entre com o nome do departamento: ");
        depName = Console.ReadLine();
        Console.WriteLine("Entre com uma data do funcionario:");
        Console.WriteLine("Nome: ");
        nameWorker = Console.ReadLine();
        Console.WriteLine("Informe o nível (Junior/MidLever/Senior): ");
        nivel = Enum.Parse<WorkerLevel>(Console.ReadLine());
        Console.WriteLine("Informe a base salarial:");
        basesalarial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


        Department departamento = new Department(depName);
        Worker funcionario = new Worker(nameWorker,basesalarial,nivel, departamento);


        Console.WriteLine("Informe quantos contratos adicionais o funcionário fez: ");
        int n = int.Parse(Console.ReadLine());

        for(int i=1; i<=n; i++)
        {
            Console.WriteLine("Entre com o contrato #"+i);
            Console.WriteLine("Data:");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Valor por hora: ");
            Double valorPorhora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Duração(Horas): ");
            int horas = int.Parse(Console.ReadLine());

            HourContract horasfuncionario = new HourContract(date, valorPorhora, horas);
            funcionario.AddContract(horasfuncionario);
        }


        Console.Write("Entre com o mes e o ano para calcular o aumento salarial(MM/YYYY): ");
        string mesAno = Console.ReadLine();
        int mes = int.Parse(mesAno.Substring(0, 2));
        int ano = int.Parse(mesAno.Substring(3));
        Console.WriteLine("Name : " + funcionario.Name);
        Console.WriteLine("Department: " + funcionario.department.Name);
        Console.WriteLine("Income for " + mesAno + ": " + funcionario.Income(ano, mes).ToString("F2", CultureInfo.InvariantCulture));
        */

        /*Order order = new Order
        {
            Id = 10,
            Moment = DateTime.Now,
            Status = OrderStatus.PendingPayment
        };

        Console.WriteLine(order);*/

        /*DateTime x = DateTime.Now;
        Console.WriteLine(x);*/

        /* Console.Write("Digite quantos funcionários serão inseridos? "); 
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
        }*/
    }
}
