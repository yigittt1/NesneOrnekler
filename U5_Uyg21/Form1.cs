﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_Uyg21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVeriBagla_Click(object sender, EventArgs e)
        {
            string [] diller = { "C#”, “Java”, “Python”,”Delphi" };
            listeVeriler.DataSource = diller;
        }
    }
}
