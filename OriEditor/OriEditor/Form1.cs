using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OriEditor {
    public partial class Form1 : Form {
        [DllImport("Orihsay.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "engineStart")]
        public static extern int engineStart(IntPtr window, int w, int h);

        [DllImport("Orihsay.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "engineUpdate")]
        public static extern void engineUpdate();

        [DllImport("Orihsay.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "engineShutdown")]
        public static extern void engineShutdown();


        [DllImport("Orihsay.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int test();
        public Form1() {
            InitializeComponent();
            int year = test();
            System.Console.WriteLine(year);
            int testvar = engineStart(gameScene.Handle, gameScene.Width, gameScene.Height);

            
        }

        private void Form1_Load(object sender, EventArgs e) {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {
            engineUpdate();
        }

        private void treeView1_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e) {
            
        }

        private void hierarchMouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                Point p = new Point(e.X, e.Y);
                contextMenuStrip1.Show(hierarchyTree, p);
                
            }
        }

        private void newGameObjectToolStripMenuItem_Click(object sender, EventArgs e) {
            TreeNodeCollection nodes = hierarchyTree.Nodes;
            nodes.Add("new gameobject");
        }


    }
}
