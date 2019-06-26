using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitaplab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuboid c = new Cuboid();
            c.mutator(50, 60);
            c.setHeigth(20);

            c.show();
            Console.ReadKey();
             
            
        }
       
    }
}
