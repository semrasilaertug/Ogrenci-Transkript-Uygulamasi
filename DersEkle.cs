using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciTranstriptUygulamasi
{
    public partial class DersEkle : Form
    {
        public DersEkle()
        {
            InitializeComponent();
        }

        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres ;User Id=postgres;Password=1234");


        private void btn_dersEkle_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = conn;

            komut_ekle.Parameters.AddWithValue("@ders_kodu", textBox_dersKodu.Text);
            komut_ekle.Parameters.AddWithValue("@ders_adi", textBox_dersAdi.Text);
            komut_ekle.Parameters.AddWithValue("@kredi", Convert.ToInt32(textBox_kredi.Text));
            komut_ekle.Parameters.AddWithValue("@akts", Convert.ToInt32(textBox_akts.Text));
            komut_ekle.Parameters.AddWithValue("@ogretim_uyesi", textBox_ogretimUyesi.Text);
            komut_ekle.Parameters.AddWithValue("@donem", textBox_donem.Text);
            komut_ekle.Parameters.AddWithValue("@harf_notu", textBox_harfNotu.Text);

            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "insert into ders (ders_kodu, ders_adi, kredi, akts, ogretim_uyesi, donem, harf_notu) values  (@ders_kodu, @ders_adi, @kredi, @akts, @ogretim_uyesi, @donem, @harf_notu)";

            NpgsqlDataReader dr = komut_ekle.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);

            }
            komut_ekle.Dispose();
            conn.Close();

            MessageBox.Show(textBox_dersKodu.Text + " kodlu ders ve bilgileri başarıyla eklendi.");
            textBox_dersKodu.Clear();
            textBox_dersAdi.Clear();
            textBox_kredi.Clear();
            textBox_akts.Clear();
            textBox_ogretimUyesi.Clear();
            textBox_donem.Clear();
            textBox_harfNotu.Clear();
        }

        private void btn_dersIptal_Click(object sender, EventArgs e)
        {
            Form1 geri_don = new Form1();
            geri_don.Show();
        }
    }
}
