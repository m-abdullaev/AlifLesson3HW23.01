using System;

namespace AlifLesson3HW23._01
{
    class Program
    {
        static void Main(string[] args)
        {

            //task2

            //int A = Convert.ToInt32(Console.ReadLine());
            //int B = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;

            //for (int i = A; i <= B; i++)
            //{
            //    sum = sum + i;
            //}
            //Console.WriteLine(sum);
            //Console.WriteLine("------------");

            //for (int i = A; i <= B; i++)
            //{
            //    if (i % 2 == 1)
            //        Console.WriteLine(i);
            //}

            //-----------------------------------------------

            //task3

            //Rectangle
            //for (int i = 0; i <= 10; i++)
            //{
            //    for (int j = 0; j <= 40; j++)
            //    {
            //        if ((j == 0 || j == 40) || (i == 0 || i == 10))
            //            Console.Write("*");

            //        else
            //            Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            //triangle
            //var h = 8;
            //var w = 30;
            //var y = 1;
            //var x = 1;
            //Console.WriteLine("*");

            //y = 1;
            //while (y++ < h)
            //{ 
            //    Console.Write("*");

            //    var l = (int)w * y / h;
            //    x = 1;
            //    while (x++ < l - 3)
            //    {
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine("*");
            //}
            //x = 0;
            //while (x++ < w)
            //{
            //    Console.Write("*");
            //}

            //Equilateral triangle
            //int h = 5;
            //for (int i = 1; i <= h; i++)
            //{
            //    for (int k = h - 1; k >= i; k--)
            //    {
            //        System.Console.Write(" ");
            //    }
            //    for (int j = 1; j <= i; j++)
            //    {
            //        if ((j == 1 || i == j || i == h))
            //        {
            //            System.Console.Write("* ");
            //        }
            //        else
            //        {
            //            System.Console.Write("  ");
            //        }
            //    }
            //    System.Console.WriteLine();
            //}
            //System.Console.WriteLine();

            //Rhombus

            //int m3 = 7;
            //int f = m3 / 2 + 1;
            //for (int i = 1; i <= m3; i++)
            //{
            //    for (int j = 1; j <= m3; j++)
            //    {
            //        if ((j == f || j == m3 - f + 1))
            //        {
            //            System.Console.Write("*");
            //        }
            //        else
            //        {
            //            System.Console.Write(" ");
            //        }
            //    }
            //    if (i <= m3 / 2)
            //    {
            //        f--;
            //    }
            //    else
            //    {
            //        f++;
            //    }
            //    System.Console.WriteLine();
            //}

            //------------------------------------------------


            //task4

            //double P;
            //double sum = 1000;
            //int month = 0;
            //Console.Write("Persentage = ");
            //P = double.Parse(Console.ReadLine());
            //while (sum <= 1100)
            //{
            //    sum = sum + sum * (P / 100);
            //    month++;
            //}
            //Console.WriteLine($"Month = {month}");
            //Console.WriteLine($"Sum = {sum}");
            //Console.ReadKey();

            //------------------------------------------------
            //task6

            //Console.WriteLine("Please enter array size");
            //int userArrSize = Convert.ToInt32(Console.ReadLine());
            //double[] arr = new double[userArrSize];
            ////input
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Array[{i}] = ");
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //double max = arr[0];
            //double min = arr[0];
            //double sum = 0;
            //double mid = 0.0;
            //double odd = 0;
            //int count = 0;
            ////to print
            ////for (int i = 0; i < arr.Length; i++)
            ////{
            ////    Console.WriteLine($"Array[{i}] = {arr[i]}");
            ////}
            ////to find max and min number
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (max <= arr[i])
            //    {
            //        max = arr[i];
            //    }
            //    if (min >= arr[i])
            //    {
            //        min = arr[i];
            //    }
            //    sum += arr[i];
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    count++;
            //}
            //mid = sum / count;
            //Console.WriteLine($"Max number = {max}");
            //Console.WriteLine($"Min number = {min}");
            //Console.WriteLine($"Sum number = {sum}");
            //Console.WriteLine($"Mid number = {mid}");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 2 != 0)
            //    {
            //        Console.WriteLine($"arr[{i}] = " + arr[i]);
            //    }
            //}

            //--------------------------------------------------
            //task7
            //int[] number = new int[] { 1, 2, 3, 4, 5 };

            //for (int i = number.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(number[i]);
            //}

            //---------------------------------------------------
            //task8

            //int userSize = Convert.ToInt32(Console.ReadLine());
            //int[] number = new int[userSize];
            //Random rnd = new Random();
            //for (int i = 0; i < number.Length; i++)
            //{
            //    number[i] = rnd.Next(1000);
            //}
            //foreach (var numbers in number)
            //{
            //    Console.WriteLine(numbers);
            //}
            //var count = Convert.ToInt32(Console.ReadLine());
            //var index = Convert.ToInt32(Console.ReadLine());
            //int[] empty = new int[count];
            //for (int z = 0; z < empty.Length; z++)
            //{
            //    if (z + index < number.Length)
            //        empty[z] = number[z + index];

            //    else
            //        empty[z] = 1;
            //}
            //for (int z = 0; z < empty.Length; z++)
            //{
            //    Console.WriteLine(empty[z]);
            //}
        }
    }
}
