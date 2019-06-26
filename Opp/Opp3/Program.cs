using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuboid cuboid = new Cuboid();

            Console.WriteLine("- Shape Type: ");
            cuboid.Shapetype = Console.ReadLine();

            Console.WriteLine("- Height: ");
            cuboid.Height = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            Console.WriteLine("- Width: ");
            cuboid.Width = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            Console.WriteLine("- Leight: ");
            cuboid.Length = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            cuboid.computeArea();

            cuboid.Show();

            //Rectangle rectangle = new Rectangle();

            //Console.WriteLine("- Shape Type: ");
            //rectangle.Shapetype = Console.ReadLine();

            //Console.WriteLine("- Lenght: ");
            //rectangle.Length = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            //Console.WriteLine("- Width: ");
            //rectangle.Width = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            //rectangle.computeArea();

            //rectangle.Show();

            Console.ReadKey();
        }
    }
}
