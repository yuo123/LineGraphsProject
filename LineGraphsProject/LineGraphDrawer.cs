using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

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

        public void Draw(Graphics gr, int drawingWidth)
        {
            GraphicsState state = gr.Save();
            gr.ScaleTransform(this.scaleX, this.scaleY);
            PointF[] range = new PointF[] { new PointF(0, 0), new PointF(drawingWidth, 0) };
            gr.TransformPoints(CoordinateSpace.World, CoordinateSpace.Page, range);
            foreach (PointF point in this.provider.GetPoints(range[0].X, range[1].X, 1))
            {

            }
            gr.Restore(state);
        }
    }
}
