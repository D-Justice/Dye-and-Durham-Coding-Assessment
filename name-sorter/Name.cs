using System;
class Name
{   
    public string First
    {get; set;}
    public string Middle
    {get; set;}
    public string Last
    {get; set;}
    public Name(string firstName, string middleName, string lastName)
    {
        First = firstName;
        Middle = middleName;
        Last = lastName;
    }

    
}