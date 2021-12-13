using MyApp;
using System;
using System.IO;
using Xunit;

namespace AssessmentUnitTests
{
    public class UnitTest1
    {
        string[] people = {"Marin Alvarez",
                                "Adonis Julius Archer",
                                "Beau Tristan Bentley",
                                "Hunter Uriah Mathew Clarke",
                                "Leo Gardner",
                                "Vaughn Lewis",
                                "London Lindsey",
                                "Mikayla Lopez",
                                "Janet Parsons",
                                "Frankie Conner Ritter",
                                "Shelby Nathan Yoder"
                                };
        string[] testCase = {"Janet Parsons",
                                "Vaughn Lewis",
                                "Adonis Julius Archer",
                                "Shelby Nathan Yoder",
                                "Marin Alvarez",
                                "London Lindsey",
                                "Beau Tristan Bentley",
                                "Leo Gardner",
                                "Hunter Uriah Mathew Clarke",
                                "Mikayla Lopez",
                                "Frankie Conner Ritter"
                                };
        [Fact]
        public void Test1()
        {
            var fileReader = new ReadFile();
            const string FileName = "./unsorted-names-list.txt";
            string[] result = fileReader.PullText(fileName: FileName);

            Assert.True(result.Length >= 0);


        }
    }
}