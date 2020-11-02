using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment2
{
    class DigitCounting
    {
        static void Main()
        {
            int m = 0, i;
            Console.WriteLine("Enter  number:");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                i = n % 10;
                if (i > 0)
                {
                    m = m + 1;
                }
                n = n / 10;
            }
            Console.WriteLine("number of digits:{0}", m);
            Console.Read();
        }
    }
}

