using Assign_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Program
    {
        static string YoungestPerson(List<Person> personList, int[] ageArray)
        {
            var youngestQuery = from person in personList where person.age == ageArray.Min() select person.FirstName;
            var youngestPerson = youngestQuery.First().ToString();
            return youngestPerson;
        }

        static string OldestPerson(List<Person> personList, int[] ageArray)
        {
            var oldestQuery = from person in personList where person.age == ageArray.Max() select person.FirstName;
            var oldestPerson = oldestQuery.First().ToString();
            return oldestPerson;
        }

        static double AverageAge(int[] ageArray)
        {
            double ageSum = 0;
            foreach (int age in ageArray)
            {
                ageSum += age;
            }
            double avgAge = ageSum / ageArray.Count();
            return avgAge;
        }

        static void Main(string[] args)
        {
            Person Ian = new Person(1, "Ian", "Brookes", "Red", 30, true);
            Person Gina = new Person(2, "Gina", "James", "Green", 18, false);
            Person Mike = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person Mary = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            List<Person> personList = new List<Person>();
            personList.Add(Ian);
            personList.Add(Gina);
            personList.Add(Mike);
            personList.Add(Mary);

            Gina.DisplayPersonInfo();

            Mike.ToString();

            Ian.ChangeFavoriteColour();
            Ian.DisplayPersonInfo();

            Mary.GetAgeInTenYears();

            Relation Brother = new Relation("Brotherhood");
            Relation Sister = new Relation("Sisterhood");
            Sister.ShowRelationShip(Gina, Mary);
            Brother.ShowRelationShip(Ian, Mike);

            var ageQuery = from person in personList select person.age;
            int[] ageArray = ageQuery.ToArray();

            Console.WriteLine($"Average age is: {AverageAge(ageArray)}");

            Console.WriteLine($"The youngest person is: {YoungestPerson(personList, ageArray)}");
            Console.WriteLine($"The oldest person is: {OldestPerson(personList, ageArray)}");

            var mQuery = from person in personList where person.FirstName.StartsWith("M") select person;
            foreach (var person in mQuery)
            {
                person.ToString();
            }

            var blueQuery = from person in personList where person.FavoriteColor.Contains("Blue") select person;
            foreach (var person in blueQuery)
            {
                person.ToString();
            }

            Console.ReadKey();
        }
    }
}
