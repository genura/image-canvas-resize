﻿namespace image_pro
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.bnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.items = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "asd",
            "asd",
            "asd",
            "a",
            "dsas",
            "da",
            "sd",
            "asd",
            "asd",
            "as",
            "da",
            "sd",
            "ads",
            "asd",
            "as",
            "dda",
            "sda",
            "sd",
            "asd",
            "asd",
            "a",
            "sda",
            "sd",
            "asd",
            "a",
            "sda",
            "sd",
            "asd",
            "as",
            "da",
            "sd",
            "asd",
            "asd",
            "a",
            "ds",
            "234",
            "svb",
            "snb",
            "sfh",
            "hjfg"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 97);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(243, 304);
            this.checkedListBox1.TabIndex = 1;
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(346, 57);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(360, 23);
            this.pBar.TabIndex = 2;
            this.pBar.Value = 23;
            this.pBar.Click += new System.EventHandler(this.ProgressBar1_Click);
            // 
            // bnStart
            // 
            this.bnStart.Location = new System.Drawing.Point(197, 12);
            this.bnStart.Name = "bnStart";
            this.bnStart.Size = new System.Drawing.Size(75, 23);
            this.bnStart.TabIndex = 3;
            this.bnStart.Text = "start";
            this.bnStart.UseVisualStyleBackColor = true;
            this.bnStart.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(278, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // items
            // 
            this.items.FormattingEnabled = true;
            this.items.Location = new System.Drawing.Point(463, 97);
            this.items.Name = "items";
            this.items.Size = new System.Drawing.Size(243, 304);
            this.items.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.items);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.bnStart);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.Button bnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.CheckedListBox items;
    }
}

