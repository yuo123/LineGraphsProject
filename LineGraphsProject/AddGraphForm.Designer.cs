namespace LineGraphsProject
{
    partial class AddGraphForm
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label9;
            this.sourceBox = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.yScale = new System.Windows.Forms.NumericUpDown();
            this.xScale = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xScale)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(9, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(66, 13);
            label1.TabIndex = 2;
            label1.Text = "Graph Type:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(9, 56);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(47, 13);
            label6.TabIndex = 11;
            label6.Text = "X Scale:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(9, 82);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(47, 13);
            label9.TabIndex = 14;
            label9.Text = "Y Scale:";
            // 
            // sourceBox
            // 
            this.sourceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sourceBox.FormattingEnabled = true;
            this.sourceBox.Location = new System.Drawing.Point(81, 6);
            this.sourceBox.Name = "sourceBox";
            this.sourceBox.Size = new System.Drawing.Size(163, 21);
            this.sourceBox.TabIndex = 0;
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.Location = new System.Drawing.Point(180, 107);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(74, 26);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // yScale
            // 
            this.yScale.DecimalPlaces = 2;
            this.yScale.Location = new System.Drawing.Point(64, 80);
            this.yScale.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.yScale.Name = "yScale";
            this.yScale.Size = new System.Drawing.Size(74, 20);
            this.yScale.TabIndex = 16;
            // 
            // xScale
            // 
            this.xScale.DecimalPlaces = 2;
            this.xScale.Location = new System.Drawing.Point(64, 54);
            this.xScale.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.xScale.Name = "xScale";
            this.xScale.Size = new System.Drawing.Size(74, 20);
            this.xScale.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Scale:";
            // 
            // AddGraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 145);
            this.Controls.Add(label6);
            this.Controls.Add(this.yScale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.xScale);
            this.Controls.Add(label9);
            this.Controls.Add(label1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.sourceBox);
            this.Name = "AddGraphForm";
            this.Text = "AddGraphForm";
            ((System.ComponentModel.ISupportInitialize)(this.yScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xScale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sourceBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.NumericUpDown yScale;
        private System.Windows.Forms.NumericUpDown xScale;
        private System.Windows.Forms.Label label2;

    }
}