using System;
namespace TrueCodersChallenges
{
	public class FebruaryChallenge
	{
		public FebruaryChallenge()
		{
		}

		public int Factorial(int n)
        {
            int fact = 1;
            for (int x = n; x > 0; x--)
            {
                fact *= x;
            }
            return fact;
        }

        public void ReportFactorial(int n)
        {
            Console.WriteLine($"The factorial of {n}");

            Console.Write("is ");
            for (int i = n; i > 1; i--)
            {
                Console.Write(i + " x ");
            }
            Console.WriteLine("1,");

            Console.WriteLine($"which is equal to {Factorial(n)}.");
        }
    }
}

