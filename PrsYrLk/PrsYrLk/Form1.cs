using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrsYrLk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_load(object sender, EventArgs e)
        {
            
           
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            int idx = 0;
            pictureBox18.Image = imageList1.Images[idx];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idx = 0;
            pictureBox1.Image = imageList1.Images[idx];
        }
       

        
        



       
    }
}
