using System;

namespace ConsoleApp2
{
    class Program
    {
        static int[][] Kopiuj(ref int[][] tablica)
        {
            tablica[0][0] = 0;
            tablica[1][1] = 0;
            tablica[2][2] = 0;
            tablica[1][1] = 0;
            tablica[3][2] = 0;

            return tablica;
        }
        static void Main(string[] args)
        {
            /*
            int[] x = { 1,2,3,4,5 };
            int[] y = new int[x.Length];

            for(int i=0; i< x.Length;i++)
            {
                y[i] = x[i];
            }

            x[2] = 100;

            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i]+" ") ;
            }

            Console.WriteLine();

            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(y[i]+" ");
            }
            */

            
            int[,] y =
            {
                {1,2,3,4,5 },
                {2,3,4,5,6 }
            };

            int[][] tab =
            {
                new int[]{ },
                new[]{1,3,2,1,4 },
                new[]{1,2 },
                new[]{1,2,3 },
                new[]{1,2,3,4 },
                new[]{1,2,3,4,5 },
            };

            //int[][] x = new int[3][];
            //x[0] = new int[] { 1, 2, 3 };
            //x[1] = new int[] { 3, 4, 5 };
            //x[2] = new int[] { 5, 6, 7 };

            Console.WriteLine("Przed kopiowaniem:");

            int[] x1 = new int[4] { 1, 2, 3, 4 };
            int[] x2 = new int[2] { 5, 6 };
            int[] x3 = new int[3] { 1, 2, 2 };
            int[] x4 = new int[4] { 5, 4, 3, 2 };
            int[][] x = new int[][] { x1, x2, x3, x4 };

            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x[i].Length; j++)
                {
                    Console.Write(x[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //int[][] z = new int[5][];
            //for (int i = 0; i < z.Length; i++)
            //{
            //    z[i] = new int[i + 1];
            //    for (int j = 0; j < z[i].Length; j++)
            //    {
            //        z[i][j] = i + j;

            //    }
            //}


            Kopiuj(ref x);
            Console.WriteLine("Po kopiowaniu:");
            //for (int i = 0; i < z.Length; i++)
            //{
            //    for (int j = 0; j < z[i].Length; j++)
            //    {
            //        Console.Write(z[i][j] + ", ");
            //    }
            //    Console.WriteLine();
            //}

            /*
            for (int i = 0; i < y.GetLength(0); i++)
            {
                for (int j = 0; j < y.GetLength(1); j++)
                {
                    Console.Write(y[i, j]);
                }
                Console.WriteLine();
            }
            */

            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x[i].Length; j++)
                {
                    Console.Write(x[i][j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
        