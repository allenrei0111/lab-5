using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5_exception
{
    internal class Circle
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set { SetRadius(value); }
        }

        public Circle(double radius)
        {
            SetRadius(radius);
        }

        private void SetRadius(double radius)
        {
            if (radius <= 0)
            {
                throw new InvalidRadiusException(radius);
            }

            this.radius = radius;
        }

        public override string ToString()
        {
            return $"Circle with radius {radius}";
        }
    }
}