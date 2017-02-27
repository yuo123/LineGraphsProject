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
            this.scaleX = scaleX;
            this.scaleY = scaleY;
        }

        public void Draw(Graphics gr, int drawingWidth, int originX)
        {
            GraphicsState state = gr.Save();
            gr.ScaleTransform(this.scaleX, this.scaleY);
            //find relevant X values in graph space
            //first point for minX, second for maxX, third for minDiscernableStep
            PointF[] range = new PointF[] { new PointF(0, 0), new PointF(drawingWidth, 0), new PointF(originX + 1, 0) };
            //World = graph, Page = form
            gr.TransformPoints(CoordinateSpace.World, CoordinateSpace.Page, range);
            //GraphicsPath is used to draw a continuous line
            GraphicsPath graph = new GraphicsPath();
            PointF last = new PointF(float.NaN, float.NaN);
            foreach (PointF point in this.provider.GetPoints(range[0].X, range[1].X, range[2].X))
            {
                if (!float.IsNaN(last.X) && point.X >= range[0].X && last.X <= range[1].X)
                    graph.AddLine(last, point);
                last = point;
            }
            gr.DrawPath(new Pen(this.color), graph);
            gr.Restore(state);
        }
    }
}
