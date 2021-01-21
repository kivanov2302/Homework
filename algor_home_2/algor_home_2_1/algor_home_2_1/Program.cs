using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algor_home_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var nodelist = new LinkedList();

            nodelist.AddNode(1);
            nodelist.AddNode(2);
            nodelist.AddNode(3);

            var node = new Node(1);
            nodelist.AddNodeAfter(node, 9);

            node = new Node(2);
            nodelist.AddNodeAfter(node, 8);

            node = new Node(3);
            nodelist.AddNodeAfter(node, 7);

            node = nodelist.FindNode(3);

            nodelist.RemoveNode(2);

            node = new Node(8);
            nodelist.RemoveNode(node);
        }
    }
}   
