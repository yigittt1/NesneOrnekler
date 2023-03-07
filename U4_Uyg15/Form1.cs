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

namespace U4_Uyg15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stack yigin = new Stack();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            yigin.Push(txtAdSoyad.Text);
            Listele();
        }
    }
}
