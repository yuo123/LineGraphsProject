using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineGraphsProject
{
    public class TestGraphProvider : ILineGraphProvider
    {
        public bool AskForParameters()
        {
            return true;
        }

        public IEnumerable<PointF> GetPoints(float minX, float maxX, float minDiscernableStep)
        {
            for (float x = minX; x <= maxX; x += minDiscernableStep)
                yield return new PointF(x, (float)(Math.Sin(x / 30) * 40 + x));
        }
    }
}
