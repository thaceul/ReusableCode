using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedMath3448;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            input = Convert.ToInt32(Console.ReadLine());
            Calculator.Factorial(input);
        }
    }
}
