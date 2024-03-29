﻿using System;

using System.ComponentModel;

using System.Drawing;
using System.Linq;

using System.Windows.Forms;


using ImageProcessor.Imaging;

using ImageProcessor;

using System.IO;

namespace image_pro
{
    public partial class ImageCanvasSizeForm : Form
    {
        public ImageCanvasSizeForm()
        {
            InitializeComponent();
        }



        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string file in files)
            {
                //.jpg, *.jpeg, *.jpe, *.jfif, *.png
                if (Path.GetExtension(file) ==".jpg" || Path.GetExtension(file) == ".jpeg" || Path.GetExtension(file) == ".jpe" || Path.GetExtension(file) == ".jfif" ||  Path.GetExtension(file) == ".png")
                       fileLists.Items.Add(file);
                               
            }


            statusRecCount();
        }
        public void statusRecCount() {
            statusStrip1.Items[6].Text =  fileLists.Items.Count.ToString();
        }
        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            
            using (OpenFileDialog Dialog = new OpenFileDialog { Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png", Title = "OpenFile Dialog", RestoreDirectory = true })
            {
                Dialog.Multiselect = true;

                if (Dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {


                    string Path = Dialog.FileName;
                    string[] fileNameAndPath = Dialog.FileNames;
                    string[] filename = Dialog.SafeFileNames;

                    txtSource.Text = System.IO.Path.GetDirectoryName(Path);
                    for (int i = 0; i < Dialog.SafeFileNames.Count(); i++)
                    {
                        fileLists.Items.Add( fileNameAndPath[i]);
                    }

                }
            }

            statusRecCount();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {

            saveFileDialog1.ShowDialog();
            txtSave.Text= System.IO.Path.GetDirectoryName(saveFileDialog1.FileName);
            

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(fileLists);
            selectedItems = fileLists.SelectedItems;
            if (fileLists.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    fileLists.Items.Remove(selectedItems[i]);
                
            }
            statusRecCount();

        }

        private void FileLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fileLists.Items.Count > 0)
            {
                btnDelete.Enabled = true;
            }
            else btnDelete.Enabled = false;
        }

        private void FileLists_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Delete) Button5_Click(sender,e);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
        
        
           for (int i = 0; i < fileLists.Items.Count; i++)
            {
                fileLists.SetSelected(i, true);
            }
            
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < fileLists.Items.Count; i++)
            {
                fileLists.SetSelected(i, false);
            }
        }

        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void BnStart_Click(object sender, EventArgs e)
        {

            // filelist bos ise...path yok ise...check kontrol false ise islem yapma...
            if (fileLists.Items.Count == 0 || txtSave.TextLength==0 || chkbox1c()==false) 
            {
                toolStripStatusLabel2.Text = "Files not found ! or Save destination path of target?";
                return;
            }

            if (cc.Checked==true && (Int32.Parse(txtEn.Text)<10 || Int32.Parse(txtBoy.Text) < 10 ) )
            {
                toolStripStatusLabel2.Text = "Must be Minimum Size: 10x10 px ";
                return;
            }
                


            //image async start
           
            if (BgrdWorker.IsBusy != true)
            {
                // parts disable
                bnStart.Enabled = false;
                btnStop.Enabled = true;
                g1.Enabled = false;
                g2.Enabled = false;
                g3.Enabled = false;

                toolStripStatusLabel2.Text = "please wait...";
                // Start the asynchronous operation.
                BgrdWorker.RunWorkerAsync( );
            }
   
        }


        private Boolean chkbox1c()
        {
            //checkbox controls
            if (c520.Checked == true || c195.Checked == true || cc.Checked == true)
            {
                return true;
            }
            else return false;


        }


        private void BtnStop_Click(object sender, EventArgs e)
        {
            if (BgrdWorker.WorkerSupportsCancellation == true)
            {
                // Cancel the async operation.
                BgrdWorker.CancelAsync();

                // parts enable
                bnStart.Enabled = true;
                btnStop.Enabled = false;
                g1.Enabled = true;
                g2.Enabled = true;
                g3.Enabled = true;
           
            }
        }



        private void BgrdWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //image async operations...
            string yolAdi = txtSave.Text;
            string p1 = "";

            ResizeLayer rs = null;
            ResizeLayer rs1 = null;
            ResizeLayer rs2 = null;
   

            Size Rsize = new Size(0, 0);

            ImageFactory resNesnesi1 = new ImageFactory(preserveExifData: false);
            ImageFactory resNesnesi2 = new ImageFactory(preserveExifData: false);
            ImageFactory resNesnesi3 = new ImageFactory(preserveExifData: false);

            // resim yüklemesi.

            for (int i = 0; i <= fileLists.Items.Count; i++)
            {

                    BgrdWorker.ReportProgress(i);
                    // check status on each step
                    if (BgrdWorker.CancellationPending == true)
                    {
                        e.Cancel = true;
                        return; // abort work, if it's cancelled
                    }

                    if (c520.Checked == true)
                    {
                        Rsize = new Size(520, 520);
                        rs = new ResizeLayer(Rsize, ResizeMode.BoxPad);
                        p1 = txtSave.Text + "/520x520";
                        yolAdi = p1;
                        //klasor yarat
                        dYarat(p1);

                        resNesnesi1.Load(fileLists.Items[i].ToString()).Resize(rs).BackgroundColor(Color.White).Save(yolAdi + "/" + System.IO.Path.GetFileName(fileLists.Items[i].ToString()));
                    }

                    if (c195.Checked == true)
                    {
                        Rsize = new Size(195, 195);
                        rs1 = new ResizeLayer(Rsize, ResizeMode.BoxPad);
                        p1 = txtSave.Text + "/195x195";
                        yolAdi = p1;
                        //klasor yarat
                        dYarat(p1);

                        resNesnesi2.Load(fileLists.Items[i].ToString()).Resize(rs1).BackgroundColor(Color.White).Save(yolAdi + "/" + System.IO.Path.GetFileName(fileLists.Items[i].ToString()));
                    }

                    if (cc.Checked == true)
                    {
                        Rsize = new Size(Int32.Parse(txtEn.Text), Int32.Parse(txtBoy.Text));
                        rs2 = new ResizeLayer(Rsize, ResizeMode.BoxPad);
                        p1 = txtSave.Text + "/"+txtEn.Text+"x"+txtBoy.Text;
                        yolAdi = p1;
                        //klasor yarat
                        dYarat(p1);

                        resNesnesi3.Load(fileLists.Items[i].ToString()).Resize(rs2).BackgroundColor(Color.White).Save(yolAdi + "/" + System.IO.Path.GetFileName(fileLists.Items[i].ToString()));
                    }

            }


            resNesnesi1 = null;
            resNesnesi2 = null;
            resNesnesi3 = null;


        }

   

        private void BgrdWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // progressbar
            

        
            if (e.ProgressPercentage > 0)
            {
               
                
                pBar.Value = (int)Math.Round((double)(e.ProgressPercentage * 100 / fileLists.Items.Count));
                toolStripStatusLabel2.Text ="  % "+ pBar.Value.ToString();
            }
        }

        private void BgrdWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // image async operations complated
          
            // parts enable
            bnStart.Enabled = true;
            btnStop.Enabled = false;
            g1.Enabled = true;
            g2.Enabled = true;
            g3.Enabled = true;
            toolStripStatusLabel2.Text = " Completed " ;
            toolStripStatusLabel2.Text = " Ready ";
            pBar.Value = 0;
        }

        private void ImageCanvasSizeForm_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Escape)
            {
                if (btnStop.Enabled==true) BtnStop_Click(sender,e);
            }


            if (e.KeyCode == Keys.Enter)
            {
                if (bnStart.Enabled == true) BnStart_Click(sender, e);
            }

        }



        private Boolean dYarat(string yol)
        {
            

            bool exists = System.IO.Directory.Exists(yol);

            if (!exists)
            {
                System.IO.Directory.CreateDirectory(yol);
                return true;
            } 
            else  return false;
        }

        private void ImageCanvasSizeForm_Load(object sender, EventArgs e)
        {

        }
    }

}
