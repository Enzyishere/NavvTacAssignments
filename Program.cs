using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        List<int> num1 = new List<int>() { 15, -9, 0, 45, 87, 98, 23, 56 };
        List<int> num2 = new List<int>() { 4, 67, 21, 88, -1, 34, 22, 99 };

        Console.WriteLine("Original Data:");
        PrintData(num1);
        PrintData(num2);

        double median = FindMedian(num1);
        Console.WriteLine($"\nMedian Value: {median}");

        double standardDeviation = CalculateStandardDeviation(num1);
        Console.WriteLine($"\nStandard Deviation: {standardDeviation}");

        List<int> uniqueNumbers = FindUnique(num1);
        Console.WriteLine("\nUnique Values:");
        foreach (int number in uniqueNumbers)
        {
            Console.WriteLine(number);
        }

        int mode = FindMode(num1);
        Console.WriteLine($"\nMode Value: {mode}");

        Console.WriteLine("\nSorted Lists:");
        SortTwoLists(num1, num2);
        PrintData(num1);
        PrintData(num2);

        Console.WriteLine("\nMerged and Sorted List:");
        List<int> mergedList = MergeTwoLists(num1, num2);
        PrintData(mergedList);
    }

    // Method to print data
    static void PrintData(List<int> data)
    {
        foreach (var item in data)
        {
            Console.WriteLine(item);
        }
    }

    // Method to find the median value
    static double FindMedian(List<int> data)
    {
        List<int> sortedData = new List<int>(data);
        sortedData.Sort();

        int count = sortedData.Count;
        if (count % 2 == 0)
        {
            int mid1 = sortedData[count / 2 - 1];
            int mid2 = sortedData[count / 2];
            return (mid1 + mid2) / 2.0;
        }
        else
        {
            return sortedData[count / 2];
        }
    }

    // Method to calculate standard deviation
    static double CalculateStandardDeviation(List<int> data)
    {
        int count = data.Count;
        double mean = CalculateMean(data);
        double sumOfSquaredDifferences = 0;

        foreach (int value in data)
        {
            sumOfSquaredDifferences += Math.Pow(value - mean, 2);
        }

        double variance = sumOfSquaredDifferences / (count - 1);
        return Math.Sqrt(variance);
    }

    static double CalculateMean(List<int> data)
    {
        double sum = 0;
        foreach (int value in data)
        {
            sum += value;
        }
        return sum / data.Count;
    }

    // Method to find unique numbers
    static List<int> FindUnique(List<int> data)
    {
        HashSet<int> uniqueSet = new HashSet<int>(data);
        return new List<int>(uniqueSet);
    }

    // Method to find the mode value
    static int FindMode(List<int> data)
    {
        Dictionary<int, int> counts = new Dictionary<int, int>();

        foreach (int number in data)
        {
            if (counts.ContainsKey(number))
            {
                counts[number]++;
            }
            else
            {
                counts[number] = 1;
            }
        }

        int mode = data[0];
        int maxCount = 0;

        foreach (var pair in counts)
        {
            if (pair.Value > maxCount)
            {
                maxCount = pair.Value;
                mode = pair.Key;
            }
        }

        return mode;
    }

    // Method to sort two lists //
    static void SortTwoLists(List<int> list1, List<int> list2)
    {
        list1.Sort();
        list2.Sort();
    }

    // Method to merge and sort two lists // 
    static List<int> MergeTwoLists(List<int> list1, List<int> list2)
    {
        List<int> mergedList = new List<int>(list1);
        mergedList.AddRange(list2);
        mergedList.Sort();
        return mergedList;
    }
}










