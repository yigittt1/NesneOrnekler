﻿using System;
using System.Windows.Forms;

namespace U4_Uyg3
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = new string[5];
        int[] notlar = new int[5];
        int index = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (index<isimler.Length)
            {
                isimler[index] = textBox1.Text;
                notlar[index] = int.Parse(textBox2.Text);
                index++;
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
