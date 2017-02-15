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
    public partial class PathInputForm : Form
    {
        public PathInputForm()
        {
            InitializeComponent();
        }

        public string GetPath()
        {
            return this.pathBox.Text;
        }
    }
}
