namespace MyApp 
{
public class ReadFile
    {
        public string[] PullText(string fileName)
        {
            string[] fullNames = File.ReadAllLines(fileName.ToString());
            return fullNames;
        }
    }
}
