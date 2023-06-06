using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int number=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите проент: ");
            int percent=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(number * percent * 0.01);
        }
    }
}
