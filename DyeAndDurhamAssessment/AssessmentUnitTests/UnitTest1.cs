using MyApp;
using System;
using System.IO;
using Xunit;

namespace AssessmentUnitTests
{
    public class UnitTest1
    {

        [Fact]
        public void Test1()
        {
            //Marin AlvarezAdonis Julius ArcherBeau Tristan BentleyHunter Uriah Mathew ClarkeLeo GardnerVaughn LewisLondon LindseyMikayla LopezJanet ParsonsFrankie Conner RitterShelby Nathan Yoder
            string[] people = { "Greg Malls", "Avery Gils", "Avery Alison", "Ben Bono" };
            
            string[] testCase = SortArray.SortAscending(people);
            Array.Sort(people);

            Assert.True(people == testCase);

        }

        [Fact]

// {"Marin Alvarez",
// "Adonis Julius Archer",
// "Beau Tristan Bentley",
// "Hunter Uriah Mathew Clarke",
// "Leo GardnerVaughn Lewis",
// "London Lindsey",
// "Mikayla Lopez",
// "Janet Parsons",
// "Frankie Conner Ritter",
// "Shelby Nathan Yoder"}
        public void Test2()
        {
            string[] people = { "Greg Malls", "Avery Gils", "Avery Alison", "Ben Bono" };

            string[] testCase = SortArray.SortDescending(people);

            Array.Reverse(people);

            Assert.True(people == testCase);
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