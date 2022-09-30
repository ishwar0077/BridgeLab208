using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Factors
a.Desc -> Computes the prime factorization of N using brute force.
b.I / P->Number to find the prime factors
c. Logic -> Traverse till i*i <= N instead of i <= N for efficiency.
d. O/P -> Print the prime factors of number N.*/

namespace HelloWorld
{
    public static class PrimeFactorization
    {
        public static void Factors()
        {
            int num;
            int count = 0;
            int flag = 0;
            Console.WriteLine("Enter a Number for prime factor : ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Prime Factors of {0} " , num );
            for (int i = 2; i < num; i++)
            {
                // check for divisibility
                if (num % i == 0)
                {
                    count = 0;
                    // check for prime number
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                            count++;
                    }
                    if (count == 2)
                    {
                        flag = 1;
                        Console.Write(i + " ");
                    }
                }
            }

            //if (flag == 0)
                //Console.Write("There is no Prime factor for {0} ", num);
        }
    }
    
}
