using System;
using System.Collections.Generic;
using System.Drawing;
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
                this.points = this.LoadFile(pathDiag.GetPath()).ToList();
                return true;
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
