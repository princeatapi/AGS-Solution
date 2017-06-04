using System;
using System.Collections.Generic;
using System.Text;

namespace AsgQuizzes
{
    public class OOShapes
    {
        private List<IShape> _shape = new List<IShape>();

        public IEnumerable<IShape> AllShapes
        {
            get { return _shape; }
        }

        public void AddTriangle(double height, double width)
        {
            _shape.Add(new Triangle(height, width));
        }

        public void AddRectangle(double height, double width)
        {
            _shape.Add(new Rectangle(height, width));
        }

        public string PrintAll()
        {
            StringBuilder builder = new StringBuilder();

            _shape.ForEach(e =>
            {
                switch (e.WhatIAm)
                {
                    case "Rectangle":
                        builder.AppendFormat("||{0}", Convert.ToInt16(e.Area));
                        break;
                    case "Triangle":
                        builder.AppendFormat("/\\{0}", Convert.ToInt16(e.Area));
                        break;
                }
            });

            return builder.ToString();
        }

    }

    /// <summary>
    /// HINT: You are expected to write classes that implement this interface
    /// </summary>
    public interface IShape
    {
        string WhatIAm { get; }
        double Area { get; }
    }

    public class Triangle : IShape
    {
        private string _whatIm;
        private double _area;
        private double _height;
        private double _width;

        public Triangle(double h, double w)
        {
            _height = h;
            _width = w;
            _whatIm = "Triangle";
        }
        public string WhatIAm
        {
            get { return _whatIm; }
        }

        public double Area
        {
            get { return 0.5 * _height * _width; }
        }
    }

    public class Rectangle : IShape
    {
        private string _whatIm;
        private double _area;
        private double _height;
        private double _width;

        public Rectangle(double h, double w)
        {
            _height = h;
            _width = w;
            _whatIm = "Rectangle";
        }
        public string WhatIAm
        {
            get { return _whatIm; }
        }

        public double Area
        {
            get { return _height * _width; }
        }
    }
}