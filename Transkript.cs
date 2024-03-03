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
    public partial class Transkript : Form
    {
        public Transkript()
        {
            InitializeComponent();
        }

        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres ;User Id=postgres;Password=1234");

        public void verileri_goster(string txt)
        {
            conn.Open();
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.Text;
            komut.CommandText = txt;
            NpgsqlDataReader dr = komut.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView_transkript.DataSource = dt;

            }
            komut.Dispose();
            conn.Close();
        }

        private void btn_transkriptGoruntule_Click(object sender, EventArgs e)
        {
            verileri_goster("select * from ders where harf_notu IS NOT NULL");
        }

        private void btn_ganoHesapla_Click(object sender, EventArgs e)
        {
            conn.Open();
            using (var komut_hesapla = new NpgsqlCommand("select kredi, harf_notu from ders where harf_notu IS NOT NULL", conn))
            using (var read = komut_hesapla.ExecuteReader())
            {
                double toplam_kredi = 0;
                double toplam_harf_notu = 0;
                double sayac = 0;
                double GANO = 10;

                while (read.Read())
                {
                    int kredi = (int)read["kredi"];
                    string harfNotu = (string)read["harf_notu"];
                    double deger = 0;

                    switch (harfNotu)
                    {
                        case "AA": deger = 4.00; break;
                        case "BA": deger = 3.50; break;
                        case "BB": deger = 3.00; break;
                        case "CB": deger = 2.50; break;
                        case "CC": deger = 2.00; break;
                        case "DC": deger = 1.50; break;
                        case "DD": deger = 1.00; break;
                        case "FD": deger = 0.50; break;
                        case "FF": deger = 0.00; break;
                    }
                    sayac += (kredi * deger);
                    toplam_kredi += kredi;
                    toplam_harf_notu += deger;

                }

                GANO = (sayac / toplam_kredi);
                GANO = Math.Round(GANO, 2);
                MessageBox.Show("Gano: " + GANO);
                conn.Close();
            }
        }

        private void btn_ganoIptal_Click(object sender, EventArgs e)
        {
            Form1 geri_don = new Form1();
            geri_don.Show();
        }

        private void btn_donemGANO_Click(object sender, EventArgs e)
        {
            conn.Open();
            using (var komut_donemHesapla = new NpgsqlCommand())
            using (var read = komut_donemHesapla.ExecuteReader())
            {
                komut_donemHesapla.Parameters.AddWithValue("@seciliDonem", textBox_donemGANO.Text);
                komut_donemHesapla.CommandText = "select kredi, harf_notu from ders where donem=@seciliDonem";
                
                double toplam_kredi = 0;
                double toplam_harf_notu = 0;
                double sayac = 0;
                double GANO = 0;

                while (read.Read())
                {
                    int kredi = (int)read["kredi"];
                    string harfNotu = (string)read["harf_notu"];
                    double deger = 0;

                    switch (harfNotu)
                    {
                        case "AA": deger = 4.00; break;
                        case "BA": deger = 3.50; break;
                        case "BB": deger = 3.00; break;
                        case "CB": deger = 2.50; break;
                        case "CC": deger = 2.00; break;
                        case "DC": deger = 1.50; break;
                        case "DD": deger = 1.00; break;
                        case "FD": deger = 0.50; break;
                        case "FF": deger = 0.00; break;
                    }
                    sayac += (kredi * deger);
                    toplam_kredi += kredi;
                    toplam_harf_notu += deger;

                }

                GANO = (sayac / toplam_kredi);
                GANO = Math.Round(GANO, 2);
                MessageBox.Show("dönem Gano: " + GANO);
                conn.Close();
            }
        }
    }
}
