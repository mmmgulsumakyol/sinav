﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinav3
{

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public string Ad { get; set; }
        public string Soyad { get; set; }
 


        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Ad;
            textBox2.Text = Soyad;


        }
        
    }
}
