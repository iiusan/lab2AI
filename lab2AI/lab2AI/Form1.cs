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
    public partial class Form1 : Form
    {
        private Form _introForm;
        private int _nNodIntrare, _nNodIesire, _nStarturiAsc;
        private List<int> _nNodAscuns = new List<int>();
        private List<Node> nodIntrare = new List<Node>();
        private static List<List<Node>> nodAscuns = new List<List<Node>>();
        private List<Node> nodIesire = new List<Node>();

        private List<ComboBox> actFunct = new List<ComboBox>();

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Form introForm, int nStratAsc, int nNodIntrare, List<int> nNodAscuns, int nNodIesire)
        {
            InitializeComponent();
            _introForm = introForm;
            _nNodIntrare = nNodIntrare;
            _nNodAscuns = nNodAscuns;
            _nNodIesire = nNodIesire;
            _nStarturiAsc = nStratAsc;

            _introForm.Hide();

            BuildNodes();
            BuildActFuncCombo();
            AttachData();
            this.Refresh();
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }


        private void p_draw_Paint(object sender, PaintEventArgs e)
        {
            DrawLines(e.Graphics);

        }

        private void DrawLines(Graphics graphics)
        {
            Pen pen = new Pen(Color.Black);

            foreach (var nodInt in nodIntrare)
            {
                foreach (var nodAsc in nodAscuns[0])
                {
                    graphics.DrawLine(pen, nodInt.GetMLocation(), nodAsc.GetMLocation());
                }
            }

            int i = 0;
            int j = 1;
            while (nodAscuns.Count != j)
            {
                foreach (var nodAsc1 in nodAscuns[i])
                {
                    foreach (var nodAsc2 in nodAscuns[j])
                    {
                        graphics.DrawLine(pen, nodAsc1.GetMLocation(), nodAsc2.GetMLocation());
                    }
                }
                i++;
                j++;
            }

            foreach (var nodIes in nodIesire)
            {
                foreach (var nodAsc in nodAscuns[nodAscuns.Count - 1])
                {
                    graphics.DrawLine(pen, nodAsc.GetMLocation(), nodIes.GetMLocation());
                }
            }

            pen.Dispose();
        }

        private void AttachData()
        {
            foreach (var nIntr in nodIntrare)
            {
                nIntr.NodeData = new AllData();
            }

            for (int j = 0; j < nodAscuns.Count; ++j)
            {
                if (j != 0)
                {
                    foreach (var nod in nodAscuns[j])
                    {
                        nod.NodeData.Nodes = nodAscuns[j - 1];
                        nod.NodeData.ActType = "rampa";
                    }
                }
                else
                {
                    foreach (var nod in nodAscuns[j])
                    {
                        nod.NodeData.Nodes = nodIntrare;
                        nod.NodeData.ActType = "rampa";
                    }
                }

            }

            foreach (var nOut in nodIesire)
            {
                nOut.NodeData = new AllData { Nodes = nodAscuns[nodAscuns.Count - 1], NodeType=NodeType.Iseire };
            }
        }

        private void BuildActFuncCombo()
        {
            foreach (var node in nodAscuns)
            {
                ComboBox box = new ComboBox();
                box.Items.Add("rampa");
                box.Items.Add("tanh");
                box.Items.Add("semn");
                box.Items.Add("treampa");
                box.Items.Add("signmoid");

                box.SelectedValueChanged += Box_SelectedValueChanged;
                box.SelectedIndex = 0;
                box.Location = new Point(node[0].Location.X, 50);
                p_draw.Controls.Add(box);
                actFunct.Add(box);
            }
        }

        private void Box_SelectedValueChanged(object sender, EventArgs e)
        {
            for(int i = 0;i < actFunct.Count; ++i)
            {
                if(sender == actFunct[i])
                    foreach(var nod in nodAscuns[i])
                    {
                        nod.NodeData.ActType = actFunct[i].SelectedItem.ToString();
                    }
            }
        }

        private void BuildNodes()
        {
            int X = 100;
            int lastY = 100;
            int padding = 10;
            for (int i = 0; i < _nNodIntrare; ++i)
            {
                Node node = new Node();
                node.Location = new Point(X, lastY);
                lastY += node.Height + padding; 
                p_draw.Controls.Add(node);
                nodIntrare.Add(node);
            }
            
            for(int j = 0;j <_nNodAscuns.Count;++j )
            {
                X += 200;
                lastY = 100;
                List<Node> list = new List<Node>();
                for (int i = 0; i < _nNodAscuns[j]; ++i)
                {
                    Node node = new Node();
                    node.Location = new Point(X, lastY);
                    lastY += node.Height + padding;
                    p_draw.Controls.Add(node);
                    list.Add(node);
                }
                nodAscuns.Add(list);
            }

            X += 200;
            lastY = 100;
            for (int i = 0; i < _nNodIesire; ++i)
            {
                Node node = new Node();
                node.Location = new Point(X, lastY);
                lastY += node.Height + padding;
                p_draw.Controls.Add(node);
                nodIesire.Add(node);
            }

        }

        

    }
}
