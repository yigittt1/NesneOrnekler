using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4_Uyg12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList sehirler = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            sehirler.Add(textBox1.Text);
            listele();
        }

        private void listele()
        {
            listBox1.Items.Clear();
            foreach (var sehir in sehirler)
            {
                listBox1.Items.Add(sehir);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int indexNo = listBox1.SelectedIndex;
            sehirler.Insert(indexNo, textBox1.Text);
            listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int indexNo = listBox1.SelectedIndex;
            sehirler[indexNo] = textBox1.Text;
            listele();
        }
    }
}
