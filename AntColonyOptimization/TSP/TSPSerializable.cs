using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntColonyOptimization.TSP
{
    /// <summary>
    /// Serializer interface for TSP graph table.
    /// </summary>
    /// <typeparam name="C">child of TSPCity</typeparam>
    /// <typeparam name="D">child of TSPDistance</typeparam>
    public interface TSPSerializable<C, D> where C : TSPCity<D> where D : TSPDistance
    {
        /// <summary>
        /// Save graph.
        /// </summary>
        /// <param name="fileName">File name.</param>
        void Serialize(string fileName);
        /// <summary>
        /// Load graph.
        /// </summary>
        /// <param name="fileName">File name.</param>
        /// <returns><c>TSPGrapg.<c></returns>
        TSPGraph<C, D> Deserialize(string fileName);
    }
}
