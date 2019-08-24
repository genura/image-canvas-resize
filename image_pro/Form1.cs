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




namespace image_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //
            using (ImageFactory resNesnesi = new ImageFactory(preserveExifData: false))
            {
                // resim yüklemesi.
                Size rsize = new Size(520,520);

                ResizeLayer rs = new ResizeLayer(rsize, ResizeMode.BoxPad);
                resNesnesi.Load("./sc.jfif").Resize(rs).BackgroundColor(Color.White).Save("./aa.jpg");

                ///aaaa

                //pBar.Value 



            }

        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {
               
        }
    }
}
