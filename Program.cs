using System.Collections.Generic;
namespace Mosh_Intermediate
{

    class MainClass
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Jethro";
            System.Console.WriteLine(cookie["name"]);
        }

    }
}
