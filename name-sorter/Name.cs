
using System;
namespace MyApp
{
    public class Name {

        public Name(string first, string middle, string last)
        {
            First = first;
            Middle = middle;
            Last = last;
        }
        public string First { get; set; }
        public string Last { get; set; }
        public string Middle { get; set; }
    }
}

