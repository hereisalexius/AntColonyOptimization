using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntColonyOptimization.ACO
{
    public class ACOProperties : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string info)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(info));
            }
        }

        private decimal _IterationsCount;
        private decimal _AntsCount;
        private decimal _Alpha;
        private decimal _Beta;
        private decimal _Q;
        private decimal _Rho;

        public decimal IterationsCount
        {
            get { return _IterationsCount; }
            set
            {
                _IterationsCount = value;
                OnPropertyChanged(PropertyNames.IterationsCount.ToString());
            }
        }
        public decimal AntsCount
        {
            get { return _AntsCount; }
            set
            {
                _AntsCount = value;
                OnPropertyChanged(PropertyNames.AntsCount.ToString());
            }
        }
        public decimal Alpha
        {
            get { return _Alpha; }
            set
            {
                _Alpha = value;
                OnPropertyChanged(PropertyNames.Alpha.ToString());
            }
        }
        public decimal Beta
        {
            get { return _Beta; }
            set
            {
                _Beta = value;
                OnPropertyChanged(PropertyNames.Beta.ToString());
            }
        }
        public decimal Q
        {
            get { return _Q; }
            set
            {
                _Q = value;
                OnPropertyChanged(PropertyNames.Q.ToString());
            }
        }
        public decimal Rho
        {
            get { return _Rho; }
            set
            {
                _Rho = value;
                OnPropertyChanged(PropertyNames.Rho.ToString());
            }
        }

        public ACOProperties()
        {

        }

        public ACOProperties(
            decimal iterations,
            decimal antsCount,
            decimal alpha,
            decimal beta,
            decimal q,
            decimal rho
            )
        {
            _IterationsCount = iterations;
            _AntsCount = antsCount;
            _Alpha = alpha;
            _Beta = beta;
            _Q = q;
            _Rho = rho;
        }

        public enum PropertyNames
        {
            IterationsCount,AntsCount,Alpha,Beta,Q,Rho

        }

    }
}
