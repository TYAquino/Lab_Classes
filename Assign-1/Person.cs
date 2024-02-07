using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_1
{
    public class Person
    {
        private int personId;
        private string firstName;
        private string lastName;
        private string favoriteColor;
        private int Age;
        private bool isWorking;

        public int PersonId
        {
            get { return personId; }
            set { personId = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string FavoriteColor
        {
            get { return favoriteColor; }
            set { favoriteColor = value; }
        }
        public int age
        {
            get { return Age; }
            set { Age = value; }
        }
        public bool IsWorking
        {
            get { return isWorking; }
            set { isWorking = value; }
        }
        public Person(int personId, string firstName, string lastName, string favoriteColour, int age, bool isWorking)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.favoriteColor = favoriteColour;
            this.age = age;
            this.isWorking = isWorking;
        }
        public void ChangeFavoriteColour()
        {
            favoriteColor = "White";
        }
        public void DisplayPersonInfo()
        {
            Console.WriteLine($"{this.personId}: {this.firstName + " " + this.lastName}'s favorite color is: {this.favoriteColor}");
        }

        public void GetAgeInTenYears()
        {
            Console.WriteLine($"{firstName + " " + lastName}'s Age in 10 years is: {Age + 10}");
        }

        public void ToString()
        {
            Console.WriteLine(
                $"PersonId: {this.personId}\n" +
                $"FirstName: {this.firstName}\n" +
                $"LastName: {this.lastName}\n" +
                $"FavoriteColour: {this.favoriteColor}\n" +
                $"Age: {this.age}\n" +
                $"IsWorking: {this.isWorking.ToString()}");
        }
    }
}
