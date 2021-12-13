using System;
using System.IO;
using System.Linq;
using MyApp;
public class SortArray
    {
        public List<Name> SortAscending(List<Name> fullNames)
        {

            List<Name> orderedList = fullNames.OrderBy(x => x.Last).ToList();

            return orderedList;
        }
    }