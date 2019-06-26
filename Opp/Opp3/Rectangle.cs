using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opp3
{
    class Rectangle : GeometricShape
    {
        private double length;
        private double width;

        public Rectangle()
        {

        }

        public Rectangle(string shapetype, double area) : base(shapetype, area)
        {

        }

        public double Length { get => length; set => length = value; }
        public double Width { get => width; set => width = value; }


        public override double computeArea()
        {
            return Area = base.computeArea()*Width;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("> Length: " + length);
            Console.WriteLine("> Width: " + width);
        }



    }
}
