using System;

class Program
{
    public static void Main()
    {
        Console.Write("MAX ARRAY: ");
        int arraySize = int.Parse(Console.ReadLine());
        int[] array = new int[arraySize];
        for (int currentIndex = 0; currentIndex < arraySize; currentIndex++)
        {
            Console.Write($"Element {currentIndex + 1}: ");
            array[currentIndex] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Choose a Sorting Algorithm: ");
        Console.WriteLine("1. Bubble Sort");
        Console.WriteLine("2. Selection Sort");
        Console.WriteLine("3. Insertion Sort");
        int sortingAlgorithmChoice = int.Parse(Console.ReadLine());

        switch (sortingAlgorithmChoice)
        {
            case 1:
                BubbleSort(array);
                break;
            case 2:
                SelectionSort(array);
                break;
            case 3:
                InsertionSort(array);
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    static void BubbleSort(int[] arr)
    {
        Console.WriteLine("Sorted Array: ");
        int size = arr.Length;
        for (int currentIndex = 0; currentIndex < size; currentIndex++)
        {
            for (int innerIndex = 0; innerIndex < size - currentIndex - 1; innerIndex++)
            {
                if (arr[innerIndex] > arr[innerIndex + 1])
                {
                    int temp = arr[innerIndex];
                    arr[innerIndex] = arr[innerIndex + 1];
                    arr[innerIndex + 1] = temp;
                }
            }
            PrintArray(arr);
        }
    }

    static void SelectionSort(int[] arr)
    {
        int size = arr.Length;
        for (int currentIndex = 0; currentIndex < size - 1; currentIndex++)
        {
            int minIndex = currentIndex;
            for (int innerIndex = currentIndex + 1; innerIndex < size; innerIndex++)
            {
                if (arr[innerIndex] < arr[minIndex])
                {
                    minIndex = innerIndex;
                }
            }
            int temp = arr[currentIndex];
            arr[currentIndex] = arr[minIndex];
            arr[minIndex] = temp;
            PrintArray(arr);
        }
    }

    static void InsertionSort(int[] arr)
    {
        int size = arr.Length;
        for (int currentIndex = 1; currentIndex < size; currentIndex++)
        {
            int key = arr[currentIndex];
            int innerIndex = currentIndex - 1;
            while (innerIndex >= 0 && arr[innerIndex] > key)
            {
                arr[innerIndex + 1] = arr[innerIndex];
                innerIndex--;
            }
            arr[innerIndex + 1] = key;
            PrintArray(arr);
        }
    }

    static void PrintArray(int[] arr)
    {
        Console.WriteLine("[" + string.Join(",", arr) + "]");
    }
}
