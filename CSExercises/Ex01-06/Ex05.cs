using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Enter Number : ");
            try
            {
                double number = Convert.ToDouble(System.Console.ReadLine());
                System.Console.WriteLine("Answer is {0:0.000} ", Math.Sqrt(number));
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Wrong input");
            }
        }
    }
}
