using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitaplab3
{
    class Retangle : GeometricShape
    {
        public  Retangle() { }

        public double length;
        public double width;
        public void mutator(double Length,double Width)
        {
            this.length = Length;
            this.width = Width;
        }
        public double accessorlength(double length)
        {
            return length;
        }
        public double accessorwidth(double width)
        {
            return width;
        }
        public override double computArea()
        {
            return this.length * this.width;
        }
        public override void show()
        {
            Console.WriteLine("------Retangle----------");
            base.show();
            Console.WriteLine("Length:" + length);
            Console.WriteLine("Width:" + width);
            
        }

    }
    
}
       
        
    
    
    

    

   
    

    
 

