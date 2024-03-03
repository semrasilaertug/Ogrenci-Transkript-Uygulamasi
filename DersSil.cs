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
    public partial class DersSil : Form
    {
        public DersSil()
        {
            InitializeComponent();
        }

        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres ;User Id=postgres;Password=1234");


        private void btn_dersSil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz?", "", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                conn.Open();
                NpgsqlCommand komut_sil = new NpgsqlCommand("delete from ders where ders_kodu = @ders_kodu", conn);
                komut_sil.Parameters.AddWithValue("@ders_kodu", textBox_silinecekDersKodu.Text);
                komut_sil.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(textBox_silinecekDersKodu.Text + " kodlu ders başarıyla silinmiştir.");
                textBox_silinecekDersKodu.Clear();
            }
        }

        private void btn_silIptal_Click(object sender, EventArgs e)
        {
            Form1 geri_don = new Form1();
            geri_don.Show();
        }
    }
}
