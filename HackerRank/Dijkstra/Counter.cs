using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Dijkstra
{
    public static class Counter
    {
        public static int[] shortestReach(int n, int[][] edges, int s)
        {
            var paths = new List<int[]>();
            var edgesDict = new Dictionary<int, List<int[]>>();

            for (var i = 1; i <= n; i++)
            {
                paths.Add(new[] {i, int.MaxValue, 0});
                edgesDict[i] = PrepareNodeEdges(i, edges);
            }

            var startNode = paths.First(x => x[0] == s);
            startNode[1] = 0;
            
            VisitNodes(startNode, n, edgesDict, paths);

            return paths
                .Where(x => x[1] > 0)
                .Select(x => x[1] == int.MaxValue ? -1 : x[1])
                .ToArray();
        }

        private static void VisitNodes(int[] startNode, int nodesCount, 
            IReadOnlyDictionary<int, List<int[]>> edgesDict, 
            IList<int[]> paths)
        {
            var visitedNodes = new List<int>();
            var currentNode = startNode;
            
            while (nodesCount > 1)
            {
                if (currentNode[1] == int.MaxValue)
                    return;

                foreach (var nodeEdge in edgesDict[currentNode[0]])
                {
                    var nodeIdx = nodeEdge[0];
                    
                    if (visitedNodes.Contains(nodeIdx)) 
                        continue;
                    
                    var nodePath = paths.First(x => x[0] == nodeIdx);

                    if (nodePath[1] == int.MaxValue || nodePath[1] > currentNode[1] + nodeEdge[1])
                        nodePath[1] = currentNode[1] + nodeEdge[1];
                }

                visitedNodes.Add(currentNode[0]);
                currentNode[2] = 1;
                nodesCount--;

                currentNode = paths.OrderBy(x => x[1]).First(x => x[2] == 0);
            }
        }

        private static List<int[]> PrepareNodeEdges(int node, IEnumerable<int[]> edges)
        {
            var cleanEdges = new List<int[]>();
            var nodeEdges = edges.Where(x => x[0] == node || x[1] == node);

            foreach (var edge in nodeEdges)
            {
                var destinationNode = edge[0] == node ? edge[1] : edge[0];
                var existing = cleanEdges.FirstOrDefault(x => x[0] == destinationNode);

                if (existing == null)
                {
                    cleanEdges.Add(new[] {destinationNode, edge[2]});
                    continue;
                }

                if (existing[1] <= edge[2])
                {
                    continue;
                }

                var existingIdx = cleanEdges.IndexOf(existing);
                cleanEdges[existingIdx][1] = edge[2];
            }

            return cleanEdges.ToList();
        }
    }
}