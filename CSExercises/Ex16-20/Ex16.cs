using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            string name, gender;
            Console.Write("Enter Name : ");
            name = Console.ReadLine();
            Console.Write("Enter Gender(M/F) : ");
            gender = Console.ReadLine();
            if (gender == "M" || gender == "m")
            {
                Console.WriteLine("Good Morning Mr." + name);
            }
            else if (gender == "F" || gender == "f")
            {
                Console.WriteLine("Good Morning Miss." + name);
            }
            else
            {
                Console.WriteLine("You Input Wrong...");
            }
        }
    }
}