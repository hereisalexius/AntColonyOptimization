using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AntColonyOptimization.ACO;

namespace AntColonyOptimization.Visual.Graphs
{
    public partial class Node : UserControl
    {
        public ACOCity City { get; set; }
        private Dictionary<ACOCity, NumericUpDown[]> _BindedDistancesLength;
        public Dictionary<ACOCity, NumericUpDown[]> BindedDistancesLength { get { return _BindedDistancesLength; } }
        public Node(ACOCity city)
        {
            InitializeComponent();
            City = city;
            Text = city.СityName;
            InitBindedDistancesLength();
        }

        private void InitBindedDistancesLength()
        {
            
            _BindedDistancesLength = new Dictionary<ACOCity, NumericUpDown[]>();
            foreach (KeyValuePair<TSP.TSPCity<ACODistance>, ACODistance> item in City.GetLinkMap())
            {
                NumericUpDown[] numericFields = new NumericUpDown[2];
                numericFields[0] = InitNumericUpDown(item.Value);
                numericFields[1] = InitNumericUpDown(item.Value);
                _BindedDistancesLength.Add((ACOCity)item.Key, numericFields);
            }
        }

        private NumericUpDown InitNumericUpDown(ACODistance dist)
        {
            NumericUpDown numeric = new NumericUpDown();
            numeric.Minimum = 1;
            numeric.Maximum = 10000;
            numeric.DecimalPlaces = 0;
            numeric.Increment = 10;
            numeric.DataBindings.Add("Value",dist,"Length");
            return numeric;
        }

        private bool _IsSelected = false;

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = ClientRectangle;
            rect.Width -= 1;
            rect.Height -= 1;
            Color c = Color.Black;
            if (_IsSelected)
            {
                c = Color.Blue;
            }
            g.FillRectangle(new SolidBrush(Color.Transparent),rect);
            g.DrawEllipse(new Pen(c, 1.0f), rect);
            float fntSize = rect.Height / City.СityName.Length;
            Font fnt = new Font("Verdana", fntSize, FontStyle.Bold, GraphicsUnit.Pixel);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            g.DrawString(Text, fnt, new SolidBrush(c), new RectangleF( rect.Left,rect.Top,rect.Width, rect.Height),sf);
        }

        private Point mouseDownLocation;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                    mouseDownLocation = e.Location;
            }
            else {
                GraphView parent = (GraphView)Parent;
                parent.Graph.RemoveCity(this.City);
                parent.Nodes.Remove(this);
                parent.Controls.Remove(this);
                parent.Refresh();
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            _IsSelected = true;
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            _IsSelected = false;
            base.OnMouseLeave(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
           
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {

                if (this.Left < 0)
                {
                    this.Left = 0;
                    this.Top = e.Y + this.Top - mouseDownLocation.Y;
                }
                else if (this.Right > Parent.Width)
                {
                    this.Left = Parent.Width - this.Width;
                    this.Top = e.Y + this.Top - mouseDownLocation.Y;
                }
                else if (this.Top < 0)
                {
                    this.Left = e.X + this.Left - mouseDownLocation.X;
                    this.Top = 0;
                }
                else if (this.Bottom > Parent.Height)
                {
                    this.Left = e.X + this.Left - mouseDownLocation.X;
                    this.Top = Parent.Height - this.Height;
                }
                else
                {
                    this.Left = e.X + this.Left - mouseDownLocation.X;
                    this.Top = e.Y + this.Top - mouseDownLocation.Y;
                }

                Parent.Refresh();
            }
        }
    }
}
