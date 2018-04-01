using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AntColonyOptimization.TSP;

namespace AntColonyOptimization.ACO
{
    public class AntColonyOptimization : TSPAlgorithm<ACOCity,ACODistance>
    {
        private List<Ant> _Ants;
        private ACOProperties _Props;
        private List<IterationStep> iterationSteps;

        public AntColonyOptimization(ACOProperties props)
        {
            _Props = props;
            _Ants = new List<Ant>();
        }

        public List<ACOCity> GetOptimalPath(TSPGraph<ACOCity,ACODistance> graph)
        {
            iterationSteps = new List<IterationStep>();
            List<ACOCity> bestPath = null;
            InitAnts(graph);
            for (int i = 0; i < _Props.IterationsCount; i++)
            {

                List<List<ACOCity>> paths = FindPaths();
                bestPath = UpdatePathsData(paths, bestPath);
                iterationSteps.Add(new IterationStep(bestPath, graph));
                foreach (Ant ant in _Ants)
                {
                    ant.ClearMemory();
                }

            }
            return bestPath;
        }

        private void InitAnts(TSPGraph<ACOCity,ACODistance> graph)
        {
            _Ants.Clear();
            foreach (ACOCity c in graph.GetCities())
            {
                c.RemoveAnts();
            }

            for (int i = 0; i < _Props.AntsCount; i++)
            {
                _Ants.Add(new Ant(_Props, graph.GetCities()));
            }
        }

        private List<List<ACOCity>> FindPaths()
        {
            List<List<ACOCity>> paths = new List<List<ACOCity>>();
            while (_Ants.Count != paths.Count)
            {
                foreach (Ant ant in _Ants)
                {
                    if (!ant.HasFinished()) ant.GoNext();
                    else paths.Add(ant.GetPath());
                }
            }
            return paths;
        }

        private List<ACOCity> UpdatePathsData(List<List<ACOCity>> paths , List<ACOCity> bestPath)
        {
            foreach (List<ACOCity> path in paths)
            {
                if (bestPath == null) bestPath = path;
                else
                {
                    double previousLength = TSPDistance.CalculateLengthOfPath<ACOCity, ACODistance>(bestPath);
                    double currentLength = TSPDistance.CalculateLengthOfPath<ACOCity, ACODistance>(path);
                    if (currentLength <= previousLength) bestPath = path;
                }
                UpdatePheromone(path);
               
            }

            return bestPath;
        }

        private void UpdatePheromone(List<ACOCity> path)
        {
            double pathLength = TSPDistance.CalculateLengthOfPath<ACOCity,ACODistance>(path);
            double deltaTau = Convert.ToDouble(_Props.Q) / pathLength;
            for (int i = 0; i < path.Count - 1; i++)
            {
                ACODistance distance = (ACODistance)path[i].GetDistanceTo(path[i + 1]);
                distance.Pheromone = (1 - Convert.ToDouble(_Props.Rho)) * distance.Pheromone + deltaTau;
            }
        }

        public List<IterationStep> GetIterationSteps()
        {
            return iterationSteps;
        } 
    }

    public class IterationStep
    {
        private List<ACOCity> pathState;
        private TSPGraph<ACOCity, ACODistance> graphState;

        public IterationStep(List<ACOCity> path, TSPGraph<ACOCity, ACODistance> graph)
        {
            pathState = new List<ACOCity>();
            graphState = new TSPGraph<ACOCity, ACODistance>();
            CopyGraph(graph);
            CopyPath(path);

           

        }

        private void CopyGraph(TSPGraph<ACOCity, ACODistance> graph)
        {
            foreach (ACOCity mainCity in graph.GetCities())
            {

                ACOCity copiedCity = (ACOCity)mainCity.Clone();


                for (int i = 0; i < graphState.GetCities().Count; i++)
                {
                    ACODistance dist = (ACODistance)((ACODistance)mainCity.GetDistanceTo(graph.GetCities()[i])).Clone();
                    copiedCity.Connect(graphState.GetCities()[i], dist);
                }

                graphState.AddCity(copiedCity);
            }
        }

        private void CopyPath(List<ACOCity> path)
        {
            foreach (ACOCity original in path)
            {
                foreach (ACOCity copy in graphState.GetCities())
                {
                    if (original.СityName == copy.СityName)
                    {
                        pathState.Add(copy);
                    }
                }
            }
        }


        public List<ACOCity> GetPath()
        {
            return pathState;
        }

        public TSPGraph<ACOCity, ACODistance> GetState()
        {
            return graphState;
        }
    }
}
