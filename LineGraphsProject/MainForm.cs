using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace LineGraphsProject
{
    public partial class MainForm : Form
    {
        private List<LineGraphDrawer> drawers;
        private Point origin;
        private SizeF scale;

        private const float SCALING_FACTOR = 0.001f;

        #region Axis Parameters
        //all values in pixels

        //thickness of the axes lines
        private const float AXIS_WIDTH = 5f;
        //thickness of the markers (horizontal for x-axis)
        private const float MARKER_WIDTH = 2f;
        //length of the markers (vertical for x-axis)
        private const float MARKER_LENGTH = 16f;
        //space between adjacent markers
        private const int MARKER_SPACING = 40;
        #endregion

        public Size GetDrawingAreaSize()
        {
            return this.drawingArea.ClientSize;
        }

        public MainForm()
        {
            InitializeComponent();
            //initialize the origin to the center of the drawing area
            this.origin = new Point(drawingArea.ClientSize.Width / 2, drawingArea.ClientSize.Height / 2);
            //initialize the scale to 1:1
            this.scale = new SizeF(1, 1);
            this.drawers = new List<LineGraphDrawer>();
            //sets drawingArea.DoubleBuffered, even tough it is protected
            this.drawingArea.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(this.drawingArea, true);
            this.drawingArea.Paint += DrawingArea_Paint;
            this.drawingArea.MouseWheel += DrawingArea_MouseWheel;
        }

        private void DrawingArea_Paint(object sender, PaintEventArgs e)
        {
            PaintAxes(e.Graphics);

            //center the graphics object on the origin, and scale it
            e.Graphics.TranslateTransform(this.origin.X, this.origin.Y);
            //scaling by -Height to invert the y-axis
            e.Graphics.ScaleTransform(scale.Width, -scale.Height);

            //draw graphs
            foreach (LineGraphDrawer drawer in this.drawers)
                drawer.Draw(e.Graphics, this.drawingArea.ClientSize.Width, origin.X);

            e.Graphics.ResetTransform();
        }

        private void PaintAxes(Graphics gr)
        {
            Pen axesPen = new Pen(Color.Black, AXIS_WIDTH);
            axesPen.EndCap = LineCap.ArrowAnchor;
            gr.DrawLine(axesPen, 0, origin.Y, drawingArea.ClientSize.Width, origin.Y); //X axis
            gr.DrawLine(axesPen, origin.X, drawingArea.ClientSize.Height, origin.X, 0); //Y axis

            //both axis calculations start from the coordinate which will pass exactly at zero, 
            //and continue as long as there is ample space between the marker and the end of the axis (as to not overlap the arrow).
            //Y axis goes backwards, as the usual convention of graphs is down-up but winforms goes up-down

            //X axis markers
            Pen markersPen = new Pen(Color.Black, MARKER_WIDTH);
            for (int x = origin.X % MARKER_SPACING; x + MARKER_SPACING < drawingArea.ClientSize.Width; x += MARKER_SPACING)
            {
                //marker
                gr.DrawLine(markersPen, x, origin.Y - (MARKER_LENGTH / 2), x, origin.Y + (MARKER_LENGTH / 2));

                //text
                //((x - origin.X) * scale.Width) ≡ the x-coordinate of the marker in graph-space
                string text = Math.Round((x - origin.X) / scale.Width, 2).ToString();
                SizeF tSize = gr.MeasureString(text, drawingArea.Font);
                //tRect has size tSize and is centered below the marker
                RectangleF tRect = new RectangleF(new PointF(x - (tSize.Width / 2), origin.Y + (MARKER_LENGTH / 2)), tSize);
                gr.DrawString(text, drawingArea.Font, Brushes.Black, tRect);
            }
            //Y axis markers
            for (int y = Floor(drawingArea.ClientSize.Height, MARKER_SPACING) + origin.Y % MARKER_SPACING; y - MARKER_SPACING > 0; y -= MARKER_SPACING)
            {
                //marker
                gr.DrawLine(markersPen, origin.X - (MARKER_LENGTH / 2), y, origin.X + (MARKER_LENGTH / 2), y);

                //text
                //((y - origin.Y) * scale.Height) ≡ the y-coordinate of the marker in graph-space
                string text = Math.Round((origin.Y - y) / scale.Height, 2).ToString();
                SizeF tSize = gr.MeasureString(text, drawingArea.Font);
                //tRect has size tSize and is centered below the marker
                RectangleF tRect = new RectangleF(new PointF(origin.X - (MARKER_LENGTH / 2) - tSize.Width, y - (tSize.Height / 2)), tSize);
                gr.DrawString(text, drawingArea.Font, Brushes.Black, tRect);
            }


            axesPen.Dispose();
            markersPen.Dispose();
        }

        private int Floor(int num, int multiples)
        {
            return multiples * (num / multiples);
        }

        private void addGraphBtn_Click(object sender, EventArgs e)
        {
            AddGraph();
        }

        /// <summary>
        /// Asks the user to select parameters for a new graph
        /// </summary>
        private void AddGraph()
        {
            AddGraphForm form = new AddGraphForm();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                this.drawers.Add(form.GetDrawer());
                drawingArea.Invalidate();
            }
        }

        /// <summary>
        /// Clears all the graphs from the screen
        /// </summary>
        private void ClearGraphs()
        {
            drawers.Clear();
            this.drawingArea.Invalidate();
        }

        private void SetOrigin(int x, int y)
        {
            this.origin = new Point(x, y);
            drawingArea.Invalidate();
        }

        private void drawingArea_SizeChanged(object sender, EventArgs e)
        {
            drawingArea.Invalidate();
        }

        #region Dragging
        private bool dragging;
        private Point dragPos;
        private Point dragOrigin;

        private void StartDragging(Point mousePos)
        {
            this.dragPos = mousePos;
            this.dragOrigin = this.origin;
            this.dragging = true;
        }

        private void ContinueDragging(Point mousePos)
        {
            SetOrigin(dragOrigin.X + mousePos.X - dragPos.X, dragOrigin.Y + mousePos.Y - dragPos.Y);
        }

        private void StopDragging(Point mousePos)
        {
            ContinueDragging(mousePos);
            this.dragging = false;
        }

        private void drawingArea_MouseDown(object sender, MouseEventArgs e)
        {
            StartDragging(e.Location);
        }

        private void drawingArea_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.dragging)
                ContinueDragging(e.Location);
        }

        private void drawingArea_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.dragging)
                StopDragging(e.Location);
        }
        #endregion

        private void quickViewBtn_Click(object sender, EventArgs e)
        {
            float x = (float)(xMax.Value - xMin.Value);
            float y = (float)(yMax.Value - yMin.Value);
            if (double.IsInfinity(1 / x))
            {
                MessageBox.Show("Invalid X Range. Please enter again.");
                return;
            }
            if (double.IsInfinity(1 / y))
            {
                MessageBox.Show("Invalid Y Range. Please enter again.");
                return;
            }

            //scale is screen-space divided by graph-space
            this.scale = new SizeF(drawingArea.ClientSize.Width / x, drawingArea.ClientSize.Height / y);
            //origin is minus the min value (then converted to screen-space). y axis is flipped as always
            SetOrigin((int)((float)-xMin.Value * this.scale.Width), drawingArea.ClientRectangle.Height - (int)((float)-yMin.Value * this.scale.Height));
        }

        private void drawingArea_MouseEnter(object sender, EventArgs e)
        {
            drawingArea.Focus();
        }

        private void DrawingArea_MouseWheel(object sender, MouseEventArgs e)
        {
            //Pow() is used so that a certain number of detents will always give the same scaling
            float scale = (float)Math.Pow(1 + SCALING_FACTOR, e.Delta);

            float scaleX = scale;
            //holding shift scales Y only
            if (ModifierKeys.HasFlag(Keys.Shift))
                scaleX = 1;

            float scaleY = scale;
            //holding Ctrl scales X only
            if (ModifierKeys.HasFlag(Keys.Control))
                scaleY = 1;

            ScaleAroundPoint(scaleX, scaleY, e.Location);

            drawingArea.Invalidate();
        }

        private void ScaleAroundPoint(float factorX, float factorY, Point location)
        {
            this.scale = new SizeF(this.scale.Width * factorX, this.scale.Height * factorY);
            SetOrigin((int)(location.X - ((location.X - origin.X) * factorX)), (int)(location.Y - (location.Y - origin.Y) * factorY));
            drawingArea.Invalidate();
        }
    }
}
