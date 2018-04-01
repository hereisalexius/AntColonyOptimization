using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntColonyOptimization.TSP
{

    /// <summary>
    /// TSP Graph - roadmap.
    /// </summary>
    /// <typeparam name="C">child of TSPCity</typeparam>
    /// <typeparam name="D">child of TSPDistance </typeparam>
    public class TSPGraph<C,D> where C:TSPCity<D> where D : TSPDistance 
    {
        private List<C> _Cities;
        public TSPGraph()
        {
            _Cities = new List<C>();
        }

        public List<C> GetCities()
        {
            return _Cities;
        }

        public bool AddCity(C city)
        {
            if (_Cities.Count==0 && !city.HasConnections())
            {
                _Cities.Add(city);
                return true;
            }
            else if (_Cities.Count == city.GetConnectionsCount() && city.IsConnectedTo(_Cities.Cast<TSPCity<D>>().ToList()))
            {
                foreach (C c in _Cities)
                {
                    c.Connect(city, (D)city.GetDistanceTo(c));
                }
                _Cities.Add(city);
                return true;
            }
            return false;
        }

        public void RemoveCity(C city)
        {
            if (_Cities.Contains(city))
            {
                _Cities.Remove(city);
                foreach (C c in _Cities)
                {
                    c.Disconnect(city);
                }
            }
        }
    }
}
