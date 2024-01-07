using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinav12
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
            public  string KullaniciAdi {  get; set; }   
        public  int Sifre {  get; set; } 
        private void button1_Click(object sender, EventArgs e)
        {
           textBox1.Text=KullaniciAdi;
            textBox2.Text = Sifre.ToString();

        }
    }
}
