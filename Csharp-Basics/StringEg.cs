using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics
{
    class StringEg
    {
        static void Main()
        {
            string firstname = " Sheetanshu";
            Console.WriteLine(" Length of the String :{0}", firstname.Length);
            Console.WriteLine(" Converting to uppercase", firstname.ToUpper());
            Console.WriteLine(" Contains: {0}", firstname.Contains("tan"));
            Console.WriteLine(" Index s :{0}", firstname.IndexOf("s"));
            Console.Read();


        }
    }
}
