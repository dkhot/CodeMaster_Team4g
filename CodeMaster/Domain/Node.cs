using System.Collections.Generic;
using System.Linq;

namespace CodeMaster.Domain
{
    public class Edge
    {
        public Node DestinationNode { get; set; }
        public Color ConnectedWith { get; set; }

    }

    public enum Color
    {
        Red = 0,
        Green = 1,
        Blue = 2
    }

    public class Node
    {
        public int Id { get; set; }
        public List<Edge> Edges { get; set; }

    }


    public class Map
    {
        private readonly List<Node> _nodes = new List<Node>();
        private const int NumberOfNodes = 6;

        public List<Node> Nodes
        {
            get { return _nodes; }
        }

        public Map()
        {
            for (var i = 0; i < NumberOfNodes; i++)
            {
                _nodes.Add(CreateNode(i));
            }
            CreateEdge(0, 1, Color.Red);
            CreateEdge(1, 0, Color.Red);
            CreateEdge(0, 2, Color.Green);
            CreateEdge(2, 0, Color.Green);
            CreateEdge(0, 4, Color.Blue);
            CreateEdge(4, 0, Color.Blue);
            CreateEdge(1, 2, Color.Blue);
            CreateEdge(2, 1, Color.Blue);
            CreateEdge(1, 3, Color.Green);
            CreateEdge(3, 1, Color.Green);
            CreateEdge(3, 4, Color.Red);
            CreateEdge(4, 3, Color.Red);
            CreateEdge(3, 5, Color.Blue);
            CreateEdge(5, 3, Color.Blue);
            CreateEdge(4, 5, Color.Green);
            CreateEdge(5, 4, Color.Green);

        }

        private static Node CreateNode(int id)
        {
            return new Node()
            {
                Id = id,
                Edges = new List<Edge>()
            };
        }

        public void CreateEdge(int sourceNodeId, int connectedNodeId, Color connectedByColor)
        {
            if (!IsNodeExists(sourceNodeId) || !IsNodeExists(connectedNodeId)) return;
            var connectedNode = _nodes.First(x => x.Id == connectedNodeId);
            var sourceNode = _nodes.First(x => x.Id == sourceNodeId);

            sourceNode.Edges.Add(new Edge
            {
                DestinationNode = connectedNode,
                ConnectedWith = connectedByColor

            });
        }

        private bool IsNodeExists(int id)
        {
            return _nodes.Any(x => x.Id == id);

        }

    }

}

