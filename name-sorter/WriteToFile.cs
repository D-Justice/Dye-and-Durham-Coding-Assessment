using System.IO;
namespace MyApp 
{
public class WriteToFile
    {
        public static void CreateAndWrite(List<Name> dataToWrite)
        {
            string[] test = dataToWrite.Select(o => o.First + " " + (o.Middle != ""? $"{o.Middle} " : "") + o.Last).ToArray();
            File.WriteAllLines("sorted-names-list.txt", test);
            Console.Write("File Written Successfully");
        }
    }
}