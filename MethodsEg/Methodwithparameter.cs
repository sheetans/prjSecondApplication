using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsEg
{
    class Methodwithparameter
    {
        void ByValue (string p)
        {
            p = " 00000000000";
            Console.WriteLine("Value changed inside method: ph: {0}", p);
        
        }
        void ByReference(ref string ph)
        {
            ph = "11111111111";
            Console.WriteLine("Value changed inside method: ph: {0}", ph);
        }

        static void Main()
        {
            string phno = "998765432";
            Methodwithparameter mobj = new Methodwithparameter();
            Console.WriteLine("Before calling byvalue method: phno: {0}", phno);
            mobj.ByValue(phno);
            Console.WriteLine("After calling byvalue method: phno: {0}", phno);
            Console.WriteLine("----------------");
            Console.WriteLine("before calling byreference method:phno:{0}",phno);
            mobj.ByReference(ref phno);
            Console.WriteLine("After calling byreference method:phno:{0}", phno);
            Console.Read();




        }
    }
}
