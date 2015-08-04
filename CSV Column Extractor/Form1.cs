using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CSV_Column_Extractor {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void srcpath_DoubleClick(object sender, EventArgs e) {
            openFileDialog1.ShowDialog();
            srcpath.Text = openFileDialog1.FileName;
        }

        private void button1_Click(object sender, EventArgs e) {
            button1.Enabled = false;
            int column = (int)colno.Value;
            StreamReader reader = new StreamReader(srcpath.Text);
            StreamWriter writer = new StreamWriter(srcpath.Text + "_COL_" + column + ".txt");
            string s = reader.ReadLine();
            int count = 0;
            int prevsec = DateTime.Now.Second;
            while (s != null) {
                string[] ss = s.Split(',');
                writer.WriteLine(ss[column]);
                // Move to next
                s = reader.ReadLine();
                count++;
                if (DateTime.Now.Second != prevsec) {
                    prevsec = DateTime.Now.Second;
                    button1.Text = "P: " + count;
                    Application.DoEvents();
                }
            }
            reader.Close();
            writer.Close();
            button1.Text = "FINISHED: " + count;
            Application.DoEvents();
        }
    }
}
