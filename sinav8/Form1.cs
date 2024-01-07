using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinav8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sayilar sayilar = new Sayilar();
            sayilar.Not1 = int.Parse(textBox1.Text);
            sayilar.Not2 = int.Parse(textBox2.Text);    
            sayilar.Not3 = int.Parse(textBox3.Text);
            
           

        }
    }
}
