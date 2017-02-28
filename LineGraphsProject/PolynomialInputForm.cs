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
    public partial class PolynomialInputForm : Form
    {
        public PolynomialInputForm()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        public Polynomial GetPolynomial()
        {
            int i = 0;
            double[] coefficients = new double[(int)orderUpDown.Value];
            foreach (Control controls in coefficientsPanel.Controls)
            {
                if (i < (int)orderUpDown.Value)
                {
                    if (!double.TryParse(controls.Text, out coefficients[i]))
                    {
                        MessageBox.Show("Invalid Input");
                        return null;
                    }
                        
                }
                i++;
            }
            return new Polynomial(coefficients);
        }

        private void PolynomialInputForm_Load(object sender, EventArgs e)
        {

        }

        private void orderUpDown_ValueChanged(object sender, EventArgs e)
        {
            OrderChanged((int)orderUpDown.Value);
        }

        private void OrderChanged(int order)
        {
            while (coefficientsPanel.Controls.Count > order)
                coefficientsPanel.Controls.RemoveAt(coefficientsPanel.Controls.Count - 1);
            while (coefficientsPanel.Controls.Count < order)
            {
                TextBox box = new TextBox();
                box.Text = "1";
                coefficientsPanel.Controls.Add(box);
            }
        }

        private void finish_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
