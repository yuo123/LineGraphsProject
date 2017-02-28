using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineGraphsProject
{
    public abstract class FileLineGraphProvider : ILineGraphProvider
    {
        //the points loaded the file
        private IEnumerable<PointF> points;

        public bool AskForParameters()
        {
            PathInputForm pathDiag = new PathInputForm();
            if (pathDiag.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.points = this.LoadFile(pathDiag.GetPath()).ToList();
                    return true;
                }
                catch (Exception ex)
                {
                    //in case there was a problem loading (probably because of unrecognized format), abort initialization
                    MessageBox.Show("Error loading the file: " + ex.Message, "Error");
                    return false;
                }
            }
            else
                return false;
        }

        public abstract IEnumerable<PointF> LoadFile(string path);

        public IEnumerable<PointF> GetPoints(float minX, float maxX, float minDiscernableStep)
        {
            return this.points;
        }
    }
}
