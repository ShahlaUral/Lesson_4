using System.Text;

namespace Lesson_4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Arrays 
         

            //Console.WriteLine("Arrays");
            #region multiDimentionalArrays 
            //int[,] nums = { { 1, 34, 21, 5 }, { 12, 5, 2, 8 } };
            //int[,,] nums3Dim = { { { 2, 5, 8, 12, 4 } }, { { 9, 12, 11, 8, 17 } }, { {11, 32, 4, 78, 56 } } };

            //PrintArrays(nums);
            #endregion

            #region Jagged Arrays

            //int[][] jaggedArray = new int[3][];

            //jaggedArray[0] = [3, 2, 5, 6];
            //jaggedArray[1] = [12, 3, 22, 11, 22, 45, 66];
            //jaggedArray[2] = [1];

            //PrintJaggedArray(jaggedArray);

            #endregion
            #endregion


            //MultiDimentinal arrays
            //int[,] numbers = { { 1, 2, 3, 4 }, { 4, 5, 6 , 4} };
            ////Jagged Array
            //int[][] numbers1 = new int[3][];
            //numbers1[0] = [ 1 ,2 ,3 ,4 ,5 ,6];
            //numbers1[1] = [2, 3];
            //numbers1[2] = [4, 5, 6, 7];
            //for (int i = 0; i < numbers1.Length; i++)
            //{
            //    for (int j = 0; j < numbers1[i].Length; j++)
            //    {
            //        Console.Write(numbers1[i][j]+" ");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 0; i < numbers.GetLength(0); i++)
            //{
            //    for (int j = 0; j < numbers.GetLength(1); j++)
            //    {
            //        Console.Write(numbers[i,j]);
            //    }
            //    Console.WriteLine();
            //}


            #region Star case

            //try
            //{
            //    int row = int.Parse(Console.ReadLine());
            //    for(int i = 0; i < row; i++)
            //    {
            //        for(int j = 0; j < row; j++)
            //        {
            //            if (i <= j)
            //                Console.Write("* ");
            //            else
            //                Console.Write(" ");

            //        }
            //        Console.WriteLine();

            //    }
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Daxil etdiyiniz deyer eded deyil");
            //}



            #endregion


            #region foreach

            //int[] numbers = { 1, 2, 3, 4 };

            //foreach(int index in numbers)
            //{
            //    if (index % 2 == 0)
            //        Console.WriteLine("even");
            //    else
            //        Console.WriteLine("odd");

            //}


            #endregion


            //Jagged Array vs Multidimensional arrays 
            // JaggedArrayVsMultiDimentionalArrays jaggedArrayVsMulti = new JaggedArrayVsMultiDimentionalArrays();



        }

        private static void PrintJaggedArray(int[][] jaggedArray)
        {
            for(int i=0; i< jaggedArray.Length; i++)
            {
                for (int j=0; j< jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void PrintArrays(int[,] nums)
        {
            for(int i = 0; i< nums.GetLength(0); i++)
            {
                for(int j = 0; j< nums.GetLength(1); j++)
                {
                    Console.Write(nums[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
