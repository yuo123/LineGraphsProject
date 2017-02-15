using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineGraphsProject
{
    public class Polynomial : IFunction
    {
        private int[] coefficients;

        public Polynomial(int[] coefficients)
        {
            this.coefficients = coefficients;
        }

        public double GetY(double x)
        {
            //TODO: implement
            return 0;
        }
    }
}
