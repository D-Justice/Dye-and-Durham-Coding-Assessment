using System.IO;
namespace MyApp 
{
public class WriteToFile
    {
        public static void CreateAndWrite(List<Name> dataToWrite)
        {
            string[] nameArray = dataToWrite.Select(name => name.First + " " + (name.Middle != ""? $"{name.Middle} " : "") + name.Last).ToArray();
            
            File.WriteAllLines("sorted-names-list.txt", nameArray);
            Console.Write("File Written Successfully");
        }
    }
}