using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using ImageProcessor.Imaging;
using ImageProcessor.Imaging.Filters.EdgeDetection;
using ImageProcessor.Imaging.Filters.Photo;
using ImageProcessor;
using System.Threading;
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
            
            using (OpenFileDialog Dialog = new OpenFileDialog { Filter = "All Files|*.*", Title = "OpenFile Dialog", RestoreDirectory = true })
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

            //image async start
           
            if (BgrdWorker.IsBusy != true)
            {
                // parts disable
                bnStart.Enabled = false;
                btnStop.Enabled = true;
                g1.Enabled = false;
                g2.Enabled = false;
                g3.Enabled = false;


                // Start the asynchronous operation.
                BgrdWorker.RunWorkerAsync( );
            }
   
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


       

            using (ImageFactory resNesnesi = new ImageFactory(preserveExifData: false))
            {
                // resim yüklemesi.
                Size rsize = new Size(520, 520);
                ResizeLayer rs = new ResizeLayer(rsize, ResizeMode.BoxPad);
                //fileLists.Items[2].ToString();
                for (int i = 0; i <= fileLists.Items.Count; i++) {
                    BgrdWorker.ReportProgress(i);
                    // check status on each step
                    if (BgrdWorker.CancellationPending == true)
                    {
                        e.Cancel = true;
                        return; // abort work, if it's cancelled
                    }

                    resNesnesi.Load(fileLists.Items[i].ToString()).Resize(rs).BackgroundColor(Color.White).Save("./"+i+".jpg");

                }
                
                
            }

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

     
    }
}
