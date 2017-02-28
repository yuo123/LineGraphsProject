using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LineGraphsProject
{
    public class XmlGraphProvider : FileLineGraphProvider
    {
        public override IEnumerable<PointF> LoadFile(string path)
        {   
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlElement root = doc.DocumentElement;

            for (int i = 0; i < root.ChildNodes.Count; i++)
            {
                XmlNode point = root.ChildNodes[i];
                
                int x = int.Parse(point["x"].InnerText);
                int y = int.Parse(point["y"].InnerText);
               
                yield return new PointF(x, y);
            }
        }
    }
}
