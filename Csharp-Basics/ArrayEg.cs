using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics
{
    class ArrayEg
    {
        static void Main()
        {
            // One Dimentional Array
            //data type[] arrname= new datatype [size];
            //data type[] arrname= new datatype [size];{}
            // new--allocates memory

            string[] flower = new string[4]; // 0,1,2,3

            flower[0] = "Lily";
            flower[1] = "rose";
            flower[2] = "Jasmine";
            flower[3] = "Lotus";

            Console.WriteLine(flower[0]);
            for (int i = 0; i < flower.Length ; i++)
            {
                Console.WriteLine("index{0}:{1}", i, flower[i]);
      
            }
            Console.WriteLine("Enter the Size");
            
            
            int size = Convert.ToInt32(Console.ReadLine());
            int[] marks = new int[size];
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine("Enter the Size{0}:", i);
                marks[i]= Convert.ToInt32(Console.ReadLine());
            }

                for (int i = 0; i < marks.Length; i++)
            {
             
                Console.WriteLine("index{0}:{1}", i, marks [i]);
            }
            Console.Read();

        }


    }
}
