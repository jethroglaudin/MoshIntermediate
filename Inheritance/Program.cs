using System;

namespace Inheritance
{
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperLink(string url)
        {
            Console.WriteLine("We added a link to " + url);
        }

    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
