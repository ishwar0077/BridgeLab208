using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public static class FlipCoin
    {
        public static void CalFlipCoin()
        {
            Console.WriteLine("Please Enter the value for number of flip");
            int HeadCount = 0;
            int TailCount = 0;
            double HeadPercentage;
            double TailPercentage;
            int flipCoin = Convert.ToInt32(Console.ReadLine());
            if(flipCoin > 0)
            {
                for(int i =0; i < flipCoin; i++)
                    {
                        Random random = new Random();
                        int number = random.Next(2);
                        Console.WriteLine("The random number is: " + number);
                        if(number == 0)
                        {
                            HeadCount++;
                        }
                        else
                        {
                            TailCount++;
                        }
                    }
                Console.WriteLine("Total Head count is: " + HeadCount);
                Console.WriteLine("Total Tail count is: " + TailCount);
                HeadPercentage = HeadCount * 100 / flipCoin;
                TailPercentage = TailCount * 100 / flipCoin;
                Console.WriteLine("Total Head count percentage is: " + HeadPercentage);
                Console.WriteLine("Total Tail count percentage is: " + TailPercentage );
            }
        }
    }
}
