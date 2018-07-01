using System;

namespace ReverseAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the initial number: ");
                var inputString = Console.ReadLine();
                int input = int.Parse(inputString);

                int stepCount = 0;
                bool exitCondition = false;
                int reverse = Reverse(input);
                while (!exitCondition)
                {
                    stepCount += 1;

                    int sum = input + reverse;

                    var s = string.Format("{0}. {1} + {2} = {3}", stepCount, input, reverse, sum);
                    Console.WriteLine(s);
                    
                    input = sum;
                    reverse = Reverse(input);
                    exitCondition = (input == reverse);
                }

                Console.WriteLine();
            }
        }

        private static int Reverse(int n)
        {
            int r = 0;
            while (n > 0)
            {
                int digit = n % 10;
                r = r * 10 + digit;
                n = n / 10;
            }

            return r;
        }
    }
}


