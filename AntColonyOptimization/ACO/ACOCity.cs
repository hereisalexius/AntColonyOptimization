using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AntColonyOptimization.TSP;

namespace AntColonyOptimization.ACO
{
    public class ACOCity : TSPCity<ACODistance> , ICloneable
    {
        private List<Ant> antsIn;

        public ACOCity(string cityName) : base(cityName)
        {
            antsIn = new List<Ant>();
        }

        public object Clone()
        {
            return new ACOCity((string)base.СityName.Clone());
        }

        public void Receive(Ant ant, List<ACOCity> citiesToVisit)
        {
            citiesToVisit.Remove(this);
            antsIn.Add(ant);
        }

        public bool Release(Ant ant, List<ACOCity> tabuList)
        {
            tabuList.Add(this);
            return antsIn.Remove(ant);
        }

        public void RemoveAnts()
        {
            antsIn.Clear();
        }
    }
}
