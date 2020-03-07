using System.Collections.Generic;

namespace MethodOverriding
{
    class MainClass
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());

            var canvs = new Canvas();
            canvs.DrawShapes(shapes);
           
        }
    }
}
