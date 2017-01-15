/*
PolandBall is a young, clever Ball. He is interested in prime numbers. He has stated a following hypothesis: 
"There exists such a positive integer n that for each positive integer m number n·m + 1 is a prime number".
Unfortunately, PolandBall is not experienced yet and doesn't know that his hypothesis is incorrect. Could you prove it wrong? 
Write a program that finds a counterexample for any n.
Input
The only number in the input is n (1 ≤ n ≤ 1000) — number from the PolandBall's hypothesis.
Output
Output such m that n·m + 1 is not a prime number. 
Your answer will be considered correct if you output any suitable m such that 1 ≤ m ≤ 103. It is guaranteed the the answer exists.
 */



using System;

class PolandBallandHypothesis
{

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        for (int m = 1; m <= 1000; m++)
        {
            for (int j = 1; j <= n; j++)
            {
                int num = (n * m + 1);
                if (num%j==0 && j!=1 && num!=j)
                {
                    Console.WriteLine(m);
                    return;
                }

            }
        }
    }

}
