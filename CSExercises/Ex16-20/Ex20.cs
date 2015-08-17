using System;
namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            int tv_qty, dvd_qty, mp3_qty, total;
            try
            {
                System.Console.Write("Enter qunatity for TV : ");
                tv_qty = Convert.ToInt32(Console.ReadLine());
                System.Console.Write("Enter qunatity for DVD : ");
                dvd_qty = Convert.ToInt32(Console.ReadLine());
                System.Console.Write("Enter qunatity for MP3 : ");
                mp3_qty= Convert.ToInt32(Console.ReadLine());
                if (tv_qty >= 0 && dvd_qty >= 0 && mp3_qty >= 0) { 
                total = (tv_qty * 900) + (dvd_qty * 500) + (mp3_qty * 700);
                Console.WriteLine(total);
                if (total > 5000 && total <10000)
                {
                    Console.WriteLine("10%");
                    total -= (total/100)*10;
                    Console.WriteLine("Total price for this order is $" + total);
                }
                else if (total > 10000)
                {
                    Console.WriteLine("15%");
                    total -= (total / 100) * 15;
                    Console.WriteLine("Total price for this order is $" + total);
                }
                }
                else
                {
                    Console.WriteLine("Qty should be positive...");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Your input is wrongs");
            }
        }
    }
}