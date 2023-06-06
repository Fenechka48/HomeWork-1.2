using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую цифру: ");
            int one=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите вторую цифру: ");
            int two=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите третью цифру: ");
            int three=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите четвертую цифру: ");
            int four=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Получилось число: " + one + two + three + four);
        }
    }
}
