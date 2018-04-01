using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntColonyOptimization.ACO
{
    public class ACODistance : TSP.TSPDistance , ICloneable
    {
        private double _Pheromone;
        public double Pheromone
        {
            get { return _Pheromone; }
            set
            {
                if (value > 0)
                {
                    _Pheromone = value;
                }
                else
                {
                    _Pheromone = .5d;
                }
                OnPropertyChanged("Pheromone");
            }
        }

        public ACODistance(double length, double pheromone) : base(length)
        {
            this.Pheromone = pheromone;
        }

        public object Clone()
        {
            return new ACODistance(LengthDouble, _Pheromone);
        }
    }
}
