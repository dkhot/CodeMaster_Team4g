using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMaster.Domain
{
    class Node
    {
        public int NodeId { get; set; }
    }

    class NodeBinding
    {
        public Node SoruceNode { get; set; }
        public Node DestinationNode { get; set; }
        public Color ConnectedByToken { get; set; }
    }

    class Map
    {
        public List<NodeBinding> NodeBindings { get; set; }
        public Node StartNode { get; set; }
        public Node EndNode { get; set; }
    }

    enum Color
    {
        Green = 1,
        Red = 2,
        Blue = 3
    }

}
