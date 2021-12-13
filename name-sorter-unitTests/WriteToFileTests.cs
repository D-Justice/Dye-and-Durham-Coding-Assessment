using MyApp;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace AssessmentUnitTests
{
    public class WriteToFileTests
    {
        [Fact]

        public void SortedNamesListFileShouldExist()
        {
            WriteToFile writeFile = new WriteToFile();
            string[] arrayToWrite = {"John", "Greg", "Bill"};
            writeFile.CreateAndWrite(arrayToWrite);
            Assert.True(File.Exists("./sorted-names-list.txt"));
        }
        
    }
}