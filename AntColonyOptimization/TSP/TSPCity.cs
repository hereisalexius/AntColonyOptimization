using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntColonyOptimization.TSP
{
    /*
     * Класс: TSPCity - представлення сутності "місто"(вершина) у графі для TSP.
     */
    /// <summary>
    /// <c>TSPCity</c> represents city(node) on graph.
    /// </summary>
    /// <typeparam name="D">Represents Distance between cities.</typeparam>
    public abstract class TSPCity<D> : INotifyPropertyChanged where D: TSPDistance 
    {
        /// <summary>
        /// Properties handler for listener on form
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Do on property changed
        /// </summary>
        /// <param name="info"></param>
        protected void OnPropertyChanged(string info)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(info));
            }
        }

   
        /// <summary>
        /// Property - City name.
        /// </summary>
        private string _CityName;
        public string СityName
        {
            get { return _CityName; }
            set
            {
                _CityName = value;
                OnPropertyChanged("CityName");
            }
        }
        //map of relation between cities.
        private Dictionary<TSPCity<D>, D> linkMap;
        
        //Конструктор - вхідні параметри: назва "міста"

        /// <summary>
        /// New City
        /// </summary>
        /// <param name="cityName">City name.</param>
        public TSPCity(string cityName)
        {
            this.СityName = cityName;
            linkMap = new Dictionary<TSPCity<D>,D>();
        }

        /// <returns>Map of relation between cities.</returns>
        public Dictionary<TSPCity<D>, D> GetLinkMap()
        {
            return this.linkMap;
        }

        /// <summary>
        /// Connect with other city.
        /// </summary>
        /// <param name="city">Other city.</param>
        /// <param name="distance">Distance between cities.</param>
        /// <returns>Is connection succeed?</returns>
        public bool Connect(TSPCity<D> city, D distance)
        {
            if (!linkMap.ContainsKey(city))
            {
                linkMap[city] = distance;
                city.Connect(this,distance);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Disconnect from other city.
        /// </summary>
        /// <param name="city">City to disconnect.</param>
        public void Disconnect(TSPCity<D> city)
        {
            if (linkMap.ContainsKey(city))
            {
                linkMap.Remove(city);
                city.Disconnect(this);
            }
        }

        /// <summary>
        /// Recieve distance between this and other city. 
        /// </summary>
        /// <param name="city">Other City.</param>
        /// <returns>Distance or null if there is no connection.</returns>
        public TSPDistance GetDistanceTo(TSPCity<D> city)
        {
            if (linkMap.ContainsKey(city))
            {
                return this.linkMap[city];
            }
            return null; 
        }

        /// <summary>
        /// Check existance of connection with other city.
        /// </summary>
        /// <param name="city">Other city.</param>
        /// <returns>Is connected?</returns>
        public bool IsConnectedTo(TSPCity<D> city)
        {
            return this.linkMap.ContainsKey(city);
        }


        /// <summary>
        /// Check existance of connection with other cities.
        /// </summary>
        /// <param name="cities">List of other cities.</param>
        /// <returns>Is connected?</returns>
        public bool IsConnectedTo(List<TSPCity<D>> cities)
        {
            foreach (TSPCity<D> city in cities)
            {
                if (!IsConnectedTo(city))
                {
                    return false;
                }
            }
            return true;
        }

        /// <returns>Does this city has connections with other cities?</returns>
        public bool HasConnections()
        {
            return this.linkMap.Count > 0;
        }

        /// <returns>Count of relations.</returns>
        public int GetConnectionsCount()
        {
            return this.linkMap.Count;
        }
    }
}
