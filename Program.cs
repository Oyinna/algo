using System;

namespace algo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // windowSlide
            int [] arr = {1, 4, 2, 10, 23, 3, 1, 0, 20};
            int k = 4;
            int n = arr.Length;

            WindowSlide windowSlide = new WindowSlide();

            Console.WriteLine(windowSlide.maxSumBruteForce(arr, n, k));
            Console.WriteLine(windowSlide.maxSumWindowSliding(arr, n, k));


            
            string Str = "cbbebi";
            int K = 3;
            LongestSubstring longestSubstring = new LongestSubstring();
            Console.WriteLine(longestSubstring.longestSubstringBruteForce(Str, K));
        }
    }
}
