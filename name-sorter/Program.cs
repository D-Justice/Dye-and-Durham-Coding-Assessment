using System;
using System.IO;
using System.Linq;
namespace MyApp
{


    public class ReadFile
    {
        public static string[] PullText(string fileName)
        {
            string[] fullNames = File.ReadAllLines(fileName.ToString());

            return fullNames;

        }

    }
    
    public class SortArray
    {
        public static string[] SortAscending(string[] fullNames)
        {

            Array.Sort(fullNames);

            return fullNames;
        }
        public static string[] SortDescending(string[] fullNames)
        {
            Array.Sort(fullNames);
            Array.Reverse(fullNames);
            return fullNames;
        }
        public static string[] SplitAndReverse(string[] fullNames)
        {
            string[] Reversed = Rearrange(fullNames);
            return Reversed;
        }
        public static string[] Normalize(string[] data)
        {
            string[] normalizedData = Rearrange(data);
            return normalizedData;
        }
        public static string[] Rearrange(string[] data)
        {
            string[] returnArray = new string[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                string[] dataSet = data[i].Split();
                string firstElement = dataSet[^1];
                string lastElement = dataSet[0];
                try
                {
                    string middleElement = dataSet[1];
                    string potentialElement = dataSet[2]; //Will fail if dataSet[2] doesn't exist
                    string input = potentialElement == lastElement ? $"{firstElement} {middleElement} {lastElement}" : $"{firstElement} {middleElement} {potentialElement} {lastElement}";
                    returnArray[i] = input;
                }
                catch
                {

                    string input = $"{firstElement} {lastElement}";
                    returnArray[i] = input;
                }
            }
            return returnArray;
        }



    }

    class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists(args[0]))
            {
                Console.WriteLine($"{args[0]} does not exist.");
                return;
            }

            string[] FileData = ReadFile.PullText(args[0]);
            string[] ReverseData = SortArray.SplitAndReverse(FileData);
            string[] SortedData = SortArray.SortAscending(ReverseData);
            string[] NormalizedData = SortArray.Normalize(SortedData);
            foreach (var i in NormalizedData)
            {
                Console.WriteLine(i);
            }
            WriteToFile.CreateAndWrite(NormalizedData);
        }
    }
}




