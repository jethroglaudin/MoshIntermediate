using System;

namespace Casting
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Text text = new Text();
            Shape shape = text;

            text.Width = 200;
            shape.Width = 100;

            Console.WriteLine(text.Width);
        }
    }
}
