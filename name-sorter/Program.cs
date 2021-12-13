namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadFile readFile = new ReadFile();
            NameParser listOfNames = new NameParser();
            SortArray sortArray = new SortArray();
            WriteToFile writeFile = new WriteToFile();

            if (!File.Exists(args[0]))
            {
                Console.WriteLine($"{args[0]} does not exist.");
                return;
            }

            string[] FileData = readFile.PullText(args[0]);
            List<Name> list = listOfNames.ParseList(FileData);
            List<Name> SortedData = sortArray.SortAscending(list);
            string[] nameArray = WriteToFile.ConvertListToArray(SortedData);
            
            writeFile.CreateAndWrite(nameArray);
        }
    }
}




