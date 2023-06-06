using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinav2023
{
    public partial class Form1 : Form
    {
        VeriTabaniIslemleri vtIslemleri = new VeriTabaniIslemleri();
        MySqlConnection baglanti;
        MySqlCommand komut;
        String komutSatiri;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            try
            {
                baglanti = vtIslemleri.baglan();
                komutSatiri = "SELECT * FROM urun";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutSatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                gridUrunler.DataSource = dataTable;
                gridUrunler.Columns["fiyat"].HeaderText = "Fiyat";
                gridUrunler.Columns["urun_adi"].HeaderText = "Ürün Adı";
                gridUrunler.Columns["adet"].HeaderText = "Adet";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    komutSatiri = "INSERT INTO urun (urun_adi,fiyat,adet) VALUES(@adi,@fiyat,@adet)";
                    komut = new MySqlCommand(komutSatiri, baglanti);
                    komut.Parameters.AddWithValue("@adet", int.Parse(txtAdet.Text.ToString()));
                    komut.Parameters.AddWithValue("@fiyat", txtFiyat.Text);
                    komut.Parameters.AddWithValue("@adi", txtUrunAdi.Text);

                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    Temizle();
                    MessageBox.Show("İşlem Başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Listele();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Temizle()
        {
            txtAdet.Clear();
            txtFiyat.Clear();
            txtUrunAdi.Clear();
        }

        private void gridUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtAdet.Text = gridUrunler.CurrentRow.Cells["adet"].Value.ToString();
                txtFiyat.Text = gridUrunler.CurrentRow.Cells["fiyat"].Value.ToString();
                txtUrunAdi.Text = gridUrunler.CurrentRow.Cells["urun_adi"].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu","Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komutSatiri = "DELETE FROM urun WHERE id = @id";
                komut = new MySqlCommand(komutSatiri, baglanti);
                komut.Parameters.AddWithValue("@no", gridUrunler.CurrentRow.Cells["id"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("İşlem Başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komutSatiri = "UPDATE urun SET adet=@adet,fiyat=@fiyat,urun_adi=@urun_adi where id=@id";
                komut = new MySqlCommand(komutSatiri, baglanti);
                komut.Parameters.AddWithValue("@adet", int.Parse(txtAdet.Text));
                komut.Parameters.AddWithValue("@fiyat", txtFiyat.Text);
                komut.Parameters.AddWithValue("@urun_adi", txtUrunAdi.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("İşlem Başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUrunAra_TextChanged(object sender, EventArgs e)
        {
            UrunArama(txtUrunAra.Text);
        }

        private void UrunArama(string aranacakUrun)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "Selecet * From urun Where ad LIKE'" + aranacakUrun + "%'";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komut);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                baglanti.Close();
                gridUrunler.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
