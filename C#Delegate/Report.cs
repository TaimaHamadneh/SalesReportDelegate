using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Delegate
{
    public class Report
    {

        public delegate bool EligibleSales(Employee e);


        public void ProcessEmployee(Employee[] employees, string title, EligibleSales isIllegible)
        {
            Console.WriteLine(title);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            foreach (var e in employees)
            {
                if (isIllegible(e))
                {
                    Console.WriteLine($"{e.Id} | {e.Name} | {e.Gender} | ${e.TotalSales} ");
                }
            }
            Console.WriteLine("\n\n");

        }
    }
}
    