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
using Microsoft.VisualBasic.FileIO;
using System.IO;
using AntColonyOptimization.TSP;

namespace AntColonyOptimization.Visual.Graphs
{
    public partial class GraphEditControl : UserControl
    {
        public GraphEditControl()
        {
            InitializeComponent();

            distanceLengthView.AllowUserToAddRows = false;
            distanceLengthView.EditingControlShowing += EditingControlShowing;
            distanceLengthView.SelectionChanged += UpdateLengthSelection;
            distanceLengthView.CellEndEdit += UpdateLengthData;
            
            distancePheromoneView.AllowUserToAddRows = false;
            distancePheromoneView.EditingControlShowing += EditingControlShowing;
            distancePheromoneView.SelectionChanged += UpdatePheromoneSelection;
            distancePheromoneView.CellEndEdit += UpdatePheromoneData;

            nodeUpDown.ValueChanged += ChangeNodeSize;
            graphView1.ControlAdded += AddNodeToListViews;
            graphView1.ControlRemoved += RemoveNodeToListViews;
        }

        protected void AddNodeToListViews(object sender, ControlEventArgs e)
        {
            Refresh();
        }

        public GraphView GetGraphView()
        {
            return graphView1;
        }

        private ACODistance GetDistance(int i, int j)
        {
            List<Node> nodes = graphView1.Nodes;
            return (ACODistance)nodes[i].City.GetDistanceTo(nodes[j].City);
        }

        protected void RemoveNodeToListViews(object sender, ControlEventArgs e)
        {
            Refresh();
        }

        private void EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(AnyCellKeyPress);
     
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(AnyCellKeyPress);
                }
        }

        private void AnyCellKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        protected void UpdateLengthSelection(object sender, EventArgs e)
        {
            int i = distanceLengthView.CurrentCell.RowIndex;
            int j = distanceLengthView.CurrentCell.ColumnIndex;
            if (i != j)
            {
                ACODistance dist = GetDistance(i, j);
                dist.IsSelected = true;
                graphView1.Refresh();
                //dist.Length = Convert.ToDecimal(distanceLengthView.CurrentCell.Value);
                dist.IsSelected = false;
            }
            else
            {
                graphView1.Refresh();
            }
        }

        protected void UpdateLengthData(object sender, EventArgs e)
        {
            int k = distanceLengthView.CurrentCell.RowIndex;
            int n = distanceLengthView.CurrentCell.ColumnIndex;
            if (k != n)
            {
                ACODistance dist = GetDistance(k, n);
                dist.Length = Convert.ToDecimal(distanceLengthView.CurrentCell.Value);
            }

            List<Node> nodes = graphView1.Nodes;

            for (int i = 0; i < nodes.Count; i++)
            {
                for (int j = 0; j < nodes.Count; j++)
                {
                    if (nodes[i] == nodes[j])
                    {
                        distanceLengthView[i, j].ReadOnly = true;
                        distanceLengthView[i, j].Style.BackColor = Color.Gray;
                    }
                    else
                    {
                        DataGridViewTextBoxCell textBoxCell = new DataGridViewTextBoxCell();
                        ACODistance dist = (ACODistance)nodes[i].City.GetDistanceTo(nodes[j].City);
                        distanceLengthView[i, j].Value = dist.Length;
                    }

                }
            }

        }

        protected void UpdatePheromoneSelection(object sender, EventArgs e)
        {
            int i = distancePheromoneView.CurrentCell.RowIndex;
            int j = distancePheromoneView.CurrentCell.ColumnIndex;
            if (i != j)
            {
                ACODistance dist = GetDistance(i, j);
                dist.IsSelected = true;
                graphView1.Refresh();
                //dist.Length = Convert.ToDecimal(distanceLengthView.CurrentCell.Value);
                dist.IsSelected = false;
            }
            else
            {
                graphView1.Refresh();
            }
        }

        protected void UpdatePheromoneData(object sender, EventArgs e)
        {
            int k = distancePheromoneView.CurrentCell.RowIndex;
            int n = distancePheromoneView.CurrentCell.ColumnIndex;
            if (k != n)
            {
                ACODistance dist = GetDistance(k, n);
                if (Convert.ToDouble(distancePheromoneView.CurrentCell.Value) > 0)
                {
                    dist.Pheromone = Convert.ToDouble(distancePheromoneView.CurrentCell.Value);
                }
                          }

            List<Node> nodes = graphView1.Nodes;

            for (int i = 0; i < nodes.Count; i++)
            {
                for (int j = 0; j < nodes.Count; j++)
                {
                    if (nodes[i] == nodes[j])
                    {
                        distancePheromoneView[i, j].ReadOnly = true;
                        distancePheromoneView[i, j].Style.BackColor = Color.Gray;
                    }
                    else
                    {
                        DataGridViewTextBoxCell textBoxCell = new DataGridViewTextBoxCell();
                        ACODistance dist = (ACODistance)nodes[i].City.GetDistanceTo(nodes[j].City);
                        distancePheromoneView[i, j].Value = dist.Pheromone;
                    }

                }
            }

        }


        protected void ChangeNodeSize(object sender, EventArgs e)
        {
            graphView1.SetNodeSize(Convert.ToInt32(nodeUpDown.Value));
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            distanceLengthView.Rows.Clear();
            distanceLengthView.Columns.Clear();
            graphView1.ClearGraph();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            graphView1.PlaceNodesAround();
        }

        public override void Refresh()
        {
            distanceLengthView.Rows.Clear();
            distanceLengthView.Columns.Clear();
            distancePheromoneView.Rows.Clear();
            distancePheromoneView.Columns.Clear();

            List<Node> nodes = graphView1.Nodes;
            foreach (Node node in nodes)
            {
                string colName = node.Text;

                distanceLengthView.Columns.Add(colName, colName);
                distanceLengthView.Columns[colName].Width = 35;
                distancePheromoneView.Columns.Add(colName, colName);
                distancePheromoneView.Columns[colName].Width = 35;
            }

            for (int i = 0; i < nodes.Count; i++)
            {
                string rowName = nodes[i].Text;
                distanceLengthView.Rows.Add();
                distanceLengthView.Rows[i].HeaderCell.Value = rowName;
                distancePheromoneView.Rows.Add();
                distancePheromoneView.Rows[i].HeaderCell.Value = rowName;
            }

            for (int i = 0; i < nodes.Count; i++)
            {
                for (int j = 0; j < nodes.Count; j++)
                {
                    if (nodes[i] == nodes[j])
                    {
                        distanceLengthView[i, j].ReadOnly = true;
                        distanceLengthView[i, j].Style.BackColor = Color.Gray;
                        distancePheromoneView[i, j].ReadOnly = true;
                        distancePheromoneView[i, j].Style.BackColor = Color.Gray;
                    }
                    else
                    {
                        DataGridViewTextBoxCell textBoxCell = new DataGridViewTextBoxCell();
                        ACODistance dist = (ACODistance)nodes[i].City.GetDistanceTo(nodes[j].City);
                        distanceLengthView[i, j].Value = dist.LengthDouble;
                        distancePheromoneView[i, j].Value = dist.Pheromone;
                    }

                }
            }
            base.Refresh();
        }

        public List<List<decimal>> LoadFromFile(decimal defaultValue)
        {
            List<List<decimal>> result = new List<List<decimal>>();
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                using (TextFieldParser parser = new TextFieldParser(@"" + file.FileName))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");
                    while (!parser.EndOfData)
                    {
                        List<decimal> row = new List<decimal>();
                        //Processing row
                        string[] fields = parser.ReadFields();
                        foreach (string field in fields)
                        {
                            string n = field;
                            if (!IsDigitsOnly(n) || n.Length==0)
                            {
                                n = defaultValue + "";
                            }
                            row.Add(Convert.ToDecimal(n));
                        }
                        result.Add(row);
                    }
                }
            }
            return result;
        }

        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        void SaveDataToCSV(DataGridView dgv)
        {
            SaveFileDialog file = new SaveFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                dgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
                dgv.SelectAll();
                DataObject dataObject = dgv.GetClipboardContent();
                File.WriteAllText(file.FileName, dataObject.GetText(TextDataFormat.CommaSeparatedValue));
            }
        }

        private void importLengthstButton_Click(object sender, EventArgs e)
        {
            List<List<decimal>> data = LoadFromFile(1);
            if (data.Count > 0 && data.Count == data[0].Count)
            {
                int nodesToAdd = data.Count - graphView1.Nodes.Count;
                for (int i = 0; i < nodesToAdd; i++)
                {
                    graphView1.AddNewNode();
                    graphView1.PlaceNodesAround();
                }

                List<Node> nodes = graphView1.Nodes;
                for (int i = 0; i < data.Count; i++)
                {
                    for (int j = 0; j < data.Count; j++)
                    {
                        if (nodes[i] != nodes[j])
                        {
                            ACODistance dist = (ACODistance)nodes[i].City.GetDistanceTo(nodes[j].City);
                            dist.Length = data[i][j];
                        }

                    }
                }
                Refresh();
            }
        }

        private void exportLengthstButton_Click(object sender, EventArgs e)
        {
            SaveDataToCSV(distanceLengthView);
        }

        private void importPheromonetButton_Click(object sender, EventArgs e)
        {
            List<List<decimal>> data = LoadFromFile(Convert.ToDecimal(.5d));
            if (data.Count > 0 && data.Count == data[0].Count)
            {
                int nodesToAdd = data.Count - graphView1.Nodes.Count;
                for (int i = 0; i < nodesToAdd; i++)
                {
                    graphView1.AddNewNode();
                    graphView1.PlaceNodesAround();
                }

                List<Node> nodes = graphView1.Nodes;
                for (int i = 0; i < data.Count; i++)
                {
                    for (int j = 0; j < data.Count; j++)
                    {
                        if (nodes[i] != nodes[j])
                        {
                            ACODistance dist = (ACODistance)nodes[i].City.GetDistanceTo(nodes[j].City);
                            dist.Pheromone = Convert.ToDouble(data[i][j]);
                        }

                    }
                }
                Refresh();
            }
        }



        private void exportPheromonetButton_Click(object sender, EventArgs e)
        {
            SaveDataToCSV(distanceLengthView);
        }

        public void SetImportState(bool state)
        {
            importLengthstButton.Enabled = state;
            importPheromonetButton.Enabled = state;
            clearButton.Enabled = state;
            refreshButton.Enabled = state;
            graphView1.Enabled = state;
            distanceLengthView.ReadOnly = !state;
            distancePheromoneView.ReadOnly = !state;
            
        }

    }
}
