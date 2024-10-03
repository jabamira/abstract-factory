using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace abstr_Fabric
{
    public abstract class Shapes
    {
        public abstract Size Size { get; }
        public abstract int X { get; }
        public abstract int Y { get; }

        public virtual void Draw(Graphics g) { }
    }

    class Triangle : Shapes
    {
        private readonly Brush _brush;
        private readonly Size _size;
        private readonly int _x;
        private readonly int _y;

        public Triangle(Brush brush, int size, int x, int y)
        {
            _brush = brush;
            _size = new Size(size, size);
            _x = x;
            _y = y;
        }

        public override Size Size => _size;
        public override int X => _x;
        public override int Y => _y;

        public override void Draw(Graphics g)
        {
            Point[] points = {
                new Point(X + Size.Width / 2, Y),
                new Point(X + Size.Width, Y + Size.Height),
                new Point(X, Y + Size.Height)
            };
            g.FillPolygon(_brush, points);
        }
    }

    class Circle : Shapes
    {
        private readonly Brush _brush;
        private readonly Size _size;
        private readonly int _x;
        private readonly int _y;

        public Circle(Brush brush, int size, int x, int y)
        {
            _brush = brush;
            _size = new Size(size, size);
            _x = x;
            _y = y;
        }

        public override Size Size => _size;
        public override int X => _x;
        public override int Y => _y;

        public override void Draw(Graphics g)
        {
            g.FillEllipse(_brush, X, Y, Size.Width, Size.Height);
        }
    }

    class Square : Shapes
    {
        private readonly Brush _brush;
        private readonly Size _size;
        private readonly int _x;
        private readonly int _y;

        public Square(Brush brush, int size, int x, int y)
        {
            _brush = brush;
            _size = new Size(size, size);
            _x = x;
            _y = y;
        }

        public override Size Size => _size;
        public override int X => _x;
        public override int Y => _y;

        public override void Draw(Graphics g)
        {
            g.FillRectangle(_brush, X, Y, Size.Width, Size.Height);
        }
    }
}