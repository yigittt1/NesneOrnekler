using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4_Uyg4
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
        private void btnEnYuksek_Click(object sender, EventArgs e)
        {
            int enyuksek = notlar[0];
            for (int i = 0; i < notlar.Length; i++)
            {
                if (notlar[i] > enyuksek)
                {
                    enyuksek = notlar[i];
                }
            }
            textBox3.Text = enyuksek.ToString();
        }

        private void btnEnDüsük_Click(object sender, EventArgs e)
        {
            int endüsük = notlar[0];
            for (int i = 0; i < notlar.Length; i++)
            {
                if (notlar[i] < endüsük)
                {
                    endüsük = notlar[i];
                }
            }
            textBox4.Text = endüsük.ToString();
        }

        private void btnOrtalama_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            double ortalama = 0;
            for (int i = 0; i < notlar.Length; i++)
            {
                toplam += notlar[i];
            }
            ortalama = toplam / notlar.Length;
            textBox5.Text = ortalama.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            if (index < isimler.Length)
            {
                isimler[index] = textBox1.Text;
                notlar[index] = int.Parse(textBox2.Text);
                index++;
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < isimler.Length; i++)
            {
                if (isimler[i] != null)
                {
                    listBox1.Items.Add(isimler[i] + ">" + notlar[i]);
                }
            }
        }
    }
}
            



