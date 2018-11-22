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
    public partial class NrNeuroni : UserControl
    {
        public NrNeuroni(int i)
        {
            InitializeComponent();
            l_nStrat.Text += $" {i}";
        }

        public int GetNeuroni()
        {
            return numericUpDown1.Value.ToInt32();
        }
    }
}
