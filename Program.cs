using BinaryTreeProj.Tree;
using BinaryTreeProj.Tree.NodeType;
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

            BinaryTree<IntNode> tree = createRandomIntTree(700, 0, 1000);

            tree.print("", true);
            Console.WriteLine(tree.lookUpLargest().ToString());
            Console.WriteLine(tree.getHeight());
        }

        public static BinaryTree<IntNode> createRandomIntTree(int nodeCount, int min, int max) {
            Random rnd = new Random();
            BinaryTree<IntNode> tree = new BinaryTree<IntNode>(new IntNode(rnd.Next(0, max)));
            var data = Enumerable.Range(0, max).OrderBy(x => rnd.Next()).Take(nodeCount).ToArray();

            foreach (var i in data) {
                tree.insert(new IntNode(i));
            }
            return tree;
        }
    }
}
