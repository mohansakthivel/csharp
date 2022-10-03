using System;

// Pair With Target Sum
class PairWithTargetSum {
  
   public static int[] search(int[] arr, int targetSum) {
    int left = 0, right = arr.Length - 1;
    while (left < right) {
      int currentSum = arr[left] + arr[right];
      if (currentSum == targetSum)
        return new int[] { left, right }; // found the pair

      if (targetSum > currentSum)
        left++; // we need a pair with a bigger sum
      else
        right--; // we need a pair with a smaller sum
    }
    return new int[] { -1, -1 };
  }

  public static void Main(string[] args) {
    int[] result = search(new int[] { 1, 2, 3, 4, 6 }, 6);
    Console.WriteLine("Pair with target sum: [ {0} , {1}]", result[0] , result[1]);
    result = search(new int[] { 2, 5, 9, 11 }, 11);
    Console.WriteLine("Pair with target sum: [ {0} , {1} ]", result[0] , result[1]);
  }
}
