using System;
using System.IO;
using System.Linq;
using MyApp;
public class SortArray
    {

        public List<Name> SortAscending(List<Name> fullNames)
        {

            List<Name> orderedList = fullNames.OrderBy(x => x.Last).ToList();

            return orderedList;
        }
        // public static string[] SortDescending(string[] fullNames)
        // {
        //     Array.Sort(fullNames);
        //     Array.Reverse(fullNames);
        //     return fullNames;
        // }

        // //Returns an array with first and last names reversed
        // public static string[] SplitAndReverse(string[] fullNames)
        // {
        //     string[] Reversed = Rearrange(fullNames);
        //     return Reversed;
        // }
        // //Returns an array with the same format as the initial data
        // public static string[] Normalize(string[] data)
        // {
        //     string[] normalizedData = Rearrange(data);
        //     return normalizedData;
        // }

        // //Swaps indexs of all elements in fullnames
        // public static string[] Rearrange(string[] data)
        // {
        //     string[] returnArray = new string[data.Length];
        //     for (int i = 0; i < data.Length; i++)
        //     {
        //         string[] dataSet = data[i].Split();
        //         string firstElement = dataSet[^1];
        //         string lastElement = dataSet[0];
        //         try
        //         {
        //             string middleElement = dataSet[1];
        //             string potentialElement = dataSet[2]; //Will fail if dataSet[2] doesn't exist
        //             string input = potentialElement == lastElement ? $"{firstElement} {middleElement} {lastElement}" : $"{firstElement} {middleElement} {potentialElement} {lastElement}";
        //             returnArray[i] = input;
        //         }
        //         catch
        //         {

        //             string input = $"{firstElement} {lastElement}";
        //             returnArray[i] = input;
        //         }
        //     }
        //     return returnArray;
        // }



    }