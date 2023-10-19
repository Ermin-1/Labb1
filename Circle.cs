using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1
{
    internal class Circle
    {
        float _pi = 3.141f;
        int _Radius;

        public Circle(int radius)
        {
            _Radius = radius;
        }


        public void getArea()
        {
            Console.WriteLine(_Radius * _Radius * _pi);
        }

    }
}
