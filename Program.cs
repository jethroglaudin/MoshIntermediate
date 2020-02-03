using System;
namespace Mosh_Intermediate
{

    class MainClass
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1992, 4, 23));

            Console.WriteLine(person.Age);
        }

    }
}
