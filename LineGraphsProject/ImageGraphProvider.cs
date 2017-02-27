using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineGraphsProject
{
    public class ImageGraphProvider : FileLineGraphProvider
    {
        public override IEnumerable<PointF> LoadFile(string path)
        {
            Bitmap bitmap = new Bitmap(path);
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    if (bitmap.GetPixel(i, j).ToArgb() != -1)
                    {
                        yield return new PointF(i, bitmap.Height - j - 1);
                        break;
                    }
                }
            }
        }
    }
}
