namespace MyApp
{
    public class NameParser
    {
        public List<Name> ParseList(string[] lines)
        {
            return lines
            .ToList()
                .Select(x =>
                {
                    return ParseListItem(x);
                }).ToList(); ;
        }

        public Name ParseListItem(string line)
        {
            var fullName = line.Split(" ").ToList();
            var firstName = fullName.First();
            var lastName = fullName.Last();
            var middleNames = string.Join(" ", fullName.Skip(1).Take(fullName.Count - 2));

            return new Name(firstName, middleNames, lastName);
        }
    }
}




