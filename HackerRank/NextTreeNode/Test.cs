using System;
using NUnit.Framework;

namespace HackerRank.NextTreeNode
{
    public class Tests
    {
        [Test]
        public void EmptyTreeTest()
        {
            Node root = null;
            Assert.IsNull(root);
        }
    
        [Test]
        public void SingleNodeTreeTest()
        {
            var root = new Node(1);
            Assert.AreEqual(1, root.Data);
            Assert.IsNull(root.Next());
        }
    
        [Test]
        public void OrderedTreeTest()
        {
            // Test tree:
            // 
            // 1
            // +-2
            //   +-3
            //   +-4
            // +-5
            //   +-6
            //   +-7
            //
            var root = new Node(
                1,
                new Node(
                    2,
                    new Node(3),
                    new Node(4)),
                new Node(
                    5,
                    new Node(6),
                    new Node(7)));

            // Expected output:
            //
            // 1
            // 2
            // 3
            // 4
            // 5
            // 6
            // 7
            //
            var n = root;
            while (n != null)
            {
                Console.WriteLine(n.Data);
                n = n.Next();
            }

            // Test
            //
            n = root;
            Assert.AreEqual(1, n.Data);
            n = n.Next();
            Assert.AreEqual(2, n.Data);
            n = n.Next();
            Assert.AreEqual(3, n.Data);
            n = n.Next();
            Assert.AreEqual(4, n.Data);
            n = n.Next();
            Assert.AreEqual(5, n.Data);
            n = n.Next();
            Assert.AreEqual(6, n.Data);
            n = n.Next();
            Assert.AreEqual(7, n.Data);
            n = n.Next();
            Assert.IsNull(n);
        }
 
        [Test]
        public void OrderedTreeFromThirdTest()
        {
            // Test tree:
            // 
            // 1
            // +-2
            //   +-3
            //   +-4
            // +-5
            //   +-6
            //   +-7
            //
            var root = new Node(
                1,
                new Node(
                    2,
                    new Node(3),
                    new Node(4)),
                new Node(
                    5,
                    new Node(6),
                    new Node(7)));

            // Expected output:
            //
            // 3
            // 4
            // 5
            // 6
            // 7
            //
            var n = root.Next().Next();
            while (n != null)
            {
                Console.WriteLine(n.Data);
                n = n.Next();
            }

            // Test
            //
            n = root;
            Assert.AreEqual(1, n.Data);
            n = n.Next();
            Assert.AreEqual(2, n.Data);
            n = n.Next();
            Assert.AreEqual(3, n.Data);
            n = n.Next();
            Assert.AreEqual(4, n.Data);
            n = n.Next();
            Assert.AreEqual(5, n.Data);
            n = n.Next();
            Assert.AreEqual(6, n.Data);
            n = n.Next();
            Assert.AreEqual(7, n.Data);
            n = n.Next();
            Assert.IsNull(n);
        }
    
        [Test]
        public void NotOrderedTreeTest()
        {
            // Test tree:
            // 
            // 11
            // +-1
            //   +-5
            //   +-2
            // +-8
            //   +-13
            //   +-0
            //
            var root = new Node(
                11,
                new Node(
                    1,
                    new Node(5),
                    new Node(2)),
                new Node(
                    8,
                    new Node(13),
                    new Node(0)));

            // Expected output:
            //
            // 11
            // 1
            // 5
            // 2
            // 8
            // 13
            // 0
            //
            var n = root;
            while (n != null)
            {
                Console.WriteLine(n.Data);
                n = n.Next();
            }

            // Test
            //
            n = root;
            Assert.AreEqual(11, n.Data);
            n = n.Next();
            Assert.AreEqual(1, n.Data);
            n = n.Next();
            Assert.AreEqual(5, n.Data);
            n = n.Next();
            Assert.AreEqual(2, n.Data);
            n = n.Next();
            Assert.AreEqual(8, n.Data);
            n = n.Next();
            Assert.AreEqual(13, n.Data);
            n = n.Next();
            Assert.AreEqual(0, n.Data);
            n = n.Next();
            Assert.IsNull(n);
        }
    
        [Test]
        public void NotOrderedTreeFromFifthTest()
        {
            // Test tree:
            // 
            // 11
            // +-1
            //   +-5
            //   +-2
            // +-8
            //   +-13
            //   +-0
            //
            var root = new Node(
                11,
                new Node(
                    1,
                    new Node(5),
                    new Node(2)),
                new Node(
                    8,
                    new Node(13),
                    new Node(0)));

            // Expected output:
            //
            // 8
            // 13
            // 0
            //
            var n = root;
            while (n != null)
            {
                Console.WriteLine(n.Data);
                n = n.Next();
            }

            // Test
            //
            n = root.Next().Next().Next().Next();
            Assert.AreEqual(8, n.Data);
            n = n.Next();
            Assert.AreEqual(13, n.Data);
            n = n.Next();
            Assert.AreEqual(0, n.Data);
            n = n.Next();
            Assert.IsNull(n);
        }
    }
}