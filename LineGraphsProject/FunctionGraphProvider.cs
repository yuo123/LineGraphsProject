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
            //TODO: implement
            return false;
        }

        public IEnumerable<PointF> GetPoints(float minX, float maxX, float minDiscernableStep)
        {
            //TODO: implement
            return null;
        }
    }
}
