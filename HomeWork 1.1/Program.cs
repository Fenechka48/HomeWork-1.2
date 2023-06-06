using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число в диапазоне от 0 до 100 :  ");
            string numberString = Console.ReadLine();
            int number;
            number = Convert.ToInt32(numberString);
            if (number < 0 || number > 100)
            {
                Console.WriteLine("Error");
            }
            else if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("Fizz Buzz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            Console.ReadLine();
        }
    }
}