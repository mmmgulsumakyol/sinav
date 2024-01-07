using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SayiiBulucu sayiiBulucu = new SayiiBulucu();
            int sayi1 = int.Parse(textBox1.Text);
            int sayi2 = int.Parse(textBox2.Text);
            int sonuc = sayiiBulucu.BuyukOlaniBul(sayi1, sayi2);
            textBox3.Text=sonuc.ToString(); 
        }
    }
}
