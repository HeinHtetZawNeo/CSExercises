using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            double x, y;
            System.Console.Write("Enter x value : ");
            try
            {
                x = Convert.ToDouble(System.Console.ReadLine());
                y = (2*x*x)-(4*x)+3;
                System.Console.WriteLine("Ansewer is " + y);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("You Entered Wrong Number..");
            }   
        }
    }
}
