using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntColonyOptimization.ACO
{
    /// <summary>
    /// <c>Ant</c> class represents ant entity for Ant Colony Optiization algorythm.
    /// </summary>
    /// <remarks>
    /// <para>Moves from node where have been to new node.</para>
    /// <para>Remember walked path.</para>
    /// <para>Knows where to go next.</para>
    /// </remarks>
    public class Ant
    {
        //nodes where been
        private List<ACOCity> _TabuList;
        //current node
        private ACOCity _CurrentCity;
        //nodes list - where to go
        private List<ACOCity> _CitiesToVisit;
        //algorythm properties
        private ACOProperties _Props;


        /// <summary>
        /// Constructor - Creates new ant for graph.
        /// </summary>
        /// <param name="props">Algorythm properties. <see cref="ACOProperties"/></param>
        /// <param name="cities">Nodes(cities) list.</param>
        public Ant(ACOProperties props, List<ACOCity> cities)
        {
            _Props = props;
            _CitiesToVisit = new List<ACOCity>(cities);
            _TabuList = new List<ACOCity>();
            SelectFirstCity();
        }

        // Randomize starting placement
        private void SelectFirstCity()
        {
            Random rand = new Random();
            //select
            _CurrentCity = _CitiesToVisit[rand.Next(0,_CitiesToVisit.Count - 1)];
            //place to city
            _CurrentCity.Receive(this, _CitiesToVisit);
        }

        /// <summary>
        /// Move Ant to next City 
        /// </summary>
        /// <returns><c>ACOCity</c> where come.</returns>
        public ACOCity GoNext()
        {
            //if bypass is not over
            if (!HasFinished())
            {
                //decide wher go next
                ACOCity cityToGo = MakeDecision();
                //leave current
                _CurrentCity.Release(this, _TabuList);
                //go to next
                _CurrentCity = cityToGo;
                _CurrentCity.Receive(this, _CitiesToVisit);
            }
            
            return _CurrentCity;
        }

        /// <summary>
        /// Returns bypassed path. 
        /// </summary>
        /// <returns>List of <c>ACOCity</c> if bypassed, else <c>null</c></returns>
        public List<ACOCity> GetPath()
        {
            //if bypassing has finished
            if (HasFinished() )
            {
                //Add last city to tabu list
                if (!_TabuList.Contains(_CurrentCity))
                {
                    _TabuList.Add(_CurrentCity);
                }
               
                return _TabuList;
            }
            return null;
        }

        /// <returns>bool - has finished travelling or not.</returns>
        public bool HasFinished()
        {
            return _CitiesToVisit.Count == 0;
        }

        /// <summary>
        /// Caculates probability of chance to go in mentiond City.
        /// </summary>
        /// <param name="to">City to go</param>
        /// <returns>Probability from 0 to 1</returns>
        protected double CalculateProbability(ACOCity to)
        {
            return CalculateVariables(to) / CalculateVariables();
        }

        // calculates decision param for next city
        private double CalculateVariables(ACOCity to)
        {
            if (_CitiesToVisit.Contains(to))
            {
                ACODistance distance = (ACODistance)_CurrentCity.GetDistanceTo(to);
                double length = distance.LengthDouble;
                double pheromone = distance.Pheromone;
                return Math.Pow(1/length, Convert.ToDouble(_Props.Beta)) * Math.Pow(pheromone, Convert.ToDouble(_Props.Alpha));
            }
            return 0;
        }

        // calculates decision param for current city
        private double CalculateVariables()
        {
            double result = 0;
            foreach (ACOCity to in _CitiesToVisit)
            {
                result += CalculateVariables(to);
            }
            return result;
        }

        // updates decision table after passing of city(for output)
        private Dictionary<ACOCity, double> GetProbabilityTable()
        {
            Dictionary<ACOCity, double> table = new Dictionary<ACOCity, double>();
            foreach (ACOCity city in _CitiesToVisit)
            {
                table[city] = CalculateProbability(city);
            }
            return table;
        }

        // ant makes decision using distance, pheromone and random value
        private ACOCity MakeDecision()
        {
            ACOCity cityToGo = null;
            Random random = new Random();
            double randomValue = random.NextDouble();
            double currentProb = 0;
            foreach (KeyValuePair<ACOCity, double> entry in GetProbabilityTable())
            {
                currentProb += entry.Value;
                if (randomValue <= currentProb)
                {
                    cityToGo = entry.Key;
                    break;
                }
            }
            return cityToGo;
        }

        // Clears ant memory for reusing proposes
        public void ClearMemory()
        {
            _CitiesToVisit = new List<ACOCity>(_TabuList);
            _CitiesToVisit.Remove(_CurrentCity);
            _TabuList.Clear();
        }
    }
}
