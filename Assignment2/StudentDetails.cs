using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    enum Grades
    {
        A = 10, B = 9, C = 8, D = 7, E = 6, F = 5
    }
    class Feedback
    {
        float Calculategrade(int[] marray)
        {
            int n;
            float p, sum = 0;
            for (int i = 0; i < marray.Length; i++)
            {
                sum = sum + marray[i];
            }
            n = marray.Length;
            p = (sum / (n));
            if (p > 90)
            {
                return (Convert.ToInt32(Grades.A));
            }
            else if (p > 80)
            {
                return (Convert.ToInt32(Grades.B));
            }
            else if (p > 70)
            {
                return (Convert.ToInt32(Grades.C));
            }
            else if (p > 60)
            {
                return (Convert.ToInt32(Grades.D));
            }
            else if (p > 50)
            {
                return (Convert.ToInt32(Grades.E));
            }
            else
            {
                return (Convert.ToInt32(Grades.F));
            }
        }



        void DisplayResultMethod(string sn, int sa, int[] list)
        {

            Console.WriteLine("The Student name: {0},  Student age:  {1}", sn, sa);
            Console.WriteLine("The grade:{0}", Calculategrade(list));

        }
        class StudentDetails
        {
            static void Main()
            {
                Console.WriteLine("Student name:");
                string name = Console.ReadLine();
                Console.WriteLine("Student age:");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("No. of subjects:");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] marks = new int[n];
                for (int i = 0; i < marks.Length; i++)
                {
                    Console.WriteLine("enter the value {0}:", i);
                    marks[i] = Convert.ToInt32(Console.ReadLine());
                }
                Feedback fd = new Feedback();
                fd.DisplayResultMethod(name, age, marks);
                Console.Read();
            }
        }
    }
}
