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
    public partial class DersGuncelle : Form
    {
        public DersGuncelle()
        {
            InitializeComponent();
        }

        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres ;User Id=postgres;Password=1234");

        
        private void btn_listeleTamam_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand komut_goster;

            if (textBox_guncellenecekDersKodu.Text.Trim() == "")
            {
                komut_goster = new NpgsqlCommand("select * from ders", conn);
            }
            else
            {
                komut_goster = new NpgsqlCommand();
                komut_goster.Connection = conn;
                komut_goster.Parameters.AddWithValue("@guncellenecekDersKodu", textBox_guncellenecekDersKodu.Text);
                komut_goster.CommandType = CommandType.Text;
                komut_goster.CommandText = "select * from ders where ders_kodu = @guncellenecekDersKodu";
            }

            NpgsqlDataReader dr = komut_goster.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView_guncelleme.DataSource = dt;
            }

            komut_goster.Dispose();
            conn.Close();
        }

        private void btn_dersGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Güncellemek istediğinize emin misiniz?", "", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                conn.Open();
                NpgsqlCommand komut_guncelle = new NpgsqlCommand("update ders set ders_kodu=@p1, " +
                    "ders_adi=@p2, kredi=@p3, akts=@p4, " +
                    "ogretim_uyesi=@p5, donem=@p6, " +
                    "harf_notu=@p7 where ders_kodu=@guncellenecekDersKodu", conn);
                komut_guncelle.Parameters.AddWithValue("@guncellenecekDersKodu", textBox_guncellenecekDersKodu.Text);
                komut_guncelle.Parameters.AddWithValue("@p1", textBox_dersKodu.Text);
                komut_guncelle.Parameters.AddWithValue("@p2", textBox_dersAdi.Text);
                komut_guncelle.Parameters.AddWithValue("@p3", int.Parse(textBox_kredi.Text));
                komut_guncelle.Parameters.AddWithValue("@p4", int.Parse(textBox_akts.Text));
                komut_guncelle.Parameters.AddWithValue("@p5", textBox_ogretimUyesi.Text);
                komut_guncelle.Parameters.AddWithValue("@p6", textBox_donem.Text);
                komut_guncelle.Parameters.AddWithValue("@p7", textBox_harfNotu.Text);
                komut_guncelle.ExecuteNonQuery();
                MessageBox.Show(textBox_dersKodu.Text + "kodlu dersin bilgileri başarıyla güncellendi.");
                conn.Close();

                textBox_dersKodu.Clear();
                textBox_dersAdi.Clear();
                textBox_kredi.Clear();
                textBox_akts.Clear();
                textBox_ogretimUyesi.Clear();
                textBox_donem.Clear();
                textBox_harfNotu.Clear();
                textBox_guncellenecekDersKodu.Clear();
                dataGridView_guncelleme.ClearSelection();
            }
        }

        private void btn_guncelleIptal_Click(object sender, EventArgs e)
        {
            Form1 geri_don = new Form1();
            geri_don.Show();
        }

        
    }
}
