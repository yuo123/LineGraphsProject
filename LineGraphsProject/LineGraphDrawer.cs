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
        private const int POINT_RADIUS = 5;
        private const int LINE_WIDTH = 1;

        private ILineGraphProvider provider;
        private float scaleX;
        private float scaleY;
        private Color color;
        //specifies whether points are marked with dots
        private bool markPoints;

        public LineGraphDrawer(ILineGraphProvider provider, float scaleX, float scaleY, Color color, bool markPoints)
        {
            this.provider = provider;
            this.color = color;
            this.scaleX = scaleX;
            this.scaleY = scaleY;
            this.markPoints = markPoints;
        }

        public void Draw(Graphics gr, Size drawingSize, Point origin)
        {
            GraphicsState state = gr.Save();
            gr.ScaleTransform(this.scaleX, this.scaleY);
            //find relevant X values in graph space
            //first point for minX, second for maxX, third for minDiscernableStep
            PointF[] range = new PointF[] { new PointF(0, drawingSize.Height), new PointF(drawingSize.Width, 0), new PointF(origin.X + 1, origin.Y + 1) };
            //World = graph, Page = form
            gr.TransformPoints(CoordinateSpace.World, CoordinateSpace.Page, range);

            //GraphicsPath is used to draw a continuous line
            GraphicsPath graph = null;
            Brush ptsBrush = null;
            Pen pen = null;
            try
            {
                //widths and sizes are set to the average they needs to be (between the two axes) in order to be LINE_WIDTH and POINT_RADIUS
                float scalingFactor = 1 / (Math.Abs(gr.Transform.Elements[0]) + Math.Abs(gr.Transform.Elements[1]));
                graph = new GraphicsPath();
                PointF last = new PointF(float.NaN, float.NaN);
                ptsBrush = new SolidBrush(this.color);
                foreach (PointF point in this.provider.GetPoints(range[0].X, range[1].X, range[2].X))
                {
                    if (!float.IsNaN(last.X) && point.X >= range[0].X && last.X <= range[1].X
                        && point.Y >= range[0].Y && point.Y <= range[1].Y)
                        graph.AddLine(last, point);
                    if (this.markPoints)
                        gr.FillEllipse(ptsBrush, point.X - POINT_RADIUS * scalingFactor, point.Y - POINT_RADIUS * scalingFactor, POINT_RADIUS * 2 * scalingFactor, POINT_RADIUS * 2 * scalingFactor);
                    last = point;
                }
                pen = new Pen(this.color, scalingFactor * LINE_WIDTH);
                gr.DrawPath(pen, graph);
            }
            catch (OverflowException)
            {
                //OverflowException is thrown when a point is drawn too far out of the screen bounds.
                //In that case, there is no need to do anything, since the point will not be visible anyway.
            }
            finally
            {
                pen.Dispose();
                ptsBrush.Dispose();
                graph.Dispose();
            }

            gr.Restore(state);
        }
    }
}
