class NameParser
{
    public List<Name> Parse(string[] fullName)
    {
        
        List<Name> names = fullName.Select(x => {
            return ParseItem(x);
        }).ToList();

        return names;
    }

    public Name ParseItem(string item)
    {
        string[] fullName = item.Split(" ");
        string first = fullName.First();
        string last = fullName.Last();
        string middle = string.Join(" ", fullName, 2, fullName[-2]);
        Console.WriteLine(first, middle, last);
        return new Name(first, middle, last);
    }
}