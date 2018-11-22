namespace lab2AI
{
    partial class Node
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.l_out = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l_out
            // 
            this.l_out.AutoSize = true;
            this.l_out.Location = new System.Drawing.Point(3, 31);
            this.l_out.MinimumSize = new System.Drawing.Size(70, 0);
            this.l_out.Name = "l_out";
            this.l_out.Size = new System.Drawing.Size(70, 13);
            this.l_out.TabIndex = 0;
            this.l_out.Text = "0";
            this.l_out.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l_out.Click += new System.EventHandler(this.label1_Click);
            // 
            // Node
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.l_out);
            this.Name = "Node";
            this.Size = new System.Drawing.Size(80, 80);
            this.Load += new System.EventHandler(this.Node_Load);
            this.Click += new System.EventHandler(this.Node_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Node_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_out;
    }
}
