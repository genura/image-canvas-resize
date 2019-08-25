using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace image_pro
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
         
        }

        private async Task TryTask()
        {
            CancellationTokenSource source = new CancellationTokenSource();
            source.CancelAfter(TimeSpan.FromSeconds(5));
            Task<int> task = Task.Run(() => slowFunc(1, 2, source.Token), source.Token);

            // (A canceled task will raise an exception when awaited).
            await task;
           
        }


        private int slowFunc(int a, int b, CancellationToken cancellationToken)
        {
            // baslat
            MessageBox.Show("aaa"); 
            string someString = string.Empty;
            for (int i = 0; i < 200000; i++)
            {
                someString += "a";

               itemler.Items.Add("a");

                if (i == 100)
                {
                   

                    cancellationToken.ThrowIfCancellationRequested(); this.Close();
                }
                    
            }

            return a + b;
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            TryTask();
            
        }
    }
}
