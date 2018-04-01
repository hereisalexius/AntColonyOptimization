using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntColonyOptimization.TSP
{
    /// <summary>
    /// Abstarct behaivor for calculation of Traveling Salesman Propblem. 
    /// Can be used for your solution implementation.
    /// </summary>
    /// <typeparam name="C">Represents City on graph.</typeparam>
    /// <typeparam name="D">Represents Distance between cities.</typeparam>
    public interface TSPAlgorithm<C,D> where C : TSPCity<D> where D:TSPDistance
    {
        /// <summary>
        /// Calculates solution of Traveling Salesman Propblem.
        /// </summary>
        /// <param name="graph">Input graph.</param>
        /// <returns>Ordered list - optimal path </returns>
        List<C> GetOptimalPath(TSPGraph<C,D> graph);
    }
}
