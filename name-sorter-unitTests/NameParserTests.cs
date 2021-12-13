using Xunit;
using MyApp;

namespace AssessmentUnitTests
{
    public class NameParserTests
    {
        [Fact]
        public void ItShouldParseALineContainingASingleMiddleName(){
            var subject = new NameParser();
            
            string fullName = "Adonis Julius Archer";

            var name = subject.ParseListItem(fullName);

            Assert.Equal("Adonis", name.First);
            Assert.Equal("Julius", name.Middle);
            Assert.Equal("Archer", name.Last);
        }

        [Fact]
        public void ItShouldParseALineContainingMoreThanOneMiddleName(){
            var subject = new NameParser();
            
            string fullName = "Hunter Uriah Mathew Clarke";

            var name = subject.ParseListItem(fullName);

            Assert.Equal("Hunter", name.First);
            Assert.Equal("Uriah Mathew", name.Middle);
            Assert.Equal("Clarke", name.Last);
            
        }

        [Fact]
        public void ItShouldParseALineContainingNoMiddleName(){
            var subject = new NameParser();
            
            string fullName = "Mikayla Lopez";

            var name = subject.ParseListItem(fullName);

            Assert.Equal("Mikayla", name.First);
            Assert.Equal("", name.Middle);
            Assert.Equal("Lopez", name.Last);
            
        }

    }
}