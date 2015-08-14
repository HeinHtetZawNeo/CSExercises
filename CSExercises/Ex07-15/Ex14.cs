using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            double a, b, c, s, temp;
            try { 
                System.Console.Write("Enter a : ");
                a = Convert.ToDouble(System.Console.ReadLine());
                System.Console.Write("Enter b : ");
                b = Convert.ToDouble(System.Console.ReadLine());
                System.Console.Write("Enter c : ");
                c = Convert.ToDouble(System.Console.ReadLine());
                s =(a + b + c) / 2;
                temp = Math.Abs(s * (s - a) * (s - b)*(s - c)); //Math.Abs change the negative number into prositive number
                System.Console.WriteLine("Answer is " + Math.Sqrt(temp)); //if S is negative.. program doesnt work properly

            }
            catch (Exception ex)
            {
                System.Console.WriteLine("You have entered wrong number...");
            }
        }
    }
}