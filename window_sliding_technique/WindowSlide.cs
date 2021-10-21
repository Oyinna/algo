/*  

This technique shows how a nested for loop in some problems can be converted to a single for loop to reduce the time complexity.
Let’s start with a problem for illustration where we can apply this technique – 

Given an array of integers of size ‘n’.
Our aim is to calculate the maximum sum of ‘k’ 
consecutive elements in the array.

Input  : arr[] = {100, 200, 300, 400}
         k = 2
Output : 700

Input  : arr[] = {1, 4, 2, 10, 23, 3, 1, 0, 20}
         k = 4 
Output : 39
We get maximum sum by adding subarray {4, 2, 10, 23}
of size 4.

Input  : arr[] = {2, 3}
         k = 3
Output : Invalid
There is no subarray of size 3 as size of whole
array is 2

*/


using System;
namespace algo
{
    class WindowSlide{
    // O(n*k) Brute Force Method
    public int maxSumBruteForce(int[] arr, int n, int k){

        if (n<k){
            Console.WriteLine("Invalid");
            return -1;
        }

        int max_sum = int.MinValue;

        for (int i = 0; i < (n-k+1); i++){
            int current_sum = 0;
            for(int j = 0; j<k; j++){
                current_sum = current_sum + arr[i+j];
            }

            max_sum = Math.Max(current_sum, max_sum);
        }

        return max_sum;

    }

    public int maxSumWindowSliding(int[] arr, int n, int k){
        if (n<k){
            Console.WriteLine("Invalid");
            return -1;
        }

        // compute first window of size k
        int max_sum = 0;
        for(int i=0; i<k; i++){
            max_sum+= arr[i];
        }

        // compute sum of remaining window by
        // removing first element of previous window and
        // adding last element of current window.
        int window_sum = max_sum;
        for(int i = k; i<n; i++){
            window_sum += arr[i]-arr[i-k];
            max_sum = Math.Max(max_sum, window_sum);

        }
        return max_sum;

    }

    }

}
