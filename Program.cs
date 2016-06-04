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

            BinaryTree<IntNode> tree = createRandomIntTree(0, 0, 30);
            tree.print();
            tree.remove(new IntNode(20));
            tree.print();
        }

        public static BinaryTree<IntNode> createRandomIntTree(int nodeCount, int min, int max) {
            Random rnd = new Random();
            var data = Enumerable.Range(0, max).OrderBy(x => rnd.Next()).Take(nodeCount).ToArray();
            int[] data1 = new int[] { 20, 10, 30, 5, 15, 25, 35, 23, 36, 27 };

            return new BinaryTree<IntNode>(IntNode.convert(data1));
        }
    }
}
