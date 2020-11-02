using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics
{
    class Two_DimensionalArray
    {
        static void Main()
        {
            Console.WriteLine("No of Row");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("No of Col");
            int col = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[row, col];
            for (int i = 0; i < row;i++)
            {
                for(int j=0; j< col; j++)
                {
                    Console.WriteLine("element in matrix - [{0},{1}] : ", i, j);
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(matrix[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.Read();


        }
    }
}
