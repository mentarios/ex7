using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a1, a2, a3;
            Console.WriteLine("digite o primeiro numero");
            a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo numero");
            a2 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o terceiro numero");
            a3 = int.Parse(Console.ReadLine());
            if (a1 > a2 && a1 > a3) { Console.WriteLine(a1); }
            if (a2 > a1 && a2 > a3) { Console.WriteLine(a2); }
            if (a3 > a2 && a3 > a1) { Console.WriteLine(a3); }

            if (a1 > a2 && a1 < a3 && a2 < a3) { Console.WriteLine(a1); }
            if (a2 > a1 && a2 < a3 && a1 < a3) { Console.WriteLine(a2); }
            if (a2 > a3 && a2 < a1 && a1 > a3) { Console.WriteLine(a2); }
            if (a3 > a1 && a3 < a2 && a2 > a1) { Console.WriteLine(a3); }

            if (a1 < a2 && a1 < a3) { Console.WriteLine(a1); }
            if (a2 < a1 && a2 < a3) { Console.WriteLine(a2); }
            if (a3 < a2 && a3 < a1) { Console.WriteLine(a3); }

            Console.ReadKey();
        }
    }
}
