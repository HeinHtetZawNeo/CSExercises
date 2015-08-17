using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            try { 
            string name, gender;
            int age;
            Console.Write("Enter Name : ");
            name = Console.ReadLine();
            Console.Write("Enter Gender(M/F) : ");
            gender = Console.ReadLine();
            Console.Write("Enter Age : ");
            age =Convert.ToInt32( Console.ReadLine());

            if (gender == "M" || gender == "m")
            {
                if (age >= 40)
                    Console.WriteLine("Good Morning Uncle "+name);
                else
                Console.WriteLine("Good Morning Mr." + name);
            }
            else if (gender == "F" || gender == "f")
            {
                if (age >= 40)
                    Console.WriteLine("Good Morning Aunty " + name);
                else
                Console.WriteLine("Good Morning Miss." + name);
            }
            else
            {
                Console.WriteLine("You Input Wrong...");
            }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Age should be the number....");
            }
        }
    }
}