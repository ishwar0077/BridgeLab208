using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public static class LeapYear
    {
        public static void leapYear()
        {
            int year;
            Console.WriteLine("Enter the year");
            string str = Console.ReadLine();
            int lenght = str.Length; //counting length of given number
            year = Convert.ToInt32(str); //converting the number sting into int
            if (lenght == 4)
            {
                if (year % 400 == 0)
                {
                    Console.WriteLine(year + " this year is leap year");
                }
                else if(year % 100 == 0)
                {
                    Console.WriteLine(year + " this year is not leap year");
                }
                else if(year % 4 == 0)
                {
                    Console.WriteLine(year + " this year is leap year");
                }
            }
            else
            {
                Console.WriteLine(year + "this year is not  leap year");
            }
         
     /*
            if (lenght == 4)
            {
                if(year %4 == 0 && year % 100 != 0 || year % 400 == 0) //logic for leap year
                {
                    Console.WriteLine( year + "this year is leap year" );
                }
                else
                {
                    Console.WriteLine( year + "this year is not  leap year" );
                }

            }
            else
            {
                Console.WriteLine("please enter the valid number");
            }
    */
        }

    }
}
