using System;

namespace OneCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.WriteLine("Напишите программу, чтобы найти значение указанного выражения");
            int a = (101 + 0) / 3;
            Console.WriteLine(a);
            double b = Math.Pow(3, -6) * 10000000.1;
            Console.WriteLine(b);
            bool c = true && true;
            Console.WriteLine(c);
            bool d = false && true;
            Console.WriteLine(d);
            bool e = (false && false) && (false && true);
            Console.WriteLine(e);
            bool f = (false && false) && (true && true);
            Console.WriteLine(f);

            Console.WriteLine("Напишите программу, которая принимает четыре целых числа от пользователя и выводит надпись равно, если все четыре равны, и не равно в противном случае");
            int a2, b2, c2, d2;
            Console.WriteLine("Напишите 4 числа");
            a2 = Convert.ToInt32(Console.ReadLine());
            b2 = Convert.ToInt32(Console.ReadLine());
            c2 = Convert.ToInt32(Console.ReadLine());
            d2 = Convert.ToInt32(Console.ReadLine());
            if (a2 == b2 && a2 == c2 && a2 == d2)
            {
                Console.WriteLine("равно");
            }
            else
            {
                Console.WriteLine("не равно");
            }

            Console.WriteLine("Напишите программу для поиска k самых больших элементов в заданном массиве. Элементы в массиве могут располагаться в любом порядке.");
            int[] a3 = new int[rnd.Next(1, 100 + 1)];
            for (int i = 0; i < a3.Length; i++)
            {
                a3[i] = rnd.Next(1, 100 + 1);
            }
            BubbleSort(a3);
            Console.WriteLine("Введите к");
            int k = Convert.ToInt32(Console.ReadLine());
            int k1 = a3.Length - k;
            for (int i = a3.Length - 1; i > k1 - 1; i--)
            {
                Console.Write(a3[i] + ",");
            }
            static void BubbleSort(int[] Array)
            {
                for (int i = 0; i < Array.Length; i++)
                {
                    for (int j = 0; j < Array.Length - 1; j++)
                    {
                        if (Array[j] > Array[j + 1])
                        {
                            int temp = Array[j];
                            Array[j] = Array[j + 1];
                            Array[j + 1] = temp;
                        }
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Напишите программу для поиска k наименьших элементов в заданном массиве. Элементы в массиве могут располагаться в любом порядке.");
            for (int i = 0; i < k; i++)
            {
                Console.Write(a3[i] + ",");
            }


            Console.WriteLine();
            Console.WriteLine("Напишите программу для умножения двух заданных целых чисел без использования оператора умножения(*).");
            Console.WriteLine("Введите целое первое число");
            int a6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите целое второе число");
            int b6 = Convert.ToInt32(Console.ReadLine());
            int c6 = 0;
            for (int i = 0; i < b6; i++)
            {
                c6 += a6;
            }
            Console.WriteLine(c6);

            Console.WriteLine("Напишите програмиу для преобразования температуры из градуса Фаренгейта в градус Цельсия.");
            Console.WriteLine("Напишите температуру в Фаренгейтах");
            double a8 = Convert.ToDouble(Console.ReadLine());
            double b8 = (a8 - 32) * 5 / 9;
            Console.WriteLine("C = {0}", b8);

            Console.WriteLine("Напишите, которая считывает число и отображает квадрат, куб и четвертую степень. ");
            Console.WriteLine("ЧИСЛО НАПИШИ");
            int a10 = Convert.ToInt32(Console.ReadLine());
            double b10 = Math.Pow(a10, 2);
            Console.WriteLine(b10);
            double c10 = Math.Pow(a10, 3);
            Console.WriteLine(c10);
            double d10 = Math.Pow(a10, 4);
            Console.WriteLine(d10);

            Console.WriteLine("Напишите программу для вычисления индекса массы тела (ИМТ). ИМТ = ВЕС / РОСТ2");
            Console.WriteLine("Напишите вес тела");
            double a9 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Напишите рост в  метрах");
            double b9 = Convert.ToDouble(Console.ReadLine());
            double c9 = a9 / b9;
            Console.WriteLine(c9 + "= имт");

            Console.WriteLine("Напишите для разбиения заданного массива целых чисел на четное число первым и нечетное число вторым.");
            int[] b7 = new int[a3.Length];
            int[] c7 = new int[a3.Length];
            for (int i = 0; i < a3.Length; i++)
            {
                double a7 = a3[i] % 2;
                if (a7 != 0)
                {
                    b7[i] = a3[i];
                }
                else
                {
                    c7[i] = a3[i];
                }
            }
            Console.WriteLine("Не чётные ==");
            foreach (int i in b7)
            {
                if (i != 0)
                {
                    Console.Write(i + ", ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Чётные ==");
            foreach (int i in c7)
            {
                if (i != 0)
                {
                    Console.Write(i + ", ");
                }
            }

            Console.WriteLine("Напишите программу, чтобы проверить, могут ли три заданные длины сторон (целые числа) образовать треугольник или нет.");
            Console.WriteLine("Напишите 3 стороны");
            int a11 = Convert.ToInt32(Console.ReadLine());
            int b11 = Convert.ToInt32(Console.ReadLine());
            int c11 = Convert.ToInt32(Console.ReadLine());
            if (a11 + b11 > c11 || a11 + c11 > b11 || c11 + b11 > a11)
            {
                Console.WriteLine("могут");
            }
            else
            {
                Console.WriteLine("не могут");
            }


            Console.WriteLine("Напишите программу для поиска чисел, превышающих среднее значение чисел данного массива.");

            int[] a12 = new int[rnd.Next(1, 100 + 1)];
            int b12 = 0;
            double c12;

            for (int i = 0; i < a12.Length; i++)
            {
                a12[i] = rnd.Next(1, 100 + 1);
                b12 += a12[i];
            }

            foreach (int i in a12)
            {
                Console.Write(i + " ");
            }

            c12 = b12 / a12.Length;

            Console.WriteLine("\n" + c12 + "\n");


            foreach (int i in a12)
            {
                if (i > c12)
                {
                    Console.Write(i + " ");
                }
            }








        }
    }
}
