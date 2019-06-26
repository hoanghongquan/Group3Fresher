using System;

namespace Opp3
{
    class GeometricShape
    {

        private string shapetype;
        private double area;

        public GeometricShape()
        {
            this.shapetype = "No Shape";
            this.area = 0.0;
        }

        public GeometricShape(string shapetype, double area)
        {
            this.shapetype = shapetype;
            this.area = area;
        }

        public string Shapetype { get => shapetype; set => shapetype = value; }
        public double Area { get => area; set => area = value; }

        public virtual double computeArea()
        {
            return area;
        }

        public virtual void Show()
        {
            Console.WriteLine("> Shape Type: " + shapetype);
            Console.WriteLine("> Area: " + area);
        }




    }
}
