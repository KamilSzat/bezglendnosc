using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bezględność
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var zadanie = new Zadanie2();
            double input = -15.5;
            double result = zadanie.AbsoluteValue(input);

            Console.WriteLine($"Wartość bezględna z {input} to {result}");
            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");

            Console.ReadKey();
        }
    }
}
