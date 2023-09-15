using ConsoleApp1;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter department's name: ");
            String departmentName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.WriteLine("Name: ");
            String nameEmployee = Console.ReadLine();
            Console.WriteLine("Level: ");
            WorkerLevel workerLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.WriteLine("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine());
            Console.WriteLine("How many contracts to this worker? ");

            Department department = new Department(departmentName);
            Worker worker = new Worker(nameEmployee, workerLevel, baseSalary);

            int contractsNumber = int.Parse(Console.ReadLine());


            for (int i = 1; i <= contractsNumber; i++)
            {

                Console.WriteLine("Enter " + i + "contract data: ");
                Console.WriteLine("Date dd/mm/yyyy");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.WriteLine("Duration (hours) ");
                int durationHours = int.Parse(Console.ReadLine());


                HourContract contract = new HourContract(date, valuePerHour, durationHours);
                worker.addCotract(contract);


            }

            Console.WriteLine("Enter month and year to calclate income: mm/yyyy");
            string monthtAndYear = Console.ReadLine();
            int month = int.Parse(monthtAndYear.Substring(0, 2));
            int year = int.Parse(monthtAndYear.Substring(3));

            Console.WriteLine("Name: " + worker.name);
            Console.WriteLine("Income for " + monthtAndYear + ":" + worker.income(year, month));


        }
    }
}