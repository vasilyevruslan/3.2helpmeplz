using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace васильев_3_._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double m, n;
            Console.WriteLine(" 2 ");
            Console.WriteLine(" Решение производится по формуле (m -...-...- n)   ");
            Console.WriteLine();
            Console.WriteLine(" Для этого необходимо ввести два числа: m и n ");
            Console.WriteLine();
            Console.WriteLine(" Введите m ");
            n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(" Введите n > m ");
            m = Convert.ToDouble(Console.ReadLine());
            while (m < n)
            {
                Console.Write("Неверное значение данной переменной! Повторите ввод ");
                Console.WriteLine();
                m = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine(" Квадрат разности чисел от m до n ");
        }
    }
}