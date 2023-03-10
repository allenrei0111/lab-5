using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5_exception
{
    internal class InvalidRadiusException : Exception
    {
        public double Radius { get; set; }
        public InvalidRadiusException() : base("Invalid radius: must be greater than zero.")
        {
        }

        public InvalidRadiusException(double radius) : base("Invalid radius:" + radius)
        {
            this.Radius = radius;
        }
    }

}


        
    
