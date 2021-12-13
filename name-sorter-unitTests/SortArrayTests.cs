using MyApp;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace AssessmentUnitTests
{
    public class SortArrayTests
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
        public void ItShouldReturnASortedArrayInTheCorrectOrder()
        {
            SortArray sortList = new SortArray();
            NameParser listOfNames = new NameParser();

            List<Name> list = listOfNames.ParseList(testCase);
            List<Name> SortedData = sortList.SortAscending(list);
            string[] nameArray = SortedData.Select(name => name.First + " " + (name.Middle != ""? $"{name.Middle} " : "") + name.Last).ToArray();

            Assert.True(people[3] == nameArray[3]);
            Assert.True(people[5] == nameArray[5]);
            Assert.True(people[^1] == nameArray[^1]);

        }
    }
}