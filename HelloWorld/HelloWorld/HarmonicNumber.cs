using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Harmonic Number
a. Desc -> Prints the Nth harmonic number: 1 / 1 + 1 / 2 + ... +1 / N
(http://users.encs.concordia.ca/~chvatal/notes/harmonic.html).
b.I / P->The Harmonic Value N.Ensure N != 0
c.Logic->compute 1 / 1 + 1 / 2 + 1 / 3 + ... +1 / N
d.O / P->Print the Nth Harmonic Value.*/

namespace HelloWorld
{
    public static class HarmonicNumber
    {
        public static void Harmonic()
        {
            double result = 0, num = 0, j;
            int n;
            // INPUT DATA
            Console.WriteLine("enter the harmonic you want to find: ");
            n = Convert.ToInt32(Console.ReadLine());

           if(n != 0)
            {
                // COMPUTATION
                for (j = 1; j <= n; j++)
                {
                    num = num + (1 / j);
                    result = num;
                }
                Console.WriteLine("the value of harmonic no. " + n + " is: " + result);
            }

        }
    }
}
