using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LineGraphsProject
{
    /// <summary>
    /// Responsible for drawing a single ILineGraphProvider on a form
    /// </summary>
    public class LineGraphDrawer
    {
        private ILineGraphProvider provider;
        private float scaleX;
        private float scaleY;

        public LineGraphDrawer(ILineGraphProvider provider)
        {
            this.provider = provider;
        }

        public void Draw(Graphics gr, Size screenSize)
        {
            gr.ScaleTransform(this.scaleX, this.scaleY);
            //TODO: implement
            gr.ResetTransform();
        }
    }
}
