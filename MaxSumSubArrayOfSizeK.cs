using System;
using System.Collections.Generic;
using System.Linq;

class MaxSumSubArrayOfSizeK {
    
    public static int findMaxSumSubArray(int k, int[] arr)      
    {
        int windowSum = 0, maxSum = 0;
        int windowStart = 0;
        for (int windowEnd = 0; windowEnd < arr.Length; windowEnd++) {
            windowSum += arr[windowEnd]; // add the next element
            // slide the window, no need to slide if we've not hit the window size of 'k'
            if (windowEnd >= k - 1) {
                maxSum = Math.Max(maxSum, windowSum);
                windowSum -= arr[windowStart]; // subtract the element going out
                windowStart++; // slide the window ahead
            }
        }
        return maxSum;
    }        
        
    static void Main(String[] args) {
        Console.WriteLine("Maximum sum of a subarray of size K: ");   
        Console.WriteLine(findMaxSumSubArray(3, new int[] {1 , 2, 3, 4, 5, 6 , 7}));
    }
}
