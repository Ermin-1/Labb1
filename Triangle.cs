using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1
{
    internal class Triangle
    {
 
        public float height;
        public float width;

        public Triangle(float height, float width)
        {
            this.height = height;
            this.width = width;
        }

        public void triangelArea()
        {
            Console.WriteLine(height * width /2 );
        }
    }
}
