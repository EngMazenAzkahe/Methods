using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        //static void SimpleMethod()
        //{
        //    Console.WriteLine("This is a Simple Method ......");
        //}
        //static int Add(int x,int y)
        //{
        //    int s = x + y;
        //    Console.WriteLine(s);
        //    return s;
        //}
        //static char GetGrade()
        //{
        //    float persent = GetPercentAvg();
        //    if (persent >= 80)
        //        return 'A';
        //    else if (persent >= 60)
        //        return 'B';
        //    else if (persent >= 40)
        //        return 'C';
        //    else
        //        return 'D';
        //}
        //static float GetPercentAvg()
        //{
        //    float totatMarks = GetTotal();
        //    float PercentAvg = totatMarks * 100 / 300;
        //    return PercentAvg;
        //}
        //static float GetTotal()
        //{
        //    Console.Write("Enter Marks 1 :");
        //    float marks1 = float.Parse(Console.ReadLine());
        //    Console.Write("Enter Marks 2 : ");
        //    float marks2 = float.Parse(Console.ReadLine());
        //    Console.Write("Enter Marks 3 : ");
        //    float marks3 = float.Parse(Console.ReadLine());
        //    float total = marks1 + marks2 + marks3;
        //    return total;
        //}


        static int AreaofRectangle(int W,int h)
        {
            int Area = W * h;
            Console.WriteLine("Area is : {0}", Area);
            return Area;
        }


        static void Main(string[] args)
        {
            AreaofRectangle( 10,15);
         
        


        }
    }
}
