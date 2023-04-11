﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4_Uyg16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Listele()
        {
            listBox1.Items.Clear();
            foreach (var ogrenci in ogrenciler)
            {
                listBox1.Items.Add(ogrenci.Key + " " + ogrenci.Value);
            }
        }
        Dictionary<int, string> ogrenciler = new Dictionary<int, string>();
        int anahtar;
        string deger;

        private void btnAra_Click(object sender, EventArgs e)
        {
            bool durum = false;
            if (textBox1.Text != " ")
            {
                anahtar = int.Parse(textBox1.Text);
                durum = ogrenciler.ContainsKey(anahtar);
            }
            else
            {
                deger = textBox2.Text;
                durum = ogrenciler.ContainsValue(deger);
            }
            if (durum == true)
            {
                MessageBox.Show("Öğrenci Kayıtlıdır.");
            }
            else
            {
                MessageBox.Show("Öğrenci Kayıtlı Değildir.");
            }


        }

        private void btnGüncalle_Click(object sender, EventArgs e)
        {
            anahtar = int.Parse(textBox1.Text);
            deger = textBox2.Text;
            ogrenciler[anahtar] = deger;
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            anahtar = int.Parse(textBox1.Text);
            ogrenciler.Remove(anahtar);
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            anahtar = int.Parse(textBox2.Text);
            deger = textBox2.Text;
            ogrenciler.Add(anahtar, deger);
            Listele();

        }
    }
}
