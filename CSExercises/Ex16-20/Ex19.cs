using System;
namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            double dist,total_cost,temp;
            try
            {
                Console.Write("Enter Distance : ");
                dist = Convert.ToDouble(Console.ReadLine());
                dist *= 10;
                dist = Math.Ceiling(dist);
                if (dist < 6)
                {
                    total_cost = 2.4;
                }
                else if (dist <= 90)
                {
                    temp = dist - 0.5;
                    Console.WriteLine("dist " + dist);
                    Console.WriteLine("temp " + temp);
                    total_cost = 2.4 + (temp * 0.04);
                }
                else
                {
                    temp = dist - 90;
                    Console.WriteLine("dist " + dist);
                    Console.WriteLine("temp " + temp);
                    total_cost = 2.4 + 3.4 + (temp*0.05);
                }
                Console.WriteLine(total_cost+"0");
            }
            catch (Exception ex)
            {
                Console.WriteLine("You input is wrong....");
            }
        }
    }
}