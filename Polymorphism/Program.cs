using System;
using System.Collections.Generic;

namespace MethodOverriding
{
    class MainClass
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            shapes.Add(new Shape { Width = 100, Height = 100, Type = ShapeType.Circle });
            shapes.Add(new Shape { Width = 100, Height = 30, Type = ShapeType.Rectangle });

            var canvs = new Canvas();
            canvs.DrawShapes(shapes);
           
        }
    }
}
