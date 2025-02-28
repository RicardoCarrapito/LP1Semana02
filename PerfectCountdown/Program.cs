using System;

namespace PerfectCountdown
{
    public class Program
    {
        private static void Main(string[] args)
        {

            int start;
            int step;
            int x;
            do
            {
                Console.WriteLine("Start number:");
                string str1 = Console.ReadLine();
                start = int.Parse(str1);

                Console.WriteLine("Step number:");
                string str2 = Console.ReadLine();
                step = int.Parse(str2);


                if (start < 1)
                {
                    Console.WriteLine("Out-of-range start or step. Try again.");
                }
                else if (step < 1)
                {
                    Console.WriteLine("Out-of-range start or step. Try again.");
                }
                else if (step >= start)
                {
                    Console.WriteLine("Start must be higher than step. Try again.");
                }

                else if (start % step > 0)
                {
                    Console.WriteLine("Start not divisible by step. Try again.");
                }
                else
                {
                     x =start-step;
                    Console.WriteLine(x);
                }

            } while (start >= 0);

        }
    }
}
