using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesClassDiagram
{
    public class Shape
    {
        protected Location Location { get; set; }

        public override string ToString()
        {
            return "";
        }

        public double Area()
        {
            return 1.1;
        }

        public double Parametar()
        {
            return 2.2;
        }
    }
}
