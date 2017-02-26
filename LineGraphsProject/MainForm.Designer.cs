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
            this.addGraphBtn = new System.Windows.Forms.Button();
            this.drawingArea = new System.Windows.Forms.Panel();
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
            this.drawingArea.Size = new System.Drawing.Size(917, 422);
            this.drawingArea.TabIndex = 1;
            this.drawingArea.SizeChanged += new System.EventHandler(this.drawingArea_SizeChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 505);
            this.Controls.Add(this.drawingArea);
            this.Controls.Add(this.addGraphBtn);
            this.Name = "MainForm";
            this.Text = "Line Graphs Visualizer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addGraphBtn;
        private System.Windows.Forms.Panel drawingArea;
    }
}

