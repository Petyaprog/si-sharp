using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For__array__metod
{
    internal class Program
    {
        static void Sum(int[] array, int n)
        {
            for (int i = 1; i < n; i++) 
            {
                if (array[i] < 0)
                {
                    array[i] = 0;
                }
            }  
        }

        static void Conclusion(int[] array, int n)
        {
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine($"{i} элемент");
                Console.WriteLine(array[i]);
            }
        }

        static void Addition(int[] array, int n, int kol)
        {
            for (int i = 1; i < n; i++) 
            {
                if (array[i] != 0) 
                {
                   kol = kol + array[i]; 
                   
                }
            }
            Console.WriteLine(kol);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("В одномерном массиве отрицательные числа меняет на ноль и складывает оставшиеся числа");
            Console.WriteLine("Введите кол-во элементов массива");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 1; i < n; i++) 
            {
                Console.WriteLine($"{i} элемент");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("=================");

            Sum(array, n);

            Conclusion(array, n);

            Console.WriteLine("=================");

            Addition(array, n, 0);

            Console.ReadLine();
        }
    }
}
