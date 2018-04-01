using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AntColonyOptimization.ACO;

namespace AntColonyOptimization
{
    public partial class MainForm : Form
    {
        private ACO.AntColonyOptimization algo;
        private List<IterationStep> iteratonSteps;
        private List<ACOCity> bestPath;

        public MainForm()
        {
            InitializeComponent();
            algo = new ACO.AntColonyOptimization(acoPropertiesControl1.Properties);
            iterSwitch.ValueChanged += IterationValueChanged;

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (graphEditControl1.GetGraphView().Graph.GetCities().Count > 3)
            {
                algo.GetOptimalPath(graphEditControl1.GetGraphView().Graph);
                iteratonSteps = algo.GetIterationSteps();
                iterSwitch.Value = 1;
                iterSwitch.ReadOnly = false;
                iterSwitch.Maximum = iteratonSteps.Count;
                iterSwitch.Value = iteratonSteps.Count;
                button1.Enabled = true;
                startButton.Enabled = false;
                graphEditControl1.SetImportState(false);
            }
        }

        protected void IterationValueChanged(object sender, EventArgs e)
        {
            int currentValue = Convert.ToInt32(iterSwitch.Value);
            graphEditControl1.SetImportState(true);
            graphEditControl1.Refresh();
            
            graphEditControl1.GetGraphView().SetGraph(iteratonSteps[currentValue - 1].GetState());

            List<ACOCity> path = iteratonSteps[currentValue - 1].GetPath();
            double totalLength = 0;
            pathText.Text = "";
            lengthsText.Text = "";
            lengthText.Text = "";
            for (int i = 0; i < path.Count - 1; i++)
            {
                double len = path[i].GetDistanceTo(path[i + 1]).LengthDouble;
                totalLength += len;
                pathText.Text += path[i].СityName + ",";
                lengthsText.Text +=  len+ ",";
            }
            pathText.Text += path[path.Count - 1].СityName + "," + path[0].СityName;
            double flen = path[path.Count - 1].GetDistanceTo(path[0]).LengthDouble;
            lengthsText.Text += flen;
            totalLength += flen;
            lengthText.Text = Convert.ToString(totalLength);
            graphEditControl1.SetImportState(false);
            graphEditControl1.GetGraphView().PaintPath(path);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            iterSwitch.ReadOnly = true;
            button1.Enabled = false;
            startButton.Enabled=  true;
            graphEditControl1.SetImportState(true);
        }
    }
}
