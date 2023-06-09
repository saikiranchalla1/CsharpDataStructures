namespace CsharpDataStructures
{
    internal class Arrays
    {
        static void Main1(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            int anInt = 0;

            anInt = 10;


            int[] employeeNos = { 1, 2, 3, 4, 5 };

            // 2 types: single dimensional vs multi-dimensional

            // <data_type>[] variableName = new <data_type>[size];

            int[] A = new int[5];

            A[0] = 10;
            A[1] = 20;
            A[2] = 30;
            A[3] = 40;
            A[4] = 50;

            int[] B = { 1, 2, 3, 4, 5, 6 };

            // for-loop

            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine($"A[{i}] is {A[i]}");
            }

            int[] C = new int[5];

            Console.WriteLine("Initial values of an int Array");
            for (int i = 0; i < C.Length; i++)
            {

                C[i] = i * 10;
                Console.WriteLine($"C[{i}] is {C[i]}");
            }

            Console.WriteLine("ForEach Demo");
            foreach (int i in C)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Methods on Arrays");

            int[] numbers = { 17, 28, 1, 2, 78, 199, 12, 23, 53 };

            Console.WriteLine("Sorted elements...");
            Array.Sort(numbers);

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Elements in reverse order");
            Array.Reverse(numbers);

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            int[] newNumbers = new int[numbers.Length];
            Console.WriteLine("Copy elements");
            Array.Copy(numbers, newNumbers, numbers.Length);

            foreach (int i in newNumbers)
            {
                Console.WriteLine(i);
            }

            // 2-D arrays: Rectangular arrays

            // int[,] matrix = new int[3, 3];

            Console.WriteLine("2-d Rectangular Arrays");
            int[,] matrix = 
                {
                {1,2,3 },
                {4,5,6}, 
                {7, 8, 9}
            };

            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    Console.WriteLine(matrix[row, column]);
                }

                Console.WriteLine("-------");
            }

            Console.WriteLine("Dynamic Initialization of 2-D Array");

            int[,] rectangularArray = new int[4, 4];

            Console.WriteLine("Default values:");

            foreach (int i in rectangularArray)
            {
                Console.WriteLine(i + " ");
            }

            for (int i = 0; i < rectangularArray.GetLength(0); i++)
            {
                for (int j = 0; j < rectangularArray.GetLength(1); j++)
                {
                    rectangularArray[i, j] = i * j + 1;
                }
            }

            Console.WriteLine("After assinging random values");
            for (int i = 0; i < rectangularArray.GetLength(0); i++)
            {
                for (int j = 0; j < rectangularArray.GetLength(1); j++)
                {
                    Console.WriteLine(rectangularArray[i, j]);
                }
            }

            // 1. Adding two matrices (should have same dimensions)
            // 2. multiply two matrices

            Console.WriteLine("Jagged Array");

            // <data_type>[][] name new <data_type>[rows][];

            int[][] arr = new int[5][];

            arr[0] = new int[5];
            arr[1] = new int[1];
            arr[2] = new int[2];
            arr[3] = new int[5];
            arr[4] = new int[10];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = i * j;
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
                Console.WriteLine("-------------");
            }

            // arr[1][0] = "123";


        }
    }
}