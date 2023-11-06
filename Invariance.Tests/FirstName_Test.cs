using Xunit;
using ValidateTheNameModelBinding.Models;

namespace Invariance.Tests
{
    public class FirstName_Test
    {
        [Theory]
        [InlineData("aaaaaa", "")]
        [InlineData("Daniel", "")]
        public void FirstName_Length_NoException(string FirstName, string LastName)
        {
            var person = new Person(FirstName, LastName);
        }

        [Theory]
        [InlineData("Daniel", "")]
        [InlineData("DanielDaniel", "")]
        public void FirstName_Character_NotAllowed_NoException(string FirstName, string LastName)
        {
            var person = new Person(FirstName, LastName);
        }

        [Theory]
        [InlineData("aa", "")]
        [InlineData("aerjhiuerahuiarheuahwawuihegaeuhgahewiuwahegaeiuhaiuewhguwaiegh", "")]
        public void FirstName_TooManyOrTooLow_Exception(string FirstName, string LastName)
        {
            var person = new Person(FirstName, LastName);
        }

        [Theory]
        [InlineData("j1ug1", "")]
        [InlineData("Dnai!sj", "")]
        public void FirstName_Characters_Exception(string FirstName, string LastName)
        {
            var person = new Person(FirstName, LastName);
        }

        [Theory]
        [InlineData("", "")]
        public void FirstName_Null_Exception(string FirstName, string LastName)
        {
            var person = new Person(FirstName, LastName);
        }
    }
}