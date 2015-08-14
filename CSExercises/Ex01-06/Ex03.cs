using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex03
    {
        public static void Main(string[] args)
        {
            try{
            System.Console.Write("Enter precision number :");
            double number = Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine("Answer is " + number * number);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Wrong input");
            }
        }
    }
}
