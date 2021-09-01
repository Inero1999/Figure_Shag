using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction (3,4);
            Fraction f2 = new Fraction(4, 3);
            WriteLine(f1 + f2);

        }
    }
}
