using System;
using System.IO;
using System.Linq;
//Reads .txt file and converts to array
public class ReadFile
    {
        public static string[] PullText(string fileName)
        {
            var listOfNames = new NameParser();

            string[] fullNames = File.ReadAllLines(fileName.ToString());

            List<Name> list = listOfNames.ParseList(fullNames);

            for (int i = 0; i < list.)

            return fullNames;

        }

    }