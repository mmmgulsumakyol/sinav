using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinav9.soru2
{
    public partial class FaktHesapla : Form
    {
        public FaktHesapla()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int faktoryel = 1;
        int sayi=int.Parse(textBox1.Text);
            for(int i = 0; i < sayi; i++) 
            { 
              faktoryel=faktoryel*i;
                faktoryel--;
              
            }

        }
    }
}
