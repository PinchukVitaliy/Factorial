using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 2000;
            //Console.WriteLine("Factorial number: {0}", Factorial(x));
            //Console.WriteLine("Result count: {0}", ReversFactorial(Factorial(x)));

            Console.WriteLine("Enter factorial namber: ");
            BigInteger number = BigInteger.Parse(Console.ReadLine());

            int reversResult = ReversFactorial(number);
            Console.WriteLine("Revers factorial: {0}", number);

            if (reversResult == -1)
            {
                Console.WriteLine("Factorial number does not exist!!!");
            }
            else if (reversResult == -2)
            {
                Console.WriteLine("Out of range!!!");
            }
            else
            {
                Console.WriteLine("Result count: {0}", reversResult);
            }

            Console.ReadKey();
        }

        static BigInteger Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }

        static int ReversFactorial(BigInteger factorial)
        {
            int count = 1;
            while (factorial > count)
            {
                if (factorial % count == 1)
                {
                    return -1;  //factorial number does not exist
                }
                factorial /= count;
                ++count;
            }
            if (count == factorial)
            {
                return count;
            }
            if (1 <= count || count <= 2000)
            {
                return -2; //out of range
            }
            return -1;
        }
    }
}
