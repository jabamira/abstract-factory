﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace abstr_Fabric
{
    namespace abstr_Fabric
    {
        public abstract class ShapeFactory
        {
            public Color Color { get; set; }

            public abstract Shapes CreateCircle(int size, int x, int y);

            public abstract Shapes CreateSquare(int size, int x, int y);

            public abstract Shapes CreateTriangle(int size, int x, int y);
        }
        public class BlueFactory : ShapeFactory
        {
            Color color { get; set; } = Color.Blue;
            override public Shapes CreateCircle(int size, int x, int y) => new Circle(Brushes.Blue, size, x, y);
            override public Shapes CreateSquare(int size, int x, int y) => new Square(Brushes.Blue, size, x, y);
            override public Shapes CreateTriangle(int size, int x, int y) => new Triangle(Brushes.Blue, size, x, y);
        }

        public class RedFactory : ShapeFactory
        {
            public Color color { get; set; } = Color.Red;
            override public Shapes CreateCircle(int size, int x, int y) => new Circle(Brushes.Red, size, x, y);
            override public Shapes CreateSquare(int size, int x, int y) => new Square(Brushes.Red, size, x, y);
            override public Shapes CreateTriangle(int size, int x, int y) => new Triangle(Brushes.Red, size, x, y);
        }

        public class GreenFactory : ShapeFactory
        {
            public Color color { get; set; } = Color.Green;
            override public Shapes CreateCircle(int size, int x, int y) => new Circle(Brushes.Green, size, x, y);
            override public Shapes CreateSquare(int size, int x, int y) => new Square(Brushes.Green, size, x, y);
            override public Shapes CreateTriangle(int size, int x, int y) => new Triangle(Brushes.Green, size, x, y);
        }

        public class GhostWhiteFactory : ShapeFactory
        {
            public Color color { get; set; } = Color.GhostWhite;
            override public Shapes CreateCircle(int size, int x, int y) => new Circle(Brushes.GhostWhite, size, x, y);
            override public Shapes CreateSquare(int size, int x, int y) => new Square(Brushes.GhostWhite, size, x, y);
            override public Shapes CreateTriangle(int size, int x, int y) => new Triangle(Brushes.GhostWhite, size, x, y);
        }



    }
}
