using System;

class RemoveDuplicatesFromUnsortedArray
{
    //Given an unsorted array of numbers and a target ‘key’, 
    //remove all instances of ‘key’ in-place and return the new length of the array.
    public static int RemoveDuplicatesFromUnsortedArray(int[] arr, int key)
    {
        int nextElement = 0; // index of the next element 
        for (int i = 0; i < arr.Length; i++)
        {          
            if (arr[i] != key)
            {
                arr[nextElement] = arr[i];
                nextElement++;
            }
        }        
        return nextElement;
    }

    public static void Main(String[] args)
    {
        int[] arr = new int[] { 3, 2, 3, 6, 3, 10, 9, 3 };
        Console.WriteLine("Length of an unsorted array after removing duplicates {0}", RemoveDuplicatesFromUnsortedArray(arr , 3));

        arr = new int[] { 3, 2, 3, 6, 3, 10, 9, 3 };
        Console.WriteLine("Length of an unsorted array after removing duplicates {0}", RemoveDuplicatesFromUnsortedArray(arr, 10));

    }
}
