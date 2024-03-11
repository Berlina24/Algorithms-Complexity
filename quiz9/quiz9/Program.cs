using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] originalArray = { 5,4,3,2,1 };
        int[] sortedArray = MergeSort(originalArray);
        DisplayArray("sortedArray", sortedArray);

        Console.WriteLine("---END---");
        Console.ReadLine();
    }

    static void DisplayArray(string label, int[] array)
    {
        Console.Write(label + ": ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + ", ");
        }
        Console.WriteLine("\n");
    }

    static int[] MergeSort(int[] arr)
    {
        if (arr.Length > 1)
        {
            int middle = arr.Length / 2;
            int[] leftArray = SplitArray(arr, 0, middle, "Left");
            int[] rightArray = SplitArray(arr, middle, arr.Length, "Right");

            leftArray = MergeSort(leftArray);
            rightArray = MergeSort(rightArray);

            return Merge(leftArray, rightArray);
        }
        else
        {
            return arr;
        }
    }

    static int[] SplitArray(int[] oldArray, int from, int to, string side)
    {
        Console.WriteLine("---SPLIT ARRAY---");
        int[] newArray = new int[to - from];
        Console.WriteLine("New size[" + side + "]:" + newArray.Length);
        int counter = 0;
        for (int i = from; i < to; i++)
        {
            newArray[counter] = oldArray[i];
            counter++;
        }
        DisplayArray("newArray[" + side + "]", newArray);
        return newArray;
    }

    static int[] Merge(int[] leftArray, int[] rightArray)
    {
        Console.WriteLine("---Merge Sort---");
        int[] mergedArray = new int[leftArray.Length + rightArray.Length];

        int indexMerged = 0;
        int indexLeft = 0;
        int indexRight = 0;

        while (indexLeft < leftArray.Length && indexRight < rightArray.Length)
        {
            Console.Write(leftArray[indexLeft] + " > " + rightArray[indexRight]);
            if (leftArray[indexLeft] > rightArray[indexRight])
            {
                mergedArray[indexMerged] = rightArray[indexRight];
                Console.WriteLine(" : true, insert " + rightArray[indexRight]);
                indexRight++;
            }
            else
            {
                mergedArray[indexMerged] = leftArray[indexLeft];
                Console.WriteLine(" : false, insert " + leftArray[indexLeft]);
                indexLeft++;
            }
            indexMerged++;
        }

        while (indexLeft < leftArray.Length)
        {
            mergedArray[indexMerged] = leftArray[indexLeft];
            Console.WriteLine("insert " + leftArray[indexLeft]);
            indexLeft++;
            indexMerged++;
        }

        while (indexRight < rightArray.Length)
        {
            mergedArray[indexMerged] = rightArray[indexRight];
            Console.WriteLine("insert " + rightArray[indexRight]);
            indexRight++;
            indexMerged++;
        }

        DisplayArray("mergedArray", mergedArray);
        return mergedArray;
    }
}
