using System;

namespace zadanko_domowe
    //ten kod generuje loswa liczbe z prime numbers
{
    class losowanie_liczb
    {
        public static void Main()
        {
            int liczby;
            while ((liczby = int.Parse(Console.ReadLine())) != 42069)
            {
                int counter = 0;
                int kulturoznawstwo = 0;
                while (counter <= liczby)
                {
                    if (isPrime(kulturoznawstwo))
                    {
                        Console.Write(kulturoznawstwo + " ");
                        counter++;
                    } 
                    kulturoznawstwo++;
                }
                Console.WriteLine();
            }
        } // algorytm
        static bool isPrime(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}