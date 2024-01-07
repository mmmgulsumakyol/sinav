using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinav6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string Okul {  get; set; }
        public string AdSoyad { get; set; }
        public int Sinif {  get; set; }
        public int No {  get; set; }

        public void button1_Click(object sender, EventArgs e)
        {
            lblOkulAdi.Text = Okul;
            lblAdSoyad.Text = AdSoyad;
            lblNo.Text= No.ToString();
            lblSinif.Text=Sinif.ToString();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblOkulAdi.Text = "   ";
            lblAdSoyad.Text = "   ";
            lblNo.Text = "    ";
            lblSinif.Text = "    ";

        }
    }
}
