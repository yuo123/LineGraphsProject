namespace LineGraphsProject
{
    partial class PolynomialInputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.finish = new System.Windows.Forms.Button();
            this.orderUpDown = new System.Windows.Forms.NumericUpDown();
            this.coefficientsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // finish
            // 
            this.finish.Location = new System.Drawing.Point(228, 219);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(44, 31);
            this.finish.TabIndex = 4;
            this.finish.Text = "Finish";
            this.finish.UseVisualStyleBackColor = true;
            // 
            // orderUpDown
            // 
            this.orderUpDown.Location = new System.Drawing.Point(228, 14);
            this.orderUpDown.Name = "orderUpDown";
            this.orderUpDown.Size = new System.Drawing.Size(46, 20);
            this.orderUpDown.TabIndex = 5;
            this.orderUpDown.ValueChanged += new System.EventHandler(this.orderUpDown_ValueChanged);
            // 
            // coefficientsPanel
            // 
            this.coefficientsPanel.AutoScroll = true;
            this.coefficientsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.coefficientsPanel.Location = new System.Drawing.Point(12, 40);
            this.coefficientsPanel.Name = "coefficientsPanel";
            this.coefficientsPanel.Size = new System.Drawing.Size(260, 173);
            this.coefficientsPanel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "How many coefficients do you wish to use?";
            // 
            // PolynomialInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coefficientsPanel);
            this.Controls.Add(this.orderUpDown);
            this.Controls.Add(this.finish);
            this.Name = "PolynomialInputForm";
            this.Text = "PolynomialInputForm";
            this.Load += new System.EventHandler(this.PolynomialInputForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button finish;
        private System.Windows.Forms.NumericUpDown orderUpDown;
        private System.Windows.Forms.FlowLayoutPanel coefficientsPanel;
        private System.Windows.Forms.Label label1;

    }
}