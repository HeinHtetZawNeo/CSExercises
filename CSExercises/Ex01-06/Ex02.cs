using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Enter Number : ");
            int number = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Answer is " + number * number);
        }
    }
}
