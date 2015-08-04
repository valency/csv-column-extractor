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
            String[] colstr = colval.Text.Split(',');
            int[] column = new int[colstr.Length];
            for (int i = 0; i < column.Length; i++) {
                column[i] = int.Parse(colstr[i]);
            }
            StreamReader reader = new StreamReader(srcpath.Text);
            StreamWriter writer = new StreamWriter(srcpath.Text + ".extract");
            string s = reader.ReadLine();
            int count = 0;
            int prevsec = DateTime.Now.Second;
            while (s != null) {
                string[] ss = s.Split(',');
                for (int i = 0; i < column.Length; i++) {
                    writer.Write(ss[column[i]]);
                    if (i < column.Length - 1) writer.Write(",");
                    else writer.WriteLine();
                }
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
            button1.Enabled = true;
            Application.DoEvents();
        }
    }
}
