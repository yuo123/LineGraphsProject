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

        public void AskForParameters()
        {
            PathInputForm pathDiag = new PathInputForm();
            pathDiag.ShowDialog();
            this.points = this.LoadFile(pathDiag.GetPath()).ToList();
        }

        public abstract IEnumerable<PointF> LoadFile(string path);

        public IEnumerable<PointF> GetPoints()
        {
            return this.points;
        }
    }
}
