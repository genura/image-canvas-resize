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
            //
            using (ImageFactory resNesnesi = new ImageFactory(preserveExifData: false))
            {
                // resim yüklemesi.
                Size rsize = new Size(520, 520);

                ResizeLayer rs = new ResizeLayer(rsize, ResizeMode.BoxPad);
                resNesnesi.Load("./sc.jfif").Resize(rs).BackgroundColor(Color.White).Save("./aa.jpg");


            }
        }
    }
}
