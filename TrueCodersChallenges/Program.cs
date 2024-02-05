using System;

namespace TrueCodersChallenges;
class Program
{
    static void Main(string[] args)
    {
        FebruaryChallenge challenge1 = new FebruaryChallenge();

        challenge1.ReportFactorial(5);

        Console.WriteLine();
        Console.WriteLine();

        challenge1.ReportFactorial(10);
    }
}

