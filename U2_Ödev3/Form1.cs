﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_Ödev3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1, s2 , toplam;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            toplam = (s1 * s1) / s2;
            if (toplam<18)
            {
                MessageBox.Show("zayıf");
            }
            if (toplam<25)
            {
                MessageBox.Show("Normal");
            }
            else
            {
                MessageBox.Show("İneksizin Fazla");
            }
        }
    }
}
