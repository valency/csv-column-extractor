﻿namespace CSV_Column_Extractor {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.colno = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.srcpath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.colno)).BeginInit();
            this.SuspendLayout();
            // 
            // colno
            // 
            this.colno.Location = new System.Drawing.Point(8, 40);
            this.colno.Name = "colno";
            this.colno.Size = new System.Drawing.Size(56, 23);
            this.colno.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "EXTRACT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // srcpath
            // 
            this.srcpath.Location = new System.Drawing.Point(8, 8);
            this.srcpath.Name = "srcpath";
            this.srcpath.Size = new System.Drawing.Size(248, 23);
            this.srcpath.TabIndex = 3;
            this.srcpath.Text = "DOUBLE CLICK TO SELECT FILE";
            this.srcpath.DoubleClick += new System.EventHandler(this.srcpath_DoubleClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 73);
            this.Controls.Add(this.srcpath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.colno);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CSV Column Extractor";
            ((System.ComponentModel.ISupportInitialize)(this.colno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown colno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox srcpath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

