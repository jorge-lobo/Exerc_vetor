using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    struct Point
    {
        public double x, y;

        public override string ToString()
        {
            return "(" + x + ", " + y + ")";  //ponto cartesiano (x,y)
        }
    }
}
