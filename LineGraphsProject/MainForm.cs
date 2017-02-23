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

        public Size GetDrawingAreaSize()
        {
            return this.drawingArea.ClientSize;
        }

        public MainForm()
        {
            InitializeComponent();
            this.drawingArea.Paint += DrawingArea_Paint;
        }

        private void DrawingArea_Paint(object sender, PaintEventArgs e)
        {
            foreach (LineGraphDrawer drawer in this.drawers)
            {
                drawer.Draw(e.Graphics, this.drawingArea.ClientSize);
            }
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
