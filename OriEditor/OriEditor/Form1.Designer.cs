namespace OriEditor {
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
            this.components = new System.ComponentModel.Container();
            this.gameScene = new System.Windows.Forms.Panel();
            this.hierarchyTree = new System.Windows.Forms.TreeView();
            this.inspector = new System.Windows.Forms.GroupBox();
            this.transformType = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newGameObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inspector.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameScene
            // 
            this.gameScene.BackColor = System.Drawing.Color.Transparent;
            this.gameScene.ForeColor = System.Drawing.Color.Transparent;
            this.gameScene.Location = new System.Drawing.Point(237, 12);
            this.gameScene.Name = "gameScene";
            this.gameScene.Size = new System.Drawing.Size(897, 738);
            this.gameScene.TabIndex = 0;
            this.gameScene.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.gameScene.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // hierarchyTree
            // 
            this.hierarchyTree.FullRowSelect = true;
            this.hierarchyTree.Location = new System.Drawing.Point(12, 12);
            this.hierarchyTree.Name = "hierarchyTree";
            this.hierarchyTree.Size = new System.Drawing.Size(219, 738);
            this.hierarchyTree.TabIndex = 1;
            this.hierarchyTree.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseClick);
            this.hierarchyTree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hierarchMouseDown);
            // 
            // inspector
            // 
            this.inspector.Controls.Add(this.label3);
            this.inspector.Controls.Add(this.label2);
            this.inspector.Controls.Add(this.textBox8);
            this.inspector.Controls.Add(this.textBox9);
            this.inspector.Controls.Add(this.textBox10);
            this.inspector.Controls.Add(this.textBox5);
            this.inspector.Controls.Add(this.textBox6);
            this.inspector.Controls.Add(this.textBox7);
            this.inspector.Controls.Add(this.textBox4);
            this.inspector.Controls.Add(this.label1);
            this.inspector.Controls.Add(this.transformType);
            this.inspector.Controls.Add(this.textBox3);
            this.inspector.Controls.Add(this.textBox2);
            this.inspector.Controls.Add(this.textBox1);
            this.inspector.Location = new System.Drawing.Point(1140, 12);
            this.inspector.Name = "inspector";
            this.inspector.Size = new System.Drawing.Size(261, 738);
            this.inspector.TabIndex = 2;
            this.inspector.TabStop = false;
            this.inspector.Text = "Inspector";
            // 
            // transformType
            // 
            this.transformType.FormattingEnabled = true;
            this.transformType.Items.AddRange(new object[] {
            "Transform",
            "RectTransform",
            "None"});
            this.transformType.Location = new System.Drawing.Point(113, 19);
            this.transformType.Name = "transformType";
            this.transformType.Size = new System.Drawing.Size(121, 21);
            this.transformType.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(176, 53);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(57, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(113, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(57, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(57, 20);
            this.textBox1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameObjectToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(168, 26);
            // 
            // newGameObjectToolStripMenuItem
            // 
            this.newGameObjectToolStripMenuItem.Name = "newGameObjectToolStripMenuItem";
            this.newGameObjectToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.newGameObjectToolStripMenuItem.Text = "New GameObject";
            this.newGameObjectToolStripMenuItem.Click += new System.EventHandler(this.newGameObjectToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Position";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(7, 20);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(176, 79);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(57, 20);
            this.textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(113, 79);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(57, 20);
            this.textBox6.TabIndex = 10;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(50, 79);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(57, 20);
            this.textBox7.TabIndex = 9;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(176, 105);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(57, 20);
            this.textBox8.TabIndex = 14;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(113, 105);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(57, 20);
            this.textBox9.TabIndex = 13;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(50, 105);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(57, 20);
            this.textBox10.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Rotation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Scale";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 762);
            this.Controls.Add(this.inspector);
            this.Controls.Add(this.hierarchyTree);
            this.Controls.Add(this.gameScene);
            this.Name = "Form1";
            this.Text = "OriEditor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.inspector.ResumeLayout(false);
            this.inspector.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gameScene;
        private System.Windows.Forms.TreeView hierarchyTree;
        private System.Windows.Forms.GroupBox inspector;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameObjectToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox transformType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
    }
}

