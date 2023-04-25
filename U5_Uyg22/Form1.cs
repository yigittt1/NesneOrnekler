﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_Uyg22
{
    public partial class Form1 : Form
    {
        ArrayList kaynakVeri = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            Kitaplar kitap = new Kitaplar();
            kitap.KitapAdi = txtKitapAdi.Text;
            kitap.KitapYazari = txtKitapYazari.Text;
            kitap.KitapTuru = txtKitapTuru.Text;
            kaynakVeri.Add(kitap);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            ListeVeri.DataSource = null;
            ListeVeri.DataSource = kaynakVeri;
            ListeVeri.DisplayMember = "Kitap Adı";
        }
    }
}
