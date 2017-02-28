using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineGraphsProject
{
    public class Polynomial : IFunction
    {
        private double[] coefficients;

        public Polynomial(double[] coefficients)
        {
            this.coefficients = coefficients;
        }

        public double GetY(double x)
        {
            double ret = 0;
            for (int i = 0; i < this.coefficients.Length; i++)
            {
                ret += (coefficients[i] * Math.Pow(x, this.coefficients.Length - i - 1));
            }
            return ret;
        }
    }
}
