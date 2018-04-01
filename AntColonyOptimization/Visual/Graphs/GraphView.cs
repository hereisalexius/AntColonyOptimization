using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AntColonyOptimization.TSP;
using AntColonyOptimization.ACO;

namespace AntColonyOptimization.Visual.Graphs
{
    public partial class GraphView : UserControl
    {
        private int _namesCounter = 0;
        private int _nodeSize = 25;
        private int _lineStrokeWidth = 2;
        private bool _paintPath = false;
        private List<ACOCity> lastPath;
        private TSPGraph<ACOCity, ACODistance> _Graph;
        public TSPGraph<ACOCity, ACODistance> Graph { get { return _Graph; } }
        private List<Node> _Nodes;
        private List<Node> _OldNodes;

        public List<Node> Nodes
        {
            get { return _Nodes; }
        }

        public GraphView()
        {
            InitializeComponent();
            _Nodes = new List<Node>();
            _Graph = new TSPGraph<ACOCity, ACODistance>();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                AddNewNode();
            }
                base.OnClick(e);
        }

        public void AddNewNode(ACOCity cityToAdd, List<ACOCity> citiesFromState)
        {

            _namesCounter++;
            ACOCity city = new ACOCity((string)cityToAdd.СityName.Clone());

            for (int i = 0; i < _Graph.GetCities().Count; i++)
            {
                city.Connect(_Graph.GetCities()[i], (ACODistance)cityToAdd.GetDistanceTo(citiesFromState[i]));
            }

            foreach (ACOCity c in _Graph.GetCities())
            {
                city.Connect(c, new ACODistance(1, 0.5));
            }
            _Graph.AddCity(city);

            Node node = new Node(city);
            node.Width = _nodeSize;
            node.Height = _nodeSize;
            node.Location = _OldNodes[_Nodes.Count].Location;
            _Nodes.Add(node);
            this.Controls.Add(node);
            
            this.Refresh();
        }

        public void AddNewNode()
        {
            _namesCounter++;
            ACOCity city = new ACOCity(_namesCounter + "");
            foreach (ACOCity c in _Graph.GetCities())
            {
                city.Connect(c, new ACODistance(1, 0.5));
            }

            _Graph.AddCity(city);

            Node node = new Node(city);
            node.Width = _nodeSize;
            node.Height = _nodeSize;
            _Nodes.Add(node);
            this.Controls.Add(node);
            PlaceNodesAround();
            this.Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = ClientRectangle;
            rect.Width -= 1;
            rect.Height -= 1;
            if (Nodes.Count == 0)
            {
                PrintText(g, "Please click on this area to add a Node.");
            }
            DrawEdges(g);
            DrawPath(g);
        }

        private void DrawPath(Graphics g)
        {
            if (_paintPath)
            {

               
                for (int i= 0; i< lastPath.Count-1;i++)
                {
                    DrawPathLine(g, i, i+1);
                }
                DrawPathLine(g, lastPath.Count - 1, 0);


            }
        }

        private void DrawPathLine(Graphics g, int i1, int i2)
        {
                Node from = PickNodeByCity(lastPath[i1]);
                Node to = PickNodeByCity(lastPath[i2]);
                Point p1 = new Point(from.Left + from.Width / 2, from.Top + from.Height / 2);
                Point p2 = new Point(to.Left + to.Width / 2, to.Top + to.Height / 2);
                g.DrawLine(new Pen(Color.Red, 2), p1, p2);
        }

        private Node PickNodeByCity(ACOCity c)
        {
            foreach (Node n in _Nodes)
            {
                if (n.City == c)
                {
                    return n;
                }
            }
            return _Nodes[0];
        }

        public void PaintPath(List<ACOCity> path)
        {
            lastPath = new List<ACOCity>();
            foreach (ACOCity c in path)
            {
                foreach (Node n in _Nodes)
                {
                    if (c.СityName == n.Text)
                    {
                        lastPath.Add(n.City);
                        break;
                    }
                }
            }
            _paintPath = true;
            Refresh();
            _paintPath = false;
        }


        private void PrintText(Graphics g, string text)
        {
            Rectangle rect = ClientRectangle;
            float fntSize = rect.Height / text.Length;
            Font fnt = new Font("Verdana", fntSize, FontStyle.Bold, GraphicsUnit.Pixel);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            g.DrawString(text, fnt, new SolidBrush(Color.Blue), new RectangleF(rect.Left, rect.Top, rect.Width, rect.Height), sf);
        }

        private void DrawEdges(Graphics g)
        {
            if (_Nodes.Count > 1)
            {
                List<Node> painted = new List<Node>();
                foreach (Node node in _Nodes)
                {
                    foreach (Node target in _Nodes)
                    {
                        if (!painted.Contains(target) && node!=target)
                        {
                            Point p1 = new Point(node.Left + node.Width / 2, node.Top + node.Height / 2);
                            Point p2 = new Point(target.Left + target.Width / 2, target.Top + target.Height / 2);
                            ACODistance dist = (ACODistance)node.City.GetDistanceTo(target.City);
                            float phromoneLineStrokeWidth = (float)((dist.Pheromone/GetMaxPheromoneValue()));
                            Color c = Color.Black;
                            if (dist.IsSelected)
                            {
                                c = Color.Blue;
                            }
                            c = Color.FromArgb((int)((c.A/2) * phromoneLineStrokeWidth) + c.A / 2, c); 
                            g.DrawLine(new Pen(c, phromoneLineStrokeWidth * 3), p1, p2);
           
                        }
                        painted.Add(node);
                    }
                }
            }
        }

        public void SetNodeSize(int size)
        {
            _nodeSize = size;
            foreach (Node node in _Nodes)
            {
                node.Width = size;
                node.Height = size;
            }
            Refresh();
        }

        public void SetLineStrokeWidth(int size)
        {
            _lineStrokeWidth = size;
            Refresh();
        }

        public double GetMaxPheromoneValue()
        {
            double max = 0;
            foreach (ACOCity city in _Graph.GetCities())
            {
                foreach (ACOCity target in _Graph.GetCities())
                {
                    if (city != target)
                    {
                        ACODistance dist = (ACODistance)city.GetDistanceTo(target);
                        if (dist.Pheromone > max)
                        {
                            max = dist.Pheromone;
                        }
                    }
                }
            }

            return max;
        }

        public void PlaceNodesAround()
        {
            if (_Nodes.Count > 1)
            {
                double radius = 160;
                double angle = 360 / _Nodes.Count * Math.PI / 180.0f;
                Point center = new Point(this.Width/2 - _Nodes[0].Width/2, this.Height/2 - _Nodes[0].Height/2);
                for (int i = 0; i < _Nodes.Count; i++)
                {
                    int x = (int)(center.X + Math.Cos(angle * i) * radius);
                    int y = (int)(center.Y + Math.Sin(angle * i) * radius);
                    _Nodes[i].Location = new Point(x, y);
                }
            }
            Refresh();
           
        }

        public void SetGraph(TSPGraph<ACOCity, ACODistance> graph)
        {
            _OldNodes = new List<Node>(_Nodes);
            ClearGraph();
            
            foreach (ACOCity city in graph.GetCities())
            {
                AddNewNode(city, graph.GetCities());
            }
            
        }

        public void ClearGraph()
        {
            _Nodes.Clear();
            Controls.Clear();
            _Graph.GetCities().Clear();
            _namesCounter = 0;
            Refresh();
        }
        public override void Refresh()
        {
            
            foreach (Node node in _Nodes)
            {
                node.Refresh();
            }
            
            base.Refresh();
        }
    }
}
