using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class SystemDate
    {
        DateTime Date()
        {
            DateTime n = DateTime.Now;
            return n;
        }
        static void Main()
        {
            SystemDate systemdate = new SystemDate();
            Console.Write("Current Date and Time is :{0} ", systemdate.Date());
            Console.Read();
        }

    }
        
}
