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
        private Color color;

        public LineGraphDrawer(ILineGraphProvider provider, float scaleX, float scaleY, Color color)
        {
            this.provider = provider;
            this.color = color;
            provider.AskForParameters();
        }

        public void Draw(Graphics gr, Size screenSize)
        {
            gr.ScaleTransform(this.scaleX, this.scaleY);
            //TODO: implement
            gr.ResetTransform();
        }
    }
}
