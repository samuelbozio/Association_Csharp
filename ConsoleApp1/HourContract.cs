using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class HourContract
    {


        public DateTime Date { get; set; }
        public double valuePerHour { get; set; }
        public int hours { get; set; }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            this.Date = date;
            this.valuePerHour = valuePerHour;
            this.hours = hours;
        }

        public double TotalValue()
        {
            return hours * valuePerHour;
        }

    }
}
