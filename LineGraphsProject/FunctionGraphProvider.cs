using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineGraphsProject
{
    public class FunctionGraphProvider : ILineGraphProvider
    {
        private IFunction function;

        public bool AskForParameters()
        {
            PolynomialInputForm myForm = new PolynomialInputForm();
            while (this.function == null)
            {
                if (myForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    this.function = myForm.GetPolynomial();
                else
                    return false;
            }
            return true;
        }

        public IEnumerable<PointF> GetPoints(float minX, float maxX, float minDiscernableStep)
        {
            for (float x = minX; x <= maxX; x += minDiscernableStep)
            {
                yield return new PointF(x, (float)this.function.GetY(x));
            }
        }
    }
}
