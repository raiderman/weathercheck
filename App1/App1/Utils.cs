using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class Utils
    {
        public double Celcius(double fahrenheit)
        {
            double c = 5.0 / 9.0 * (fahrenheit - 32);

            return c;
        }
        
        public double Kilometers(double millas)
        {
            double k = 1.60934 * millas;

            return k;

        }
    }
}
