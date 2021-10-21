/*

Question
Given a string, find the length of the longest substring in it with no more than K distinct/unique characters.

Input: String="cbbebi", K=10 Output: 6

Input: String="araaci", K=1 Output: 2

An explanation on how to solve it
First, we will insert characters from the beginning of the string until we have K distinct characters in the HashMap.

These characters will constitute our sliding window. We are asked to find the longest such window 
having no more than K distinct characters. We will remember the length of this window as the longest window so far.

After this, we will keep adding one character in the sliding window (i.e., slide the window ahead) 
in a stepwise fashion.

In each step, we will try to shrink the window from the beginning if the count of distinct characters in the HashMap 
is larger than K. We will shrink the window until we have no more than K distinct characters in the HashMap. 
This is needed as we intend to find the longest window.

While shrinking, we’ll decrement the character’s frequency going out of the window and remove it from the HashMap 
if its frequency becomes zero.

At the end of each step, we’ll check if the current window length is the longest so far, and if so, 
remember its length.
espp : i03318536 i03318536
rise vise, bambu

*/

using System;
using System.Collections.Generic;

namespace algo{
    class LongestSubstring{
        
        public int longestSubstringBruteForce (string Str, int K){
            if(Str.Length < K){
                return Str.Length;
            }  

            // Dictionary<key,value>
            Dictionary<int, char> window = new Dictionary<int, char>();
            int distinct = 0;


            for(int i=0; i< Str.Length; i++) {
                if(!window.ContainsValue(Str[i])){
                    distinct += 1;
                }
                window.Add(i, Str[i]);
                if(distinct == K){
                    break;
                }                
            }
            int windowLength = window.Count;
            int keyToShrink = 0;

            for(int j = windowLength; j< Str.Length; j++){
                if(!window.ContainsValue(Str[j])){
                    window.Remove(keyToShrink);
                    keyToShrink+=1;
                }

                window.Add(j, Str[j]);
                

            }

            Console.WriteLine("first", "second");
            return windowLength;



        }
    }
}