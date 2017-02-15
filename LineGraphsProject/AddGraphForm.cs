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
    /// <summary>
    /// A form for choosing a graph type and range
    /// </summary>
    public partial class AddGraphForm : Form
    {
        private ILineGraphProvider provider;

        public AddGraphForm()
        {
            InitializeComponent();
            //TODO: implement from some click event
        }

        public ILineGraphProvider GetProvider()
        {
            return this.provider;
        }
    }
}
