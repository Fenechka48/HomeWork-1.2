using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите показания температуры: ");
            double temperature = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Выберите шкалу Цельсия или шкалу Фарингейта: ");
            char scale = Convert.ToChar(Console.ReadLine());
        }
    }
}
