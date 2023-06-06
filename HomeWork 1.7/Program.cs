using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                int buffer;
                buffer = num1;
                num1 = num2;
                num2 = buffer;
            }

            for (int i = num1; i <= num2; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
