﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KutuphaneProjesi
{
    public partial class formOgrenci : Form
    {
        VeriTabanİslemleri vtIslemleri = new VeriTabanİslemleri();
        MySqlConnection baglanti;
        MySqlCommand komut;
        string komutSatiri;
        private void formOgrenci_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            try
            {
                baglanti = vtIslemleri.baglan();
                komutSatiri = "Select * From ogrenciler";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutSatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                gridOgrenci.DataSource = dataTable;
                gridOgrenci.Columns["ogrenci_no"].HeaderText = "Öğrenci Numarası";
                gridOgrenci.Columns["ad"].HeaderText = "Ad";
                gridOgrenci.Columns["soyad"].HeaderText = "Soyad";
                gridOgrenci.Columns["sinif"].HeaderText = "Sınıf";
                gridOgrenci.Columns["cinsiyet"].HeaderText = "Cinsiyet";
                gridOgrenci.Columns["telefon"].HeaderText = "Telefon";
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
                    baglanti.Open();
                }
                komutSatiri = "INSERT INTO ogrenciler (ogrenci_no,ad,soyad,sinif,cinsiyet,telefon) VALUES(@no,@ad,@soyad,@sinif,@cinsiyet,@telefon)";
                komut = new MySqlCommand(komutSatiri, baglanti);
                komut.Parameters.AddWithValue("@no", int.Parse(txtNo.Text));
                komut.Parameters.AddWithValue("@ad", txtAd.Text);
                komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                komut.Parameters.AddWithValue("@sinif", int.Parse(comboSinif.SelectedItem.ToString())); 
                komut.Parameters.AddWithValue("@cinsiyet", comboCinsiyet.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("İşlem başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Listele();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtNo.Clear();
            txtTelefon.Clear();
        }

        private void gridOgrenci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNo.Text = gridOgrenci.CurrentRow.Cells["ogrenci_no"].Value.ToString();
                txtAd.Text = gridOgrenci.CurrentRow.Cells["ad"].Value.ToString();
                txtSoyad.Text = gridOgrenci.CurrentRow.Cells["soyad"].Value.ToString();
                txtTelefon.Text = gridOgrenci.CurrentRow.Cells["telefon"].Value.ToString();
                comboSinif.SelectedItem = gridOgrenci.CurrentRow.Cells["sinif"].Value.ToString();
                comboSinif.SelectedItem = gridOgrenci.CurrentRow.Cells["cinsiyet"].Value.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                komutSatiri = "DELETE FROM ogrenciler WHERE ogrenci_no = @no";
                komut = new MySqlCommand(komutSatiri, baglanti);
                komut.Parameters.AddWithValue("@no", gridOgrenci.CurrentRow.Cells["ogrenci_no"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("İşlem başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Listele();
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
                komutSatiri = "UPDATE ogrenciler SET (ogrenci_no,ad,soyad,sinif,cinsiyet,telefon) VALUES(@no,@ad,@soyad,@sinif,@cinsiyet,@telefon)";
                komut = new MySqlCommand(komutSatiri, baglanti);
                komut.Parameters.AddWithValue("@no", int.Parse(gridOgrenci.CurrentRow.Cells["ogrenci_no"].Value.ToString()));
                komut.Parameters.AddWithValue("@ad", txtAd.Text);
                komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                komut.Parameters.AddWithValue("@sinif", int.Parse(comboSinif.SelectedItem.ToString()));
                komut.Parameters.AddWithValue("@cinsiyet", comboCinsiyet.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("İşlem başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Listele();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
