using System;

namespace Looking_for_bananas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[4, 4] {
               {10, 33, 13, 15} ,
               {22, 21, 4, 1 } ,
               {5, 0, 2, 3},
               {0, 6, 14, 2},
            };

            FindMaxBananas obj = new FindMaxBananas(a);
            obj.findMaxBananas();
            Print2DArray(a);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade máxima de {obj.maxBananas}");

            Console.WriteLine("Path percorrrido");
            foreach (var path in obj.paths)
            {
                Console.WriteLine(path);
            }

            a = new int[3, 3] {
               {1, 3, 3} ,
               {2, 1, 4} ,
               {0, 6, 4}
            };

            obj = new FindMaxBananas(a);
            obj.findMaxBananas();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            Print2DArray(a);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade máxima de {obj.maxBananas}");

            Console.WriteLine($"Path percorrrido");
            foreach (var path in obj.paths)
            {
                Console.WriteLine(path);
            }

            a = new int[4, 4] {
               {1, 3, 1, 5} ,
               {2, 2, 4, 1} ,
               {5, 0, 2, 3},
               {0, 6, 1, 2},
            };

            obj = new FindMaxBananas(a);
            obj.findMaxBananas();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            Print2DArray(a);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade máxima de {obj.maxBananas}");

            Console.WriteLine($"Path percorrrido");
            foreach (var path in obj.paths)
            {
                Console.WriteLine(path);
            }

            Console.ReadLine();
        }

        public static void Print2DArray<T>(T[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
