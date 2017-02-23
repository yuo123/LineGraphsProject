﻿namespace LineGraphsProject
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label9;
            this.sourceBox = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.minX = new System.Windows.Forms.NumericUpDown();
            this.maxX = new System.Windows.Forms.NumericUpDown();
            this.minY = new System.Windows.Forms.NumericUpDown();
            this.maxY = new System.Windows.Forms.NumericUpDown();
            this.byRangePanel = new System.Windows.Forms.Panel();
            this.byScalePanel = new System.Windows.Forms.Panel();
            this.yScale = new System.Windows.Forms.NumericUpDown();
            this.xScale = new System.Windows.Forms.NumericUpDown();
            this.byScaleBtn = new System.Windows.Forms.RadioButton();
            this.byRangeBtn = new System.Windows.Forms.RadioButton();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.minX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxY)).BeginInit();
            this.byRangePanel.SuspendLayout();
            this.byScalePanel.SuspendLayout();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(3, 5);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(52, 13);
            label2.TabIndex = 3;
            label2.Text = "X Range:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(138, 5);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(20, 13);
            label3.TabIndex = 4;
            label3.Text = "To";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(138, 31);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(20, 13);
            label4.TabIndex = 8;
            label4.Text = "To";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(3, 31);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(52, 13);
            label5.TabIndex = 7;
            label5.Text = "Y Range:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(3, 5);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(47, 13);
            label6.TabIndex = 11;
            label6.Text = "X Scale:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(3, 31);
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
            this.addBtn.Location = new System.Drawing.Point(172, 207);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(74, 26);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // minX
            // 
            this.minX.DecimalPlaces = 2;
            this.minX.Location = new System.Drawing.Point(58, 3);
            this.minX.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.minX.Name = "minX";
            this.minX.Size = new System.Drawing.Size(74, 20);
            this.minX.TabIndex = 5;
            // 
            // maxX
            // 
            this.maxX.DecimalPlaces = 2;
            this.maxX.Location = new System.Drawing.Point(164, 3);
            this.maxX.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.maxX.Name = "maxX";
            this.maxX.Size = new System.Drawing.Size(74, 20);
            this.maxX.TabIndex = 6;
            // 
            // minY
            // 
            this.minY.DecimalPlaces = 2;
            this.minY.Location = new System.Drawing.Point(58, 29);
            this.minY.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.minY.Name = "minY";
            this.minY.Size = new System.Drawing.Size(74, 20);
            this.minY.TabIndex = 10;
            // 
            // maxY
            // 
            this.maxY.DecimalPlaces = 2;
            this.maxY.Location = new System.Drawing.Point(164, 29);
            this.maxY.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.maxY.Name = "maxY";
            this.maxY.Size = new System.Drawing.Size(74, 20);
            this.maxY.TabIndex = 9;
            // 
            // byRangePanel
            // 
            this.byRangePanel.Controls.Add(label2);
            this.byRangePanel.Controls.Add(this.minY);
            this.byRangePanel.Controls.Add(label3);
            this.byRangePanel.Controls.Add(this.maxY);
            this.byRangePanel.Controls.Add(this.minX);
            this.byRangePanel.Controls.Add(label4);
            this.byRangePanel.Controls.Add(this.maxX);
            this.byRangePanel.Controls.Add(label5);
            this.byRangePanel.Location = new System.Drawing.Point(6, 131);
            this.byRangePanel.Name = "byRangePanel";
            this.byRangePanel.Size = new System.Drawing.Size(255, 67);
            this.byRangePanel.TabIndex = 11;
            // 
            // byScalePanel
            // 
            this.byScalePanel.Controls.Add(label6);
            this.byScalePanel.Controls.Add(this.yScale);
            this.byScalePanel.Controls.Add(this.xScale);
            this.byScalePanel.Controls.Add(label9);
            this.byScalePanel.Enabled = false;
            this.byScalePanel.Location = new System.Drawing.Point(6, 53);
            this.byScalePanel.Name = "byScalePanel";
            this.byScalePanel.Size = new System.Drawing.Size(255, 49);
            this.byScalePanel.TabIndex = 12;
            // 
            // yScale
            // 
            this.yScale.DecimalPlaces = 2;
            this.yScale.Location = new System.Drawing.Point(58, 29);
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
            this.xScale.Location = new System.Drawing.Point(58, 3);
            this.xScale.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.xScale.Name = "xScale";
            this.xScale.Size = new System.Drawing.Size(74, 20);
            this.xScale.TabIndex = 13;
            // 
            // byScaleBtn
            // 
            this.byScaleBtn.AutoSize = true;
            this.byScaleBtn.Location = new System.Drawing.Point(6, 30);
            this.byScaleBtn.Name = "byScaleBtn";
            this.byScaleBtn.Size = new System.Drawing.Size(70, 17);
            this.byScaleBtn.TabIndex = 13;
            this.byScaleBtn.TabStop = true;
            this.byScaleBtn.Text = "By Scale:";
            this.byScaleBtn.UseVisualStyleBackColor = true;
            this.byScaleBtn.CheckedChanged += new System.EventHandler(this.byScaleBtn_CheckedChanged);
            // 
            // byRangeBtn
            // 
            this.byRangeBtn.AutoSize = true;
            this.byRangeBtn.Checked = true;
            this.byRangeBtn.Location = new System.Drawing.Point(6, 108);
            this.byRangeBtn.Name = "byRangeBtn";
            this.byRangeBtn.Size = new System.Drawing.Size(75, 17);
            this.byRangeBtn.TabIndex = 14;
            this.byRangeBtn.TabStop = true;
            this.byRangeBtn.Text = "By Range:";
            this.byRangeBtn.UseVisualStyleBackColor = true;
            // 
            // AddGraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 241);
            this.Controls.Add(this.byRangeBtn);
            this.Controls.Add(this.byScaleBtn);
            this.Controls.Add(this.byScalePanel);
            this.Controls.Add(this.byRangePanel);
            this.Controls.Add(label1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.sourceBox);
            this.Name = "AddGraphForm";
            this.Text = "AddGraphForm";
            ((System.ComponentModel.ISupportInitialize)(this.minX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxY)).EndInit();
            this.byRangePanel.ResumeLayout(false);
            this.byRangePanel.PerformLayout();
            this.byScalePanel.ResumeLayout(false);
            this.byScalePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xScale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sourceBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.NumericUpDown minX;
        private System.Windows.Forms.NumericUpDown maxX;
        private System.Windows.Forms.NumericUpDown minY;
        private System.Windows.Forms.NumericUpDown maxY;
        private System.Windows.Forms.Panel byRangePanel;
        private System.Windows.Forms.Panel byScalePanel;
        private System.Windows.Forms.NumericUpDown yScale;
        private System.Windows.Forms.NumericUpDown xScale;
        private System.Windows.Forms.RadioButton byScaleBtn;
        private System.Windows.Forms.RadioButton byRangeBtn;

    }
}