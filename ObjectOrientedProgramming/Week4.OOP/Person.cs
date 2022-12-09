/*
 Create a class Person with one constructor to initialize the values:
- FirstName
- LastName
- Age
- Gender (Check if gender is Male or Female. If not, throw an Exception)

Add Introduce method with the following message: "Hi, mi name is <FULL NAME> and I am a <AGE> year old <GENDER>."
 */
namespace Week4.OOP
{
    public class Person
    {
        public int age;
        public string gender;
        public string firstName;
        public string lastName;
        public Address address;

        public Person(string firstName, string lastName, int age, string gender, Address address)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.address = address;

            if (gender == "male" || gender == "female")
            {
                this.gender = gender;
            }
            else 
            {
                throw new Exception("Gender is not valid.");
            }
        }

        public void Introduce()
        {
            string textToShow = $"Hi, my name is {firstName} {lastName} and I am a {this.age} year old {this.gender}. Living on street {address.street.ToLower()}, state {address.state}.";

            Console.WriteLine(textToShow);

            // SAU

            //Console.WriteLine($"Hi, my name is {this.firstName} {this.lastName} and I am a {this.age} year old {this.gender}.");
        }

        public int GetAgePlusTen()
        {
            return this.age + 10;
        }
    }
}
