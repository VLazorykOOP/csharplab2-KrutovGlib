namespace Lab2CSharp
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Third third = new Third();
            third.third();
        }

        static void first()
        { // одновимірний
            Console.Write("1 - One-dimensional array" +"\n"+
                "2 - Matrix"+"\n");
            int choise = int.Parse(Console.ReadLine());

            if (choise == 1)
            {

                Console.Write("Enter size of arr: ");
                int arrSize = int.Parse(Console.ReadLine());
                int[] arr = new int[arrSize];
                for (int i = 0; i < arrSize; i++)
                {
                    Console.Write($"Enter {i + 1} element of arr: ");
                    arr[i] = int.Parse(Console.ReadLine());
                }
                int Sum = 0;
                for (int j = 0; j < arrSize; j++)
                {
                    if (arr[j] % 9 == 0)
                    {
                        Sum += arr[j];
                    }
                }
                Console.Write("Result = " + Sum);
            } 
            else if(choise == 2)
            { //двовимірний 
                Console.Write("Number of rows: ");
                int rows = int.Parse(Console.ReadLine());

                Console.Write("Number of columns: ");
                int columns = int.Parse(Console.ReadLine());

                int[,] array = new int[rows, columns];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write($"Enter element [{i},{j}]: ");
                        array[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                int sum = 0;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (array[i, j] % 9 == 0)
                        {
                            sum += array[i, j];
                        }
                    }
                }

                Console.WriteLine($"Result : {sum}");
            }

            static void second()
            {
                Console.Write("Enter size of arr: ");
                int size = int.Parse(Console.ReadLine());
                int[] arr = new int[size];
                for(int i = 0; i < size; i++)
                {
                    Console.Write($"Enter {i + 1} element: ");
                    arr[i] = int.Parse(Console.ReadLine()) ;
                }
                int result = 0;
                for(int i = 1; i < size; i++)
                {
                    if (arr[i] > arr[result])
                    {
                        result = i;
                    }
                }
                Console.WriteLine("Number of first max element = "+ result);
            }

        
        }
    }
}
