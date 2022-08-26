//Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и 
//предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21
using System;
class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int s = 9;
        int[] a = new int[s];
        for (int i = 0; i < s; i++)
            a[i] = random.Next(100);
        Console.Write("[");
        {
            for (int i = 0; i < s; i++)
                Console.Write($"{" "}{+a[i]}{","}");
        }
        Console.Write("]");
        Console.WriteLine("   ");

        int result = 0;
        int n = 0;
        Console.WriteLine("Результат умножения:  ");
        Console.Write("[");
        for (int i = 0; i < s - 1; i++)
        {
            if (i < s - 1)
                result = a[i] * a[s - 1 - n];
            n++;
            Console.Write($"{""}{+result}{","}");
            if (i == (s - n-2))
            break;
        }
        Console.Write("]");


    }

}