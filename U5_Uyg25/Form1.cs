﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_Uyg25
{
    public partial class Form1 : Form
    {
        DataTable tablo = new DataTable();
        public Form1()
        {
            tablo.Columns.Add("Numara", typeof(int));
            tablo.Columns.Add("Ad Soyad", typeof(string));
            tablo.Columns.Add("Notu", typeof(int));
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int numara = int.Parse(txtNumara.Text);
            string adsoyad = txtAdSoyad.Text;
            int notu = int.Parse(txtDersNotu.Text);
            tablo.Rows.Add(numara, adsoyad, notu);
            Bagla();
        }

        private void Bagla()
        {
            
        }
    }
}
