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
    public partial class RightNode : UserControl
    {
        public decimal Out { get { return nUD_inW.Value; } }

        public RightNode(decimal val)
        {
            InitializeComponent();
            nUD_inW.Value = val;
        }
    }
}
