namespace lab2AI
{
    partial class Form1
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
            _introForm.Dispose();
           // _introForm.Show();
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
            this.p_draw = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // p_draw
            // 
            this.p_draw.AutoScroll = true;
            this.p_draw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_draw.Location = new System.Drawing.Point(0, 0);
            this.p_draw.Name = "p_draw";
            this.p_draw.Size = new System.Drawing.Size(1037, 543);
            this.p_draw.TabIndex = 0;
            this.p_draw.Paint += new System.Windows.Forms.PaintEventHandler(this.p_draw_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 543);
            this.Controls.Add(this.p_draw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_draw;
    }
}

