using BinaryTreeProj.Tree;
using BinaryTreeProj.Tree.INodeType;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BinaryTreeProj {
    partial class Form1 : Form, Observer<BinaryTree<IntNode>> {
        public Form1() {
            InitializeComponent();
        }

        BinaryTree<IntNode> tree = createRandomIntTree(10, 0, 20);

        private void Form1_Load(object sender, EventArgs e) {
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            comboBoxVisitTree.SelectedIndex = 0;
            AllocConsole();
            tree.attach(this);
            tree.notify();
        }

        static BinaryTree<IntNode> createRandomIntTree(int nodeCount, int min, int max) {
            Random rnd = new Random();
            var data = Enumerable.Range(0, max).OrderBy(x => rnd.Next()).Take(nodeCount).ToArray();
            int[] data1 = new int[] { 20, 10, 30, 5, 15, 25, 35, 23, 36, 27 };

            return new BinaryTree<IntNode>(IntNode.convert(data));
        }

        public void update(BinaryTree<IntNode> s) {
            labelLeafNode.Text = tree.countLeafNodes().ToString();
            labelCountSingle.Text = tree.nSingleOnly().ToString();
            labelCountRight.Text = tree.nRightOnly().ToString();
            labelCountLeft.Text = tree.nLeftOnly().ToString();
            labelCountBoth.Text = tree.nBoth().ToString();
            labelHeight.Text = tree.getHeight().ToString();
            labelCountNodes.Text = tree.countNodes().ToString();
            labelCountNodeDepth.Text = tree.countNodesOnDepth((int)numericUpDownDepth.Value).ToString();
            labelPathLength.Text = tree.pathLength(new IntNode((int)numericUpDownPath.Value)).ToString();
            labelFindLargest.Text = "";
            labelFindSmallest.Text = "";
            labelLargestLeft.Text = "";
            labelSmallestRight.Text = "";
            tree.print();
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void numericUpDownDepth_ValueChanged(object sender, EventArgs e) {
            labelCountNodeDepth.Text = tree.countNodesOnDepth((int)numericUpDownDepth.Value).ToString();
        }

        private void numericUpDownDepth_KeyUp(object sender, KeyEventArgs e) {
            labelCountNodeDepth.Text = tree.countNodesOnDepth((int)numericUpDownDepth.Value).ToString();
        }

        private void numericUpDownPath_ValueChanged(object sender, EventArgs e) {
            labelPathLength.Text = tree.pathLength(new IntNode((int)numericUpDownPath.Value)).ToString();
        }

        private void numericUpDownPath_KeyUp(object sender, KeyEventArgs e) {
            labelPathLength.Text = tree.pathLength(new IntNode((int)numericUpDownPath.Value)).ToString();
        }

        private void buttonFindSmallest_Click(object sender, EventArgs e) {
            var smallestNode = tree.findSmallest();
            labelFindSmallest.Text = smallestNode == null ? "" : smallestNode.ToString();
        }

        private void buttonFindLargest_Click(object sender, EventArgs e) {
            var largestNode = tree.findLargest();
            labelFindLargest.Text = largestNode == null ? "" : largestNode.ToString();
        }

        private void buttonLargestLeft_Click(object sender, EventArgs e) {
            var largestLeft = tree.findLeftLargest();
            labelLargestLeft.Text = largestLeft == null ? "" : largestLeft.ToString();
        }

        private void buttonSmallestRight_Click(object sender, EventArgs e) {
            var smallestRight = tree.findRightSmallest();
            labelSmallestRight.Text = smallestRight == null ? "" : smallestRight.ToString();
        }

        private void buttonFindNode_Click(object sender, EventArgs e) {
            bool result = tree.find(new IntNode((int)numericUpDownFindNode.Value));
            MessageBox.Show(result.ToString(), "Result");
        }

        private void comboBoxVisitTree_SelectedIndexChanged(object sender, EventArgs e) {
            IEnumerable<String> result = null;

            switch (comboBoxVisitTree.SelectedIndex) {
                case 1:
                    result = tree.getAllValues(LNRVisitor.get());
                    break;
                case 2:
                    result = tree.getAllValues(NLRVisitor.get());
                    break;
                case 3:
                    result = tree.getAllValues(LRNVisitor.get());
                    break;
                default:
                    return;
            }
            MessageBox.Show(String.Join(", ", result), comboBoxVisitTree.Text);
            comboBoxVisitTree.SelectedIndex = 0;
        }

        private void buttonNodeInsert_Click(object sender, EventArgs e) {
            var numStrings = textBoxNodeInsert.Text.Split(',');
            tree.insertRange(numStrings.Select(x => new IntNode(int.Parse(x))).ToArray());
        }

        private void textBoxNodeInsert_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar != Convert.ToChar(Keys.Return)) {
                return;
            }

            var numStrings = textBoxNodeInsert.Text.Split(',');
            tree.insertRange(numStrings.Select(x => new IntNode(int.Parse(x))).ToArray());
        }

        private void textBoxNodeInsert_Leave(object sender, EventArgs e) {
            textBoxNodeInsert.Text = "Insert numbers seperated by commas...";
        }

        private void textBoxNodeInsert_Enter(object sender, EventArgs e) {
            textBoxNodeInsert.Text = "";
        }
    }
}
