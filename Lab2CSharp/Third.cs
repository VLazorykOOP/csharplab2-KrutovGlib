using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2CSharp
{
    internal class Third
    {
        

        public void third()
        {
            Console.Write("Enter size of arr (n): ");
            int n = int.Parse(Console.ReadLine());

            int[,] array = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine($"Enter [{i},{j}] element :");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Array: ");
            PrintArray(array);

            if (n % 2 == 0)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n - 1; j += 2)
                    {
                        SwapColumns(array, i, j, j + 1);
                    }
                }
                Console.WriteLine("Array after swaping:");
                PrintArray(array);
            }
            else
            {
                Console.WriteLine("");
            }
        }
        static void PrintArray(int[,] array)
        {
            int n = array.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        static void SwapColumns(int[,] array, int row, int col1, int col2)
        {
            int temp;
            int n = array.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                temp = array[row, col1];
                array[row, col1] = array[row, col2];
                array[row, col2] = temp;
            }
        }

    }

   
}
