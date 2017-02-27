using System;
using System.Windows.Forms;

namespace LineGraphsProject
{
    partial class MainForm
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
            System.Windows.Forms.GroupBox groupBox1;
            this.addGraphBtn = new System.Windows.Forms.Button();
            this.drawingArea = new System.Windows.Forms.Panel();
            this.xMin = new System.Windows.Forms.NumericUpDown();
            this.yMin = new System.Windows.Forms.NumericUpDown();
            this.xMax = new System.Windows.Forms.NumericUpDown();
            this.yMax = new System.Windows.Forms.NumericUpDown();
            this.quickViewBtn = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMax)).BeginInit();
            this.SuspendLayout();
            // 
            // addGraphBtn
            // 
            this.addGraphBtn.Location = new System.Drawing.Point(12, 12);
            this.addGraphBtn.Name = "addGraphBtn";
            this.addGraphBtn.Size = new System.Drawing.Size(158, 53);
            this.addGraphBtn.TabIndex = 0;
            this.addGraphBtn.Text = "Add Graph...";
            this.addGraphBtn.UseVisualStyleBackColor = true;
            this.addGraphBtn.Click += new System.EventHandler(this.addGraphBtn_Click);
            // 
            // drawingArea
            // 
            this.drawingArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawingArea.Location = new System.Drawing.Point(12, 71);
            this.drawingArea.Name = "drawingArea";
            this.drawingArea.Size = new System.Drawing.Size(917, 464);
            this.drawingArea.TabIndex = 1;
            this.drawingArea.SizeChanged += new System.EventHandler(this.drawingArea_SizeChanged);
            this.drawingArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingArea_MouseDown);
            this.drawingArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingArea_MouseMove);
            this.drawingArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawingArea_MouseUp);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 13);
            label1.TabIndex = 2;
            label1.Text = "X Axis:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(119, 39);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(16, 13);
            label2.TabIndex = 3;
            label2.Text = "to";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 37);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(39, 13);
            label3.TabIndex = 4;
            label3.Text = "Y Axis:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(119, 16);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(16, 13);
            label4.TabIndex = 5;
            label4.Text = "to";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.quickViewBtn);
            groupBox1.Controls.Add(this.yMax);
            groupBox1.Controls.Add(this.xMax);
            groupBox1.Controls.Add(this.yMin);
            groupBox1.Controls.Add(this.xMin);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new System.Drawing.Point(176, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(267, 63);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quick-View";
            // 
            // xMin
            // 
            this.xMin.DecimalPlaces = 2;
            this.xMin.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.xMin.Location = new System.Drawing.Point(51, 14);
            this.xMin.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.xMin.Minimum = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            this.xMin.Name = "xMin";
            this.xMin.Size = new System.Drawing.Size(62, 20);
            this.xMin.TabIndex = 6;
            // 
            // yMin
            // 
            this.yMin.DecimalPlaces = 2;
            this.yMin.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.yMin.Location = new System.Drawing.Point(51, 37);
            this.yMin.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.yMin.Minimum = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            this.yMin.Name = "yMin";
            this.yMin.Size = new System.Drawing.Size(62, 20);
            this.yMin.TabIndex = 8;
            // 
            // xMax
            // 
            this.xMax.DecimalPlaces = 2;
            this.xMax.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.xMax.Location = new System.Drawing.Point(141, 14);
            this.xMax.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.xMax.Minimum = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            this.xMax.Name = "xMax";
            this.xMax.Size = new System.Drawing.Size(70, 20);
            this.xMax.TabIndex = 7;
            // 
            // yMax
            // 
            this.yMax.DecimalPlaces = 2;
            this.yMax.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.yMax.Location = new System.Drawing.Point(141, 37);
            this.yMax.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.yMax.Minimum = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            this.yMax.Name = "yMax";
            this.yMax.Size = new System.Drawing.Size(70, 20);
            this.yMax.TabIndex = 9;
            // 
            // quickViewBtn
            // 
            this.quickViewBtn.Location = new System.Drawing.Point(217, 16);
            this.quickViewBtn.Name = "quickViewBtn";
            this.quickViewBtn.Size = new System.Drawing.Size(44, 41);
            this.quickViewBtn.TabIndex = 10;
            this.quickViewBtn.Text = "Set";
            this.quickViewBtn.UseVisualStyleBackColor = true;
            this.quickViewBtn.Click += new System.EventHandler(this.quickViewBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 547);
            this.Controls.Add(groupBox1);
            this.Controls.Add(this.drawingArea);
            this.Controls.Add(this.addGraphBtn);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "Line Graphs Visualizer";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addGraphBtn;
        private System.Windows.Forms.Panel drawingArea;
        private NumericUpDown yMax;
        private NumericUpDown xMax;
        private NumericUpDown yMin;
        private NumericUpDown xMin;
        private Button quickViewBtn;
    }
}

