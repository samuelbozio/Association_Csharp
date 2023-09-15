using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Worker
    {

        public String name { get; set; }
        public WorkerLevel level { get; set; }
        public Double baseSalary { get; set; }
        public Department departament { get; set; } //Assoc departament

        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker(string name, WorkerLevel level, double baseSalary)
        {
            this.name = name;
            this.level = level;
            this.baseSalary = baseSalary;
        }

        public void addCotract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void removeContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public Double income(int year, int mounth)
        {
            double soma = baseSalary;

            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == mounth)
                {

                    soma += contract.TotalValue();
                }
            }
            return soma;
        }


    }
}
