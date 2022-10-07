using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Program
    {
        public static void Uravnenie(double a, double b, double c)
        {
            double D = (b * b) - (4 * a * c);
            if (D < 0)
            {
                Console.WriteLine("Корней нет");
            }
            else
            {
                if (D == 0)
                {
                    double x = (-b) / a / 2;
                    Console.WriteLine("Корень: " + x);
                }
                else
                {
                    double x1 = ((-b) + Math.Sqrt(D)) / a / 2;
                    double x2 = ((-b) - Math.Sqrt(D)) / a / 2;
                    Console.Write($"Корни: {x1}, {x2}");
                }
            }
        }
        public static int Index(int[] numbers, int a)
        {
            for (int i = 0; i < numbers.Length;  i++)
            {
                if (a == numbers[i])
                {
                    return i;
                }
            }
            return 100000000;
        }
        public static void Peremena(int[] numbers, int a, int b)
        {
            int d = Index(numbers, a);
            int e = Index(numbers, b);
            numbers[d] = b;
            numbers[e] = a;
            for (int i = 0; i < 10; i++)
            {
                if (i < 9)
                {
                    Console.Write(numbers[i] + " ");
                }
                if (i == 9)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }
        static void Sort12(int[] mas)
        {
            int a;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        a = mas[i];
                        mas[i] = mas[j];
                        mas[j] = a;
                    }
                }
            }
            for (int i = 0; i < mas.Length; i++)
            {
                if (i < 9)
                {
                    Console.Write(mas[i] + " ");
                }
                if (i == 9)
                {
                    Console.WriteLine(mas[i]);
                }
            }
        }
        static void Sort7(int[] mas)
        {
            int a;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        a = mas[i];
                        mas[i] = mas[j];
                        mas[j] = a;
                    }
                }
            }
            for (int i = 0; i < mas.Length; i++)
            {
                if (i < 9)
                {
                    Console.Write(mas[i] + " ");
                }
                if (i == 9)
                {
                    Console.WriteLine(mas[i]);
                }
            }
        }
        public static double[] Task4(params int[] numbers)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                a += numbers[i];
                b *= numbers[i];
            }
            int f = numbers.Length + 1;
            double c = a / f;
            double[] asd = { a, b, c };
            return asd;
        }
        public static void Task5(int a)
        {
            switch (a)
            {
                case 1:
                    Console.WriteLine(" # \n" + "## \n" + " # \n" + " # \n" + "###");
                    break;
                case 2:
                    Console.WriteLine(" # \n" + "# #\n" + "  #\n" + " # \n" + "###");
                    break;
                case 3:
                    Console.WriteLine("## \n" + "  #\n" + " # \n" + "  #\n" + "## ");
                    break;
                case 4:
                    Console.WriteLine("# #\n" + "# #\n" + "###\n" + "  #\n" + "  #");
                    break;
                case 5:
                    Console.WriteLine("###\n" + "#  \n" + "###\n" + "  #\n" + "## ");
                    break;
                case 6:
                    Console.WriteLine(" ##\n" + "#  \n" + "###\n" + "# #\n" + "###");
                    break;
                case 7:
                    Console.WriteLine("###\n" + "  #\n" + "  #\n" + " # \n" + " # ");
                    break;
                case 8:
                    Console.WriteLine("###\n" + "# #\n" + "###\n" + "# #\n" + "###");
                    break;
                case 9:
                    Console.WriteLine("###\n" + "# #\n" + "###\n" + "  #\n" + "## ");
                    break;
                case 0:
                    Console.WriteLine(" # \n" + "# #\n" + "# #\n" + "# #\n" + " # ");
                    break;
            }
            if (a < 0 || a > 9)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Задча 1");
            Console.Write("Введиет коэффициент а: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введиет коэффициент b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введиет коэффициент c: ");
            int c = int.Parse(Console.ReadLine());
            Uravnenie(a, b, c);

            Console.WriteLine("Задча 2");
            int[] numbers2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.Write("Введите число: ");
            int a2 = int.Parse(Console.ReadLine());
            Console.Write("Введите число: ");
            int b2 = int.Parse(Console.ReadLine());
            Peremena(numbers2, a2, b2);

            Console.WriteLine("Задча 3");
            int[] numbers3 = { 5, 7, 8, 1, 6, 3, 2, 10, 4, 9};
            Sort12(numbers3);

            Console.WriteLine("Задча 4");
            double[] asd = Task4(1, 2, 3, 4, 5);
            Console.Write(asd[0] + " ");
            Console.Write(asd[1] + " ");
            Console.WriteLine(asd[2]);

            Console.WriteLine("Задча 5");
            int a5 = int.Parse(Console.ReadLine());
            Task5(a5);

            Console.WriteLine("Задча 7");
            int[] numbers7 = {1, 3, 545,34,53,45,345, 435 };
            Sort7(numbers7);
        }
    }
}
