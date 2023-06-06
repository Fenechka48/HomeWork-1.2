using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите шестизначное число: ");
            string numberString = Console.ReadLine();
            int numInt= Convert.ToInt32(numberString);

            if (numInt > 999999 || numInt < 100000)
            {
                Console.WriteLine("Error");
            }

            Console.WriteLine("Введите цифры, которые надо поменять местами в числе: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            char[] numberStringArr = numberString.ToCharArray();
            char temp1 = numberStringArr[num1 - 1];
            char temp2 = numberStringArr[num2 - 1];

            numberStringArr[num1 - 1] = temp2;
            numberStringArr[num2 - 1] = temp1;

            Console.WriteLine(numberStringArr);
            Console.ReadLine();
        }
    }
}
