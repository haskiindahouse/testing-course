using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Triangle
    {
        private float a = 1;
        private float b = 1;
        private float c = 1;

        public double s 
        {
            get 
            {
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c)); 
            }

            private set {}
        }

        public bool isRectangular
        {
            get 
            {
                return (a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a);
            }

            private set { }
        }
        
        public bool isIsosceles 
        {
            get 
            {
                return a == b || a == c || b == c;
            }
            
            private set { }
        }

        public bool isSuper
        {
            get 
            {
                return isRectangular && isIsosceles;
            }

            private set { }
        }

        public Triangle(float a, float b, float c) 
        {
            if (a < 0 || b < 0 || c < 0)
                throw new NegativeException();
            else if (!(((a + b) > c) && ((b + c) > a) && ((a + c) > b)))
                throw new UnexistingException();
              
            this.a = a;
            this.b = b;
            this.c = c;
        }
    }
}
