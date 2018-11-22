using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2AI
{
    public partial class Intro : Form
    {
        List<NrNeuroni> _nrNeuroni = new List<NrNeuroni>();

        public Intro()
        {
            InitializeComponent();
            nUD_nSraturiAsc.Minimum = 1;
            nUD_nSraturiAsc.MouseDown += nUD_nSraturiAsc_VisibleChanged;
            nUD_nSraturiAsc.KeyUp += nUD_nSraturiAsc_VisibleChanged;
            flowLayoutPanel1.AutoScroll = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(this, nUD_nSraturiAsc.Value.ToInt32(), nUD_nIntrare.Value.ToInt32(), _nrNeuroni.ToIntList(), nUD_nIesire.Value.ToInt32());
            form.Show();
        }

        private void nUD_nSraturiAsc_VisibleChanged(object sender, EventArgs e)
        {
            _nrNeuroni = new List<NrNeuroni>();
            flowLayoutPanel1.Controls.Clear();
            for (int i = 1; i <= nUD_nSraturiAsc.Value; ++i)
            {
                NrNeuroni n = new NrNeuroni(i);
                flowLayoutPanel1.Controls.Add(n);
                _nrNeuroni.Add(n);
            }
        }
    }
}
