using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinav11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int sayi = int.Parse(textBox1.Text);
            while (true)
            {
                if (sayi == 0)
                    break;
                toplam = toplam + sayi;
            }
            label3.Text = toplam.ToString();
        }
    }
}
