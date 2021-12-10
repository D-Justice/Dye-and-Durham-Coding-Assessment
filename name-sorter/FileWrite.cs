using System.IO;
namespace MyApp 
{
public class WriteToFile
    {
        public static void CreateAndWrite(string[] dataToWrite)
        {
            File.WriteAllLines("sorted-names-list.txt", dataToWrite);
            Console.Write("File Written Successfully");
        }
    }
}