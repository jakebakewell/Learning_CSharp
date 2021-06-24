using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Loop from 1 to 255
            Console.WriteLine("********** Loop 1-255");
            for (int i = 1; i < 256; i++) {
                Console.WriteLine(i);
            }
            //Loop through 1-100 and print all values that are divisible by 3 or 5 but not both
            Console.WriteLine("Loop through 1-100 printing multiples");
            for (int i = 1; i < 101; i++) {
                if(!(i % 5 == 0 && i % 3 == 0)) {
                    if(i % 5 == 0 || i % 3 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            // Same as previous 1-100 loop but print fizz and buzz instead
            Console.WriteLine("Loop through 1-100 printing fizz and buzz for multiples");
            for (int i = 1; i < 101; i++) {
                if (i % 15 == 0) {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0) {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0) {
                    Console.WriteLine("Buzz");
                }
            }
            //Same loops as above but using while instead of for
            Console.WriteLine("********** While Loop 1-255");
            int j = 1;
            while (j < 256) {
                Console.WriteLine(j);
                j++;
            }
            Console.WriteLine("Loop through 1-100 printing multiples");
            j = 1;
            while (j < 101) {
                if(!(j % 5 == 0 && j % 3 == 0)) {
                    if(j % 5 == 0 || j % 3 == 0)
                    {
                        Console.WriteLine(j);
                    }
                }
                j++;
            }
                Console.WriteLine("Loop through 1-100 printing fizz and buzz for multiples");
                j = 1;
            while (j < 101) {
                if (j % 15 == 0) {
                    Console.WriteLine("FizzBuzz");
                }
                else if (j % 3 == 0) {
                    Console.WriteLine("Fizz");
                }
                else if (j % 5 == 0) {
                    Console.WriteLine("Buzz");
                }
                j++;
            }
        }
    }
}
