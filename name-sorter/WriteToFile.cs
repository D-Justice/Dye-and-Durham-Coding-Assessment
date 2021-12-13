using System.IO;
namespace MyApp 
{
public class WriteToFile
    {   
        public static string[] ConvertListToArray(List<Name> list)
        {
            string[] nameArray = list.Select(name => name.First + " " + (name.Middle != ""? $"{name.Middle} " : "") + name.Last).ToArray();
            return nameArray;
        }
        public void CreateAndWrite(string[] dataToWrite)
        {
            
            File.WriteAllLines("sorted-names-list.txt", dataToWrite);
            Console.Write("File Written Successfully");
        }
    }
}