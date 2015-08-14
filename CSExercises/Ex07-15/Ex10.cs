using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            double x1, x2, y1, y2, distance;
            try
            {
                System.Console.Write("Enter x1 : ");
                x1 = Convert.ToDouble(System.Console.ReadLine());
                System.Console.Write("Enter y1 : ");
                y1 = Convert.ToDouble(System.Console.ReadLine());
                System.Console.Write("Enter x2 : ");
                x2 = Convert.ToDouble(System.Console.ReadLine());
                System.Console.Write("Enter y2 : ");
                y2 = Convert.ToDouble(System.Console.ReadLine());
                distance = Math.Sqrt(Math.Pow(x2 - x1, 2)+Math.Pow(y2-y1,2));
                System.Console.WriteLine("Distance between 2 points is "+distance);

            }catch(Exception ex){
                System.Console.WriteLine("wrong number");
            }
        }
    }
}
