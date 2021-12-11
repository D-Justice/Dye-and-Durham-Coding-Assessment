using System;
using System.IO;
using System.Linq;
namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileReader = new ReadFile();
            if (!File.Exists(args[0]))
            {
                Console.WriteLine($"{args[0]} does not exist.");
                return;
            }

            string[] FileData = fileReader.PullText(args[0]);
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




