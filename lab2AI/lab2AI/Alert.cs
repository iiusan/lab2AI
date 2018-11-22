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
    public partial class Alert : Form
    {
        public decimal Out {  get { return (_data.Nodes.Count == 0) ? nUD_initOut.Value : nUD_out.Value; } }
        public decimal W {  get { return nUD_inW.Value; } }
        public decimal X {  get { return nUD_inX.Value; } }

        private AllData _data;

        public Alert(AllData data)
        {
            InitializeComponent();
            _data = data;
            foreach(var node in data.Nodes)
            {
                flowLayoutPanel1.Controls.Add(new RightNode(node.NodeData.TotalOut));
            }

            if (data.Nodes.Count == 0)
            {
                p_allNodes.Hide();
                nUD_inW.ValueChanged += In_ValueChanged;
                nUD_inW.MouseUp += In_ValueChanged;
                nUD_inW.KeyUp += In_ValueChanged;
                nUD_inX.ValueChanged += In_ValueChanged;
                nUD_inX.MouseUp += In_ValueChanged;
                nUD_inX.KeyUp += In_ValueChanged;
                nUD_inW.Value = data.W;
                nUD_inX.Value = data.X;
            }
            else
            {
                p_int.Hide();
                //get nUD from UC, add value changed  ev.(foreach)
                nUD_gin.Value = GetIn();
                l_func.Text = data.ActType;
                Act.ShowControlsFor(data.ActType, p_gVal, p_tVal);
                UpdateActValue();
                nUD_gin.ValueChanged += Gin_ValueChanged;
                nUD_gin.MouseUp += Gin_ValueChanged;
                nUD_gin.KeyUp += Gin_ValueChanged;

                nUP_t.ValueChanged += Gin_ValueChanged;
                nUP_t.MouseUp += Gin_ValueChanged;
                nUP_t.KeyUp += Gin_ValueChanged;

                nUP_ga.ValueChanged += Gin_ValueChanged;
                nUP_ga.MouseUp += Gin_ValueChanged;
                nUP_ga.KeyUp += Gin_ValueChanged;

                tB_binary.CheckStateChanged += Gin_ValueChanged;
            }
        }

        private void Gin_ValueChanged(object sender, EventArgs e)
        {
            UpdateActValue();
        }

        private void In_ValueChanged(object sender, EventArgs e)
        {
            nUD_initOut.Value = nUD_inW.Value * nUD_inX.Value;

        }


        private void InStratAscuns_ValueChanged(object sender, EventArgs e)
        {
            nUD_gin.Value = GetIn();

        }

        private void UpdateActValue()
        {
            var act = Convert.ToDecimal(Act.GetActFor(_data.ActType, nUD_gin.Value.ToDouble(), nUP_t.Value.ToDouble(), nUP_ga.Value.ToDouble()));

            nUD_act.Value = act;
            if (tB_binary.Checked)
            {
                nUD_out.Value = Convert.ToDecimal(Act.GetActBinaryForRes(_data.ActType, nUD_gin.Value.ToDouble(), nUP_t.Value.ToDouble(), nUP_ga.Value.ToDouble()));
            }
            else
            {
                nUD_out.Value = act;
            }

        }

        /// <summary>
        /// gets gin(sum only)-produs, ...
        /// </summary>
        /// <returns></returns>
        private decimal GetIn()
        {
            decimal d = 0;
            foreach (var node in _data.Nodes)
            {
                d += node.Out;
            }
            return d;
        }
    }
}
