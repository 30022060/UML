using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_task_1
{
    class Program
    {
        static void Main(string[] args)
        {


            

            string check = "y";
            while (check == "y")
            {
                Person.counter++;
                Person newPerson = new Person();
                Console.Write("Enter person's name: ");
                newPerson.Fname = Console.ReadLine();
                Console.Write("Enter person's last name: ");
                newPerson.Lname = Console.ReadLine();
                Console.Write("Enter person's age: ");
                newPerson.Age = Console.ReadLine();
                people.add(newPerson); ;
                Console.Write("Add another?");
                check = Console.ReadLine();
            }

            Console.Write($"No. of people created: {Person.counter}");
            foreach (Person x in people) ;
            Console.WriteLine($"Name: {x.Fname} {x.Lname}\n Age: {x.Age}");
                      
        }

        List<Person> peopl = new List<Person>()
        {
            new Person("Bob","Morris",60),
            new Person("Tim","Morris",60),
            new Person("Jack","Morris",60),
        };




      
    }
    class Person
    {
        private string fname;
        private string lname;
        private int age;
        private static int counter;

        public string Fname { get { return fname; } set { fname = value; } }
        public string Lname { get { return lname; } set { lname = value; } }
        public int Age { get { return age; } set { age = value; } }

        public string ReturnDeets()
        {
            return $"First Name: {fname}\nLast Name: {Lname}\nAge: {Age}";
        }
    }
}
