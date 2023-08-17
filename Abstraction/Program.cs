using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(20,25);
            rectangle.Calculatearea();
            Console.WriteLine(rectangle);
        }
    }
}
