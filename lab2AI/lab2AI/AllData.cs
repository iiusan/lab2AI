using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2AI
{
    public class AllData
    {
        public string ActType { get; set; }
        public string InFuncType = "suma";
        public decimal TotalIn { get; set; }
        public decimal TotalOut { get; set; }
        public bool IsBianry { get; set; }
        public double FormX { get; set; }
        public double FormT { get; set; }
        public double FormG { get; set; }
        public decimal W { get; set; }
        public decimal X { get; set; }
        public List<Node> Nodes = new List<Node>();
        public NodeType NodeType = NodeType.NA;
        public Form1 ParentForm { get; set; }
}
}
