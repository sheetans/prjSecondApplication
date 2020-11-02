using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics
{

    enum Feedback
    {
        Poor=1,fair,good,excellent
    }
    class EnumerationEg
    {
        static void Main()
        {
            string Ename = " Sai";
            Console.WriteLine(" name:{0}||feedback:{1}", Ename, Feedback.good);
            Console.WriteLine(" name:{0}||feedback:{1}", Ename, (int)Feedback.good);
            Console.WriteLine(" name:{0}||feedback:{1}", Ename, Convert.ToInt32(Feedback.good));
            Console.Read();

        }

    }
}
