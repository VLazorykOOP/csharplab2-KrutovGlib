using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2CSharp
{
    internal class Fourth
    {
        public  void fourth() 
        {
            // Запит розмірності масиву
            Console.Write("Enter number of rows:  ");
            int n = int.Parse(Console.ReadLine());

            // Створення східчастого масиву
            int[][] jaggedArray = new int[n][];

            // Заповнення масиву даними
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter number of elements in {i + 1} row: ");
                int m = int.Parse(Console.ReadLine());
                jaggedArray[i] = new int[m];

                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Enter element [{i},{j}]: ");
                    jaggedArray[i][j] = int.Parse(Console.ReadLine());
                }
            }

            // Створення масиву для зберігання номерів перших від'ємних елементів
            int[] firstNegativeIndices = new int[n];

            // Знаходження номерів перших від'ємних елементів
            for (int i = 0; i < n; i++)
            {
                firstNegativeIndices[i] = FindFirstNegativeIndex(jaggedArray[i]);
            }

            // Виведення номерів перших від'ємних елементів на консоль
            Console.WriteLine("Numbers of firsts negative elements in array:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Рядок {i + 1}: {firstNegativeIndices[i]}");
            }
        }

        static int FindFirstNegativeIndex(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    return i;
                }
            }
            return -1; // Якщо немає від'ємних елементів, повертаємо -1
        }
    }
}
