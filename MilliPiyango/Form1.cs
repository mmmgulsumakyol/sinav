using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilliPiyango
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            for(i = 0; i < 7; i++) 
            {
               
                    if (i == 0)
                    {
                        listBox1.Items.Clear();
                        Random random = new Random();
                        i = random.Next(0, 9);
                        listBox1.Items.Add(i);
                    }
                    if (i == 1 )
                    {
                        listBox2.Items.Clear();
                        Random random = new Random();
                        i = random.Next(0, 9);
                        listBox2.Items.Add(i);
                    }
                    if(i == 2 )
                {
                    listBox3.Items.Clear();
                    Random random = new Random();
                    i=random.Next(0, 9); listBox3.Items.Add(i);
                }
                if (i == 3)
                    {
                    listBox4.Items.Clear();
                    Random random = new Random();
                    i = random.Next(0, 9);
                    listBox4.Items.Add(i);
                    }
                if (i == 4)
                {
                    listBox5.Items.Clear();
                    Random random = new Random();
                    i = random.Next(0, 9);
                    listBox5.Items.Add(i);
                }
                if (i == 3)
                {
                    listBox6.Items.Clear();
                    Random random = new Random();
                    i = random.Next(0, 9);
                    listBox6.Items.Add(i);
                }
                if (i == 6)
                {
                    listBox7.Items.Clear();
                    Random random = new Random();
                    i = random.Next(0, 9);
                    listBox7.Items.Add(i);
                }
            }
                }
            }
        }
   

