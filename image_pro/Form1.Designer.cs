﻿namespace image_pro
{
    partial class ImageCanvasSizeForm
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
            this.g1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSave = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.bnStart = new System.Windows.Forms.Button();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.g3 = new System.Windows.Forms.GroupBox();
            this.txtBoy = new System.Windows.Forms.TextBox();
            this.txtEn = new System.Windows.Forms.TextBox();
            this.cc = new System.Windows.Forms.CheckBox();
            this.c195 = new System.Windows.Forms.CheckBox();
            this.c520 = new System.Windows.Forms.CheckBox();
            this.g2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.fileLists = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.BgrdWorker = new System.ComponentModel.BackgroundWorker();
            this.g1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.g3.SuspendLayout();
            this.g2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // g1
            // 
            this.g1.Controls.Add(this.button2);
            this.g1.Controls.Add(this.label2);
            this.g1.Controls.Add(this.txtSource);
            this.g1.Controls.Add(this.label1);
            this.g1.Controls.Add(this.txtSave);
            this.g1.Controls.Add(this.button1);
            this.g1.Location = new System.Drawing.Point(16, 15);
            this.g1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.g1.Name = "g1";
            this.g1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.g1.Size = new System.Drawing.Size(611, 153);
            this.g1.TabIndex = 5;
            this.g1.TabStop = false;
            this.g1.Text = "[ 1 ]";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(488, 96);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "Browse . . .";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Source";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(17, 50);
            this.txtSource.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSource.Name = "txtSource";
            this.txtSource.ReadOnly = true;
            this.txtSource.Size = new System.Drawing.Size(447, 22);
            this.txtSource.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Target";
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(17, 98);
            this.txtSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSave.Name = "txtSave";
            this.txtSave.ReadOnly = true;
            this.txtSave.Size = new System.Drawing.Size(447, 22);
            this.txtSave.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(488, 49);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Browse . . .";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStop);
            this.groupBox2.Controls.Add(this.bnStart);
            this.groupBox2.Controls.Add(this.pBar);
            this.groupBox2.Location = new System.Drawing.Point(16, 554);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(611, 92);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " [ 4 ]";
            // 
            // btnStop
            // 
            this.btnStop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(513, 23);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 50);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "S&top";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // bnStart
            // 
            this.bnStart.Location = new System.Drawing.Point(351, 23);
            this.bnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bnStart.Name = "bnStart";
            this.bnStart.Size = new System.Drawing.Size(143, 50);
            this.bnStart.TabIndex = 6;
            this.bnStart.Text = "&Start >>";
            this.bnStart.UseVisualStyleBackColor = true;
            this.bnStart.Click += new System.EventHandler(this.BnStart_Click);
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(17, 34);
            this.pBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(300, 28);
            this.pBar.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.stTxt,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6});
            this.statusStrip1.Location = new System.Drawing.Point(0, 666);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(643, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabel1.Text = "Status :";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // stTxt
            // 
            this.stTxt.Name = "stTxt";
            this.stTxt.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(160, 17);
            this.toolStripStatusLabel3.Text = "                                                   ";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(79, 17);
            this.toolStripStatusLabel4.Text = "Image Count:";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel5.Text = "|";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(0, 17);
            // 
            // g3
            // 
            this.g3.Controls.Add(this.txtBoy);
            this.g3.Controls.Add(this.txtEn);
            this.g3.Controls.Add(this.cc);
            this.g3.Controls.Add(this.c195);
            this.g3.Controls.Add(this.c520);
            this.g3.Location = new System.Drawing.Point(16, 438);
            this.g3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.g3.Name = "g3";
            this.g3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.g3.Size = new System.Drawing.Size(611, 101);
            this.g3.TabIndex = 10;
            this.g3.TabStop = false;
            this.g3.Text = "[ 3 ] :  Image size settings";
            // 
            // txtBoy
            // 
            this.txtBoy.Location = new System.Drawing.Point(444, 55);
            this.txtBoy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoy.Name = "txtBoy";
            this.txtBoy.Size = new System.Drawing.Size(132, 22);
            this.txtBoy.TabIndex = 5;
            this.txtBoy.Text = "0";
            this.txtBoy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox4_KeyPress);
            // 
            // txtEn
            // 
            this.txtEn.Location = new System.Drawing.Point(444, 23);
            this.txtEn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEn.Name = "txtEn";
            this.txtEn.Size = new System.Drawing.Size(132, 22);
            this.txtEn.TabIndex = 4;
            this.txtEn.Text = "0";
            this.txtEn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox4_KeyPress);
            // 
            // cc
            // 
            this.cc.AutoSize = true;
            this.cc.Location = new System.Drawing.Point(347, 46);
            this.cc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(78, 20);
            this.cc.TabIndex = 3;
            this.cc.Text = "Custom :";
            this.cc.UseVisualStyleBackColor = true;
            // 
            // c195
            // 
            this.c195.AutoSize = true;
            this.c195.Checked = true;
            this.c195.CheckState = System.Windows.Forms.CheckState.Checked;
            this.c195.Location = new System.Drawing.Point(199, 46);
            this.c195.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c195.Name = "c195";
            this.c195.Size = new System.Drawing.Size(100, 20);
            this.c195.TabIndex = 2;
            this.c195.Text = "195 X 195 px";
            this.c195.UseVisualStyleBackColor = true;
            // 
            // c520
            // 
            this.c520.AutoSize = true;
            this.c520.Checked = true;
            this.c520.CheckState = System.Windows.Forms.CheckState.Checked;
            this.c520.Location = new System.Drawing.Point(16, 46);
            this.c520.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c520.Name = "c520";
            this.c520.Size = new System.Drawing.Size(100, 20);
            this.c520.TabIndex = 1;
            this.c520.Text = "520 X 520 px";
            this.c520.UseVisualStyleBackColor = true;
            // 
            // g2
            // 
            this.g2.Controls.Add(this.btnDelete);
            this.g2.Controls.Add(this.fileLists);
            this.g2.Controls.Add(this.button4);
            this.g2.Controls.Add(this.button3);
            this.g2.Location = new System.Drawing.Point(16, 175);
            this.g2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.g2.Name = "g2";
            this.g2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.g2.Size = new System.Drawing.Size(611, 256);
            this.g2.TabIndex = 11;
            this.g2.TabStop = false;
            this.g2.Text = "[ 2 ] : Image List";
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(488, 34);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.Button5_Click);
            // 
            // fileLists
            // 
            this.fileLists.FormattingEnabled = true;
            this.fileLists.ItemHeight = 16;
            this.fileLists.Location = new System.Drawing.Point(17, 70);
            this.fileLists.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fileLists.Name = "fileLists";
            this.fileLists.ScrollAlwaysVisible = true;
            this.fileLists.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.fileLists.Size = new System.Drawing.Size(569, 164);
            this.fileLists.TabIndex = 15;
            this.fileLists.SelectedIndexChanged += new System.EventHandler(this.FileLists_SelectedIndexChanged);
            this.fileLists.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FileLists_KeyUp);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(137, 34);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 14;
            this.button4.Text = "Deselect all";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 34);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 13;
            this.button3.Text = "Select all";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "-";
            // 
            // BgrdWorker
            // 
            this.BgrdWorker.WorkerReportsProgress = true;
            this.BgrdWorker.WorkerSupportsCancellation = true;
            this.BgrdWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgrdWorker_DoWork);
            this.BgrdWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgrdWorker_ProgressChanged);
            this.BgrdWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgrdWorker_RunWorkerCompleted);
            // 
            // ImageCanvasSizeForm
            // 
            this.AcceptButton = this.bnStart;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnStop;
            this.ClientSize = new System.Drawing.Size(643, 688);
            this.Controls.Add(this.g2);
            this.Controls.Add(this.g3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.g1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "ImageCanvasSizeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IR: Image Resize v b0.12  | cuneyt.yener";
            this.Load += new System.EventHandler(this.ImageCanvasSizeForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ImageCanvasSizeForm_KeyDown);
            this.g1.ResumeLayout(false);
            this.g1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.g3.ResumeLayout(false);
            this.g3.PerformLayout();
            this.g2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox g1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bnStart;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox g3;
        private System.Windows.Forms.GroupBox g2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.CheckBox c520;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel stTxt;
        private System.Windows.Forms.CheckBox c195;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListBox fileLists;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtBoy;
        private System.Windows.Forms.TextBox txtEn;
        private System.Windows.Forms.CheckBox cc;
        private System.ComponentModel.BackgroundWorker BgrdWorker;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
    }
}

