﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uyg6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbLamba.Checked == true)
            {
                listBox1.Items.Add("Lambalar Açık");
            }
            else
            {
                listBox1.Items.Add("Lambalar Kapalı");
            }


            if (cbKombi.Checked==true)
            {
                listBox1.Items.Add("Kombi Açık");
            }
            else
            {
                listBox1.Items.Add("Kombi Kapalı");
            }
        }
    }
}
