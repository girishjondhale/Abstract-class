using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class Abstract
    {
        public abstract void Calculatearea();
    }

    public class Rectangle : Abstract
    {
        public int length, breadth;
        public int area;
        public Rectangle(int length, int breadth)
        { 
            this.length = length;
            this.breadth = breadth;
        }
        public override void Calculatearea()
        { 
            area=length*breadth;
        }

        public override string ToString()
        {
            return$"area of rectangle={area }"; 
        }


    }
}
