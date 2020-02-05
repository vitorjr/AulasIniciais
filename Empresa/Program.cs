using Empresa.Entities;
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
            Console.WriteLine("Enter retal data: ");
            Console.WriteLine("Car model:");
            string model = Console.ReadLine();
            Console.WriteLine("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

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
}
