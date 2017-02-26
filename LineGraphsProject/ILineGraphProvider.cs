using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LineGraphsProject
{
    public interface ILineGraphProvider
    {
        IEnumerable<PointF> GetPoints(float minX, float maxX, float minDiscernableStep);
        /// <summary>
        /// Asks the user for parameters for the graph source
        /// </summary>
        void AskForParameters();
    }
}
