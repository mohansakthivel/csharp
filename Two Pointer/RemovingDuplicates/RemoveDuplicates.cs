using System;

class RemoveDuplicatesFromArray
{

    public static int RemoveDuplicates(int[] arr)
    {
        int nextNonDuplicate = 1; // index of the next non-duplicate element 
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[nextNonDuplicate - 1] != arr[i])
            {
                arr[nextNonDuplicate] = arr[i];
                nextNonDuplicate++;
            }
        }
        return nextNonDuplicate;
    }

    public static void Main(String[] args)
    {

        int[] arr = new int[] { 2, 3, 3, 3, 6, 9, 9 };
        Console.WriteLine("Length of an array after removing duplicates {0}", RemoveDuplicates(arr));

        arr = new int[] { 2, 2, 2, 11 };
        Console.WriteLine("Length of an array after removing duplicates {0}", RemoveDuplicates(arr));

    }
}
