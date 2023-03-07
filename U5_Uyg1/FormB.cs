using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_Uyg1
{
    public partial class FormB : Form
    {
        public FormB()
        {
            InitializeComponent();
        }

        private void FormB_Load(object sender, EventArgs e)
        {
            MessageBox.Show("FormB Yükleniyor");
        }

        private void FormB_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("FormB Kapanıyor");
        }

        private void FormB_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("FormB Kapandı");
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FormB Click Olayı Çalışıyor");
        }
    }
}
