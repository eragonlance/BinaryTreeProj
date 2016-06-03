using BinaryTreeProj.Tree;
using BinaryTreeProj.Tree.INodeType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryTreeProj {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            BinaryTree<IntNode> tree = createRandomIntTree(40, 0, 50);

            tree.print("", true);
            //Console.WriteLine(tree.countLeafNodes());
            //Console.WriteLine(tree.countNodesWithSingleSubtree());
            //Console.WriteLine(tree.countNodesWithOnlyRightSubtree());
            //Console.WriteLine(tree.countNodesWithOnlyLeftSubTree());
            //Console.WriteLine(tree.countNodesWithBothSubTree());
            //Console.WriteLine(tree.countNodes());
            //Console.WriteLine(tree.countNodesOnDepth(3));
            Console.WriteLine(tree.pathLength(new IntNode(30)));
            //Console.WriteLine(tree.lookUpLargest().ToString());
            //Console.WriteLine(tree.getHeight());
        }

        public static BinaryTree<IntNode> createRandomIntTree(int nodeCount, int min, int max) {
            Random rnd = new Random();
            var data = Enumerable.Range(0, max).OrderBy(x => rnd.Next()).Take(nodeCount);

            return new BinaryTree<IntNode>(IntNode.convert(data));
        }
    }
}
