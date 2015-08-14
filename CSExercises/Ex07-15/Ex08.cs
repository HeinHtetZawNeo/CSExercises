using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            double Centi, Faher;
            System.Console.Write("Enter centigrate : ");
            try
            {
                Centi =Convert.ToDouble(System.Console.ReadLine());
                Faher = 1.8 * Centi + 32;
                System.Console.WriteLine("Converted Fahrenheit is "+Faher);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("You Entered Wrong Number..");
            }
        }
    }
}
