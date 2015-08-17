using System;

namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            try
            {
                int mark;
                Console.Write("Enter mark : ");
                mark = Convert.ToInt32(Console.ReadLine());
                if (mark < 0 || mark >100)
                {
                    System.Console.WriteLine("**Error**");
                }else if(mark<40){
                    System.Console.WriteLine("You scored {0} makrs which is {1} grade.", mark, "F");
                }
                else if (mark < 60)
                {
                    System.Console.WriteLine("You scored {0} makrs which is {1} grade.", mark, "C");
                }
                else if (mark < 80)
                {
                    System.Console.WriteLine("You scored {0} makrs which is {1} grade.", mark, "B");
                }
                else if (mark <=100)
                {
                    System.Console.WriteLine("You scored {0} makrs which is {1} grade.", mark, "A");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("You enterd wrong input...");
            }
        }
    }
}