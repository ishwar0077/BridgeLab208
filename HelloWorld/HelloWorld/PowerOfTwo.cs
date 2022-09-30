using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Power of 2
a. Desc -> This program takes a command-line argument N and prints a table of the
powers of 2 that are less than or equal to 2^N.
b. I/P -> The Power Value N. Only works if 0 <= N < 31 since 2^31 overflows an int
c. Logic -> repeat until i equals N.
*/

namespace HelloWorld
{
    public static class PowerOfTwo
    {
		public static void Power()
		{
			int num;
			int mul = 1;

			Console.WriteLine("Enter the number");
			num = Convert.ToInt32(Console.ReadLine());
			if (num >= 0 && num > 31) 
			{
				Console.WriteLine("value of number should be 0 to 30");
				
			}

			else 
			{
				Console.WriteLine(mul);
				for (int i = 1; i <= num; i++) {
					mul = mul * 2;
                    Console.WriteLine(mul);
				}
			}
		}
    }
}
