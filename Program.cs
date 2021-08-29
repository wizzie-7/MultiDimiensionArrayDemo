using System;

namespace MultiDimiensionArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int r;
            //int c;
            ////int size1, size2;
            ////int[,] Arr1 = new int[99, 99];
            ////int[,] Arr2 = new int[99, 99];


            //Console.WriteLine("Enter size of row :");
            //int size1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter size of colomn :");
            //int size2 = Convert.ToInt32(Console.ReadLine());
            //int[,] Arr1 = new int[size1, size2];
            //for (r = 0; r <= size1 - 1; r++)
            //{
            //    for (c = 0; c <= size2 - 1; c++)
            //    {
            //        Console.WriteLine("Enter the [" + r + "," + c + "]  in 1st Array :");
            //        Arr1[r, c] = Convert.ToInt32(Console.ReadLine());
            //    }

            //}


            //int[,] Arr2 = new int[size1, size2];
            //for (r = 0; r <= size1 - 1; r++)
            //{
            //    for (c = 0; c <= size2 - 1; c++)
            //    {
            //        Console.WriteLine("Enter the [" + r + "," + c + "]  in ND Array :");
            //        Arr2[r, c] = Convert.ToInt32(Console.ReadLine());
            //    }

            //}

            //Console.Write("\nMatrices A: \n");
            //for (r = 0; r < size1; r++)
            //{
            //    Console.Write("\n");
            //    for (c = 0; c < size2; c++)
            //    {
            //        Console.Write("{0}\t", Arr1[r, c]);
            //    }

            //}
            //Console.Write("\n\n");

            //Console.Write("\nMatrices B: \n");
            //for (r = 0; r <= size1 - 1; r++)
            //{
            //    Console.Write("\n");
            //    for (c = 0; c < size2; c++)
            //    {
            //        Console.Write("{0}\t", Arr2[r, c]);
            //    }

            //}
            //Console.Write("\n\n");
            AdditionOfTwoDimensArr ads = new AdditionOfTwoDimensArr();
            ads.GetInput();
            ads.Addition();
            ads.PrintAddtion();


        }
    }
    public class AdditionOfTwoDimensArr
    {
        int r;
        int c;
        int siz1;
        int siz2;
        int[,] Arr1 = new int[99,99];
        int[,] Arr2 = new int[99, 99];
        int[,] Arr3 = new int[99, 99];
        public void GetInput()
        {
            Console.WriteLine("Enter size of row :");
            int siz1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter size of colomn :");
            int siz2 = Convert.ToInt32(Console.ReadLine());
            //int[,] Arr1 = new int[siz1, siz2];
            for (r = 0; r <= siz1 - 1; r++)
            {
                for (c = 0; c <= siz2 - 1; c++)
                {
                    Console.WriteLine("Enter the [" + r + "," + c + "]  in 1st Array :");
                    Arr1[r, c] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //int[,] Arr2 = new int[siz1, siz2];
            for (r = 0; r <= siz1 - 1; r++)
            {
                for (c = 0; c <= siz2 - 1; c++)
                {
                    Console.WriteLine("Enter the [" + r + "," + c + "]  in 2nd Array :");
                    Arr2[r, c] = Convert.ToInt32(Console.ReadLine());
                }

            }

        }
        public void Addition()
        {
            
            //int[,] arr3 = new int[siz1, siz2];
            for (r = 0; r <= siz1 - 1; r++)
            {
                for (c = 0; c <= siz2 - 1; c++)
                {
                    Arr3[r, c] = Arr1[r, c] + Arr2[r, c];
                }
            }
            
        }
        public void PrintAddtion()
        {
            Console.Write("\nMatrices A: \n");
            for (r = 0; r <= siz1-1; r++)
            {
                Console.Write("\n");
                for (c = 0; c < siz2-1; c++)
                {
                    Console.Write("{0}\t", Arr1[r, c]);
                }

            }
            Console.Write("\n\n");

            Console.Write("\nMatrices B: \n");
            for (r = 0; r <= siz1 - 1; r++)
            {
                Console.Write("\n");
                for (c = 0; c <= siz2-1; c++)
                {
                    Console.Write("{0}\t", Arr2[r, c]);
                }

            }
            Console.Write("\n\n");
            Console.Write("\nMatrices B: \n");
            for (r = 0; r <= siz1-1 ; r++)
            {
                Console.Write("\n");
                for (c = 0; c <= siz2-1 ; c++)
                {
                    Console.Write("{0}\t", Arr3[r, c]);
                }

            }
            Console.Write("\n\n");
        }



    }
}
