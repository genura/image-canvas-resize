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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public Thread thOlustur =null;


        private void Button1_Click(object sender, EventArgs e)
        {
            //
            using (ImageFactory resNesnesi = new ImageFactory(preserveExifData: false))
            {
                // resim yüklemesi.
                Size rsize = new Size(520, 520);

                ResizeLayer rs = new ResizeLayer(rsize, ResizeMode.BoxPad);
                resNesnesi.Load("./sc.jfif").Resize(rs).BackgroundColor(Color.White).Save("./aa.jpg");

                ///aaaa

                //pBar.Value 



            }

        }



      

        private void Button2_Click(object sender, EventArgs e)
        {


            Thread t = new Thread(doWork);          // Kick off a new thread
             t.Start();

            btnStop.Enabled = true;


           
           // frm.ShowDialog();
            

           // item_ekleAsync();

        }

        public async Task item_ekleAsync() {
            for (var i=0;i<=100;i++)
            {
                
                await Task.Delay(1000);
            }
            
        }




        //thread=
        private volatile bool m_StopThread;

        private void BtnStop_Click(object sender, EventArgs e)
        {
            m_StopThread = false;
        }

         void doWork()
        {
            while (m_StopThread)
            {
                for (int i = 0; i < 200000; i++)
                {

                    if (m_StopThread == false)
                    {
                        MessageBox.Show("asd");
                    }
                   

                

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BnStart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("aaa");
                }

        private void ToolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string file in files)
            {
                fileLists.Items.Add(file);

                //THEN DO WHATEVER YOU WANT TO EACH file in files
                //e.g.



            }
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
                if (Dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string Path = Dialog.FileName;
                    string FolderName = System.IO.Path.GetDirectoryName(Path);
                    System.IO.DirectoryInfo info = new System.IO.DirectoryInfo(FolderName);
                    MessageBox.Show(info.Name);
                }
            }
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {

            saveFileDialog1.ShowDialog();
            MessageBox.Show(saveFileDialog1.FileName);
            /*
            using (OpenFileDialog Dialog = new OpenFileDialog { Filter = "All Files|*.*", Title = "OpenFile Dialog", RestoreDirectory = true })
            {
                if (Dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string Path = Dialog.FileName;
                    string FolderName = System.IO.Path.GetDirectoryName(Path);
                    System.IO.DirectoryInfo info = new System.IO.DirectoryInfo(FolderName);
                    MessageBox.Show(info.Name);
                }
            }
            */
        }



    }
}
