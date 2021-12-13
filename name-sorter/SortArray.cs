using MyApp;

namespace MyApp
{
public class SortArray
    {
        public List<Name> SortAscending(List<Name> fullNames)
        {

            List<Name> orderedList = fullNames.OrderBy(x => x.Last).ToList();

            return orderedList;
        }
    }
}