namespace BinaryTreeProj {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonNodeInsert = new System.Windows.Forms.Button();
            this.buttonRandomize = new System.Windows.Forms.Button();
            this.textBoxNodeInsert = new System.Windows.Forms.TextBox();
            this.comboBoxVisitTree = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDownFindNode = new System.Windows.Forms.NumericUpDown();
            this.buttonFindNode = new System.Windows.Forms.Button();
            this.labelSmallestRight = new System.Windows.Forms.Label();
            this.buttonSmallestRight = new System.Windows.Forms.Button();
            this.labelLargestLeft = new System.Windows.Forms.Label();
            this.buttonLargestLeft = new System.Windows.Forms.Button();
            this.labelFindLargest = new System.Windows.Forms.Label();
            this.buttonFindLargest = new System.Windows.Forms.Button();
            this.buttonFindSmallest = new System.Windows.Forms.Button();
            this.labelFindSmallest = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelPathLength = new System.Windows.Forms.Label();
            this.numericUpDownPath = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.labelCountNodeDepth = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelCountNodes = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCountBoth = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelCountLeft = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCountRight = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCountSingle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLeafNode = new System.Windows.Forms.Label();
            this.numericUpDownDepth = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxTree = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFindNode)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTree)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonClear);
            this.splitContainer1.Panel1.Controls.Add(this.buttonNodeInsert);
            this.splitContainer1.Panel1.Controls.Add(this.buttonRandomize);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxNodeInsert);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxVisitTree);
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBoxTree);
            this.splitContainer1.Size = new System.Drawing.Size(1221, 668);
            this.splitContainer1.SplitterDistance = 285;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(198, 519);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(83, 23);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonNodeInsert
            // 
            this.buttonNodeInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNodeInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNodeInsert.Location = new System.Drawing.Point(198, 461);
            this.buttonNodeInsert.Name = "buttonNodeInsert";
            this.buttonNodeInsert.Size = new System.Drawing.Size(83, 23);
            this.buttonNodeInsert.TabIndex = 5;
            this.buttonNodeInsert.Text = "Insert";
            this.buttonNodeInsert.UseVisualStyleBackColor = true;
            this.buttonNodeInsert.Click += new System.EventHandler(this.buttonNodeInsert_Click);
            // 
            // buttonRandomize
            // 
            this.buttonRandomize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRandomize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRandomize.Location = new System.Drawing.Point(198, 490);
            this.buttonRandomize.Name = "buttonRandomize";
            this.buttonRandomize.Size = new System.Drawing.Size(83, 23);
            this.buttonRandomize.TabIndex = 7;
            this.buttonRandomize.Text = "Randomize";
            this.buttonRandomize.UseVisualStyleBackColor = true;
            this.buttonRandomize.Click += new System.EventHandler(this.buttonRandomize_Click);
            // 
            // textBoxNodeInsert
            // 
            this.textBoxNodeInsert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNodeInsert.Location = new System.Drawing.Point(4, 435);
            this.textBoxNodeInsert.Name = "textBoxNodeInsert";
            this.textBoxNodeInsert.Size = new System.Drawing.Size(277, 20);
            this.textBoxNodeInsert.TabIndex = 4;
            this.textBoxNodeInsert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNodeInsert_KeyPress);
            // 
            // comboBoxVisitTree
            // 
            this.comboBoxVisitTree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVisitTree.FormattingEnabled = true;
            this.comboBoxVisitTree.Items.AddRange(new object[] {
            "--Visit tree--",
            "Left-Node-Right",
            "Node-Left-Right",
            "Left-Right-Node"});
            this.comboBoxVisitTree.Location = new System.Drawing.Point(3, 396);
            this.comboBoxVisitTree.Name = "comboBoxVisitTree";
            this.comboBoxVisitTree.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVisitTree.TabIndex = 3;
            this.comboBoxVisitTree.SelectedIndexChanged += new System.EventHandler(this.comboBoxVisitTree_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.58363F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.41637F));
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownFindNode, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.buttonFindNode, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.labelSmallestRight, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.buttonSmallestRight, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelLargestLeft, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttonLargestLeft, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelFindLargest, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonFindLargest, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonFindSmallest, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelFindSmallest, 1, 0);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 229);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(281, 161);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // numericUpDownFindNode
            // 
            this.numericUpDownFindNode.Dock = System.Windows.Forms.DockStyle.Left;
            this.numericUpDownFindNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownFindNode.Location = new System.Drawing.Point(161, 130);
            this.numericUpDownFindNode.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDownFindNode.Name = "numericUpDownFindNode";
            this.numericUpDownFindNode.Size = new System.Drawing.Size(56, 22);
            this.numericUpDownFindNode.TabIndex = 20;
            // 
            // buttonFindNode
            // 
            this.buttonFindNode.AutoSize = true;
            this.buttonFindNode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFindNode.Location = new System.Drawing.Point(3, 130);
            this.buttonFindNode.Name = "buttonFindNode";
            this.buttonFindNode.Size = new System.Drawing.Size(152, 26);
            this.buttonFindNode.TabIndex = 8;
            this.buttonFindNode.Text = "Find node with value";
            this.buttonFindNode.UseVisualStyleBackColor = true;
            this.buttonFindNode.Click += new System.EventHandler(this.buttonFindNode_Click);
            // 
            // labelSmallestRight
            // 
            this.labelSmallestRight.AutoSize = true;
            this.labelSmallestRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSmallestRight.Location = new System.Drawing.Point(161, 95);
            this.labelSmallestRight.Name = "labelSmallestRight";
            this.labelSmallestRight.Size = new System.Drawing.Size(117, 32);
            this.labelSmallestRight.TabIndex = 7;
            this.labelSmallestRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSmallestRight
            // 
            this.buttonSmallestRight.AutoSize = true;
            this.buttonSmallestRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSmallestRight.Location = new System.Drawing.Point(3, 98);
            this.buttonSmallestRight.Name = "buttonSmallestRight";
            this.buttonSmallestRight.Size = new System.Drawing.Size(152, 26);
            this.buttonSmallestRight.TabIndex = 6;
            this.buttonSmallestRight.Text = "Find smallest on the right";
            this.buttonSmallestRight.UseVisualStyleBackColor = true;
            this.buttonSmallestRight.Click += new System.EventHandler(this.buttonSmallestRight_Click);
            // 
            // labelLargestLeft
            // 
            this.labelLargestLeft.AutoSize = true;
            this.labelLargestLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLargestLeft.Location = new System.Drawing.Point(161, 63);
            this.labelLargestLeft.Name = "labelLargestLeft";
            this.labelLargestLeft.Size = new System.Drawing.Size(117, 32);
            this.labelLargestLeft.TabIndex = 5;
            this.labelLargestLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonLargestLeft
            // 
            this.buttonLargestLeft.AutoSize = true;
            this.buttonLargestLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLargestLeft.Location = new System.Drawing.Point(3, 66);
            this.buttonLargestLeft.Name = "buttonLargestLeft";
            this.buttonLargestLeft.Size = new System.Drawing.Size(152, 26);
            this.buttonLargestLeft.TabIndex = 4;
            this.buttonLargestLeft.Text = "Find largest on the left";
            this.buttonLargestLeft.UseVisualStyleBackColor = true;
            this.buttonLargestLeft.Click += new System.EventHandler(this.buttonLargestLeft_Click);
            // 
            // labelFindLargest
            // 
            this.labelFindLargest.AutoSize = true;
            this.labelFindLargest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFindLargest.Location = new System.Drawing.Point(161, 31);
            this.labelFindLargest.Name = "labelFindLargest";
            this.labelFindLargest.Size = new System.Drawing.Size(117, 32);
            this.labelFindLargest.TabIndex = 3;
            this.labelFindLargest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonFindLargest
            // 
            this.buttonFindLargest.AutoSize = true;
            this.buttonFindLargest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFindLargest.Location = new System.Drawing.Point(3, 34);
            this.buttonFindLargest.Name = "buttonFindLargest";
            this.buttonFindLargest.Size = new System.Drawing.Size(152, 26);
            this.buttonFindLargest.TabIndex = 2;
            this.buttonFindLargest.Text = "Find largest";
            this.buttonFindLargest.UseVisualStyleBackColor = true;
            this.buttonFindLargest.Click += new System.EventHandler(this.buttonFindLargest_Click);
            // 
            // buttonFindSmallest
            // 
            this.buttonFindSmallest.AutoSize = true;
            this.buttonFindSmallest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFindSmallest.Location = new System.Drawing.Point(3, 3);
            this.buttonFindSmallest.Name = "buttonFindSmallest";
            this.buttonFindSmallest.Size = new System.Drawing.Size(152, 25);
            this.buttonFindSmallest.TabIndex = 0;
            this.buttonFindSmallest.Text = "Find smallest";
            this.buttonFindSmallest.UseVisualStyleBackColor = true;
            this.buttonFindSmallest.Click += new System.EventHandler(this.buttonFindSmallest_Click);
            // 
            // labelFindSmallest
            // 
            this.labelFindSmallest.AutoSize = true;
            this.labelFindSmallest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFindSmallest.Location = new System.Drawing.Point(161, 0);
            this.labelFindSmallest.Name = "labelFindSmallest";
            this.labelFindSmallest.Size = new System.Drawing.Size(117, 31);
            this.labelFindSmallest.TabIndex = 1;
            this.labelFindSmallest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.labelPathLength, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownPath, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.labelCountNodeDepth, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelCountNodes, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelHeight, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelCountBoth, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelCountLeft, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelCountRight, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelCountSingle, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelLeafNode, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownDepth, 1, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(281, 208);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelPathLength
            // 
            this.labelPathLength.AutoSize = true;
            this.labelPathLength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPathLength.Location = new System.Drawing.Point(224, 177);
            this.labelPathLength.Name = "labelPathLength";
            this.labelPathLength.Size = new System.Drawing.Size(53, 30);
            this.labelPathLength.TabIndex = 20;
            this.labelPathLength.Text = "0";
            this.labelPathLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownPath
            // 
            this.numericUpDownPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownPath.Location = new System.Drawing.Point(163, 180);
            this.numericUpDownPath.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDownPath.Name = "numericUpDownPath";
            this.numericUpDownPath.Size = new System.Drawing.Size(54, 22);
            this.numericUpDownPath.TabIndex = 19;
            this.numericUpDownPath.ValueChanged += new System.EventHandler(this.numericUpDownPath_ValueChanged);
            this.numericUpDownPath.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDownPath_KeyUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(4, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 30);
            this.label9.TabIndex = 18;
            this.label9.Text = "Path length to node";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCountNodeDepth
            // 
            this.labelCountNodeDepth.AutoSize = true;
            this.labelCountNodeDepth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCountNodeDepth.Location = new System.Drawing.Point(224, 148);
            this.labelCountNodeDepth.Name = "labelCountNodeDepth";
            this.labelCountNodeDepth.Size = new System.Drawing.Size(53, 28);
            this.labelCountNodeDepth.TabIndex = 16;
            this.labelCountNodeDepth.Text = "0";
            this.labelCountNodeDepth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(4, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "No. of nodes on depth";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCountNodes
            // 
            this.labelCountNodes.AutoSize = true;
            this.labelCountNodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCountNodes.Location = new System.Drawing.Point(224, 127);
            this.labelCountNodes.Name = "labelCountNodes";
            this.labelCountNodes.Size = new System.Drawing.Size(53, 20);
            this.labelCountNodes.TabIndex = 14;
            this.labelCountNodes.Text = "0";
            this.labelCountNodes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label8, 2);
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(4, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "No. of nodes";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHeight.Location = new System.Drawing.Point(224, 106);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(53, 20);
            this.labelHeight.TabIndex = 12;
            this.labelHeight.Text = "0";
            this.labelHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label4, 2);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(4, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tree height";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCountBoth
            // 
            this.labelCountBoth.AutoSize = true;
            this.labelCountBoth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCountBoth.Location = new System.Drawing.Point(224, 85);
            this.labelCountBoth.Name = "labelCountBoth";
            this.labelCountBoth.Size = new System.Drawing.Size(53, 20);
            this.labelCountBoth.TabIndex = 10;
            this.labelCountBoth.Text = "0";
            this.labelCountBoth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label7, 2);
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(4, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "No. of nodes with both subtrees";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCountLeft
            // 
            this.labelCountLeft.AutoSize = true;
            this.labelCountLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCountLeft.Location = new System.Drawing.Point(224, 64);
            this.labelCountLeft.Name = "labelCountLeft";
            this.labelCountLeft.Size = new System.Drawing.Size(53, 20);
            this.labelCountLeft.TabIndex = 8;
            this.labelCountLeft.Text = "0";
            this.labelCountLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label5, 2);
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(4, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "No. of nodes with only left subtree";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCountRight
            // 
            this.labelCountRight.AutoSize = true;
            this.labelCountRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCountRight.Location = new System.Drawing.Point(224, 43);
            this.labelCountRight.Name = "labelCountRight";
            this.labelCountRight.Size = new System.Drawing.Size(53, 20);
            this.labelCountRight.TabIndex = 6;
            this.labelCountRight.Text = "0";
            this.labelCountRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label3, 2);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(4, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "No. of nodes with only right subtree";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCountSingle
            // 
            this.labelCountSingle.AutoSize = true;
            this.labelCountSingle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCountSingle.Location = new System.Drawing.Point(224, 22);
            this.labelCountSingle.Name = "labelCountSingle";
            this.labelCountSingle.Size = new System.Drawing.Size(53, 20);
            this.labelCountSingle.TabIndex = 4;
            this.labelCountSingle.Text = "0";
            this.labelCountSingle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "No. of leaf nodes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(4, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "No. of nodes with single subtree";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLeafNode
            // 
            this.labelLeafNode.AutoSize = true;
            this.labelLeafNode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLeafNode.Location = new System.Drawing.Point(224, 1);
            this.labelLeafNode.Name = "labelLeafNode";
            this.labelLeafNode.Size = new System.Drawing.Size(53, 20);
            this.labelLeafNode.TabIndex = 1;
            this.labelLeafNode.Text = "0";
            this.labelLeafNode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownDepth
            // 
            this.numericUpDownDepth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownDepth.Location = new System.Drawing.Point(163, 151);
            this.numericUpDownDepth.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDownDepth.Name = "numericUpDownDepth";
            this.numericUpDownDepth.Size = new System.Drawing.Size(54, 22);
            this.numericUpDownDepth.TabIndex = 17;
            this.numericUpDownDepth.ValueChanged += new System.EventHandler(this.numericUpDownDepth_ValueChanged);
            this.numericUpDownDepth.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDownDepth_KeyUp);
            // 
            // pictureBoxTree
            // 
            this.pictureBoxTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxTree.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTree.Name = "pictureBoxTree";
            this.pictureBoxTree.Size = new System.Drawing.Size(931, 664);
            this.pictureBoxTree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTree.TabIndex = 0;
            this.pictureBoxTree.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 668);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFindNode)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelLeafNode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCountSingle;
        private System.Windows.Forms.Label labelCountBoth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelCountLeft;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCountRight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCountNodes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCountNodeDepth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownDepth;
        private System.Windows.Forms.Label labelPathLength;
        private System.Windows.Forms.NumericUpDown numericUpDownPath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonFindSmallest;
        private System.Windows.Forms.Label labelFindSmallest;
        private System.Windows.Forms.Button buttonFindLargest;
        private System.Windows.Forms.Label labelFindLargest;
        private System.Windows.Forms.Button buttonLargestLeft;
        private System.Windows.Forms.Label labelSmallestRight;
        private System.Windows.Forms.Button buttonSmallestRight;
        private System.Windows.Forms.Label labelLargestLeft;
        private System.Windows.Forms.NumericUpDown numericUpDownFindNode;
        private System.Windows.Forms.Button buttonFindNode;
        private System.Windows.Forms.ComboBox comboBoxVisitTree;
        private System.Windows.Forms.TextBox textBoxNodeInsert;
        private System.Windows.Forms.Button buttonNodeInsert;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonRandomize;
        private System.Windows.Forms.PictureBox pictureBoxTree;
    }
}

