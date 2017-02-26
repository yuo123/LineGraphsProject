using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace LineGraphsProject
{
    public class ColorSelectionButton : Button
    {
        private static ColorDialog m_diag = new ColorDialog();

        public override string Text
        {
            get
            {
                return "";
            }

            set
            {
                return;
            }
        }

        public ColorSelectionButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.Text = "";
            this.UseVisualStyleBackColor = false;
        }

        protected override void OnClick(EventArgs e)
        {
            if (m_diag.ShowDialog() == DialogResult.OK)
                this.BackColor = m_diag.Color;
            base.OnClick(e);
        }
    }
}
