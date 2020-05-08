using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Deikstra
{
    public static class Counter
    {
        public static int[] ShortestReach(int n, int[][] edges, int s)
        {
            var paths = new int?[n + 1];
            var visited = new bool[n + 1];
            
            // Set Dummy node (zero index) and S node values
            paths[0] = 0;
            paths[s] = 0;
            visited[0] = true;

            var cleanEdges = new List<int[]>();

            foreach (var edge in edges)
            {
                var duplicate = cleanEdges.FirstOrDefault(x =>
                    x[0] == edge[0] && x[1] == edge[1] || x[0] == edge[1] && x[1] == edge[0]);

                if (duplicate == null)
                {
                    cleanEdges.Add(edge);
                }
                else if (duplicate[2] > edge[2])
                {
                    cleanEdges[cleanEdges.IndexOf(duplicate)] = edge;
                }
            }
            
            VisitNode(s, cleanEdges, visited, paths);

            var result = paths.Where(x => x != 0).Select(x => x ?? -1).ToArray();

            return result;
        }

        private static void VisitNode(int node, IEnumerable<int[]> edges, IList<bool> visited, IList<int?> paths)
        {
            if (!paths[node].HasValue)
                throw new Exception("The node you are going to process has no value");
            
            var nodeEdges = edges.Where(x => x[0] == node || x[1] == node).ToList();
            var nextNodes = new List<int>();

            foreach (var edge in nodeEdges)
            {
                var nextNode = edge[0] != node ? edge[0] : edge[1];
                var edgeValue = edge[2];

                nextNodes.Add(nextNode);

                if (!paths[nextNode].HasValue || paths[nextNode].Value > paths[node] + edgeValue)
                    paths[nextNode] = paths[node] + edgeValue;
            }

            visited[node] = true;

            foreach (var nextNode in nextNodes.Where(nextNode => !visited[nextNode]))
            {
                VisitNode(nextNode, edges, visited, paths);
            }
        }
    }
}