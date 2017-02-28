using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (!File.Exists(this.pathBox.Text))
                MessageBox.Show("File not found: " + this.pathBox.Text, "File Not Found");
            else
                this.Close();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                this.pathBox.Text = openFileDialog.FileName;
        }

        private void pathBox_Validating(object sender, CancelEventArgs e)
        {
            //remove trailing and leading whitespace and parenthesis
            this.pathBox.Text = this.pathBox.Text.Trim(' ', '"');
        }
    }
}
