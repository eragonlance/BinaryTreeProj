using BinaryTreeProj.Tree;
using BinaryTreeProj.Tree.INodeType;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BinaryTreeProj {
    partial class Form1 : Form, Observer<BinaryTree<IntNode>> {
        public Form1() {
            InitializeComponent();
            this.Text = "Binary Tree";
        }

        private static BinaryTree<IntNode> tree = null;
        private static IntNode highlightedNode = null;

        private void Form1_Load(object sender, EventArgs e) {
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            comboBoxVisitTree.SelectedIndex = 0;

            insertRandom(50, 0, 100);
        }

        public void update(BinaryTree<IntNode> t) {
            if (tree != t) {
                return;
            }

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
            pictureBoxTree.Image = tree.draw(highlightedNode);
            GC.Collect();
        }

        private void drawHighlight() {
            pictureBoxTree.Image = tree.draw(highlightedNode);
            highlightedNode = null;
            GC.Collect();
        }

        static void insertRandom(int nodeCount, int min, int max) {
            Random rnd = new Random();
            var data = Enumerable.Range(0, max).OrderBy(x => rnd.Next()).Take(nodeCount).ToArray();

            tree.insertRange(IntNode.convert(data));
        }

        public Form1(BinaryTree<IntNode> t) : this() {
            tree = t;
            t.attach(this);
        }

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
            highlightedNode = tree.findSmallest();

            if (highlightedNode != null) {
                labelFindSmallest.Text = highlightedNode.ToString();
                drawHighlight();
            }
        }

        private void buttonFindLargest_Click(object sender, EventArgs e) {
            highlightedNode = tree.findLargest();

            if (highlightedNode != null) {
                labelFindLargest.Text = highlightedNode.ToString();
                drawHighlight();
            }
        }

        private void buttonLargestLeft_Click(object sender, EventArgs e) {
            highlightedNode = tree.findLeftLargest();

            if (highlightedNode != null) {
                labelLargestLeft.Text = highlightedNode.ToString();
                drawHighlight();
            }
        }

        private void buttonSmallestRight_Click(object sender, EventArgs e) {
            highlightedNode = tree.findRightSmallest();

            if (highlightedNode != null) {
                labelSmallestRight.Text = highlightedNode.ToString();
                drawHighlight();
            }
        }

        private void buttonFindNode_Click(object sender, EventArgs e) {
            var node = new IntNode((int)numericUpDownFindNode.Value);

            if (tree.find(node)) {
                highlightedNode = node;
            }

            drawHighlight();
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
            var numList = new List<int>();

            foreach (var i in numStrings) {
                int n;

                if (int.TryParse(i, out n)) {
                    numList.Add(n);
                }
            }

            if (numList.Count() < numStrings.Count()) {
                MessageBox.Show("Not a valid sequence. Please type a list of numbers seperated by a comma.");
                return;
            }

            tree.insertRange(numList.Select(x => new IntNode(x)).ToArray());
            textBoxNodeInsert.Text = "";
        }

        private void textBoxNodeInsert_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar != Convert.ToChar(Keys.Return)) {
                return;
            }

            buttonNodeInsert_Click(sender, new EventArgs());
        }

        private void buttonRandomize_Click(object sender, EventArgs e) {
            tree.clear();
            insertRandom(50, 0, 100);
        }

        private void buttonClear_Click(object sender, EventArgs e) {
            highlightedNode = null;
            tree.clear();
        }

        private void buttonRemove_Click(object sender, EventArgs e) {
            tree.remove(new IntNode((int)numericUpDownRemove.Value));
        }
    }
}
