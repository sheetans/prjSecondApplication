using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class ReverseNaturalNo
    {
        static void Main()
        {
            int i, n;
            Console.WriteLine("Enter the no");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Natural number in reverse Order");
            for (i=n; i>=1; i--)
            {
                
                Console.WriteLine( "{0}",i);
            }
            Console.Read();
        }
    }
}
