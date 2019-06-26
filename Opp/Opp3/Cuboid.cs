using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opp3
{
    class Cuboid:Rectangle
    {
        private double height;

        public Cuboid()
        {
        }

        public Cuboid(string shapetype, double area) : base(shapetype, area)
        {

        }

        public double Height { get => height; set => height = value; }

        public override double computeArea()
        {
            
            return Area = base.computeArea()* Height;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("> Length: " + Height);
        }
    }
}
