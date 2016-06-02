using BinaryTreeProj.Tree;
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

            int max = 100;
            Random rnd = new Random();
            BinaryTree tree = new BinaryTree(rnd.Next(0, max));
            var data = Enumerable.Range(0, max).OrderBy(x => rnd.Next()).Take((int)(max / 2)).ToArray();

            foreach (var i in data) {
                tree.insert(i);
            }

            tree.print("", true);
            Console.WriteLine(tree.lookUpLargest());
            Console.WriteLine(tree.getHeight());
        }
    }
}
