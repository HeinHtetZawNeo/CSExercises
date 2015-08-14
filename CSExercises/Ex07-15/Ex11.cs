using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Enter total kilmeter : ");
            try
            {
                double kilo = Convert.ToDouble(System.Console.ReadLine());
                System.Console.WriteLine("total price is {0}",2.4+(0.4*kilo));
            }
            catch (Exception ex)
            {

            }
        }
    }
}
