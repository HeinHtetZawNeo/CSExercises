using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            int input, temp, a,b,c;
            System.Console.Write("Enter 3 digit - ");
            try
            {
                input = Convert.ToInt32(System.Console.ReadLine());
                if (input > 1000)
                {
                    System.Console.WriteLine("Please Enter only 3 digit");
                }
                else
                {
                    temp = input;
                    a = input % 10;
                    temp -= a;
                    b = (input % 100) / 10;
                    temp -= b;
                    c = temp / 100;
                    System.Console.WriteLine("3rd no - " +a);
                    System.Console.WriteLine("2nd no - " +b);
                    System.Console.WriteLine("1st no - " +c);
                    System.Console.WriteLine("Armstrong Number - {0}",(a*a*a+b*b*b+c*c*c));
                }

            }
            catch (Exception ex)
            {
                System.Console.WriteLine("You entered wrong input...");
            }
        }
    }
}