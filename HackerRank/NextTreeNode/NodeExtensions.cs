using System.Linq;

namespace HackerRank.NextTreeNode
{
    public static class NodeExtensions
    {
        public static Node Next(this Node node)
        {
            var previousChildIdx = -1;
        
            while (true)
            {
                if (node == null)
                    return null;

                var childrenList = node.Children.ToList();

                if (childrenList.Count > 0 && childrenList.IndexOf(childrenList.Last()) != previousChildIdx)
                    return childrenList[previousChildIdx + 1];

                var parent = node.Parent;
                var nodeIdx = parent?.Children.ToList().IndexOf(node) ?? -1;

                node = parent;
                previousChildIdx = nodeIdx;
            }
        }
    }
}