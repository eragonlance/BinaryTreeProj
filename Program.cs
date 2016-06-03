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

            BinaryTree<IntNode> tree = createRandomIntTree(10, 0, 20);

            tree.print("", true);
            var res = tree.getAllValues();
            foreach (var i in res) {
                Console.Write(i + ' ');
            }
            Console.WriteLine();
            res = tree.getAllValues(NLRVisitor.get());
            foreach (var i in res) {
                Console.Write(i + ' ');
            }
            res = tree.getAllValues(LRNVisitor.get());
            Console.WriteLine();
            foreach (var i in res) {
                Console.Write(i + ' ');
            }
        }

        public static BinaryTree<IntNode> createRandomIntTree(int nodeCount, int min, int max) {
            Random rnd = new Random();
            var data = Enumerable.Range(0, max).OrderBy(x => rnd.Next()).Take(nodeCount);

            return new BinaryTree<IntNode>(IntNode.convert(data));
        }
    }
}
