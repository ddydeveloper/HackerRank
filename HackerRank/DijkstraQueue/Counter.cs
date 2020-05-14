using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.DijkstraQueue
{
    public static class Counter
    {
        public static int[] ShortestReach(int n, int[][] edges, int s)
        {
            var paths = new int[n + 1][];

            var uniqueEdgesDict = new Dictionary<int, Tuple<int, int>[]>();
            
            for (var i = 1; i <= n; i++)
            {
                paths[i] = new[] {i, int.MaxValue};
                uniqueEdgesDict[i] = edges
                    .Where(x => x[0] == i || x[1] == i)
                    .OrderBy(x => x[2])
                    .Select(x => x[0] == i ? new {f = x[1], s = x[2]} : new {f = x[0], s = x[2]})
                    .GroupBy(x => x.f)
                    .Select(x => new Tuple<int, int>(x.First().f, x.First().s))
                    .ToArray();
            }

            var startNode = paths[s];
            startNode[1] = 0;
            
            VisitNodes(startNode, uniqueEdgesDict, paths);
            
            return paths
                .Skip(1)
                .Where(x => x[1] > 0)
                .Select(x => x[1] == int.MaxValue ? -1 : x[1])
                .ToArray();
        }

        private static void VisitNodes(int[] startNode,  
            IReadOnlyDictionary<int, Tuple<int, int>[]> edgesDict, 
            IReadOnlyList<int[]> paths)
        {
            var visitedNodes = new List<int>();

            var queue = new List<int[]> {startNode};

            while (queue.Count > 0)
            {
                var currentNode = queue[0];
                queue.RemoveAt(0);
                
                var nodeEdges = edgesDict[currentNode[0]];
                
                foreach (var (index, distance) in nodeEdges)
                {
                    if (visitedNodes.Contains(index)) 
                        continue;

                    if (paths[index][1] == int.MaxValue)
                    {
                        paths[index][1] = currentNode[1] + distance;
                        queue.Add(paths[index]);
                    } 
                    else if (paths[index][1] > currentNode[1] + distance)
                    {
                        paths[index][1] = currentNode[1] + distance;
                    }
                }

                visitedNodes.Add(currentNode[0]);
                queue = queue.OrderBy(x => x[1]).ToList();
            }
        }
    }
}