using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneProjesi
{
    public partial class formKitap : Form
    {
        public formKitap()
        {
            InitializeComponent();
        }

        VeriTabaniIslemleri vtİslemler = new VeriTabaniIslemleri();
        MySqlConnection baglanti;
        MySqlCommand komut;
        string komutSatiri;
        private string aranacakKelime;

        private void formKitap_Load(object sender, EventArgs e)
        {
            KitapTurYukle();
            KitapListele();
        }

        private void KitapTurYukle()
        {
            try
            {
                baglanti = vtİslemler.baglan();
                komutSatiri = "Select * From kitap_turleri";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutSatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                comboKitapTur.DataSource = dataTable;
                comboKitapTur.ValueMember = "tur_adi";
                comboKitapTur.DisplayMember = "tur_adi";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KitapListele()
        {
            try
            {
                baglanti = vtİslemler.baglan();
                komutSatiri = "Select kitap_id, tur_adi, kitap_adi, yazar, yayinevi, sayfa_sayisi From kitaplar,kitap_turleri where kitaplar, tur_id=kitap_turleri,tur_id";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutSatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                gridKitap.DataSource = dataTable;

                gridKitap.Columns["kitap_id"].HeaderText = "ID";
                gridKitap.Columns["kitap_id"].Width = 20;
                gridKitap.Columns["tur_adi"].HeaderText = "Tür";
                gridKitap.Columns["tur_adi"].Width = 30;
                gridKitap.Columns["kitap_adi"].HeaderText = "Kitap";
                gridKitap.Columns["kitap_adi"].Width = 90;
                gridKitap.Columns["yazar"].HeaderText = "Yazar";
                gridKitap.Columns["yazar"].Width = 80;
                gridKitap.Columns["yayinevi"].HeaderText = "Yayın Evi";
                gridKitap.Columns["yayinevi"].Width = 80;
                gridKitap.Columns["sayfa_sayisi."].HeaderText = "Sayfa Sayisi";
                gridKitap.Columns["sayfa_sayisi"].Width = 50;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "INSERT INTO kitaplar (tur_id, kitap_adi, yazar, yayinevi,sayfa_sayisi)" + "VALUES(@tur_id, kitap_id, @yazar,@yayinevi,@sayfa_sayisi";
                komut.Parameters.AddWithValue("@tur_id", int.Parse(comboKitapTur.SelectedValue.ToString()));
                komut.Parameters.AddWithValue("@kitap_adi", txtKitapAdi.Text);
                komut.Parameters.AddWithValue("@yazar", txtYazar.Text);
                komut.Parameters.AddWithValue("@yayinevi", txtYayinEvi.Text);
                komut.Parameters.AddWithValue("@sayfa_sayisi", int.Parse(txtSayfaSayisi.Text));

                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("İşlem Başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void Temizle()
        {
            txtKitapAdi.Clear();
            txtSayfaSayisi.Clear();
            txtYayinEvi.Clear();
            txtYazar.Clear();
        }

        private void gridKitap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtKitapAdi.Text = gridKitap.CurrentRow.Cells["kitap_adi"].Value.ToString();
                txtSayfaSayisi.Text = gridKitap.CurrentRow.Cells["sayfa_sayisi"].Value.ToString();
                txtYayinEvi.Text = gridKitap.CurrentRow.Cells["yayinevi"].Value.ToString();
                txtYazar.Text = gridKitap.CurrentRow.Cells["yazar"].Value.ToString();
                comboKitapTur.Text = gridKitap.CurrentRow.Cells["tur_adi"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtKitapArama_TextChanged(object sender, EventArgs e)
        {
            kitapArama(txtKitapArama.Text);
        }

        private void kitapArama(string text)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komutSatiri = "Select kitap_id, tur_adi,kitap_adi,yazar,yayinevi,sayfa_sayisi From kitaplar, kitap_turleri" + "where kitaplar tur_id=kitap_turleri.tur_id and kitap_adi LIKE" + aranacakKelime + "%'";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutSatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                baglanti.Close();
                gridKitap.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "DELETE FROM kitaplar WHERE kitap_id = @kitap_id";

                komut.Parameters.AddWithValue("@kitap_id", gridKitap.CurrentRow.Cells["kitap_id"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("İşlem Başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                KitapListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
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
                komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "UPDATE kitaplar SET tur_id=@tur_id, kitap_adi=@kitap_adi," + "yazar=@yazar, yayinevi=@yayinevi, sayfa_sayisi=@sayfa_sayisi, where kitap_id=@kitap_id";
                komut.Parameters.AddWithValue("@kitap_id", int.Parse(gridKitap.CurrentRow.Cells["kitap_adi"].Value.ToString()));
                komut.Parameters.AddWithValue("@tur_id", int.Parse(comboKitapTur.SelectedValue.ToString()));
                komut.Parameters.AddWithValue("@kitap_adi", txtKitapAdi.Text);
                komut.Parameters.AddWithValue("@yazar", txtYazar.Text);
                komut.Parameters.AddWithValue("@yayinevi", txtYayinEvi.Text);
                komut.Parameters.AddWithValue("sayfa_sayisi", int.Parse(txtSayfaSayisi.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("İşlem Başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                KitapListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
