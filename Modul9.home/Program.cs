using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul9.home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var manager = new Manager("Almas", 20, 190000, 70000);
            var developer = new Developer("Dias", 21, 250000, 650, 0.5m);

            Console.WriteLine(manager.GetInfo());
            Console.WriteLine($"Annual Salary with Bonus: {manager.CalculateAnnualSalary()}");

            Console.WriteLine(developer.GetInfo());
            Console.WriteLine($"Annual Salary with Code Bonus: {developer.CalculateAnnualSalary()}");
            Console.ReadKey();
        }
    }
}
