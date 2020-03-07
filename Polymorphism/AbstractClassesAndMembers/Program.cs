using System;

namespace AbstractClassesAndMembers
{
    public class Rectangle: Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");
        }
    }
    class MainClass
    {
        static void Main(string[] args)
        {
            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();
            Console.WriteLine("Hello World!");
        }
    }
}
