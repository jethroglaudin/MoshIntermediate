using System;

namespace Mosh_Intermediate
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            //var person = new Person();
            var person = Person.Parse("John");
           
            person.Introduce("Jethro");
            Console.WriteLine("Hello World!");
        }
    }
}
