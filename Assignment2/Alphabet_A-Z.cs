using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Alphabet_A_Z
    {
        static void Main()
        {

            char i='A';
            Console.WriteLine(" Alphabets A to Z:");
            while (i<= 'Z')
            {
                Console.Write("{0} ", i);
                i++;
            }
            Console.Read();

        }
    }
}
