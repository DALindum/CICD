using System.Text.RegularExpressions;

namespace ValidateTheNameModelBinding.Models
{
    public class Person
    {
        private string firstName;
        private string lastName;

        public Person(string firstName, string lastName)
        {
            isFirstNameValid(firstName);
            isLastNameValid(lastName);

            this.firstName = firstName; 
            this.lastName = lastName;
        }

        private void isFirstNameValid(string name)
        {
            var regex = new Regex(@"^([a-zA-Z]*$)");
            if(name.Length >= 20 || name.Length < 3 || !regex.IsMatch(name))
            {
                throw new Exception("First name failed");
            }
        }
        private void isLastNameValid(string name)
        {
            ///Add Invariance validation Here
            /// Throw an Exception if the name is invalid
        }
    }
}
