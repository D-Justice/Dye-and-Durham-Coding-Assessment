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


            string[] ReverseData = SortArray.SplitAndReverse(testCase);
            string[] SortedData = SortArray.SortAscending(ReverseData);
            string[] NormalizedData = SortArray.Normalize(SortedData);
            for (int i = 0; i < NormalizedData.Length; i++)
            {
                Console.WriteLine($"{people[i]}, {NormalizedData[i]}");
            }

            Assert.True(people[3] == NormalizedData[3]);

        }

        [Fact]


        public void Test2()
        {


            string[] ReverseData = SortArray.SplitAndReverse(testCase);
            string[] SortedData = SortArray.SortDescending(ReverseData);
            string[] NormalizedData = SortArray.Normalize(SortedData);
            Array.Reverse(people);
            Assert.True(people[3] == NormalizedData[3], $"{NormalizedData[3]} should be equal to {people[3]}");
        }

        [Fact]
        public void Test3()
        {
            const string FileName = "./unsorted-names-list.txt";
            string[] result = ReadFile.PullText(fileName: FileName);

            Assert.True(result.Length >= 0);


        }
    }
}