using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            double salary, Housing, travel;
            System.Console.Write("Enter Salary : ");
            try
            {
                salary = Convert.ToDouble(System.Console.ReadLine());
                Housing = ((salary/100)*10);
                travel = ((salary / 100) * 3);
                System.Console.WriteLine("\n\n\n\nSalary\t\t\t:" + salary);
                System.Console.WriteLine("Housing allowance\t:" + Housing);
                System.Console.WriteLine("Travel allowance\t:" + travel);
                System.Console.WriteLine("----------------");
                System.Console.WriteLine("Total\t\t\t:" + (salary+Housing+travel));
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("You Are Entering Wrong Number....");
            }
        }
    }
}
