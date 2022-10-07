using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._10._2022
{
    internal class Task1
    {
        public static void MaxNumber(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine("Наибольшее число: " + a);
            }
            else
            {
                Console.WriteLine("Наибольшее число: " + b);
            }
        }
        public static void Perestanovka(ref int a, ref int b)
        {
            Console.WriteLine(b + " " + a);
        }
        public static void Factorial(int a)
        {
            int b = 1;
            for (int i = 1; i <= a; i++)
            {
                b *= i;
            }
            Console.WriteLine(b);
        }
        public static int Factorial2(int a)
        {
            if (a == 1)
            {
                return 1;
            }
            else
            {
                return a * Factorial2(a - 1);
            }
        }
        public static void NOD(int a, int b, int c)
        {
            int d = Math.Min(a, Math.Min(b, c));
            int e = 0;
            for (int i = 1; i <= d; i++)
            {
                if (a % i == 0 & b % i == 0 & c % i == 0)
                {
                    e = i;
                }
            }
            Console.WriteLine($"Наименьший общий делитель чисел {a}, {b}, {c}: " + e);
        }
        public static int Fib(int a)
        {
            if (a == 1 || a == 2)
            {
                return 1;
            }
            else
            {
                return Fib(a - 1) + Fib(a - 2);

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1");
            Console.Write("Введите число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число: ");
            int b = int.Parse(Console.ReadLine());
            MaxNumber(a, b);

            Console.WriteLine("Задача 2");
            Console.Write("Введите число: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Введите число: ");
            int d = int.Parse(Console.ReadLine());
            Perestanovka(ref c, ref d);

            Console.WriteLine("Задача 3");
            Console.Write("Введите число: ");
            int e = int.Parse(Console.ReadLine());
            Factorial(e);

            Console.WriteLine("Задача 4");
            Console.Write("Введите число: ");
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial2(f));

            Console.WriteLine("Задача 5");
            Console.Write("Введите число: ");
            int g = int.Parse(Console.ReadLine());
            Console.Write("Введите число: ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("Введите число: ");
            int i = int.Parse(Console.ReadLine());
            NOD(g, h, i);

            Console.WriteLine("Задача 6");
            Console.Write("Введите число: ");
            int j = int.Parse(Console.ReadLine());
            Console.WriteLine(Fib(j));
        }
    }
}
