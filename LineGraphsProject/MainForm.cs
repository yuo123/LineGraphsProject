using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineGraphsProject
{
    public partial class MainForm : Form
    {
        private List<LineGraphDrawer> drawers;
        private Point origin;
        private SizeF scale;

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
            this.drawingArea.Paint += DrawingArea_Paint;
        }

        private void DrawingArea_Paint(object sender, PaintEventArgs e)
        {
            //center the graphics object on the origin, and scale it
            e.Graphics.TranslateTransform(this.origin.X, this.origin.Y);
            e.Graphics.ScaleTransform(scale.Width, scale.Height);
            foreach (LineGraphDrawer drawer in this.drawers)
                drawer.Draw(e.Graphics, this.drawingArea.ClientSize.Width, origin.X);

            e.Graphics.ResetTransform();
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
            form.ShowDialog(this);
            this.drawers.Add(form.GetDrawer());
        }

        /// <summary>
        /// Clears all the graphs from the screen
        /// </summary>
        private void ClearGraphs()
        {
            drawers.Clear();
            this.drawingArea.Invalidate();
        }
    }
}
