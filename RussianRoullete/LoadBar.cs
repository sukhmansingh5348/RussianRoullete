using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRoullete
{
    public partial class LoadBar : Form
    {
        public LoadBar()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            loadingBar.Value = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            loadingBar.Value+=1;
            if(loadingBar.Value== 100)
            {
                timer1.Stop();
                (new RussianRoullette()).Show();
                this.Hide();
            }
        }
    }
}
