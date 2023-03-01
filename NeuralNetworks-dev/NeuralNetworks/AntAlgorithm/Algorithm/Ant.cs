using NeuralNetworks.AntAlgorithm.UI;
using System.Collections.Generic;
using System.Linq;

namespace NeuralNetworks.AntAlgorithm.Algorithm
{
    public class Ant
    {
        private readonly List<int> _observedVertices;

        public Ant(int startedVertex)
        {
            _observedVertices = new List<int> { startedVertex };
        }

        public List<int> GetObservedVertices()
        {
            return _observedVertices.ToList();
        }
        public bool IsEdgeViewed(int startedVertex, int endedVertex)
        {
            if (!_observedVertices.Contains(startedVertex) || !_observedVertices.Contains(endedVertex))
            {
                return false;
            }

            return GetNextVertexIndex(startedVertex) == _observedVertices.IndexOf(endedVertex);
        }

        public void AddVertex(int vertex)
        {
            _observedVertices.Add(vertex);
        }
        
        public bool IsVertexObserved(int vertex)
        {
            return _observedVertices.Contains(vertex);
        }     

        private int GetNextVertexIndex(int vertex)
        {
            return (_observedVertices.IndexOf(vertex) + 1) % _observedVertices.Count;
        }        
    }
}
