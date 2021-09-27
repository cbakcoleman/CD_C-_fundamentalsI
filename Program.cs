using System;

namespace cd_c__fundamentalsI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Create a loop that prints all values from 1-255
            for (int i = 1; i <= 255; i++)
            {
                System.Console.WriteLine(i);
            }

            // Create a new loop that prints all values from 1-100 that are divisible by 3 or 5 but not both
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    System.Console.WriteLine(i);
                }
                else if (i % 5 == 0 && i % 3 != 0) 
                {
                    System.Console.WriteLine(i);
                }
            }

            // Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multips of both 3 and 5
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    System.Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0 && i % 3 != 0) 
                {
                    System.Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    System.Console.WriteLine("FizzBuzz");
                }
            }

            // (Optional) If you used "for" loops for your solution, try doing the same with "while" loops. Vice-Versa if you  used "while" loops!
            // Create a loop that prints all values from 1-255
            int j = 1;
            while (j < 256)
            {
                System.Console.WriteLine(j);
                j++;
            }

            // Create a new loop that prints all values from 1-100 that are divisible by 3 or 5 but not both
            int k = 1;
            while (k < 101)
            {
                if (k % 3 == 0 && k % 5 != 0)
                {
                    System.Console.WriteLine(k);
                    k++;
                }
                else if (k % 5 == 0 && k % 3 != 0)
                {
                    System.Console.WriteLine(k);
                    k++;
                }
                else 
                {
                    k++;
                }
            }
            
            // Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multips of both 3 and 5
            int f = 1;
            while (f < 101)
            {
                if (f % 3 == 0 && f % 5 != 0)
                {
                    System.Console.WriteLine("Fizz");
                    f++;
                }
                else if (f % 5 == 0 && f % 3 != 0)
                {
                    System.Console.WriteLine("Buzz");
                    f++;
                }
                else if (f % 3 == 0 && f % 5 == 0)
                {
                    System.Console.WriteLine("FizzBuzz");
                    f++;
                }
                else 
                {
                    f++;
                }
            }

        }
    }
}
