using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class ReverseNo
    {
        static void Main()
        {
            int n, remainder, reverse = 0;
            Console.WriteLine(" Enter Number");
            n = Convert.ToInt32(Console.ReadLine());
            while(n>0)
            {
                remainder = n % 10;
                reverse = reverse * 10 + remainder;
                n = n / 10;
            }
            Console.WriteLine(" The Reverse Number is:{0}", reverse);
            Console.Read();
        }
    }
}
