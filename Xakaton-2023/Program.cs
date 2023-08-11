using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xakaton_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Вас зовут: "); Console.ReadLine();
            int age = 0;
            Console.Write("Вам лет: "); age = int.Parse(Console.ReadLine()); Console.Write($"Вам лет: {age}");
            Console.ReadKey();
        }
    }
}
