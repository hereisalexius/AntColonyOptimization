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

namespace AntColonyOptimization.Visual.Controls
{
    public partial class ACOPropertiesControl : UserControl
    {
        private ACOProperties _Properties;
        public ACOProperties Properties { get { return _Properties; } }
        public ACOPropertiesControl()
        {
            InitializeComponent();
            InitProperties();
        }

        private void InitProperties()
        {
            _Properties = new ACOProperties(100,15,1,1,100,Convert.ToDecimal(0.5d));
            iterationsUpDown.DataBindings.Add("Value", _Properties, ACOProperties.PropertyNames.IterationsCount.ToString());
            antCountUpDown.DataBindings.Add("Value", _Properties, ACOProperties.PropertyNames.AntsCount.ToString());
            alphaUpDown.DataBindings.Add("Value", _Properties, ACOProperties.PropertyNames.Alpha.ToString());
            betaUpDown.DataBindings.Add("Value", _Properties, ACOProperties.PropertyNames.Beta.ToString());
            qUpDown.DataBindings.Add("Value", _Properties, ACOProperties.PropertyNames.Q.ToString());
            rhoUpDown.DataBindings.Add("Value", _Properties, ACOProperties.PropertyNames.Rho.ToString());
        }


    }
}
