using System;
using System.Collections.Generic;

namespace questions
{
    //Source: https://youtu.be/zaBhtODEL0w?t=375
    public class Graph
    {
        Dictionary<int, Node> _nodeLookup = new Dictionary<int, Node>();
        public class Node
        {
            private int Value;
            private LinkedList<Node> AdjacentNodes = new LinkedList<Node>();
            Node(int id)
            {
                Value = id;
            }

            private Node getNode(int id) 
            { 
                // TODO
                return new Node(id); 
            }

            public void addEdge(int source, int destination)
            {
                
            }

            // DFS implementation
            public bool hasPathDFS(int source, int destination)
            {
                Node s = getNode(source);
                Node d = getNode(destination);
                HashSet<int> visited = new HashSet<int>();

                return hasPathDFS(s, d, visited);
            }

            private bool hasPathDFS(Node source, Node destination, HashSet<int> visited)
            {
                if (visited.Contains(source.Value)){
                    return false;
                }
                visited.Add(source.Value);

                if(source == destination){
                    return true;
                }

                foreach (Node adjacentnode in source.AdjacentNodes){
                    
                    if (hasPathDFS(adjacentnode, destination, visited))
                    {
                        return true;
                    }
                }

                return false;
            }

            // BFS implementation
            public bool hasPathBFS(int source, int destination)
            {
                return hasPathBFS(getNode(source), getNode(destination));
            }

            private bool hasPathBFS(Node source, Node destination)
            {
                HashSet<int> visited = new HashSet<int>();
                Queue<Node> nextToVisit = new Queue<Node>();

                nextToVisit.Enqueue(source);
                while (nextToVisit.Count > 0)
                {
                    Node latestNode = nextToVisit.Dequeue();
                    if (latestNode == destination)
                    {
                        return true;
                    }

                    if (visited.Contains(latestNode.Value))
                    {
                        continue;
                    }

                    visited.Add(latestNode.Value);
                    foreach (var adjacentNode in latestNode.AdjacentNodes)
                    {
                        nextToVisit.Enqueue(adjacentNode);
                    }
                }

                return false;
            }
        }
    }
}
