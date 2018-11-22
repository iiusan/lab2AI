using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2AI
{
    public partial class Node : UserControl
    {
        public AllData NodeData = new AllData();

        public decimal Out { set { l_out.Text = value.ToString(); NodeData.TotalOut = value; } get { return l_out.Text.ToDecimal(); } }

        public Node()
        {
            InitializeComponent();
        }


        private void Node_Load(object sender, EventArgs e)
        {
            l_out.BackColor = Color.White;

        }

        private void Node_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 2);
            Graphics graphics = e.Graphics;
            graphics.FillEllipse(Brushes.White, 0, 0, 78, 78);
            graphics.DrawEllipse(pen, 0, 0, 78, 78);
            pen.Dispose();
        }

        public Point GetMLocation()
        {
            return new Point(this.Location.X + 40, this.Location.Y + 40);
        }

        private void Node_Click(object sender, EventArgs e)
        {
            OnClick();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            OnClick();
        }


        private void OnClick()
        {
                Alert alert = new Alert(NodeData);
                alert.ShowDialog();
                Out = alert.Out;
                NodeData.W = alert.W;
                NodeData.X = alert.X;
        }

    }
}
