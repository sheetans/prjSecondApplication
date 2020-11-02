using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class CourseDetails
    {
        void DisplayingCourseDetails(string cn,int id,int fee)
        {

            Console.WriteLine("Cname:{0}||Cid:{1}||Feeamount:{2}", cn, id, fee);

        }

        static void Main()
        {
            string CName; int Cid, feeamount;
            Console.WriteLine("Enter Cname");
            CName = Console.ReadLine();
            Console.WriteLine("Enter Cid");
            Cid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter feeamount");
            feeamount = Convert.ToInt32(Console.ReadLine());
            CourseDetails coursedetails = new CourseDetails();
            coursedetails.DisplayingCourseDetails(CName, Cid, feeamount);
            Console.Read();
  
            
        }

    }
}
