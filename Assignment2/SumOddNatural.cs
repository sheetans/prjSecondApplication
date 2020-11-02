using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class SumOddNatural
    {
        static void Main()
        {
            int i, n, sum=0;
            Console.Write("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i<= n; i++)
            {  
                Console.Write("{0} ", (2*i-1));
                sum = sum + (2*i-1);
            }
            
            Console.WriteLine("The Sum of odd Natural Number : {0}", sum);
            Console.Read();
        }
    }
}
